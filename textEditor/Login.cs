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
    partial class Login : Form
    {     
        public UserList userList;
    
        public Login(UserList userList)
        { 
            InitializeComponent();
            this.userList = userList;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void newUserBtn_Clicked(object sender, EventArgs e)
        {
            NewUser newUser = new NewUser(userList, this);
            newUser.Show();
            this.Hide();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(usernameTxt.Text) && !string.IsNullOrEmpty(passwordTxt.Text))
            {
                User user = userList.Login(usernameTxt.Text, passwordTxt.Text);
                if (user != null)
                {
                    TextEditor textEditor = new TextEditor(userList);
                    textEditor.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Fields incomplete", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}


