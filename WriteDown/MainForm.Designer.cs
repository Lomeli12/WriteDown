﻿namespace WriteDown {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exportToHTMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.newStripButton = new System.Windows.Forms.ToolStripButton();
            this.openStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveAllStripButton = new System.Windows.Forms.ToolStripButton();
            this.openMD = new System.Windows.Forms.OpenFileDialog();
            this.saveMD = new System.Windows.Forms.SaveFileDialog();
            this.mainTabControl = new MdiTabControl.TabControl();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 551);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1019, 22);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip1";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1019, 24);
            this.menuStrip.TabIndex = 4;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveToolStripMenuItem,
            this.saveAllToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator2,
            this.exportToHTMLToolStripMenuItem,
            this.toolStripSeparator3,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = global::WriteDown.Properties.Resources.page_add;
            this.newToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newProjectButtonClick);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::WriteDown.Properties.Resources.folder_page;
            this.openToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openProjectButtonClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(154, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveProjectButtonClick);
            // 
            // saveAllToolStripMenuItem
            // 
            this.saveAllToolStripMenuItem.Enabled = false;
            this.saveAllToolStripMenuItem.Image = global::WriteDown.Properties.Resources.disk_multiple;
            this.saveAllToolStripMenuItem.Name = "saveAllToolStripMenuItem";
            this.saveAllToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.saveAllToolStripMenuItem.Text = "Save All";
            this.saveAllToolStripMenuItem.Click += new System.EventHandler(this.saveAllProjectsButtonClick);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(154, 6);
            // 
            // exportToHTMLToolStripMenuItem
            // 
            this.exportToHTMLToolStripMenuItem.Enabled = false;
            this.exportToHTMLToolStripMenuItem.Image = global::WriteDown.Properties.Resources.html_go;
            this.exportToHTMLToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.exportToHTMLToolStripMenuItem.Name = "exportToHTMLToolStripMenuItem";
            this.exportToHTMLToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.exportToHTMLToolStripMenuItem.Text = "Export to HTML";
            this.exportToHTMLToolStripMenuItem.ToolTipText = "Not Ready Yet";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(154, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::WriteDown.Properties.Resources.door_out;
            this.exitToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newStripButton,
            this.openStripButton,
            this.saveStripButton,
            this.saveAllStripButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1019, 25);
            this.toolStrip.TabIndex = 5;
            this.toolStrip.Text = "toolStrip1";
            // 
            // newStripButton
            // 
            this.newStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newStripButton.Image = global::WriteDown.Properties.Resources.page_add;
            this.newStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.newStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newStripButton.Name = "newStripButton";
            this.newStripButton.Size = new System.Drawing.Size(23, 22);
            this.newStripButton.Text = "New";
            this.newStripButton.Click += new System.EventHandler(this.newProjectButtonClick);
            // 
            // openStripButton
            // 
            this.openStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openStripButton.Image = global::WriteDown.Properties.Resources.folder_page;
            this.openStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.openStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openStripButton.Name = "openStripButton";
            this.openStripButton.Size = new System.Drawing.Size(23, 22);
            this.openStripButton.Text = "Save";
            this.openStripButton.Click += new System.EventHandler(this.openProjectButtonClick);
            // 
            // saveStripButton
            // 
            this.saveStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveStripButton.Enabled = false;
            this.saveStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveStripButton.Image")));
            this.saveStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveStripButton.Name = "saveStripButton";
            this.saveStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveStripButton.Text = "Save";
            this.saveStripButton.Click += new System.EventHandler(this.saveProjectButtonClick);
            // 
            // saveAllStripButton
            // 
            this.saveAllStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveAllStripButton.Enabled = false;
            this.saveAllStripButton.Image = global::WriteDown.Properties.Resources.disk_multiple;
            this.saveAllStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.saveAllStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveAllStripButton.Name = "saveAllStripButton";
            this.saveAllStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveAllStripButton.Text = "Save All";
            this.saveAllStripButton.Click += new System.EventHandler(this.saveAllProjectsButtonClick);
            // 
            // openMD
            // 
            this.openMD.Filter = "Markdown File|*.md;*.txt;*.markdown;*.mdown|All Files|*.*";
            this.openMD.Title = "Open MD File";
            this.openMD.FileOk += new System.ComponentModel.CancelEventHandler(this.openMD_FileOk);
            // 
            // saveMD
            // 
            this.saveMD.Filter = "Markdown File|*.md;*.txt;*.markdown;*.mdown|All Files|*.*";
            this.saveMD.Title = "Save File...";
            this.saveMD.FileOk += new System.ComponentModel.CancelEventHandler(this.saveMD_FileOk);
            // 
            // mainTabControl
            // 
            this.mainTabControl.AllowDrop = true;
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(0, 49);
            this.mainTabControl.MenuRenderer = null;
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mainTabControl.Size = new System.Drawing.Size(1019, 502);
            this.mainTabControl.TabCloseButtonImage = null;
            this.mainTabControl.TabCloseButtonImageDisabled = null;
            this.mainTabControl.TabCloseButtonImageHot = null;
            this.mainTabControl.TabIndex = 6;
            this.mainTabControl.TabsDirection = MdiTabControl.TabControl.FlowDirection.RightToLeft;
            this.mainTabControl.SelectedTabChanged += new System.EventHandler(this.mainTabControl_SelectedTabChanged);
            this.mainTabControl.TabIndexChanged += new System.EventHandler(this.mainTabControl_TabIndexChanged);
            this.mainTabControl.DragDrop += new System.Windows.Forms.DragEventHandler(this.dropFile);
            this.mainTabControl.DragEnter += new System.Windows.Forms.DragEventHandler(this.dragFile);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 573);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = global::WriteDown.Properties.Resources.writedown_icon;
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "WriteDown";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton newStripButton;
        public MdiTabControl.TabControl mainTabControl;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openMD;
        private System.Windows.Forms.SaveFileDialog saveMD;
        private System.Windows.Forms.ToolStripMenuItem exportToHTMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton openStripButton;
        private System.Windows.Forms.ToolStripButton saveStripButton;
        private System.Windows.Forms.ToolStripButton saveAllStripButton;
    }
}

