using System;
using System.Windows.Forms;

namespace rCryptForms
{
    class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// <param name="args">start specified parameters.</param>
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
                rConsole.Initialize(args);
            }
        }
    }
}
