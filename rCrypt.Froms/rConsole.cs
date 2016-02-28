using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

namespace rCryptForms
{
    /// <summary>
    /// Provides access to some Win32 methods
    /// </summary>
    internal static class NativeMethodes
    {
        [DllImport("kernel32.dll")]
        public static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        public static extern bool ShowWindow(IntPtr hWnd, int iCmdShow);
    }

    /// <summary>
    /// The main entry point for the console.
    /// </summary>
    class rConsole
    {
        /// <summary>
        /// sets the console visibility.
        /// </summary>
        /// <param name="visible"><c>true</c> to view the console; <c>false</c> to hide the console.</param>
        public static void Visible(bool visible)
        {
            NativeMethodes.ShowWindow(NativeMethodes.GetConsoleWindow(), (visible) ? 5 : 0);
        }

        /// <summary>
        /// Initialize of the console.
        /// </summary>
        /// <param name="args">parameters to be considered in the Initialize.</param>
        public static void Initialize(string[] args)
        {
            Assembly _Assembly = Assembly.GetExecutingAssembly();
            Stream str = _Assembly.GetManifestResourceStream("rCryptForms.Resources.rCryptForms_logo.txt");
            StreamReader rd = new StreamReader(str);
            Console.Write(rd.ReadToEnd());

            foreach (var s in args)
            {
                Console.WriteLine(s);
            }

            control.read();
        }

        /// <summary>
        /// control through console commands.
        /// </summary>
        internal static class control
        {
            public static void read()
            {
                string wort = Console.ReadLine();
                Console.WriteLine(wort);

                read();
            }
        }
    }
}
