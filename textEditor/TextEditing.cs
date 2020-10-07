using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace textEditor
{
    class TextEditing
    {
        private float font;
        private String saveFile;
        private UserList userList;
        public TextEditing(UserList userList)
        {
            this.userList = userList;
            this.font = 8;
        }

        public void OpenFile(RichTextBox rtb)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Open a rtf file";            
            DialogResult dr = openFileDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog.FileName);
                rtb.Text = sr.ReadToEnd();
                sr.Close();
            }
            
        }

        public void NewFile(RichTextBox rtb)
        {
            rtb.Clear();
        }

        public void SaveAsFile(RichTextBox rtb)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Rich Text Files (*.rtf)|*.rtf|All files (*.*)|*.*";
            DialogResult dr = saveFile.ShowDialog();
            if (dr == DialogResult.OK)
            {
                StreamWriter streamWriter = new StreamWriter(saveFile.FileName);
                streamWriter.Write(rtb.Text);
                streamWriter.Close();
                this.saveFile = saveFile.FileName;
            }
        }

        public void SaveFile(RichTextBox rtb)
        {
            if (this.saveFile != null)
            {
                File.WriteAllText(this.saveFile, rtb.Text);
            }
            else
            {
                SaveAsFile(rtb);
            }
        }

        public void Cut(RichTextBox rtb)
        {
            rtb.Cut();
        }

        public void Copy(RichTextBox rtb)
        {
            rtb.Copy();
        }

        public void Paste(RichTextBox rtb)
        {
            rtb.Paste();
        }

        public void Bold(RichTextBox rtb)
        {
            if (rtb.SelectionFont.Bold)
            {
                rtb.SelectionFont = new Font(rtb.SelectionFont, rtb.SelectionFont.Style ^ FontStyle.Bold);
            }
            else
            {
                rtb.SelectionFont = new Font(rtb.SelectionFont, rtb.SelectionFont.Style | FontStyle.Bold);
            }
        }

        public void Italic(RichTextBox rtb)
        {
            if (rtb.SelectionFont.Italic)
            {
                rtb.SelectionFont = new Font(rtb.SelectionFont, rtb.SelectionFont.Style ^ FontStyle.Italic);
            }
            else
            {
                rtb.SelectionFont = new Font(rtb.SelectionFont, rtb.SelectionFont.Style | FontStyle.Italic);
            }
        }

        public void Underline(RichTextBox rtb)
        {
            if (rtb.SelectionFont.Underline)
            {
                rtb.SelectionFont = new Font(rtb.SelectionFont, rtb.SelectionFont.Style ^ FontStyle.Underline);
            }
            else
            {
                rtb.SelectionFont = new Font(rtb.SelectionFont, rtb.SelectionFont.Style | FontStyle.Underline);
            }
        }

        public void Font(RichTextBox rtb, ToolStripComboBox font)
        {
            this.font = float.Parse(font.Text);
            rtb.SelectionFont = new Font(rtb.Font.Name, float.Parse(font.Text));
        }

        public void InitialiseUsernameLabel(ToolStripLabel usernameLbl)
        {
            usernameLbl.Text = "User Name: " + userList.GetLoggedIn().getUsername();
        }

        public bool CheckUserType()
        {
            return (userList.GetLoggedIn().getAccountType()).Equals("Edit");
        }
    }
}
