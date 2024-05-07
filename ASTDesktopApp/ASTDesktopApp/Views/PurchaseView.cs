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
	// this is purchase view
	public partial class PurchaseView : SampleViews
	{
		public PurchaseView()
		{
			InitializeComponent();

		}

		private void PurchaseView_Load(object sender, EventArgs e)
		{
			LoadData();
		}
		private void LoadData()
		{
			// Clear the existing data
			ListBox lb = new ListBox();
			lb.Items.Add(dgvID);
			lb.Items.Add(dgvSupplierName);
			lb.Items.Add(dgvSupplierID);
			lb.Items.Add(dgvAmount);
			lb.Items.Add(dgvDate);



			string query = @"SELECT p.PurchaseID, s.Name, p.SupplierID, SUM(pp.Amount), p.PurchaseDate
							FROM PurchaseProduct as pp
							INNER JOIN Purchases as p on pp.PurchaseID = p.PurchaseID
							INNER JOIN Suppliers as s on p.SupplierID = s.SupplierID							
							GROUP BY p.PurchaseID, s.SupplierName, s.SupplierID, p.Date ORDER BY p.PurchaseID";


			MainClass.LoadData(query, PurchaseDataGridView, lb);


		}


		private void AddNewButton_Click_1(object sender, EventArgs e)
		{
			//open the Addpurchases.cs form when this button is clicked:
			MainClass.BlurBackground(new AddPurchases());
			AddPurchases add = new AddPurchases();
			add.Show();
			LoadData();

		}


		private void PurchaseDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (PurchaseDataGridView.CurrentCell.OwningColumn.Name == "dgvEdit")
			{
				AddPurchases addpurchase = new AddPurchases();
				addpurchase.setSup(MainClass.GetName(Convert.ToInt32(PurchaseDataGridView.CurrentRow.Cells["dgvSupplierID"].Value), "Suppliers"));
				addpurchase.setProduct(MainClass.GetName(Convert.ToInt32(PurchaseDataGridView.CurrentRow.Cells["dgvProductID"].Value), "Products"));
				addpurchase.setCost(PurchaseDataGridView.CurrentRow.Cells["dgvCost"].Value.ToString());
				addpurchase.setQuantity(PurchaseDataGridView.CurrentRow.Cells["dgvQuantity"].Value.ToString());
				addpurchase.setID(PurchaseDataGridView.CurrentRow.Cells["dgvID"].Value.ToString());



				MainClass.BlurBackground(addpurchase);
				LoadData();


			}
			if (PurchaseDataGridView.CurrentCell.OwningColumn.Name == "dgvDel")

			{
				DialogResult dr = MessageBox.Show("Are you sure you want to delete this record?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (dr == DialogResult.Yes)
				{
					int pID = Convert.ToInt32(PurchaseDataGridView.CurrentRow.Cells["dgvID"].Value);
					string query = "DELETE FROM ProductPurchase WHERE PurchaseID = '" + pID + "'";
					string query2 = "DELETE FROM Purchases WHERE PurchaseID = '" + pID + "'";
					Hashtable ht = new Hashtable();
					if (MainClass.SQL(query, ht) > 0)
					{
						// If the deletion is successful, reload the data
						LoadData();
						MessageBox.Show("purchase deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else
					{
						// If there's an error, show the error message
						MessageBox.Show("An error occurred while deleting the purchase", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}


		}

	}
}
