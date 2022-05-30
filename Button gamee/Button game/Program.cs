using System;
using System.Windows.Forms;

namespace Button_game
{
    internal static class State
    {
        public static string Name { get; set; }
    }

    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        public static void Close() => Application.Exit();
    }
}
