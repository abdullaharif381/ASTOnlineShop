using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Properties;
using MaterialSkin.Controls;
using ASTDesktopApp.Models;


namespace ASTDesktopApp
{
    public partial class LoginForm : MaterialForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if(MainClass.IsValidUser(UsernameTextBox.Text, PasswordTextBox.Text) == true)
            {
                this.Hide();
                MainForm main = new MainForm();
                main.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    }
}
