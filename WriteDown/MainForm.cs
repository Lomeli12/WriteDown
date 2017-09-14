using System;
using System.Windows.Forms;
using CefSharp;

namespace WriteDown {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e) {
            Cef.Shutdown();
            Globals.clearTempFolder();
        }

        private void mainForm_Load(object sender, EventArgs e) {
            mainTabControl.TabPages.Add(new TabForm());
            Globals.tabCount++;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e) {
            var tab = mainTabControl.TabPages.Add(new TabForm());
            mainTabControl.TabIndex = mainTabControl.TabPages.get_IndexOf(tab);
            Globals.tabCount++;
        }

        private void newStripButton_Click(object sender, EventArgs e) {
            newToolStripMenuItem_Click(sender, e);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e) {
            openMD.ShowDialog();
        }

        private void openMD_FileOk(object sender, System.ComponentModel.CancelEventArgs e) {
            var tab = mainTabControl.TabPages.Add(new TabForm(openMD.FileName));
            mainTabControl.TabIndex = mainTabControl.TabPages.get_IndexOf(tab);
            Globals.tabCount++;
        }
    }
}