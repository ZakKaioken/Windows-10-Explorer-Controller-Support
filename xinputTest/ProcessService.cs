using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace xinputTest
{
    public static class ProcessService
    {

        [DllImport("user32.dll")]
        private static extern IntPtr GetWindowThreadProcessId(IntPtr hWnd, out uint ProcessId);

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        public static Process GetActiveProcess()
        {
            IntPtr hwnd = GetForegroundWindow();
            GetWindowThreadProcessId(hwnd, out uint pid);
            return Process.GetProcessById((int)pid);
        }
    }
}
