using System;
using System.IO;
using System.Text;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using Markdig;

namespace WriteDown {
    public partial class TabForm : Form {
        public ChromiumWebBrowser chromeBrowser;
        private string tempFile, filePath, initText;
        private bool browserInitialized, textChanged;
        private MainForm parent;

        public TabForm(MainForm parent) {
            init(parent);
            writeTempFile();
        }

        public TabForm(MainForm parent, string existingFile) {
            init(parent);
            openFile(existingFile);
        }

        void init(MainForm parent) {
            this.parent = parent;
            tempFile = Path.Combine(Globals.TEMP_FOLDER, DateTimeOffset.Now.ToUnixTimeMilliseconds() + ".html");
            Globals.createTempFolder();
            InitializeComponent();
            initializeChromium();
            Globals.LEXER_THEME.applySyntaxTheme(editor);
        }

        public void initializeChromium() {
            chromeBrowser = new ChromiumWebBrowser(tempFile) {Dock = DockStyle.Fill};
            chromeBrowser.AllowDrop = false;
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
            if (initText != null) {
                textChanged = !initText.Equals(editor.Text);
                if (textChanged) {
                    if (!Text.EndsWith("*")) {
                        parent.saveCount++;
                        Text = Text + "*";
                    }
                    if (Icon != Properties.Resources.red_disk_icon) Icon = Properties.Resources.red_disk_icon;
                } else {
                    if (Text.EndsWith("*")) {
                        Text = Text.Substring(0, Text.Length - 1);
                        parent.saveCount--;
                    }
                    if (Icon != Properties.Resources.disk_icon) Icon = Properties.Resources.disk_icon;
                }
            } else if (Icon != Properties.Resources.red_disk_icon) {
                textChanged = true;
                Icon = Properties.Resources.red_disk_icon;
                parent.saveCount++;
            }
            writeTempFile();
            parent.setSaveButtonState(textChanged);
            parent.updateSaveAllState();
        }

        private void tab_FormClosed(object sender, FormClosedEventArgs e) {
            if ((parent.mainTabControl.TabPages.Count - 1) < 1) {
                Globals.clearTempFolder();
                Globals.safeExit();
            }
        }

        public void saveFile(string path) {
            File.WriteAllText(path, editor.Text, Encoding.UTF8);
            filePath = path;
            initText = editor.Text;
            textChanged = false;
            parent.saveCount--;
            if (Text.EndsWith("*")) Text = Text.Substring(0, Text.Length - 1);
            if (Icon != Properties.Resources.disk_icon) Icon = Properties.Resources.disk_icon;
        }

        public string getFilePath() => filePath;

        public bool hasFilePath() => !string.IsNullOrWhiteSpace(filePath) && isValidPath(filePath);

        public bool emptyFile() => string.IsNullOrEmpty(editor.Text) && !hasFilePath();

        public bool hasChanges() => textChanged;

        public void openFile(string path) {
            if (String.IsNullOrWhiteSpace(path) || !isValidPath(path)) return;
            if (File.Exists(path)) {
                filePath = path;
                Text = Path.GetFileName(path);
                var text = File.ReadAllText(path);
                initText = text;
                editor.Text = text;
                if (Icon != Properties.Resources.disk_icon) Icon = Properties.Resources.disk_icon;
            }
        }

        private bool isValidPath(string path) {
            try {
                Path.GetFullPath(path);
            } catch(Exception) {
                return false;
            }
            return true;
        }
    }
}