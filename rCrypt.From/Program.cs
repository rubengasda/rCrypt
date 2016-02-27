using System;
using System.Windows.Forms;

namespace rCryptForm
{
    class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                rConsole.Visible(false);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new mainForm());
            }
            else
            {
                rConsole.s.initialize(args);
            }
        }
    }
}
