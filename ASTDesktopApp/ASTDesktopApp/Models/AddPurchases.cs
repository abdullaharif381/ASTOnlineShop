using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace ASTDesktopApp.Models
{
	public partial class AddPurchases : SampleAdd
	{
		public int id, supId, prodId = 0;

		public AddPurchases()
		{
			InitializeComponent();
		}
		// getter setter
		public string getProdName()
		{
			return ProductComboBox.Text;
		}
		public string getSupplierName()
		{
			return SupplierComboBox.Text;
		}
		public string getCost()
		{
			return CostTextBox.Text;
		}
		public string getAmount()
		{
			return AmountTextBox.Text;
		}
		public object getDate()
		{
			return dateTimePicker1.MinDate;
		}

		// method to set the category, name, description, cost, price, and image
		public void setID(string ID)
		{
			id = Convert.ToInt32(ID);
		}
		public void setProdID(int ID)
		{
			prodId = ID;
		}
		public void setProduct(string p)
		{
			ProductComboBox.SelectedValue = p;
		}
		public void setSup(string name)
		{
			SupplierComboBox.Text = name;
		}

		public void setCost(string cost)
		{
			CostTextBox.Text = cost;
		}
		public void setQuantity(string q)
		{
			QuantityTextBox.Text = q;

		}

		private void AddPurchases_Load(object sender, EventArgs e)
		{
			string query = "select ProductID, Name  from Products";
			string query2 = "select SupplierID, Name  from Suppliers";
			MainClass.FillCombo(query, ProductComboBox, "Name", "ProductID");
			MainClass.FillCombo(query2, SupplierComboBox, "Name", "SupplierID");
			if (supId > 0)
			{
				SupplierComboBox.SelectedValue = supId;

			}
			//LoadData(); 
		}

		private void ProductComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (ProductComboBox.SelectedIndex != -1)
			{
				QuantityTextBox.Text = "";
				GetDetails();
			}
		}

		private void GetDetails()
		{
			DataRowView row = ProductComboBox.SelectedItem as DataRowView;
			if (row != null)
			{
				int selectedProductId = Convert.ToInt32(row["ProductID"]);
				string query = $"Select * from Products where ProductID = {selectedProductId};";
				SQLiteCommand cmd = new SQLiteCommand(query, MainClass.Connection);
				SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
				DataTable dt = new DataTable();
				da.Fill(dt);
				if (dt.Rows.Count > 0)
				{
					CostTextBox.Text = dt.Rows[0]["Cost"].ToString();
					CalculateAmount();
				}
			}
		}
		private void CalculateAmount()
		{
			double qty = 0;
			double cost = 0;

			// Use invariant culture to ensure consistent parsing regardless of user's locale settings
			double.TryParse(QuantityTextBox.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out qty);
			double.TryParse(CostTextBox.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out cost);

			// Ensure that the application does not crash if CostTextBox.Text is empty
			if (string.IsNullOrEmpty(CostTextBox.Text))
			{
				cost = 0;
			}

			double amount = qty * cost;
			AmountTextBox.Text = amount.ToString(CultureInfo.InvariantCulture);
		}

		private void QuantityTextBox_TextChanged(object sender, EventArgs e)
		{
			CalculateAmount();
		}
		private void CostTextBox_TextChanged_1(object sender, EventArgs e)
		{
			CalculateAmount();
		}
		private void QuantityTextBox_TextChanged_1(object sender, EventArgs e)
		{
			CalculateAmount();
		}

		private void CostTextBox_TextChanged(object sender, EventArgs e)
		{
			CalculateAmount();
		}

		private void AddButton_Click(object sender, EventArgs e)
		{
			string pid, pname, qty, cost, amount;
			pname = ProductComboBox.Text;
			pid = ProductComboBox.SelectedValue.ToString();
			qty = QuantityTextBox.Text;
			cost = CostTextBox.Text;
			amount = AmountTextBox.Text;
			string date = DateTime.Now.ToString("yyyy-MM-dd");
			PurchaseAddDataGridView.Rows.Add(PurchaseAddDataGridView.Rows.Count + 1, pid, pname, qty, cost, amount, date);
		}

		private void PurchaseAddDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			int count = 0;
			foreach (DataGridViewRow row in PurchaseAddDataGridView.Rows)
			{
				count++;
				row.Cells[0].Value = count;
			}
		}
		public override void SaveButton_Click(object sender, EventArgs e)
		{
			if (MainClass.IsEntryValid(this) == false)
			{
				// there are errors in the data user entered
				MessageBox.Show("Please enter all required fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else
			{
				string query = "";
				string categoryName = MainClass.GetName(id, "PurchaseProduct"); // Get category name based on catId



				if (id == 0)
				{
					query = @"INSERT INTO PurchaseProduct (ProductID, SupplierID, Quantity, Cost, Amount, Date) 
                                VALUES (@prodId, @supId, @qty, @cost, @amount, @date)";

				}
				else
				{
					query = @"UPDATE PurchaseProduct SET ProductID = @prodId,
                                                SupplierID = @supId,
                                                Quantity = @qty,
                                                Cost = @cost,
                                                Amount = @amount,
												Date = @date
                                                WHERE PurchaseProductID = @id";

				}
				Hashtable ht = new Hashtable();
				ht.Add("@id", id);
				ht.Add("@prodId", Convert.ToInt32(ProductComboBox.SelectedValue));
				ht.Add("@supId", Convert.ToInt32(SupplierComboBox.SelectedValue));
				ht.Add("@qty", Convert.ToInt32(QuantityTextBox.Text));
				ht.Add("@cost", Convert.ToInt32(CostTextBox.Text));
				ht.Add("@amount", Convert.ToInt32(AmountTextBox.Text));
				ht.Add("@date", dateTimePicker1.Value.Date.ToString("yyyy-MM-dd"));






				if (MainClass.SQL(query, ht) > 0)
				{
					// show message of saving data closely
					MessageBox.Show("Product saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
					id = 0;
					SupplierComboBox.SelectedIndex = 0;
					SupplierComboBox.SelectedIndex = -1;
					ProductComboBox.SelectedIndex = 0;
					ProductComboBox.SelectedIndex = -1;
					QuantityTextBox.Text = "";
					CostTextBox.Text = "";
					AmountTextBox.Text = "";
					AmountTextBox.Focus();

				}




			}
			base.SaveButton_Click(sender, e);
		}

		private void QuantityTextBox_Click(object sender, EventArgs e)
		{

		}


	}
}
