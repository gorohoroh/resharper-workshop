namespace EssentialShortcuts
{
    // Alt+Enter
    //
    // Used to apply quick fixes to inspections ("squigglies"), or apply
    // context specific actions, depending on location of text caret
    //
    // Also allows searching and applying all ReSharper commands direct
    // from the menu.
    //
    // Icon is displayed in gutter margin on left of editor, e.g. yellow
    // lightbulb to fix warning, red light bulb to fix error, hammer to
    // apply a context action, etc.

    // 1. Apply QuickFix for an inspection
    //    The class doesn't match ReSharper's naming style
    //    Place text caret on "squiggly". Note the lightbulb in the margin on the left
    //    Click the light bulb, or hit "Alt+Enter"
    //    Select "Rename to 'BadlyNamedClass'" to fix
    //
    // (More on inspections in section 3)
    // FEATURE Improve code naming based on ReSharper's default naming rules or your own. VS2015 does not do this
    // FEATURE Find and remove code that is not used anywhere in solution (if solution-wide analysis is on, ReSharper can check usage of non-private code). VS2015 does not do this
    public class badlyNamedClass
    {
    }

    // FEATURE Move class to a separate file if its name doesn't correspond to the name of the file it's currently in. VS2015 does not do this
    public class ContextAction
    {
        // FEATURE Upgrade method to C#6 using expression body. VS2015 does not do this
        // FEATURE Check parameter for null
        // FEATURE Create overload without parameter
        public static string FormatString(string arg)
        {
            // 2. Apply context action
            //    Place text caret on "arg"
            //    Note the hammer action - a context action is available (no squiggly!)
            //    Hit Alt+Enter, select "To String.Format invocation"

            if (arg == "C# language level < 6")
            {
                // FEATURE Convert concatenation to string.Format() call
                return "Hello" + arg + "World";
            }
            else
            {
                // FEATURE Migrate to C#6 by using string interpolation
                return string.Format("Hello{0}World", arg);

            }
        }
    }

    // 3. Go to action
    //    Place text caret on class name below
    //    Alt+Enter, note magnifying glass
    //    Click magnifying glass, start typing "rename"
    //    Or, just start typing "rename" from menu
    //    Filters ReSharper commands and applies
    // FEATURE Create derived type quickly from any given class or interface
    public class GoToAction
    {
    }
}
