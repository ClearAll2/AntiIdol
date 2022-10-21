namespace AntiIdol
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        private static Mutex? m_Mutex;
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            m_Mutex = new Mutex(true, "AntiIdol");

            if (m_Mutex.WaitOne(0, false))
            {
                Application.Run(new Main());
            }
            else
            {
                NativeMethods.PostMessage(
                        (IntPtr)NativeMethods.HWND_BROADCAST,
                        NativeMethods.WM_SHOWMEANTI,
                        IntPtr.Zero,
                        IntPtr.Zero);
                return;
            }
        }
    }
}