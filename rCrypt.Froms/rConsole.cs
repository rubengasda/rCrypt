using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

namespace rCryptForms
{
    internal static class NativeMethodes
    {
        [DllImport("kernel32.dll")]
        public static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        public static extern bool ShowWindow(IntPtr hWnd, int iCmdShow);
    }

    class rConsole
    {
        public static void Visible(Boolean visible)
        {
            NativeMethodes.ShowWindow(NativeMethodes.GetConsoleWindow(), (visible) ? 5 : 0);
        }

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

            s.read();
        }

        internal static class s
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
