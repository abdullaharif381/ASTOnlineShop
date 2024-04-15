using MaterialSkin.Controls;
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
    public partial class AddCustomer : SampleAdd
    {
        public int id = 0;
        public AddCustomer()
        {
            InitializeComponent();
        }
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
        public string setPhone(string phone)
        {
            return PhoneTextBox.Text;
        }
        public void setID(string ID)
        {
            id = Convert.ToInt32(ID);
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
                    query = $"INSERT INTO Customers (Name, Address, Phone) VALUES ('{NameTextBox.Text}', '{AddressTextBox.Text}', '{PhoneTextBox.Text}')";
                }
                else
                {
                    query = $"UPDATE Customers SET Name = '{NameTextBox.Text}', Address = '{AddressTextBox.Text}', Phone = '{PhoneTextBox.Text}' WHERE CustomerID = {id}";
                }

                Hashtable ht = new Hashtable();
                ht.Add("@name", NameTextBox.Text);
                ht.Add("@address", AddressTextBox.Text);
                ht.Add("@phone", PhoneTextBox.Text);

                if (MainClass.SQL(query, ht) > 0)
                {
                    MessageBox.Show("Customer added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    id = 0;
                    NameTextBox.Text = "";
                    AddressTextBox.Text = "";
                    PhoneTextBox.Text = "";
                    NameTextBox.Focus();
                    this.Close(); // Close the form after successful user addition
                }
            }
        }


        private void AddCustomers_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
