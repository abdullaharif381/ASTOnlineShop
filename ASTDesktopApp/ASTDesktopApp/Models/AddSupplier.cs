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
    public partial class AddSupplier : SampleAdd
    {
        public AddSupplier()
        {
            InitializeComponent();
        }
        public int id = 0;
       
        public override void CloseButton_Click(object sender, EventArgs e)
        {
            //immediately close the form
            Close();
            this.Close();

        }
        public string getName()
        {
            return NameTextBox.Text;
        }
        public string getAddress()
        {
            return AddressTextBox.Text;
        }
        public string getPhone()
        {
            return PhoneTextBox.Text;
        }
        public string getID()
        {
            return id.ToString();

        }
        public void setName(string name)
        {
            NameTextBox.Text = name;
        }
        public void setAddress(string address)
        {
            AddressTextBox.Text = address;
        }
        public void setPhone(string phone)
        {
            PhoneTextBox.Text = phone;
        }
        public void setID(string ID)
        {
            id = Convert.ToInt32(ID);
        }
        private void SupplierDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Suppress the error dialog
            e.ThrowException = false;
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
                    query = $"INSERT INTO Suppliers (Name, Address, Phone) VALUES ('{NameTextBox.Text}', '{AddressTextBox.Text}', '{PhoneTextBox.Text}')";
                }
                else
                {
                    query = $"UPDATE Suppliers SET Name = '{NameTextBox.Text}', Address = '{AddressTextBox.Text}', Phone = '{PhoneTextBox.Text}' WHERE SupplierID = {id}";
                }

                Hashtable ht = new Hashtable();
                ht.Add("@name", NameTextBox.Text);
                ht.Add("@address", AddressTextBox.Text);
                ht.Add("@phone", PhoneTextBox.Text);

                if (MainClass.SQL(query, ht) > 0)
                {
                    MessageBox.Show("Supplier added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    id = 0;
                    NameTextBox.Text = "";
                    AddressTextBox.Text = "";
                    PhoneTextBox.Text = "";
                    NameTextBox.Focus();
                    this.Close(); // Close the form after successful user addition
                }
            }
        }
      

        private void AddSuppliers_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
