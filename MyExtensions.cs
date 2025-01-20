using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditClipboardContents;

// Get the bound function from the DataGridView for handling the SelectionChanged event, remove it and re-add it after clearing the selection
public static class DataGridViewExtensions
{
    public static void ClearSelectionNoEvent(this DataGridView dgv)
    {
        // 1. Find the static "EVENT_DATAGRIDVIEWSELECTIONCHANGED" field on DataGridView
        BindingFlags eventBindingFlags = BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField;
        FieldInfo eventKeyField = typeof(DataGridView).GetField("EVENT_DATAGRIDVIEWSELECTIONCHANGED", eventBindingFlags);

        if ( eventKeyField == null )
        {
            // Field not found (likely .NET Core / .NET 5+). Just clear as fallback.
            dgv.ClearSelection();
            return;
        }

        // This is the private object used as the dictionary key in the "Events" EventHandlerList
        object eventKey = eventKeyField.GetValue(null);

        // 2. Get the EventHandlerList from the inherited Component property
        BindingFlags listBindingFlags = BindingFlags.NonPublic | BindingFlags.Instance;
        PropertyInfo eventsProperty = typeof(Component).GetProperty("Events", listBindingFlags);

        if ( eventsProperty == null )
        {
            dgv.ClearSelection();
            return;
        }

        EventHandlerList eventHandlerList = (EventHandlerList)eventsProperty.GetValue(dgv);
        if ( eventHandlerList == null )
        {
            dgv.ClearSelection();
            return;
        }

        // 3. Grab the existing delegate(s) for the event key
        Delegate existingHandlers = eventHandlerList[eventKey];
        if ( existingHandlers == null )
        {
            // No handlers attached, do a simple clear
            dgv.ClearSelection();
            return;
        }

        // 4. Temporarily remove them
        eventHandlerList.RemoveHandler(eventKey, existingHandlers);

        // 5. Clear selection silently
        dgv.ClearSelection();

        // 6. Re-add the original handlers
        eventHandlerList.AddHandler(eventKey, existingHandlers);
    }
}


