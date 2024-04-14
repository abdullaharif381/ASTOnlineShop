using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MaterialSkin.Controls;
using MaterialSkin.Properties;


namespace ASTDesktopApp.Models
{
    public partial class AddUsers : SampleAdd
    {
        public int id = 0;
        public AddUsers()
        {
            InitializeComponent();
        }
        public override void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public override void SaveButton_Click(object sender, EventArgs e)
        {
            if (!MainClass.IsUserValid(this))
            {
                MaterialMessageBox.Show("User not added", "Error", MessageBoxButtons.OK, true);
            }
            else
            {
                string query = "";
                if (id == 0)
                {
                    query = $"INSERT INTO Users (Username, Password, Role) VALUES ('{UsernameTextBox.Text}', '{PasswordTextBox.Text}', '{RoleTextBox.Text}')";
                }
                else
                {
                    query = $"UPDATE users SET username = '{UsernameTextBox.Text}', password = '{PasswordTextBox.Text}', role = '{RoleTextBox.Text}' WHERE id = {id}";
                }

                Hashtable ht = new Hashtable();
                ht.Add("@username", UsernameTextBox.Text);
                ht.Add("@password", PasswordTextBox.Text);
                ht.Add("@role", RoleTextBox.Text);

                if (MainClass.SQL(query, ht) > 0)
                {
                    MaterialMessageBox.Show("User added successfully", "Success", MessageBoxButtons.OK, true);
                    id = 0;
                    UsernameTextBox.Text = "";
                    PasswordTextBox.Text = "";
                    RoleTextBox.Text = "";
                    UsernameTextBox.Focus();
                    this.Close(); // Close the form after successful user addition
                }
            }
        }


        private void AddUsers_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
