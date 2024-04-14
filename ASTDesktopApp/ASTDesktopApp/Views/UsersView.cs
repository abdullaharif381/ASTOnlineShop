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
using ASTDesktopApp.Models;
using MaterialSkin.Controls;
using MaterialSkin.Properties;

namespace ASTDesktopApp.Views
{
	/*CREATE TABLE IF NOT EXISTS Users (
   UserID INTEGER PRIMARY KEY AUTOINCREMENT,
   Username TEXT UNIQUE NOT NULL,
   Password TEXT NOT NULL,
   Role TEXT NOT NULL
);*/
	public partial class UsersView : SampleViews
	{
		public UsersView()
		{
			InitializeComponent();
		}

		private void UsersView_Load(object sender, EventArgs e)
		{
			// Load the data from the database
			LoadData();
		}
	   
		public void LoadData()
		{
			// Clear the existing data
			ListBox lb = new ListBox();
			lb.Items.Add(dgvID);
			lb.Items.Add(dgvUsername);
			lb.Items.Add(dgvRole);
			lb.Items.Add(dgvPassword);
			
			string query = "SELECT UserID, Username, Role  FROM Users WHERE Username like '%" + SearchTextBox.Text + "%' ORDER BY UserID";
			MainClass.LoadData(query, UserDataGridView, lb);


		}

		private void UserDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (UserDataGridView.CurrentCell.OwningColumn.Name == "dgvEdit" )
			{
				AddUsers addUser = new AddUsers();                
				addUser.setID((UserDataGridView.CurrentRow.Cells["dgvID"].Value.ToString()));
				addUser.setUsername(UserDataGridView.CurrentRow.Cells["dgvUsername"].Value.ToString());
				addUser.setRole(UserDataGridView.CurrentRow.Cells["dgvRole"].Value.ToString());
				MainClass.BlurBackground(addUser);
				LoadData();


			}
			if(UserDataGridView.CurrentCell.OwningColumn.Name == "dgvDel")

			{
				DialogResult dr = MessageBox.Show("Are you sure you want to delete this record?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (dr == DialogResult.Yes)
				{
					int userID = Convert.ToInt32(UserDataGridView.CurrentRow.Cells["dgvID"].Value);
					string query = "DELETE FROM Users WHERE UserID = '" + userID + "'";
					Hashtable ht = new Hashtable();
					if (MainClass.SQL(query, ht) > 0)
					{
						// If the deletion is successful, reload the data
						LoadData();
						MessageBox.Show("User deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else
					{
						// If there's an error, show the error message
						MessageBox.Show("An error occurred while deleting the user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}

			
			
		}
		public override void AddNewButton_Click(object sender, EventArgs e)
		{
			// open the AddUsers.cs form when this button is clicked:
			MainClass.BlurBackground(new AddUsers());
			AddUsers add = new AddUsers();
			add.Show();
			LoadData();



		}

		public override void SearchTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void SearchTextBox_Click_1(object sender, EventArgs e)
		{

		}
	}
}
