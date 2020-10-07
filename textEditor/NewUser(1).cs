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
    partial class NewUser : Form
    {
        private UserList userList;
        private Form loginForm;
        public NewUser(UserList userList, Form login)
        {
            InitializeComponent();
            dob.Format = DateTimePickerFormat.Custom;
            dob.CustomFormat = "dd-MM-yyyy";
            userTypeCb.SelectedItem = "Edit";
            this.userList = userList;
            this.loginForm = login;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void NewUser_Load(object sender, EventArgs e)
        {

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(usernameTxt.Text) && !string.IsNullOrEmpty(passwordTxt.Text) && !string.IsNullOrEmpty(password2Txt.Text) &&
                !string.IsNullOrEmpty(fNameTxt.Text) && !string.IsNullOrEmpty(lNameTxt.Text) && !string.IsNullOrEmpty(dob.Text) && !string.IsNullOrEmpty(userTypeCb.Text))
            {
                if (!passwordTxt.Text.Equals(password2Txt.Text))
                {
                    MessageBox.Show("Passwords do not match", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (userList.UsernameExists(usernameTxt.Text))
                {
                    MessageBox.Show("Username already exists", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    userList.NewUser(usernameTxt.Text, passwordTxt.Text, userTypeCb.Text, fNameTxt.Text, lNameTxt.Text, dob.Text);
                    TextEditor textEditor = new TextEditor(userList);
                    textEditor.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Fields incomplete", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            loginForm.Show();
        }
    }
}
