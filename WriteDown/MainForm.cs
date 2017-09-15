using System;
using System.IO;
using System.Windows.Forms;
using CefSharp;

namespace WriteDown {
    public partial class MainForm : Form {
        public int saveCount, saveAllIndex;
        public bool saveAll;

        public MainForm() {
            InitializeComponent();
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e) {
            Cef.Shutdown();
            Globals.clearTempFolder();
        }

        private void mainForm_Load(object sender, EventArgs e) {
            mainTabControl.TabPages.Add(new TabForm(this));
        }

        private void newProjectButtonClick(object sender, EventArgs e) {
            var tab = mainTabControl.TabPages.Add(new TabForm(this));
            mainTabControl.TabIndex = mainTabControl.TabPages.get_IndexOf(tab);
        }

        private void openProjectButtonClick(object sender, EventArgs e) {
            openMD.ShowDialog();
        }

        private void openMD_FileOk(object sender, System.ComponentModel.CancelEventArgs e) => openFile(openMD.FileName);

        void openFile(string file) {
            var currentTab = mainTabControl.SelectedForm;
            if (currentTab is TabForm) {
                if (((TabForm) currentTab).emptyFile()) {
                    ((TabForm) currentTab).openFile(file);
                    return;
                }
            }
            var tab = mainTabControl.TabPages.Add(new TabForm(this, file));
            mainTabControl.TabIndex = mainTabControl.TabPages.get_IndexOf(tab);
        }

        private void saveProjectButtonClick(object sender, EventArgs e) {
            var obj = mainTabControl.SelectedForm;
            if (obj is TabForm) {
                var tab = (TabForm) obj;
                if (tab.hasFilePath()) tab.saveFile(tab.getFilePath());
                else saveMD.ShowDialog();
            }
        }

        private void saveMD_FileOk(object sender, System.ComponentModel.CancelEventArgs e) {
            if (saveAll) {
                var tabPage = mainTabControl.TabPages[saveAllIndex];
                if (tabPage.Form is TabForm) {
                    var tab = tabPage.Form as TabForm;
                    tab.saveFile(saveMD.FileName);
                }
            } else {
                var obj = mainTabControl.SelectedForm;
                if (obj is TabForm) {
                    var tab = (TabForm)obj;
                    tab.saveFile(saveMD.FileName);
                }
            }
            saveMD.FileName = "";
        }

        private void dragFile(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void dropFile(object sender, DragEventArgs e) {
            string[] files = (string[]) e.Data.GetData(DataFormats.FileDrop);
            foreach (var file in files) {
                if (isMarkdownFile(file)) openFile(file);
            }
        }

        bool isMarkdownFile(string path) {
            var ext = Path.GetExtension(path);
            return !string.IsNullOrWhiteSpace(ext) && (ext.Equals(".md", StringComparison.InvariantCultureIgnoreCase) ||
                ext.Equals(".txt", StringComparison.InvariantCultureIgnoreCase) ||
                ext.Equals(".markdown", StringComparison.InvariantCultureIgnoreCase) ||
                ext.Equals(".mdown", StringComparison.InvariantCultureIgnoreCase));
        }

        public void setSaveButtonState(bool state) {
            saveStripButton.Enabled = state;
            saveToolStripMenuItem.Enabled = state;
        }

        public void updateSaveAllState() {
            saveAllStripButton.Enabled = saveCount > 0;
            saveAllToolStripMenuItem.Enabled = saveCount > 0;
        }

        void mainTabControl_TabIndexChanged(object sender, EventArgs e) {
        }

        void mainTabControl_TabPressed(object sender, EventArgs e) {
            
        }

        void saveAsToolStripMenuItem_Click(object sender, EventArgs e) => saveMD.ShowDialog();

        void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Globals.clearTempFolder();
            Globals.safeExit();
        }

        private void mainTabControl_SelectedTabChanged(object sender, EventArgs e) {
            var obj = mainTabControl.SelectedForm;
            if (obj is TabForm) {
                var tab = (TabForm) obj;
                setSaveButtonState(tab.hasChanges());
                updateSaveAllState();
            } else exitToolStripMenuItem_Click(sender, e);
        }

        void saveAllProjectsButtonClick(object sender, EventArgs e) {
            saveAll = true;
            for (int i = (mainTabControl.TabPages.Count -1); i >= 0; i--) {
                var tabPage = mainTabControl.TabPages[i];
                if (tabPage.Form is TabForm) {
                    var tab = tabPage.Form as TabForm;
                    if (tab.hasFilePath()) tab.saveFile(tab.getFilePath());
                    else {
                        saveAllIndex = i;
                        saveMD.ShowDialog();
                    }
                }
            }
            saveAll = false;
        }
    }
}