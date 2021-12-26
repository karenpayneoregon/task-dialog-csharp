using System;
using System.Windows.Forms;

namespace WindowsFormsLibrary.Classes
{
    public class Win32Window : IWin32Window
    {
        readonly IntPtr handle;
        public Win32Window(IWin32Window window)
        {
            handle = window.Handle;
        }
        IntPtr IWin32Window.Handle => handle;
    }
}
