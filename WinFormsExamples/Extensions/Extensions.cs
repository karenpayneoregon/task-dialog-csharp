using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using WinFormsExamples.Classes;

namespace WinFormsExamples.Extensions
{
    /// <summary>
    /// Common string extensions 
    /// </summary>
    public static class Extensions
    {
        [DebuggerStepThrough]
        public static string ToYesNoString(this bool value) => (value ? "Yes" : "No");
    }
}
