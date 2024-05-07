namespace ASTDesktopApp.Views
{
	partial class PurchaseView
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
			PurchaseDataGridView = new DataGridView();
			SrNo = new DataGridViewTextBoxColumn();
			dgvID = new DataGridViewTextBoxColumn();
			dgvSupplierName = new DataGridViewTextBoxColumn();
			dgvSupplierID = new DataGridViewTextBoxColumn();
			dgvAmount = new DataGridViewTextBoxColumn();
			dgvDate = new DataGridViewTextBoxColumn();
			dgvEdit = new DataGridViewImageColumn();
			dgvDel = new DataGridViewImageColumn();
			TopViewPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)PurchaseDataGridView).BeginInit();
			SuspendLayout();
			// 
			// AddNewButton
			// 
			AddNewButton.Click += AddNewButton_Click_1;
			// 
			// PurchaseDataGridView
			// 
			PurchaseDataGridView.AllowUserToAddRows = false;
			PurchaseDataGridView.AllowUserToDeleteRows = false;
			PurchaseDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			PurchaseDataGridView.BackgroundColor = SystemColors.InactiveBorder;
			PurchaseDataGridView.BorderStyle = BorderStyle.Fixed3D;
			PurchaseDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
			PurchaseDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			PurchaseDataGridView.Columns.AddRange(new DataGridViewColumn[] { SrNo, dgvID, dgvSupplierName, dgvSupplierID, dgvAmount, dgvDate, dgvEdit, dgvDel });
			PurchaseDataGridView.Dock = DockStyle.Fill;
			PurchaseDataGridView.EditMode = DataGridViewEditMode.EditOnEnter;
			PurchaseDataGridView.Location = new Point(3, 169);
			PurchaseDataGridView.Name = "PurchaseDataGridView";
			PurchaseDataGridView.ReadOnly = true;
			PurchaseDataGridView.RowHeadersWidth = 51;
			dataGridViewCellStyle5.BackColor = Color.AliceBlue;
			dataGridViewCellStyle5.Padding = new Padding(10, 0, 10, 2);
			PurchaseDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
			PurchaseDataGridView.ScrollBars = ScrollBars.Horizontal;
			PurchaseDataGridView.Size = new Size(794, 278);
			PurchaseDataGridView.TabIndex = 5;
			PurchaseDataGridView.CellContentClick += PurchaseDataGridView_CellContentClick;
			// 
			// SrNo
			// 
			SrNo.HeaderText = "SrNo";
			SrNo.MinimumWidth = 6;
			SrNo.Name = "SrNo";
			SrNo.ReadOnly = true;
			// 
			// dgvID
			// 
			dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = Color.AliceBlue;
			dataGridViewCellStyle1.ForeColor = Color.FromArgb(34, 40, 49);
			dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 173, 181);
			dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(34, 40, 49);
			dgvID.DefaultCellStyle = dataGridViewCellStyle1;
			dgvID.FillWeight = 50F;
			dgvID.HeaderText = "ID";
			dgvID.MinimumWidth = 50;
			dgvID.Name = "dgvID";
			dgvID.ReadOnly = true;
			// 
			// dgvSupplierName
			// 
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = Color.AliceBlue;
			dataGridViewCellStyle2.ForeColor = Color.FromArgb(34, 40, 49);
			dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 173, 181);
			dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(34, 40, 49);
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
			dgvSupplierName.DefaultCellStyle = dataGridViewCellStyle2;
			dgvSupplierName.FillWeight = 95.0780258F;
			dgvSupplierName.HeaderText = "Supplier";
			dgvSupplierName.MinimumWidth = 6;
			dgvSupplierName.Name = "dgvSupplierName";
			dgvSupplierName.ReadOnly = true;
			// 
			// dgvSupplierID
			// 
			dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
			dgvSupplierID.DefaultCellStyle = dataGridViewCellStyle3;
			dgvSupplierID.HeaderText = "SupplierID";
			dgvSupplierID.MinimumWidth = 6;
			dgvSupplierID.Name = "dgvSupplierID";
			dgvSupplierID.ReadOnly = true;
			dgvSupplierID.Visible = false;
			// 
			// dgvAmount
			// 
			dgvAmount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = Color.AliceBlue;
			dataGridViewCellStyle4.ForeColor = Color.FromArgb(34, 40, 49);
			dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(0, 173, 181);
			dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(34, 40, 49);
			dgvAmount.DefaultCellStyle = dataGridViewCellStyle4;
			dgvAmount.HeaderText = "Amount";
			dgvAmount.MinimumWidth = 6;
			dgvAmount.Name = "dgvAmount";
			dgvAmount.ReadOnly = true;
			// 
			// dgvDate
			// 
			dgvDate.HeaderText = "Date";
			dgvDate.MinimumWidth = 6;
			dgvDate.Name = "dgvDate";
			dgvDate.ReadOnly = true;
			// 
			// dgvEdit
			// 
			dgvEdit.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dgvEdit.FillWeight = 26.8907566F;
			dgvEdit.HeaderText = "";
			dgvEdit.Image = Properties.Resources.pen;
			dgvEdit.MinimumWidth = 20;
			dgvEdit.Name = "dgvEdit";
			dgvEdit.ReadOnly = true;
			// 
			// dgvDel
			// 
			dgvDel.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dgvDel.FillWeight = 38.03121F;
			dgvDel.HeaderText = "";
			dgvDel.Image = Properties.Resources.trash;
			dgvDel.MinimumWidth = 40;
			dgvDel.Name = "dgvDel";
			dgvDel.ReadOnly = true;
			// 
			// PurchaseView
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(PurchaseDataGridView);
			Location = new Point(0, 0);
			Name = "PurchaseView";
			Load += PurchaseView_Load;
			Controls.SetChildIndex(TopViewPanel, 0);
			Controls.SetChildIndex(PurchaseDataGridView, 0);
			TopViewPanel.ResumeLayout(false);
			TopViewPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)PurchaseDataGridView).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView PurchaseDataGridView;
		private DataGridViewTextBoxColumn SrNo;
		private DataGridViewTextBoxColumn dgvID;
		private DataGridViewTextBoxColumn dgvSupplierName;
		private DataGridViewTextBoxColumn dgvSupplierID;
		private DataGridViewTextBoxColumn dgvAmount;
		private DataGridViewTextBoxColumn dgvDate;
		private DataGridViewImageColumn dgvEdit;
		private DataGridViewImageColumn dgvDel;
	}
}