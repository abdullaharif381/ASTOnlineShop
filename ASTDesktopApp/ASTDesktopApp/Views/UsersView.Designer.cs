namespace ASTDesktopApp.Views
{
    partial class UsersView
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
            UserDataGridView = new DataGridView();
            dgvSr = new DataGridViewTextBoxColumn();
            dgvID = new DataGridViewTextBoxColumn();
            dgvUsername = new DataGridViewTextBoxColumn();
            dgvPassword = new DataGridViewTextBoxColumn();
            dgvRole = new DataGridViewTextBoxColumn();
            dvgEdit = new DataGridViewImageColumn();
            dvgDel = new DataGridViewImageColumn();
            TopViewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UserDataGridView).BeginInit();
            SuspendLayout();
            // 
            // SearchTextBox
            // 
            SearchTextBox.Click += SearchTextBox_Click_1;
            // 
            // UserDataGridView
            // 
            UserDataGridView.AllowUserToAddRows = false;
            UserDataGridView.AllowUserToDeleteRows = false;
            UserDataGridView.BackgroundColor = Color.FromArgb(238, 238, 238);
            UserDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UserDataGridView.Columns.AddRange(new DataGridViewColumn[] { dgvSr, dgvID, dgvUsername, dgvPassword, dgvRole, dvgEdit, dvgDel });
            UserDataGridView.Dock = DockStyle.Fill;
            UserDataGridView.EditMode = DataGridViewEditMode.EditOnF2;
            UserDataGridView.Location = new Point(3, 169);
            UserDataGridView.Name = "UserDataGridView";
            UserDataGridView.ReadOnly = true;
            UserDataGridView.RowHeadersWidth = 51;
            UserDataGridView.Size = new Size(794, 278);
            UserDataGridView.TabIndex = 4;
            UserDataGridView.CellContentClick += UserDataGridView_CellContentClick;
            // 
            // dgvSr
            // 
            dgvSr.FillWeight = 20F;
            dgvSr.HeaderText = "Sr.";
            dgvSr.MinimumWidth = 20;
            dgvSr.Name = "dgvSr";
            dgvSr.ReadOnly = true;
            dgvSr.Width = 40;
            // 
            // dgvID
            // 
            dgvID.HeaderText = "ID";
            dgvID.MinimumWidth = 6;
            dgvID.Name = "dgvID";
            dgvID.ReadOnly = true;
            dgvID.Visible = false;
            dgvID.Width = 125;
            // 
            // dgvUsername
            // 
            dgvUsername.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvUsername.HeaderText = "Username";
            dgvUsername.MinimumWidth = 6;
            dgvUsername.Name = "dgvUsername";
            dgvUsername.ReadOnly = true;
            // 
            // dgvPassword
            // 
            dgvPassword.HeaderText = "Password";
            dgvPassword.MinimumWidth = 6;
            dgvPassword.Name = "dgvPassword";
            dgvPassword.ReadOnly = true;
            dgvPassword.Visible = false;
            dgvPassword.Width = 125;
            // 
            // dgvRole
            // 
            dgvRole.HeaderText = "Role";
            dgvRole.MinimumWidth = 6;
            dgvRole.Name = "dgvRole";
            dgvRole.ReadOnly = true;
            dgvRole.Width = 125;
            // 
            // dvgEdit
            // 
            dvgEdit.FillWeight = 40F;
            dvgEdit.HeaderText = "";
            dvgEdit.Image = Properties.Resources.edit;
            dvgEdit.MinimumWidth = 40;
            dvgEdit.Name = "dvgEdit";
            dvgEdit.ReadOnly = true;
            dvgEdit.Width = 40;
            // 
            // dvgDel
            // 
            dvgDel.FillWeight = 40F;
            dvgDel.HeaderText = "";
            dvgDel.Image = Properties.Resources.del;
            dvgDel.MinimumWidth = 40;
            dvgDel.Name = "dvgDel";
            dvgDel.ReadOnly = true;
            dvgDel.Width = 40;
            // 
            // UsersView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(UserDataGridView);
            Location = new Point(0, 0);
            Name = "UsersView";
            Text = "UsersView";
            Controls.SetChildIndex(TopViewPanel, 0);
            Controls.SetChildIndex(SearchTextBox, 0);
            Controls.SetChildIndex(materialLabel1, 0);
            Controls.SetChildIndex(UserDataGridView, 0);
            TopViewPanel.ResumeLayout(false);
            TopViewPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UserDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView UserDataGridView;
        private DataGridViewTextBoxColumn dgvSr;
        private DataGridViewTextBoxColumn dgvID;
        private DataGridViewTextBoxColumn dgvUsername;
        private DataGridViewTextBoxColumn dgvPassword;
        private DataGridViewTextBoxColumn dgvRole;
        private DataGridViewImageColumn dvgEdit;
        private DataGridViewImageColumn dvgDel;
    }
}