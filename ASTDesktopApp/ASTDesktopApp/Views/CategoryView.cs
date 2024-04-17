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
    public partial class CategoryView: SampleViews
    {
        public CategoryView()
        {
            InitializeComponent();
            // Attach the DataError event handler to the DataGridView
            CategoryDataGridView.DataError += CategoryDataGridView_DataError;
        }

        private void CategoryView_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            // Clear the existing data
            ListBox lb = new ListBox();
            lb.Items.Add(dgvID);
            lb.Items.Add(dgvName);

            string query = "SELECT CategoryID, Name FROM Categories WHERE Name LIKE '%" + SearchTextBox.Text + "%' ORDER BY CategoryID";
            MainClass.LoadData(query, CategoryDataGridView, lb);
        }

        private void CategoryDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (CategoryDataGridView.CurrentCell.OwningColumn.Name == "dgvEdit")
            {
                AddCategory addCategory = new AddCategory();
                addCategory.setID((CategoryDataGridView.CurrentRow.Cells["dgvID"].Value.ToString()));
                addCategory.setName(CategoryDataGridView.CurrentRow.Cells["dgvName"].Value.ToString());
                MainClass.BlurBackground(addCategory);
                LoadData();
            }
            if (CategoryDataGridView.CurrentCell.OwningColumn.Name == "dgvDel")
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete this record?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    int categoryID = Convert.ToInt32(CategoryDataGridView.CurrentRow.Cells["dgvID"].Value);
                    string query = "DELETE FROM Categories WHERE CategoryID = '" + categoryID + "'";
                    Hashtable ht = new Hashtable();
                    if (MainClass.SQL(query, ht) > 0)
                    {
                        // If the deletion is successful, reload the data
                        LoadData();
                        MessageBox.Show("Category deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // If there's an error, show the error message
                        MessageBox.Show("An error occurred while deleting the category", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public override void AddNewButton_Click(object sender, EventArgs e)
        {
            // open the AddUsers.cs form when this button is clicked:
            MainClass.BlurBackground(new AddCategory());
            AddCategory add = new AddCategory();
            add.Show();
            LoadData();
        }

        public override void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            // Implement search functionality here
        }

        private void SearchTextBox_Click_1(object sender, EventArgs e)
        {
            // Implement search functionality here
        }

        private void TopViewPanel_Paint(object sender, PaintEventArgs e)
        {
            // Implement any custom painting here
        }

        // Event handler for handling DataGridView data errors
        private void CategoryDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Suppress the error dialog
            e.ThrowException = false;
        }
    }
}
