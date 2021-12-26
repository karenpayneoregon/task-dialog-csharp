using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsLibrary.LanguageExtensions
{
    /// <summary>
    /// Common string extensions 
    /// </summary>
    public static class Extensions
    {
        [DebuggerStepThrough]
        public static string ToYesNoString(this bool value) => (value ? "Yes" : "No");

        /// <summary>
        /// Get Visual Studio version 
        /// </summary>
        /// <param name="sender"><see cref="TaskDialogRadioButton"/></param>
        /// <returns>Version</returns>
        [DebuggerStepThrough]
        public static VisualStudioVersion Version(this TaskDialogRadioButton sender) => sender is null ? VisualStudioVersion.None : (VisualStudioVersion)sender.Tag;

        public static (bool hasUrl, string address) GetAddress(this TaskDialogCommandLinkButton button)
        {
            if (button.Tag is not null)
            {
                return (true, Convert.ToString(button.Tag));
            }
            else
            {
                return (false,null);
            }
        }
        /// <summary>
        /// Set web address for use in opening a web page
        /// </summary>
        /// <param name="button"></param>
        /// <param name="address"></param>
        public static void SetAddress(this TaskDialogCommandLinkButton button, string address)
        {
            button.Tag = address;
        }

    }
}
