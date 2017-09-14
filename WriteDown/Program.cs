using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace WriteDown {
    static class Program {
        [STAThread]
        static void Main() {
            AppDomain.CurrentDomain.AssemblyResolve += resolver;
            Globals.initCef();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        private static Assembly resolver(object sender, ResolveEventArgs args) {
            if (args.Name.StartsWith("CefSharp")) {
                var assemblyName = args.Name.Split(new[] {','}, 2)[0] + ".dll";
                var archSpecificPath = Path.Combine(AppDomain.CurrentDomain.SetupInformation.ApplicationBase,
                    Environment.Is64BitProcess ? "x64" : "x86", assemblyName);

                return File.Exists(archSpecificPath) ? Assembly.LoadFile(archSpecificPath) : null;
            }
            return null;
        }
    }
}