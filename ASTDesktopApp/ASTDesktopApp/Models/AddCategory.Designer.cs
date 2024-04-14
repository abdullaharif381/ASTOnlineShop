namespace ASTDesktopApp.Models
{
    partial class AddCategory
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
            materialTextBox21 = new MaterialSkin.Controls.MaterialTextBox2();
            NameTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            label1 = new Label();
            SuspendLayout();
            // 
            // materialTextBox21
            // 
            materialTextBox21.AnimateReadOnly = false;
            materialTextBox21.AutoCompleteMode = AutoCompleteMode.None;
            materialTextBox21.AutoCompleteSource = AutoCompleteSource.None;
            materialTextBox21.BackgroundImageLayout = ImageLayout.None;
            materialTextBox21.CharacterCasing = CharacterCasing.Normal;
            materialTextBox21.Depth = 0;
            materialTextBox21.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox21.HideSelection = true;
            materialTextBox21.LeadingIcon = null;
            materialTextBox21.Location = new Point(298, 849);
            materialTextBox21.MaxLength = 32767;
            materialTextBox21.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox21.Name = "materialTextBox21";
            materialTextBox21.PasswordChar = '\0';
            materialTextBox21.PrefixSuffixText = null;
            materialTextBox21.ReadOnly = false;
            materialTextBox21.RightToLeft = RightToLeft.No;
            materialTextBox21.SelectedText = "";
            materialTextBox21.SelectionLength = 0;
            materialTextBox21.SelectionStart = 0;
            materialTextBox21.ShortcutsEnabled = true;
            materialTextBox21.Size = new Size(312, 48);
            materialTextBox21.TabIndex = 2;
            materialTextBox21.TabStop = false;
            materialTextBox21.Text = "materialTextBox21";
            materialTextBox21.TextAlign = HorizontalAlignment.Left;
            materialTextBox21.TrailingIcon = null;
            materialTextBox21.UseSystemPasswordChar = false;
            // 
            // NameTextBox
            // 
            NameTextBox.AnimateReadOnly = false;
            NameTextBox.AutoCompleteMode = AutoCompleteMode.None;
            NameTextBox.AutoCompleteSource = AutoCompleteSource.None;
            NameTextBox.BackgroundImageLayout = ImageLayout.None;
            NameTextBox.CharacterCasing = CharacterCasing.Normal;
            NameTextBox.Depth = 0;
            NameTextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            NameTextBox.HideSelection = true;
            NameTextBox.LeadingIcon = null;
            NameTextBox.Location = new Point(25, 209);
            NameTextBox.MaxLength = 32767;
            NameTextBox.MouseState = MaterialSkin.MouseState.OUT;
            NameTextBox.Name = "NameTextBox";
            NameTextBox.PasswordChar = '\0';
            NameTextBox.PrefixSuffixText = null;
            NameTextBox.ReadOnly = false;
            NameTextBox.RightToLeft = RightToLeft.No;
            NameTextBox.SelectedText = "";
            NameTextBox.SelectionLength = 0;
            NameTextBox.SelectionStart = 0;
            NameTextBox.ShortcutsEnabled = true;
            NameTextBox.Size = new Size(310, 48);
            NameTextBox.TabIndex = 3;
            NameTextBox.TabStop = false;
            NameTextBox.TextAlign = HorizontalAlignment.Left;
            NameTextBox.TrailingIcon = null;
            NameTextBox.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 186);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 4;
            label1.Text = "Category Name";
            label1.Click += label1_Click;
            // 
            // AddCategory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 450);
            Controls.Add(label1);
            Controls.Add(NameTextBox);
            Controls.Add(materialTextBox21);
            Location = new Point(0, 0);
            Name = "AddCategory";
            Text = "Add Category";
            Controls.SetChildIndex(materialTextBox21, 0);
            Controls.SetChildIndex(NameTextBox, 0);
            Controls.SetChildIndex(label1, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox21;
        private MaterialSkin.Controls.MaterialTextBox2 NameTextBox;
        private Label label1;
    }
}