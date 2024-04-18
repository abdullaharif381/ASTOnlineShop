using ASTDesktopApp.Models;
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

namespace ASTDesktopApp.Views
{
    public partial class CustomersView : SampleViews
    {
        public CustomersView()
        {
            InitializeComponent();
            //CustomerDataGridView.DataError += CustomerDataGridView_DataError;
        }

        private void CustomersView_Load(object sender, EventArgs e)
        {
            LoadData();
            
        }

        public void LoadData()
        {
            // Clear the existing data
            ListBox lb = new ListBox();
            lb.Items.Add(dgvID);
            lb.Items.Add(dgvName);
            lb.Items.Add(dgvAddress);
            lb.Items.Add(dgvPhone);


            string query = "SELECT CustomerID, Name, Address, Phone  FROM Customers WHERE Name LIKE '%" + SearchTextBox.Text + "%' OR Address LIKE '%" + SearchTextBox.Text + "%' OR Phone LIKE '%" + SearchTextBox.Text + "%' ORDER BY CustomerID";
            MainClass.LoadData(query, CustomerDataGridView, lb);


        }

        private void CustomerDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (CustomerDataGridView.CurrentCell.OwningColumn.Name == "dgvEdit")
            {
                AddCustomer addCustomer = new AddCustomer();
                addCustomer.setID((CustomerDataGridView.CurrentRow.Cells["dgvID"].Value.ToString()));
                addCustomer.setName(CustomerDataGridView.CurrentRow.Cells["dgvName"].Value.ToString());
                addCustomer.setAddress(CustomerDataGridView.CurrentRow.Cells["dgvAddress"].Value.ToString());
                addCustomer.setPhone(CustomerDataGridView.CurrentRow.Cells["dgvPhone"].Value.ToString());
                MainClass.BlurBackground(addCustomer);
                LoadData();


            }
            if (CustomerDataGridView.CurrentCell.OwningColumn.Name == "dgvDel")

            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete this record?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    int CustomerID = Convert.ToInt32(CustomerDataGridView.CurrentRow.Cells["dgvID"].Value.ToString());
                    string query = "DELETE FROM Customers WHERE CustomerID = '" + CustomerID + "'";
                    Hashtable ht = new Hashtable();
                    if (MainClass.SQL(query, ht) > 0)
                    {
                        // If the deletion is successful, reload the data
                        LoadData();
                        MessageBox.Show("Customer deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // If there's an error, show the error message
                        MessageBox.Show("An error occurred while deleting the customer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }



        }

        private void CustomerDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Suppress the error dialog
            e.ThrowException = false;
        }
        public override void AddNewButton_Click(object sender, EventArgs e)
        {
            // open the addCustomers.cs form when this button is clicked:
            MainClass.BlurBackground(new AddCustomer());
            AddCustomer add = new AddCustomer();
            add.Show();
            LoadData();



        }

        private void CustomerDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        public override void SearchButton_Click(object sender, EventArgs e)
        {
            base.SearchButton_Click(sender, e);
            LoadData();

        }
        public override void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

    }
}
