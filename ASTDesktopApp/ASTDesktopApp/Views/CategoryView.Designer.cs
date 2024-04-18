namespace ASTDesktopApp.Views
{
    partial class CategoryView
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            CategoryDataGridView = new DataGridView();
            SrNo = new DataGridViewTextBoxColumn();
            dgvID = new DataGridViewTextBoxColumn();
            dgvName = new DataGridViewTextBoxColumn();
            dgvEdit = new DataGridViewImageColumn();
            dgvDel = new DataGridViewImageColumn();
            TopViewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CategoryDataGridView).BeginInit();
            SuspendLayout();
            // 
            // SearchTextBox
            // 
            SearchTextBox.Location = new Point(371, 24);
            // 
            // TopViewPanel
            // 
            TopViewPanel.Paint += TopViewPanel_Paint;
            // 
            // CategoryDataGridView
            // 
            CategoryDataGridView.AllowUserToAddRows = false;
            CategoryDataGridView.AllowUserToDeleteRows = false;
            CategoryDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            CategoryDataGridView.BackgroundColor = SystemColors.InactiveBorder;
            CategoryDataGridView.BorderStyle = BorderStyle.Fixed3D;
            CategoryDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            CategoryDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CategoryDataGridView.Columns.AddRange(new DataGridViewColumn[] { SrNo, dgvID, dgvName, dgvEdit, dgvDel });
            CategoryDataGridView.Dock = DockStyle.Fill;
            CategoryDataGridView.EditMode = DataGridViewEditMode.EditOnEnter;
            CategoryDataGridView.Location = new Point(3, 169);
            CategoryDataGridView.Name = "CategoryDataGridView";
            CategoryDataGridView.ReadOnly = true;
            CategoryDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = Color.AliceBlue;
            dataGridViewCellStyle3.Padding = new Padding(10, 0, 10, 2);
            CategoryDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            CategoryDataGridView.ScrollBars = ScrollBars.Horizontal;
            CategoryDataGridView.Size = new Size(794, 278);
            CategoryDataGridView.TabIndex = 5;
            CategoryDataGridView.CellContentClick += CategoryDataGridView_CellContentClick;
            // 
            // SrNo
            // 
            SrNo.HeaderText = "SrNo";
            SrNo.MinimumWidth = 6;
            SrNo.Name = "SrNo";
            SrNo.ReadOnly = true;
            SrNo.Width = 6;
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
            dgvID.Width = 50;
            // 
            // dgvName
            // 
            dgvName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.AliceBlue;
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(34, 40, 49);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 173, 181);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(34, 40, 49);
            dgvName.DefaultCellStyle = dataGridViewCellStyle2;
            dgvName.HeaderText = "Category Name";
            dgvName.MinimumWidth = 6;
            dgvName.Name = "dgvName";
            dgvName.ReadOnly = true;
            // 
            // dgvEdit
            // 
            dgvEdit.HeaderText = "";
            dgvEdit.Image = Properties.Resources.pen;
            dgvEdit.MinimumWidth = 6;
            dgvEdit.Name = "dgvEdit";
            dgvEdit.ReadOnly = true;
            dgvEdit.Width = 6;
            // 
            // dgvDel
            // 
            dgvDel.HeaderText = "";
            dgvDel.Image = Properties.Resources.trash;
            dgvDel.MinimumWidth = 6;
            dgvDel.Name = "dgvDel";
            dgvDel.ReadOnly = true;
            dgvDel.Width = 6;
            // 
            // CategoryView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CategoryDataGridView);
            Location = new Point(0, 0);
            Name = "CategoryView";
            Text = "Categories";
            Load += CategoryView_Load;
            Controls.SetChildIndex(TopViewPanel, 0);
            Controls.SetChildIndex(CategoryDataGridView, 0);
            TopViewPanel.ResumeLayout(false);
            TopViewPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CategoryDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView CategoryDataGridView;
        private DataGridViewTextBoxColumn SrNo;
        private DataGridViewTextBoxColumn dgvID;
        private DataGridViewTextBoxColumn dgvName;
        private DataGridViewImageColumn dgvEdit;
        private DataGridViewImageColumn dgvDel;
    }
}