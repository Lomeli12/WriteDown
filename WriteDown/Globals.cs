using System;
using System.IO;
using System.Windows.Forms;
using Markdig;
using WriteDown.Themes;
using CefSharp;

namespace WriteDown {
    class Globals {
        public static SyntaxTheme LEXER_THEME = new SyntaxTheme();
        public static readonly string HTML_HEAD =
            "<!DOCTYPE html>\n<html lang=\"en\">\n<head><meta charset=\"utf-8\">" +
            "<link rel=\"stylesheet\" type=\"text/css\" href=\"{0}\"></head><body><div class=\"container\">";
        public static readonly string HTML_END = "</div></body></html>";
        public static readonly string APP_PATH = AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
        public static readonly string THEME_FOLDER = Path.Combine(APP_PATH, "themes");
        public static readonly string DARKLY_THEME = Path.Combine(THEME_FOLDER, "darkly");
        public static readonly string FLATLY_THEME = Path.Combine(THEME_FOLDER, "flatly");
        public static readonly string DARKLY_CSS = Path.Combine(DARKLY_THEME, "bootstrap.min.css");
        public static readonly string FLATLY_CSS = Path.Combine(FLATLY_THEME, "bootstrap.min.css");
        public static bool DARK_MODE = true;
        public static readonly MarkdownPipeline pipeline =
            new MarkdownPipelineBuilder().UseEmojiAndSmiley().UseAdvancedExtensions().Build();
        public static readonly char DIR_SEP = Path.DirectorySeparatorChar;
        public static readonly string APP_DATA = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        public static readonly string APP_FOLDER = Path.Combine(APP_DATA, "writedown");
        public static readonly string TEMP_FOLDER = Path.Combine(APP_FOLDER, "temp");

        public static string getHTMLHead() => string.Format(HTML_HEAD, DARK_MODE ? DARKLY_CSS : FLATLY_CSS);

        public static void createTempFolder() {
            if (!Directory.Exists(APP_FOLDER)) Directory.CreateDirectory(APP_FOLDER);
            if (!Directory.Exists(TEMP_FOLDER)) Directory.CreateDirectory(TEMP_FOLDER);
        }

        public static void clearTempFolder() {
            if (!Directory.Exists(TEMP_FOLDER)) return;
            Directory.Delete(TEMP_FOLDER, true);
        }

        public static void initCef() {
            if (Cef.IsInitialized) return;
            var settings = new CefSettings();
            settings.BrowserSubprocessPath = Path.Combine(AppDomain.CurrentDomain.SetupInformation.ApplicationBase,
                Environment.Is64BitProcess ? "x64" : "x86", "CefSharp.BrowserSubprocess.exe");
            Cef.Initialize(settings, performDependencyCheck: false, browserProcessHandler: null);
        }

        public static void safeExit() {
            Cef.Shutdown();
            Application.Exit();
        }
    }
}