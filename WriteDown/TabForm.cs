using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using Markdig;
using ScintillaNET;

namespace WriteDown {
    public partial class TabForm : Form {
        public ChromiumWebBrowser chromeBrowser;
        private string tempFile;
        private bool browserInitialized;

        public TabForm() {
            init();
            writeTempFile();
        }

        public TabForm(string existingFile) {
            init();
            if (File.Exists(existingFile)) {
                Text = Path.GetFileName(existingFile);
                var text = File.ReadAllText(existingFile);
                editor.Text = text;
            }
        }

        void init() {
            tempFile = Path.Combine(Globals.TEMP_FOLDER, DateTimeOffset.Now.ToUnixTimeMilliseconds() + ".html");
            Globals.createTempFolder();
            InitializeComponent();
            initializeChromium();
            Globals.LEXER_THEME.applySyntaxTheme(editor);
        }

        public void initializeChromium() {
            chromeBrowser = new ChromiumWebBrowser(tempFile) {Dock = DockStyle.Fill};
            chromeBrowser.IsBrowserInitializedChanged += browser_init;
            layoutPanel.Controls.Add(chromeBrowser, 1, 0);
        }

        private void tab_Load(object sender, EventArgs e) {
            editor.Margins[0].Width = 16;
        }

        void writeTempFile() {
            Globals.createTempFolder();
            var result = Globals.getHTMLHead() + Markdown.ToHtml(editor.Text, Globals.pipeline) + Globals.HTML_END;
            File.WriteAllText(tempFile, result);
            if (browserInitialized) chromeBrowser.Reload();
        }

        private void browser_init(object sender, IsBrowserInitializedChangedEventArgs e) {
            chromeBrowser.Reload();
            browserInitialized = e.IsBrowserInitialized;
        }

        private void editor_TextChanged(object sender, EventArgs e) {
            writeTempFile();
        }

        private void tab_FormClosed(object sender, FormClosedEventArgs e) {
            Globals.tabCount--;
            if (Globals.tabCount <= 0) {
                Cef.Shutdown();
                Application.Exit();
            }
        }
    }
}