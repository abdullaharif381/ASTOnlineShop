﻿namespace ASTDesktopApp.Views
{
    partial class SuppliersView
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            SupplierDataGridView = new DataGridView();
            SrNo = new DataGridViewTextBoxColumn();
            dgvID = new DataGridViewTextBoxColumn();
            dgvName = new DataGridViewTextBoxColumn();
            dgvAddress = new DataGridViewTextBoxColumn();
            dgvPhone = new DataGridViewTextBoxColumn();
            dgvEdit = new DataGridViewImageColumn();
            dgvDel = new DataGridViewImageColumn();
            TopViewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SupplierDataGridView).BeginInit();
            SuspendLayout();
            // 
            // SupplierDataGridView
            // 
            SupplierDataGridView.AllowUserToAddRows = false;
            SupplierDataGridView.AllowUserToDeleteRows = false;
            SupplierDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SupplierDataGridView.BackgroundColor = SystemColors.InactiveBorder;
            SupplierDataGridView.BorderStyle = BorderStyle.Fixed3D;
            SupplierDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            SupplierDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SupplierDataGridView.Columns.AddRange(new DataGridViewColumn[] { SrNo, dgvID, dgvName, dgvAddress, dgvPhone, dgvEdit, dgvDel });
            SupplierDataGridView.Dock = DockStyle.Fill;
            SupplierDataGridView.EditMode = DataGridViewEditMode.EditOnEnter;
            SupplierDataGridView.Location = new Point(3, 169);
            SupplierDataGridView.Name = "SupplierDataGridView";
            SupplierDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle1.BackColor = Color.AliceBlue;
            dataGridViewCellStyle1.Padding = new Padding(10, 0, 10, 2);
            SupplierDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            SupplierDataGridView.ScrollBars = ScrollBars.Horizontal;
            SupplierDataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            SupplierDataGridView.Size = new Size(794, 278);
            SupplierDataGridView.TabIndex = 6;
            SupplierDataGridView.CellContentClick += SupplierDataGridView_CellContentClick_2;
            // 
            // SrNo
            // 
            SrNo.HeaderText = "SrNo";
            SrNo.MinimumWidth = 6;
            SrNo.Name = "SrNo";
            // 
            // dgvID
            // 
            dgvID.HeaderText = "ID";
            dgvID.MinimumWidth = 6;
            dgvID.Name = "dgvID";
            dgvID.Resizable = DataGridViewTriState.True;
            // 
            // dgvName
            // 
            dgvName.HeaderText = "Name";
            dgvName.MinimumWidth = 6;
            dgvName.Name = "dgvName";
            // 
            // dgvAddress
            // 
            dgvAddress.HeaderText = "Address";
            dgvAddress.MinimumWidth = 6;
            dgvAddress.Name = "dgvAddress";
            // 
            // dgvPhone
            // 
            dgvPhone.HeaderText = "Phone";
            dgvPhone.MinimumWidth = 6;
            dgvPhone.Name = "dgvPhone";
            // 
            // dgvEdit
            // 
            dgvEdit.HeaderText = "";
            dgvEdit.Image = Properties.Resources.pen;
            dgvEdit.MinimumWidth = 6;
            dgvEdit.Name = "dgvEdit";
            dgvEdit.Resizable = DataGridViewTriState.True;
            // 
            // dgvDel
            // 
            dgvDel.HeaderText = "";
            dgvDel.Image = Properties.Resources.trash;
            dgvDel.MinimumWidth = 6;
            dgvDel.Name = "dgvDel";
            dgvDel.Resizable = DataGridViewTriState.True;
            // 
            // SuppliersView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SupplierDataGridView);
            Location = new Point(0, 0);
            Name = "SuppliersView";
            Text = "Suppliers";
            Load += SuppliersView_Load_1;
            Controls.SetChildIndex(TopViewPanel, 0);
            Controls.SetChildIndex(SupplierDataGridView, 0);
            TopViewPanel.ResumeLayout(false);
            TopViewPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SupplierDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView SupplierDataGridView;
        private DataGridViewTextBoxColumn SrNo;
        private DataGridViewTextBoxColumn dgvID;
        private DataGridViewTextBoxColumn dgvName;
        private DataGridViewTextBoxColumn dgvAddress;
        private DataGridViewTextBoxColumn dgvPhone;
        private DataGridViewImageColumn dgvEdit;
        private DataGridViewImageColumn dgvDel;
    }
}