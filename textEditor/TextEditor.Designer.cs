namespace textEditor
{
    partial class TextEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMi = new System.Windows.Forms.ToolStripMenuItem();
            this.openMi = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.saveMi = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsMi = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.logoutMi = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutMi = new System.Windows.Forms.ToolStripMenuItem();
            this.copyMi = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteMi = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMi = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newBtn = new System.Windows.Forms.ToolStripButton();
            this.openBtn = new System.Windows.Forms.ToolStripButton();
            this.saveBtn = new System.Windows.Forms.ToolStripButton();
            this.saveAsBtn = new System.Windows.Forms.ToolStripButton();
            this.boldBtn = new System.Windows.Forms.ToolStripButton();
            this.italicsBtn = new System.Windows.Forms.ToolStripButton();
            this.underlineBtn = new System.Windows.Forms.ToolStripButton();
            this.fontCb = new System.Windows.Forms.ToolStripComboBox();
            this.helpBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.usernameLbl = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.cutBtn = new System.Windows.Forms.ToolStripButton();
            this.copyBtn = new System.Windows.Forms.ToolStripButton();
            this.pasteBtn = new System.Windows.Forms.ToolStripButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(851, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMi,
            this.openMi,
            this.saveToolStripMenuItem,
            this.saveMi,
            this.saveAsMi,
            this.toolStripMenuItem1,
            this.logoutMi});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newMi
            // 
            this.newMi.Image = global::textEditor.Properties.Resources.NewFile_16x;
            this.newMi.Name = "newMi";
            this.newMi.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newMi.Size = new System.Drawing.Size(180, 22);
            this.newMi.Text = "New";
            this.newMi.Click += new System.EventHandler(this.newMi_Click);
            // 
            // openMi
            // 
            this.openMi.Image = global::textEditor.Properties.Resources.OpenFolder_16x;
            this.openMi.Name = "openMi";
            this.openMi.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openMi.Size = new System.Drawing.Size(180, 22);
            this.openMi.Text = "Open";
            this.openMi.Click += new System.EventHandler(this.openMi_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(177, 6);
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveMi
            // 
            this.saveMi.Image = global::textEditor.Properties.Resources.Save_16x;
            this.saveMi.Name = "saveMi";
            this.saveMi.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveMi.Size = new System.Drawing.Size(180, 22);
            this.saveMi.Text = "Save ";
            this.saveMi.Click += new System.EventHandler(this.saveMi_Click);
            // 
            // saveAsMi
            // 
            this.saveAsMi.Image = global::textEditor.Properties.Resources.SaveAs_16x;
            this.saveAsMi.Name = "saveAsMi";
            this.saveAsMi.Size = new System.Drawing.Size(180, 22);
            this.saveAsMi.Text = "Save as";
            this.saveAsMi.Click += new System.EventHandler(this.saveAsMi_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // logoutMi
            // 
            this.logoutMi.Image = global::textEditor.Properties.Resources.Exit_16x;
            this.logoutMi.Name = "logoutMi";
            this.logoutMi.Size = new System.Drawing.Size(180, 22);
            this.logoutMi.Text = "Logout";
            this.logoutMi.Click += new System.EventHandler(this.logoutMi_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutMi,
            this.copyMi,
            this.pasteMi});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // cutMi
            // 
            this.cutMi.Image = global::textEditor.Properties.Resources.Cut_16x;
            this.cutMi.Name = "cutMi";
            this.cutMi.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutMi.Size = new System.Drawing.Size(144, 22);
            this.cutMi.Text = "Cut";
            this.cutMi.Click += new System.EventHandler(this.cutMi_Click);
            // 
            // copyMi
            // 
            this.copyMi.Image = global::textEditor.Properties.Resources.Copy_16x;
            this.copyMi.Name = "copyMi";
            this.copyMi.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyMi.Size = new System.Drawing.Size(144, 22);
            this.copyMi.Text = "Copy";
            this.copyMi.Click += new System.EventHandler(this.copyMi_Click);
            // 
            // pasteMi
            // 
            this.pasteMi.Image = global::textEditor.Properties.Resources.Paste_16x;
            this.pasteMi.Name = "pasteMi";
            this.pasteMi.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteMi.Size = new System.Drawing.Size(144, 22);
            this.pasteMi.Text = "Paste";
            this.pasteMi.Click += new System.EventHandler(this.pasteMi_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpMi});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpMi
            // 
            this.helpMi.Name = "helpMi";
            this.helpMi.Size = new System.Drawing.Size(180, 22);
            this.helpMi.Text = "About...";
            this.helpMi.Click += new System.EventHandler(this.helpMi_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newBtn,
            this.openBtn,
            this.saveBtn,
            this.saveAsBtn,
            this.boldBtn,
            this.italicsBtn,
            this.underlineBtn,
            this.fontCb,
            this.helpBtn,
            this.toolStripSeparator1,
            this.usernameLbl});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(851, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newBtn
            // 
            this.newBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newBtn.Image = global::textEditor.Properties.Resources.NewFile_16x;
            this.newBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(23, 22);
            this.newBtn.Tag = "";
            this.newBtn.Text = "toolStripButton1";
            this.newBtn.ToolTipText = "New file";
            this.newBtn.Click += new System.EventHandler(this.newBtn_Click);
            // 
            // openBtn
            // 
            this.openBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openBtn.Image = global::textEditor.Properties.Resources.OpenFolder_16x;
            this.openBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(23, 22);
            this.openBtn.Text = "toolStripButton2";
            this.openBtn.ToolTipText = "Open File";
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveBtn.Image = global::textEditor.Properties.Resources.Save_16x;
            this.saveBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(23, 22);
            this.saveBtn.Text = "toolStripButton3";
            this.saveBtn.ToolTipText = "Save";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // saveAsBtn
            // 
            this.saveAsBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveAsBtn.Image = global::textEditor.Properties.Resources.SaveAs_16x;
            this.saveAsBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveAsBtn.Name = "saveAsBtn";
            this.saveAsBtn.Size = new System.Drawing.Size(23, 22);
            this.saveAsBtn.Text = "toolStripButton4";
            this.saveAsBtn.ToolTipText = "Save as";
            this.saveAsBtn.Click += new System.EventHandler(this.saveAsBtn_Click);
            // 
            // boldBtn
            // 
            this.boldBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.boldBtn.Image = global::textEditor.Properties.Resources.Bold_16x;
            this.boldBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.boldBtn.Name = "boldBtn";
            this.boldBtn.Size = new System.Drawing.Size(23, 22);
            this.boldBtn.Text = "toolStripButton5";
            this.boldBtn.ToolTipText = "Bold";
            this.boldBtn.Click += new System.EventHandler(this.boldBtn_Click);
            // 
            // italicsBtn
            // 
            this.italicsBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.italicsBtn.Image = global::textEditor.Properties.Resources.Italic_16x;
            this.italicsBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.italicsBtn.Name = "italicsBtn";
            this.italicsBtn.Size = new System.Drawing.Size(23, 22);
            this.italicsBtn.Text = "toolStripButton6";
            this.italicsBtn.ToolTipText = "Italics";
            this.italicsBtn.Click += new System.EventHandler(this.italicsBtn_Click);
            // 
            // underlineBtn
            // 
            this.underlineBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.underlineBtn.Image = global::textEditor.Properties.Resources.Underline_16x;
            this.underlineBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.underlineBtn.Name = "underlineBtn";
            this.underlineBtn.Size = new System.Drawing.Size(23, 22);
            this.underlineBtn.Text = "toolStripButton7";
            this.underlineBtn.ToolTipText = "Underline";
            this.underlineBtn.Click += new System.EventHandler(this.underlineBtn_Click);
            // 
            // fontCb
            // 
            this.fontCb.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20"});
            this.fontCb.Name = "fontCb";
            this.fontCb.Size = new System.Drawing.Size(121, 25);
            this.fontCb.Text = "8";
            this.fontCb.ToolTipText = "Font size";
            this.fontCb.SelectedIndexChanged += new System.EventHandler(this.fontCb_IndexChanged);
            // 
            // helpBtn
            // 
            this.helpBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpBtn.Image = global::textEditor.Properties.Resources.Question_16x;
            this.helpBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(23, 22);
            this.helpBtn.Text = "toolStripButton8";
            this.helpBtn.ToolTipText = "Help";
            this.helpBtn.Click += new System.EventHandler(this.helpBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // usernameLbl
            // 
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(75, 22);
            this.usernameLbl.Text = "usernameLbl";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutBtn,
            this.copyBtn,
            this.pasteBtn});
            this.toolStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStrip2.Location = new System.Drawing.Point(0, 53);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(24, 80);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // cutBtn
            // 
            this.cutBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutBtn.Image = global::textEditor.Properties.Resources.Cut_16x;
            this.cutBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutBtn.Name = "cutBtn";
            this.cutBtn.Size = new System.Drawing.Size(22, 20);
            this.cutBtn.Text = "Cut";
            this.cutBtn.Click += new System.EventHandler(this.cutBtn_Click);
            // 
            // copyBtn
            // 
            this.copyBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyBtn.Image = global::textEditor.Properties.Resources.Copy_16x;
            this.copyBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyBtn.Name = "copyBtn";
            this.copyBtn.Size = new System.Drawing.Size(22, 20);
            this.copyBtn.Text = "Copy";
            this.copyBtn.Click += new System.EventHandler(this.copyBtn_Click);
            // 
            // pasteBtn
            // 
            this.pasteBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteBtn.Image = global::textEditor.Properties.Resources.Paste_16x;
            this.pasteBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteBtn.Name = "pasteBtn";
            this.pasteBtn.Size = new System.Drawing.Size(22, 20);
            this.pasteBtn.Text = "Paste";
            this.pasteBtn.Click += new System.EventHandler(this.pasteBtn_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(27, 52);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.richTextBox1.Size = new System.Drawing.Size(831, 458);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // TextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(851, 502);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "TextEditor";
            this.Text = "textEditor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newMi;
        private System.Windows.Forms.ToolStripMenuItem openMi;
        private System.Windows.Forms.ToolStripMenuItem saveMi;
        private System.Windows.Forms.ToolStripMenuItem saveAsMi;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutMi;
        private System.Windows.Forms.ToolStripMenuItem copyMi;
        private System.Windows.Forms.ToolStripMenuItem pasteMi;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMi;
        private System.Windows.Forms.ToolStripSeparator saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem logoutMi;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newBtn;
        private System.Windows.Forms.ToolStripButton openBtn;
        private System.Windows.Forms.ToolStripButton saveBtn;
        private System.Windows.Forms.ToolStripButton saveAsBtn;
        private System.Windows.Forms.ToolStripButton boldBtn;
        private System.Windows.Forms.ToolStripButton italicsBtn;
        private System.Windows.Forms.ToolStripButton underlineBtn;
        private System.Windows.Forms.ToolStripComboBox fontCb;
        private System.Windows.Forms.ToolStripButton helpBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel usernameLbl;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton cutBtn;
        private System.Windows.Forms.ToolStripButton copyBtn;
        private System.Windows.Forms.ToolStripButton pasteBtn;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}