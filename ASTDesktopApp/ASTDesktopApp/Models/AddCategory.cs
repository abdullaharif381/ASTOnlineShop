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

namespace ASTDesktopApp.Models
{
    public partial class AddCategory : SampleAdd
    {
        public int id = 0;
        public AddCategory()
        {
            InitializeComponent();
        }
        public override void CloseButton_Click(object sender, EventArgs e)
        {
            //immediately close the form
            Close();
            this.Close();

        }
        public void setID(string ID)
        {
            id = Convert.ToInt32(ID);
        }

        public void setName(string name)
        {
            NameTextBox.Text = name;
        }
        public string getID()
        {
            // return id
            return id.ToString();
        }
        
        public string getName()
        {
            return NameTextBox.Text;
        }

        public override void SaveButton_Click(object sender, EventArgs e)
        {
            if (!MainClass.IsEntryValid(this))
            {
                MessageBox.Show("Please enter all the required fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string query = "";
                if (id == 0)
                {
                    query = $"INSERT INTO Categories (Name) VALUES ('{NameTextBox.Text}')";
                }
                else
                {
                    query = $"UPDATE Categories SET Name = '{NameTextBox.Text}' WHERE CategoryID = {id}";
                }

                Hashtable ht = new Hashtable();
                ht.Add("@Name", NameTextBox.Text);


                if (MainClass.SQL(query, ht) > 0)
                {
                    MessageBox.Show("Category added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    id = 0;
                    NameTextBox.Text = "";
                    NameTextBox.Focus();
                    this.Close(); // Close the form after successful Category addition
                }
            }
        }


        private void AddCategorys_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
