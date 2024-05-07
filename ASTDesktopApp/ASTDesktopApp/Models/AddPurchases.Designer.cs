namespace ASTDesktopApp.Models
{
	partial class AddPurchases
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
			dateTimePicker1 = new DateTimePicker();
			SupplierComboBox = new MaterialSkin.Controls.MaterialComboBox();
			ProductComboBox = new MaterialSkin.Controls.MaterialComboBox();
			QuantityTextBox = new MaterialSkin.Controls.MaterialTextBox2();
			CostTextBox = new MaterialSkin.Controls.MaterialTextBox2();
			AmountTextBox = new MaterialSkin.Controls.MaterialTextBox2();
			AddButton = new MaterialSkin.Controls.MaterialButton();
			materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
			materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
			materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
			materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
			materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
			PurchaseAddDataGridView = new DataGridView();
			dgvSr = new DataGridViewTextBoxColumn();
			dgvID = new DataGridViewTextBoxColumn();
			dgvItem = new DataGridViewTextBoxColumn();
			dgvQuantity = new DataGridViewTextBoxColumn();
			dgvCost = new DataGridViewTextBoxColumn();
			dgvAmount = new DataGridViewTextBoxColumn();
			dgvDate = new DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)PurchaseAddDataGridView).BeginInit();
			SuspendLayout();
			// 
			// dateTimePicker1
			// 
			dateTimePicker1.Location = new Point(861, 129);
			dateTimePicker1.Name = "dateTimePicker1";
			dateTimePicker1.Size = new Size(250, 27);
			dateTimePicker1.TabIndex = 10;
			// 
			// SupplierComboBox
			// 
			SupplierComboBox.AutoResize = false;
			SupplierComboBox.BackColor = Color.FromArgb(255, 255, 255);
			SupplierComboBox.Depth = 0;
			SupplierComboBox.DrawMode = DrawMode.OwnerDrawVariable;
			SupplierComboBox.DropDownHeight = 174;
			SupplierComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
			SupplierComboBox.DropDownWidth = 121;
			SupplierComboBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
			SupplierComboBox.ForeColor = Color.FromArgb(222, 0, 0, 0);
			SupplierComboBox.FormattingEnabled = true;
			SupplierComboBox.IntegralHeight = false;
			SupplierComboBox.ItemHeight = 43;
			SupplierComboBox.Location = new Point(105, 129);
			SupplierComboBox.MaxDropDownItems = 4;
			SupplierComboBox.MouseState = MaterialSkin.MouseState.OUT;
			SupplierComboBox.Name = "SupplierComboBox";
			SupplierComboBox.Size = new Size(300, 49);
			SupplierComboBox.StartIndex = 0;
			SupplierComboBox.TabIndex = 1;
			// 
			// ProductComboBox
			// 
			ProductComboBox.AutoResize = false;
			ProductComboBox.BackColor = Color.FromArgb(255, 255, 255);
			ProductComboBox.Depth = 0;
			ProductComboBox.DrawMode = DrawMode.OwnerDrawVariable;
			ProductComboBox.DropDownHeight = 174;
			ProductComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
			ProductComboBox.DropDownWidth = 121;
			ProductComboBox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
			ProductComboBox.ForeColor = Color.FromArgb(222, 0, 0, 0);
			ProductComboBox.FormattingEnabled = true;
			ProductComboBox.IntegralHeight = false;
			ProductComboBox.ItemHeight = 43;
			ProductComboBox.Location = new Point(105, 231);
			ProductComboBox.MaxDropDownItems = 4;
			ProductComboBox.MouseState = MaterialSkin.MouseState.OUT;
			ProductComboBox.Name = "ProductComboBox";
			ProductComboBox.Size = new Size(300, 49);
			ProductComboBox.StartIndex = 0;
			ProductComboBox.TabIndex = 3;
			ProductComboBox.SelectedIndexChanged += ProductComboBox_SelectedIndexChanged;
			// 
			// QuantityTextBox
			// 
			QuantityTextBox.AnimateReadOnly = false;
			QuantityTextBox.AutoCompleteMode = AutoCompleteMode.None;
			QuantityTextBox.AutoCompleteSource = AutoCompleteSource.None;
			QuantityTextBox.BackgroundImageLayout = ImageLayout.None;
			QuantityTextBox.CharacterCasing = CharacterCasing.Normal;
			QuantityTextBox.Depth = 0;
			QuantityTextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
			QuantityTextBox.HideSelection = true;
			QuantityTextBox.LeadingIcon = null;
			QuantityTextBox.Location = new Point(605, 232);
			QuantityTextBox.MaxLength = 32767;
			QuantityTextBox.MouseState = MaterialSkin.MouseState.OUT;
			QuantityTextBox.Name = "QuantityTextBox";
			QuantityTextBox.PasswordChar = '\0';
			QuantityTextBox.PrefixSuffixText = null;
			QuantityTextBox.ReadOnly = false;
			QuantityTextBox.RightToLeft = RightToLeft.No;
			QuantityTextBox.SelectedText = "";
			QuantityTextBox.SelectionLength = 0;
			QuantityTextBox.SelectionStart = 0;
			QuantityTextBox.ShortcutsEnabled = true;
			QuantityTextBox.Size = new Size(150, 48);
			QuantityTextBox.TabIndex = 5;
			QuantityTextBox.TabStop = false;
			QuantityTextBox.TextAlign = HorizontalAlignment.Left;
			QuantityTextBox.TrailingIcon = null;
			QuantityTextBox.UseSystemPasswordChar = false;
			QuantityTextBox.Click += QuantityTextBox_Click;
			QuantityTextBox.TextChanged += QuantityTextBox_TextChanged_1;
			// 
			// CostTextBox
			// 
			CostTextBox.AnimateReadOnly = false;
			CostTextBox.AutoCompleteMode = AutoCompleteMode.None;
			CostTextBox.AutoCompleteSource = AutoCompleteSource.None;
			CostTextBox.BackgroundImageLayout = ImageLayout.None;
			CostTextBox.CharacterCasing = CharacterCasing.Normal;
			CostTextBox.Depth = 0;
			CostTextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
			CostTextBox.HideSelection = true;
			CostTextBox.LeadingIcon = null;
			CostTextBox.Location = new Point(433, 232);
			CostTextBox.MaxLength = 32767;
			CostTextBox.MouseState = MaterialSkin.MouseState.OUT;
			CostTextBox.Name = "CostTextBox";
			CostTextBox.PasswordChar = '\0';
			CostTextBox.PrefixSuffixText = null;
			CostTextBox.ReadOnly = false;
			CostTextBox.RightToLeft = RightToLeft.No;
			CostTextBox.SelectedText = "";
			CostTextBox.SelectionLength = 0;
			CostTextBox.SelectionStart = 0;
			CostTextBox.ShortcutsEnabled = true;
			CostTextBox.Size = new Size(150, 48);
			CostTextBox.TabIndex = 7;
			CostTextBox.TabStop = false;
			CostTextBox.TextAlign = HorizontalAlignment.Left;
			CostTextBox.TrailingIcon = null;
			CostTextBox.UseSystemPasswordChar = false;
			CostTextBox.TextChanged += CostTextBox_TextChanged_1;
			// 
			// AmountTextBox
			// 
			AmountTextBox.AnimateReadOnly = false;
			AmountTextBox.AutoCompleteMode = AutoCompleteMode.None;
			AmountTextBox.AutoCompleteSource = AutoCompleteSource.None;
			AmountTextBox.BackgroundImageLayout = ImageLayout.None;
			AmountTextBox.CharacterCasing = CharacterCasing.Normal;
			AmountTextBox.Depth = 0;
			AmountTextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
			AmountTextBox.HideSelection = true;
			AmountTextBox.LeadingIcon = null;
			AmountTextBox.Location = new Point(776, 232);
			AmountTextBox.MaxLength = 32767;
			AmountTextBox.MouseState = MaterialSkin.MouseState.OUT;
			AmountTextBox.Name = "AmountTextBox";
			AmountTextBox.PasswordChar = '\0';
			AmountTextBox.PrefixSuffixText = null;
			AmountTextBox.ReadOnly = false;
			AmountTextBox.RightToLeft = RightToLeft.No;
			AmountTextBox.SelectedText = "";
			AmountTextBox.SelectionLength = 0;
			AmountTextBox.SelectionStart = 0;
			AmountTextBox.ShortcutsEnabled = true;
			AmountTextBox.Size = new Size(150, 48);
			AmountTextBox.TabIndex = 9;
			AmountTextBox.TabStop = false;
			AmountTextBox.TextAlign = HorizontalAlignment.Left;
			AmountTextBox.TrailingIcon = null;
			AmountTextBox.UseSystemPasswordChar = false;
			// 
			// AddButton
			// 
			AddButton.AutoSize = false;
			AddButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			AddButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			AddButton.Depth = 0;
			AddButton.HighEmphasis = true;
			AddButton.Icon = null;
			AddButton.Location = new Point(1002, 231);
			AddButton.Margin = new Padding(4, 6, 4, 6);
			AddButton.MouseState = MaterialSkin.MouseState.HOVER;
			AddButton.Name = "AddButton";
			AddButton.NoAccentTextColor = Color.Empty;
			AddButton.Padding = new Padding(20, 23, 23, 20);
			AddButton.Size = new Size(108, 47);
			AddButton.TabIndex = 11;
			AddButton.Text = "Add";
			AddButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			AddButton.UseAccentColor = false;
			AddButton.UseVisualStyleBackColor = true;
			AddButton.Click += AddButton_Click;
			// 
			// materialLabel1
			// 
			materialLabel1.AutoSize = true;
			materialLabel1.Depth = 0;
			materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
			materialLabel1.Location = new Point(105, 107);
			materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
			materialLabel1.Name = "materialLabel1";
			materialLabel1.Size = new Size(59, 19);
			materialLabel1.TabIndex = 0;
			materialLabel1.Text = "Supplier";
			// 
			// materialLabel2
			// 
			materialLabel2.AutoSize = true;
			materialLabel2.Depth = 0;
			materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
			materialLabel2.Location = new Point(104, 207);
			materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
			materialLabel2.Name = "materialLabel2";
			materialLabel2.Size = new Size(56, 19);
			materialLabel2.TabIndex = 2;
			materialLabel2.Text = "Product";
			// 
			// materialLabel3
			// 
			materialLabel3.AutoSize = true;
			materialLabel3.Depth = 0;
			materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
			materialLabel3.Location = new Point(605, 210);
			materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
			materialLabel3.Name = "materialLabel3";
			materialLabel3.Size = new Size(61, 19);
			materialLabel3.TabIndex = 4;
			materialLabel3.Text = "Quantity";
			// 
			// materialLabel4
			// 
			materialLabel4.AutoSize = true;
			materialLabel4.Depth = 0;
			materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
			materialLabel4.Location = new Point(433, 211);
			materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
			materialLabel4.Name = "materialLabel4";
			materialLabel4.Size = new Size(33, 19);
			materialLabel4.TabIndex = 6;
			materialLabel4.Text = "Cost";
			// 
			// materialLabel5
			// 
			materialLabel5.AutoSize = true;
			materialLabel5.Depth = 0;
			materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
			materialLabel5.Location = new Point(776, 210);
			materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
			materialLabel5.Name = "materialLabel5";
			materialLabel5.Size = new Size(57, 19);
			materialLabel5.TabIndex = 8;
			materialLabel5.Text = "Amount";
			// 
			// PurchaseAddDataGridView
			// 
			PurchaseAddDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			PurchaseAddDataGridView.BackgroundColor = SystemColors.InactiveBorder;
			PurchaseAddDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			PurchaseAddDataGridView.Columns.AddRange(new DataGridViewColumn[] { dgvSr, dgvID, dgvItem, dgvQuantity, dgvCost, dgvAmount, dgvDate });
			PurchaseAddDataGridView.Location = new Point(105, 308);
			PurchaseAddDataGridView.Name = "PurchaseAddDataGridView";
			PurchaseAddDataGridView.ReadOnly = true;
			PurchaseAddDataGridView.RowHeadersWidth = 51;
			PurchaseAddDataGridView.Size = new Size(1006, 253);
			PurchaseAddDataGridView.TabIndex = 12;
			PurchaseAddDataGridView.CellFormatting += PurchaseAddDataGridView_CellFormatting;
			// 
			// dgvSr
			// 
			dgvSr.HeaderText = "SrNo";
			dgvSr.MinimumWidth = 6;
			dgvSr.Name = "dgvSr";
			dgvSr.ReadOnly = true;
			// 
			// dgvID
			// 
			dgvID.HeaderText = "ID";
			dgvID.MinimumWidth = 6;
			dgvID.Name = "dgvID";
			dgvID.ReadOnly = true;
			dgvID.Visible = false;
			// 
			// dgvItem
			// 
			dgvItem.HeaderText = "Item";
			dgvItem.MinimumWidth = 6;
			dgvItem.Name = "dgvItem";
			dgvItem.ReadOnly = true;
			// 
			// dgvQuantity
			// 
			dgvQuantity.HeaderText = "Quantity";
			dgvQuantity.MinimumWidth = 6;
			dgvQuantity.Name = "dgvQuantity";
			dgvQuantity.ReadOnly = true;
			// 
			// dgvCost
			// 
			dgvCost.HeaderText = "Cost";
			dgvCost.MinimumWidth = 6;
			dgvCost.Name = "dgvCost";
			dgvCost.ReadOnly = true;
			// 
			// dgvAmount
			// 
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
			// AddPurchases
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1221, 683);
			Controls.Add(PurchaseAddDataGridView);
			Controls.Add(materialLabel5);
			Controls.Add(materialLabel4);
			Controls.Add(materialLabel3);
			Controls.Add(materialLabel2);
			Controls.Add(materialLabel1);
			Controls.Add(AddButton);
			Controls.Add(AmountTextBox);
			Controls.Add(CostTextBox);
			Controls.Add(QuantityTextBox);
			Controls.Add(ProductComboBox);
			Controls.Add(SupplierComboBox);
			Controls.Add(dateTimePicker1);
			Location = new Point(0, 0);
			Name = "AddPurchases";
			Text = "Add Purchase";
			Load += AddPurchases_Load;
			Controls.SetChildIndex(dateTimePicker1, 0);
			Controls.SetChildIndex(SupplierComboBox, 0);
			Controls.SetChildIndex(ProductComboBox, 0);
			Controls.SetChildIndex(QuantityTextBox, 0);
			Controls.SetChildIndex(CostTextBox, 0);
			Controls.SetChildIndex(AmountTextBox, 0);
			Controls.SetChildIndex(AddButton, 0);
			Controls.SetChildIndex(materialLabel1, 0);
			Controls.SetChildIndex(materialLabel2, 0);
			Controls.SetChildIndex(materialLabel3, 0);
			Controls.SetChildIndex(materialLabel4, 0);
			Controls.SetChildIndex(materialLabel5, 0);
			Controls.SetChildIndex(PurchaseAddDataGridView, 0);
			((System.ComponentModel.ISupportInitialize)PurchaseAddDataGridView).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DateTimePicker dateTimePicker1;
		private MaterialSkin.Controls.MaterialComboBox SupplierComboBox;
		private MaterialSkin.Controls.MaterialComboBox ProductComboBox;
		private MaterialSkin.Controls.MaterialTextBox2 QuantityTextBox;
		private MaterialSkin.Controls.MaterialTextBox2 CostTextBox;
		private MaterialSkin.Controls.MaterialTextBox2 AmountTextBox;
		private MaterialSkin.Controls.MaterialButton AddButton;
		private MaterialSkin.Controls.MaterialLabel materialLabel1;
		private MaterialSkin.Controls.MaterialLabel materialLabel2;
		private MaterialSkin.Controls.MaterialLabel materialLabel3;
		private MaterialSkin.Controls.MaterialLabel materialLabel4;
		private MaterialSkin.Controls.MaterialLabel materialLabel5;
		private DataGridView PurchaseAddDataGridView;
		private DataGridViewTextBoxColumn dgvSr;
		private DataGridViewTextBoxColumn dgvID;
		private DataGridViewTextBoxColumn dgvItem;
		private DataGridViewTextBoxColumn dgvQuantity;
		private DataGridViewTextBoxColumn dgvCost;
		private DataGridViewTextBoxColumn dgvAmount;
		private DataGridViewTextBoxColumn dgvDate;
	}
}