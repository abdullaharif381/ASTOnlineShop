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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            UserDataGridView = new DataGridView();
            dgvID = new DataGridViewTextBoxColumn();
            dgvUsername = new DataGridViewTextBoxColumn();
            dgvPassword = new DataGridViewTextBoxColumn();
            dgvRole = new DataGridViewTextBoxColumn();
            dgvEdit = new DataGridViewImageColumn();
            dgvDel = new DataGridViewImageColumn();
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
            UserDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            UserDataGridView.BackgroundColor = SystemColors.InactiveBorder;
            UserDataGridView.BorderStyle = BorderStyle.Fixed3D;
            UserDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            UserDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UserDataGridView.Columns.AddRange(new DataGridViewColumn[] { dgvID, dgvUsername, dgvPassword, dgvRole, dgvEdit, dgvDel });
            UserDataGridView.Dock = DockStyle.Fill;
            UserDataGridView.EditMode = DataGridViewEditMode.EditOnEnter;
            UserDataGridView.Location = new Point(3, 169);
            UserDataGridView.Name = "UserDataGridView";
            UserDataGridView.ReadOnly = true;
            UserDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = Color.AliceBlue;
            dataGridViewCellStyle5.Padding = new Padding(10, 0, 10, 2);
            UserDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            UserDataGridView.ScrollBars = ScrollBars.Horizontal;
            UserDataGridView.Size = new Size(794, 278);
            UserDataGridView.TabIndex = 4;
            UserDataGridView.CellContentClick += UserDataGridView_CellContentClick;
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
            // dgvUsername
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.AliceBlue;
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(34, 40, 49);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 173, 181);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(34, 40, 49);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvUsername.DefaultCellStyle = dataGridViewCellStyle2;
            dgvUsername.FillWeight = 95.0780258F;
            dgvUsername.HeaderText = "User";
            dgvUsername.MinimumWidth = 6;
            dgvUsername.Name = "dgvUsername";
            dgvUsername.ReadOnly = true;
            // 
            // dgvPassword
            // 
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvPassword.DefaultCellStyle = dataGridViewCellStyle3;
            dgvPassword.HeaderText = "Password";
            dgvPassword.MinimumWidth = 6;
            dgvPassword.Name = "dgvPassword";
            dgvPassword.ReadOnly = true;
            dgvPassword.Visible = false;
            // 
            // dgvRole
            // 
            dgvRole.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.AliceBlue;
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(34, 40, 49);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(0, 173, 181);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(34, 40, 49);
            dgvRole.DefaultCellStyle = dataGridViewCellStyle4;
            dgvRole.HeaderText = "Role";
            dgvRole.MinimumWidth = 6;
            dgvRole.Name = "dgvRole";
            dgvRole.ReadOnly = true;
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
            // UsersView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(UserDataGridView);
            Location = new Point(0, 0);
            Name = "UsersView";
            Text = "Users";
            
            //Controls.SetChildIndex(materialLabel1, 0);
            Controls.SetChildIndex(UserDataGridView, 0);
            TopViewPanel.ResumeLayout(false);
            TopViewPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UserDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView UserDataGridView;
        private DataGridViewTextBoxColumn dgvID;
        private DataGridViewTextBoxColumn dgvUsername;
        private DataGridViewTextBoxColumn dgvPassword;
        private DataGridViewTextBoxColumn dgvRole;
        private DataGridViewImageColumn dgvEdit;
        private DataGridViewImageColumn dgvDel;
    }
}