using ASTDesktopApp.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASTDesktopApp.Views
{
    public partial class SuppliersView: SampleViews
    {
        public SuppliersView()
        {
            InitializeComponent();
           // SupplierDataGridView.DataError += SupplierDataGridView_DataError;
        }

        private void SuppliersView_Load(object sender, EventArgs e)
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

            string query = "SELECT SupplierID, Name, Address, Phone  FROM Suppliers WHERE Name like '%" + SearchTextBox.Text + "%' ORDER BY SupplierID";
            MainClass.LoadData(query, SupplierDataGridView, lb);


        }
        //private void SupplierDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        //{
        //    // Suppress the error dialog
        //    e.ThrowException = false;
        //}
        private void SupplierDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
                

            //    DataGridView dataGridView = (DataGridView)sender;

            //    if (dataGridView.Columns[e.ColumnIndex].Name == "dgvEdit")
            //    {
            //        // Handle edit action
            //        AddSupplier addSupplier = new AddSupplier();
            //        ((dataGridView.CurrentRow.Cells["dgvID"].Value)).ToString();
            //        ((dataGridView.CurrentRow.Cells["dgvName"].Value)).ToString();
            //        ((dataGridView.CurrentRow.Cells["dgvAddress"].Value)).ToString();
            //        ((dataGridView.CurrentRow.Cells["dgvPhone"].Value)).ToString();
            //        MainClass.BlurBackground(addSupplier);
            //        LoadData();
            //    }
            //    else if (dataGridView.Columns[e.ColumnIndex].Name == "dgvDel")
            //    {
            //        // Handle delete action
            //        DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //        if (result == DialogResult.Yes)
            //        {
            //            int SupplierID = Convert.ToInt32(dataGridView.CurrentRow.Cells["dgvID"].Value);
            //            string query = "DELETE FROM Suppliers WHERE SupplierID = '" + SupplierID + "'";
            //            Hashtable ht = new Hashtable();
            //            if (MainClass.SQL(query, ht) > 0)
            //            {
            //                // If the deletion is successful, reload the data
            //                LoadData();
            //                MessageBox.Show("Supplier deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            }
            //            else
            //            {
            //                // If there's an error, show the error message
            //                MessageBox.Show("An error occurred while deleting the supplier", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            }
            //        }
            //    }
            //}
            //catch (FormatException ex)
            //{
            //    // Handle the FormatException
            //    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //catch (Exception ex)
            //{
            //    // Handle other exceptions
            //    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }







       
        public override void AddNewButton_Click(object sender, EventArgs e)
        {
            // open the addSuppliers.cs form when this button is clicked:
            MainClass.BlurBackground(new AddSupplier());
            AddSupplier add = new AddSupplier();
            add.Show();
            LoadData();



        }

        private void SupplierDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void SupplierDataGridView_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            try
            {


                DataGridView dataGridView = (DataGridView)sender;

                if (dataGridView.Columns[e.ColumnIndex].Name == "dgvEdit")
                {
                    // Handle edit action
                    AddSupplier addSupplier = new AddSupplier();
                    addSupplier.setID((SupplierDataGridView.CurrentRow.Cells["dgvID"].Value.ToString()));
                    addSupplier.setName(SupplierDataGridView.CurrentRow.Cells["dgvName"].Value.ToString());
                    addSupplier.setAddress(SupplierDataGridView.CurrentRow.Cells["dgvAddress"].Value.ToString());
                    addSupplier.setPhone(SupplierDataGridView.CurrentRow.Cells["dgvPhone"].Value.ToString());
                    MainClass.BlurBackground(addSupplier);
                    LoadData();
            
                }
                else if (dataGridView.Columns[e.ColumnIndex].Name == "dgvDel")
                {
                    // Handle delete action
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        int SupplierID = Convert.ToInt32(dataGridView.CurrentRow.Cells["dgvID"].Value);
                        string query = "DELETE FROM Suppliers WHERE SupplierID = '" + SupplierID + "'";
                        Hashtable ht = new Hashtable();
                        if (MainClass.SQL(query, ht) > 0)
                        {
                            // If the deletion is successful, reload the data
                            LoadData();
                            MessageBox.Show("Supplier deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            // If there's an error, show the error message
                            MessageBox.Show("An error occurred while deleting the supplier", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (FormatException ex)
            {
                // Handle the FormatException
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SuppliersView_Load_1(object sender, EventArgs e)
        {

        }
        public override void SearchButton_Click(object sender, EventArgs e)
        {
            base.SearchButton_Click(sender, e);
            LoadData();
        }


    }
}
