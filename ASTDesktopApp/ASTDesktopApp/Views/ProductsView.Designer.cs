namespace ASTDesktopApp.Views
{
    partial class ProductsView
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
            ProductDataGridView = new DataGridView();
            dgvSrNo = new DataGridViewTextBoxColumn();
            dgvID = new DataGridViewTextBoxColumn();
            dgvItem = new DataGridViewTextBoxColumn();
            dgvCategoryID = new DataGridViewTextBoxColumn();
            dgvCategoryName = new DataGridViewTextBoxColumn();
            dgvDetail = new DataGridViewTextBoxColumn();
            dgvPrice = new DataGridViewTextBoxColumn();
            gdvPrice = new DataGridViewTextBoxColumn();
            dgvCost = new DataGridViewTextBoxColumn();
            dgvEdit = new DataGridViewImageColumn();
            dgvDel = new DataGridViewImageColumn();
            TopViewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProductDataGridView).BeginInit();
            SuspendLayout();
            // 
            // ProductDataGridView
            // 
            ProductDataGridView.AllowUserToAddRows = false;
            ProductDataGridView.AllowUserToDeleteRows = false;
            ProductDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductDataGridView.Columns.AddRange(new DataGridViewColumn[] { dgvSrNo, dgvID, dgvItem, dgvCategoryID, dgvCategoryName, dgvDetail, dgvPrice, gdvPrice, dgvCost, dgvEdit, dgvDel });
            ProductDataGridView.Dock = DockStyle.Fill;
            ProductDataGridView.GridColor = Color.Teal;
            ProductDataGridView.Location = new Point(3, 169);
            ProductDataGridView.Name = "ProductDataGridView";
            ProductDataGridView.ReadOnly = true;
            ProductDataGridView.RowHeadersWidth = 51;
            ProductDataGridView.Size = new Size(794, 278);
            ProductDataGridView.TabIndex = 4;
            ProductDataGridView.CellContentClick += ProductDataGridView_CellContentClick_1;
            // 
            // dgvSrNo
            // 
            dgvSrNo.HeaderText = "SrNo";
            dgvSrNo.MinimumWidth = 6;
            dgvSrNo.Name = "dgvSrNo";
            dgvSrNo.ReadOnly = true;
            dgvSrNo.Width = 125;
            // 
            // dgvID
            // 
            dgvID.HeaderText = "ID";
            dgvID.MinimumWidth = 6;
            dgvID.Name = "dgvID";
            dgvID.ReadOnly = true;
            dgvID.Width = 125;
            // 
            // dgvItem
            // 
            dgvItem.HeaderText = "Product";
            dgvItem.MinimumWidth = 6;
            dgvItem.Name = "dgvItem";
            dgvItem.ReadOnly = true;
            dgvItem.Width = 125;
            // 
            // dgvCategoryID
            // 
            dgvCategoryID.HeaderText = "Category";
            dgvCategoryID.MinimumWidth = 6;
            dgvCategoryID.Name = "dgvCategoryID";
            dgvCategoryID.ReadOnly = true;
            dgvCategoryID.Visible = false;
            dgvCategoryID.Width = 125;
            // 
            // dgvCategoryName
            // 
            dgvCategoryName.HeaderText = "Category";
            dgvCategoryName.MinimumWidth = 6;
            dgvCategoryName.Name = "dgvCategoryName";
            dgvCategoryName.ReadOnly = true;
            dgvCategoryName.Width = 125;
            // 
            // dgvDetail
            // 
            dgvDetail.HeaderText = "Product Details";
            dgvDetail.MinimumWidth = 6;
            dgvDetail.Name = "dgvDetail";
            dgvDetail.ReadOnly = true;
            dgvDetail.Width = 125;
            // 
            // dgvPrice
            // 
            dgvPrice.HeaderText = "Sale Price";
            dgvPrice.MinimumWidth = 6;
            dgvPrice.Name = "dgvPrice";
            dgvPrice.ReadOnly = true;
            dgvPrice.Width = 125;
            // 
            // gdvPrice
            // 
            gdvPrice.HeaderText = "Sale Price";
            gdvPrice.MinimumWidth = 6;
            gdvPrice.Name = "gdvPrice";
            gdvPrice.ReadOnly = true;
            gdvPrice.Width = 125;
            // 
            // dgvCost
            // 
            dgvCost.HeaderText = "Cost";
            dgvCost.MinimumWidth = 6;
            dgvCost.Name = "dgvCost";
            dgvCost.ReadOnly = true;
            dgvCost.Width = 125;
            // 
            // dgvEdit
            // 
            dgvEdit.HeaderText = "Edit";
            dgvEdit.Image = Properties.Resources.pen;
            dgvEdit.MinimumWidth = 6;
            dgvEdit.Name = "dgvEdit";
            dgvEdit.ReadOnly = true;
            dgvEdit.Resizable = DataGridViewTriState.True;
            dgvEdit.SortMode = DataGridViewColumnSortMode.Automatic;
            dgvEdit.Width = 125;
            // 
            // dgvDel
            // 
            dgvDel.HeaderText = "Del";
            dgvDel.MinimumWidth = 6;
            dgvDel.Name = "dgvDel";
            dgvDel.ReadOnly = true;
            dgvDel.Width = 125;
            // 
            // ProductsView
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new Size(800, 450);
            Controls.Add(ProductDataGridView);
            Location = new Point(0, 0);
            Name = "ProductsView";
            Text = "Products";
            Controls.SetChildIndex(TopViewPanel, 0);
            Controls.SetChildIndex(ProductDataGridView, 0);
            TopViewPanel.ResumeLayout(false);
            TopViewPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ProductDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ProductDataGridView;
        private DataGridViewTextBoxColumn dgvSrNo;
        private DataGridViewTextBoxColumn dgvID;
        private DataGridViewTextBoxColumn dgvItem;
        private DataGridViewTextBoxColumn dgvCategoryID;
        private DataGridViewTextBoxColumn dgvCategoryName;
        private DataGridViewTextBoxColumn dgvDetail;
        private DataGridViewTextBoxColumn dgvPrice;
        private DataGridViewTextBoxColumn gdvPrice;
        private DataGridViewTextBoxColumn dgvCost;
        private DataGridViewImageColumn dgvEdit;
        private DataGridViewImageColumn dgvDel;
    }
}