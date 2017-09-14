using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WriteDown {
    static class Program {
        [STAThread]
        static void Main() {
            AppDomain.CurrentDomain.AssemblyResolve += resolver;
            var json = File.ReadAllText(Path.Combine(Globals.APP_PATH, "testtheme.json"));
            Globals.LEXER_THEME = JsonConvert.DeserializeObject<SyntaxTheme>(json);
            Globals.initCef();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        private static Assembly resolver(object sender, ResolveEventArgs args) {
            if (args.Name.StartsWith("CefSharp")) {
                var assemblyName = args.Name.Split(new[] {','}, 2)[0] + ".dll";
                var archSpecificPath = Path.Combine(Globals.APP_PATH, Environment.Is64BitProcess ? "x64" : "x86",
                    assemblyName);

                return File.Exists(archSpecificPath) ? Assembly.LoadFile(archSpecificPath) : null;
            }
            return null;
        }
    }
}