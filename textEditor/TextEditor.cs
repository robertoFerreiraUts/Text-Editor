using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace textEditor
{
    partial class TextEditor : Form
    {
        private TextEditing textEditing;
        private bool editType;
        public TextEditor(UserList userList)
        {
            InitializeComponent();
            this.textEditing = new TextEditing(userList);
            textEditing.InitialiseUsernameLabel(usernameLbl);
            editType = textEditing.CheckUserType();
            richTextBox1.ReadOnly = !editType;
        }

        
        private void newBtn_Click(object sender, EventArgs e)
        {
            if (editType)
                textEditing.NewFile(this.richTextBox1);
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            textEditing.OpenFile(this.richTextBox1);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveAsBtn_Click(object sender, EventArgs e)
        {
            if (editType)
                textEditing.SaveAsFile(this.richTextBox1);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (editType)
                textEditing.SaveFile(this.richTextBox1);
        }

        private void boldBtn_Click(object sender, EventArgs e)
        {
            textEditing.Bold(this.richTextBox1);
        }

        private void italicsBtn_Click(object sender, EventArgs e)
        {
            textEditing.Italic(this.richTextBox1);
        }

        private void underlineBtn_Click(object sender, EventArgs e)
        {
            textEditing.Underline(this.richTextBox1);
        }

        private void cutBtn_Click(object sender, EventArgs e)
        {
            textEditing.Cut(this.richTextBox1);
        }

        private void copyBtn_Click(object sender, EventArgs e)
        {
            textEditing.Copy(this.richTextBox1);
        }

        private void pasteBtn_Click(object sender, EventArgs e)
        {
            textEditing.Paste(this.richTextBox1);
        }

        private void fontCb_Click(object sender, EventArgs e)
        {

        }

        private void fontCb_IndexChanged(object sender, EventArgs e)
        {
            textEditing.Font(this.richTextBox1, this.fontCb);
        }

        private void newMi_Click(object sender, EventArgs e)
        {
            if (editType)
                textEditing.NewFile(this.richTextBox1);
        }

        private void openMi_Click(object sender, EventArgs e)
        {
            textEditing.OpenFile(this.richTextBox1);
        }

        private void saveMi_Click(object sender, EventArgs e)
        {
            if (editType)
                textEditing.SaveFile(this.richTextBox1);
        }

        private void saveAsMi_Click(object sender, EventArgs e)
        {
            if (editType)
                textEditing.SaveAsFile(this.richTextBox1);
        }

        private void cutMi_Click(object sender, EventArgs e)
        {
            textEditing.Cut(this.richTextBox1);
        }

        private void copyMi_Click(object sender, EventArgs e)
        {
            textEditing.Copy(this.richTextBox1);
        }

        private void pasteMi_Click(object sender, EventArgs e)
        {
            textEditing.Paste(this.richTextBox1);
        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void helpMi_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void logoutMi_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
