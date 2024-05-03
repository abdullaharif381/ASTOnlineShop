namespace ASTDesktopApp.Models
{
    partial class AddProducts
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
            try
            {
                // The code that may throw the KeyNotFoundException
                // For example:
                // MaterialSkinManager.getFontByType(fontType type, RightToLeft RightToLeft);


                materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
                NameTextBox = new MaterialSkin.Controls.MaterialTextBox2();
                CategoryComboBox = new MaterialSkin.Controls.MaterialComboBox();
                DetailMultiLineTextBox = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
                CostTextBox = new MaterialSkin.Controls.MaterialTextBox2();
                materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
                PriceTextBox = new MaterialSkin.Controls.MaterialTextBox2();
                materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
                ProductPictureBox = new PictureBox();
                materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
                materialButton1 = new MaterialSkin.Controls.MaterialButton();
                materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
                ((System.ComponentModel.ISupportInitialize)ProductPictureBox).BeginInit();
                SuspendLayout();
                // 
                // materialLabel1
                // 
                materialLabel1.AutoSize = true;
                materialLabel1.Depth = 0;
                materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
                materialLabel1.Location = new Point(28, 96);
                materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
                materialLabel1.Name = "materialLabel1";
                materialLabel1.Size = new Size(78, 19);
                materialLabel1.TabIndex = 2;
                materialLabel1.Text = "Item Name";
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
                NameTextBox.Location = new Point(25, 129);
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
                NameTextBox.Size = new Size(223, 48);
                NameTextBox.TabIndex = 3;
                NameTextBox.TabStop = false;
                NameTextBox.TextAlign = HorizontalAlignment.Left;
                NameTextBox.TrailingIcon = null;
                NameTextBox.UseSystemPasswordChar = false;
                // 
                // CategoryComboBox
                // 
                CategoryComboBox.AutoResize = false;
                CategoryComboBox.BackColor = Color.FromArgb(255, 255, 255);
                CategoryComboBox.Depth = 0;
                CategoryComboBox.DrawMode = DrawMode.OwnerDrawVariable;
                CategoryComboBox.DropDownHeight = 174;
                CategoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                CategoryComboBox.DropDownWidth = 121;
                CategoryComboBox.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
                CategoryComboBox.ForeColor = Color.FromArgb(222, 0, 0, 0);
                CategoryComboBox.FormattingEnabled = true;
                CategoryComboBox.IntegralHeight = false;
                CategoryComboBox.ItemHeight = 43;
                CategoryComboBox.Location = new Point(284, 128);
                CategoryComboBox.MaxDropDownItems = 4;
                CategoryComboBox.MouseState = MaterialSkin.MouseState.OUT;
                CategoryComboBox.Name = "CategoryComboBox";
                CategoryComboBox.Size = new Size(241, 49);
                CategoryComboBox.StartIndex = 0;
                CategoryComboBox.TabIndex = 4;
                // 
                // DetailMultiLineTextBox
                // 
                DetailMultiLineTextBox.AnimateReadOnly = false;
                DetailMultiLineTextBox.BackgroundImageLayout = ImageLayout.None;
                DetailMultiLineTextBox.CharacterCasing = CharacterCasing.Normal;
                DetailMultiLineTextBox.Depth = 0;
                DetailMultiLineTextBox.HideSelection = true;
                DetailMultiLineTextBox.Location = new Point(25, 210);
                DetailMultiLineTextBox.MaxLength = 32767;
                DetailMultiLineTextBox.MouseState = MaterialSkin.MouseState.OUT;
                DetailMultiLineTextBox.Name = "DetailMultiLineTextBox";
                DetailMultiLineTextBox.PasswordChar = '\0';
                DetailMultiLineTextBox.ReadOnly = false;
                DetailMultiLineTextBox.ScrollBars = ScrollBars.None;
                DetailMultiLineTextBox.SelectedText = "";
                DetailMultiLineTextBox.SelectionLength = 0;
                DetailMultiLineTextBox.SelectionStart = 0;
                DetailMultiLineTextBox.ShortcutsEnabled = true;
                DetailMultiLineTextBox.Size = new Size(223, 125);
                DetailMultiLineTextBox.TabIndex = 5;
                DetailMultiLineTextBox.TabStop = false;
                DetailMultiLineTextBox.Text = "Details of the product go here";
                DetailMultiLineTextBox.TextAlign = HorizontalAlignment.Left;
                DetailMultiLineTextBox.UseSystemPasswordChar = false;
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
                CostTextBox.Location = new Point(284, 287);
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
                CostTextBox.Size = new Size(107, 48);
                CostTextBox.TabIndex = 8;
                CostTextBox.TabStop = false;
                CostTextBox.Text = "0";
                CostTextBox.TextAlign = HorizontalAlignment.Left;
                CostTextBox.TrailingIcon = null;
                CostTextBox.UseSystemPasswordChar = false;
                // 
                // materialLabel3
                // 
                materialLabel3.AutoSize = true;
                materialLabel3.Depth = 0;
                materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
                materialLabel3.Location = new Point(284, 265);
                materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
                materialLabel3.Name = "materialLabel3";
                materialLabel3.Size = new Size(70, 19);
                materialLabel3.TabIndex = 7;
                materialLabel3.Text = "Cost (Rs.)";
                // 
                // PriceTextBox
                // 
                PriceTextBox.AnimateReadOnly = false;
                PriceTextBox.AutoCompleteMode = AutoCompleteMode.None;
                PriceTextBox.AutoCompleteSource = AutoCompleteSource.None;
                PriceTextBox.BackgroundImageLayout = ImageLayout.None;
                PriceTextBox.CharacterCasing = CharacterCasing.Normal;
                PriceTextBox.Depth = 0;
                PriceTextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
                PriceTextBox.HideSelection = true;
                PriceTextBox.LeadingIcon = null;
                PriceTextBox.Location = new Point(413, 287);
                PriceTextBox.MaxLength = 32767;
                PriceTextBox.MouseState = MaterialSkin.MouseState.OUT;
                PriceTextBox.Name = "PriceTextBox";
                PriceTextBox.PasswordChar = '\0';
                PriceTextBox.PrefixSuffixText = null;
                PriceTextBox.ReadOnly = false;
                PriceTextBox.RightToLeft = RightToLeft.No;
                PriceTextBox.SelectedText = "";
                PriceTextBox.SelectionLength = 0;
                PriceTextBox.SelectionStart = 0;
                PriceTextBox.ShortcutsEnabled = true;
                PriceTextBox.Size = new Size(112, 48);
                PriceTextBox.TabIndex = 10;
                PriceTextBox.TabStop = false;
                PriceTextBox.Text = "0";
                PriceTextBox.TextAlign = HorizontalAlignment.Left;
                PriceTextBox.TrailingIcon = null;
                PriceTextBox.UseSystemPasswordChar = false;
                // 
                // materialLabel4
                // 
                materialLabel4.AutoSize = true;
                materialLabel4.Depth = 0;
                materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
                materialLabel4.Location = new Point(413, 265);
                materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
                materialLabel4.Name = "materialLabel4";
                materialLabel4.Size = new Size(108, 19);
                materialLabel4.TabIndex = 9;
                materialLabel4.Text = "Sale Price (Rs.)";
                // 
                // ProductPictureBox
                // 
                ProductPictureBox.BorderStyle = BorderStyle.FixedSingle;
                ProductPictureBox.ErrorImage = null;
                ProductPictureBox.Image = Properties.Resources.productimage;
                ProductPictureBox.ImageLocation = "";
                ProductPictureBox.InitialImage = null;
                ProductPictureBox.Location = new Point(584, 129);
                ProductPictureBox.Name = "ProductPictureBox";
                ProductPictureBox.Size = new Size(165, 155);
                ProductPictureBox.TabIndex = 11;
                ProductPictureBox.TabStop = false;
                // 
                // materialLabel5
                // 
                materialLabel5.AutoSize = true;
                materialLabel5.Depth = 0;
                materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
                materialLabel5.Location = new Point(293, 96);
                materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
                materialLabel5.Name = "materialLabel5";
                materialLabel5.Size = new Size(64, 19);
                materialLabel5.TabIndex = 12;
                materialLabel5.Text = "Category";
                // 
                // materialButton1
                // 
                materialButton1.AutoSize = false;
                materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
                materialButton1.Depth = 0;
                materialButton1.HighEmphasis = true;
                materialButton1.Icon = null;
                materialButton1.Location = new Point(584, 299);
                materialButton1.Margin = new Padding(4, 6, 4, 6);
                materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
                materialButton1.Name = "materialButton1";
                materialButton1.NoAccentTextColor = Color.Empty;
                materialButton1.Size = new Size(165, 36);
                materialButton1.TabIndex = 13;
                materialButton1.Text = "Browse Image";
                materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
                materialButton1.UseAccentColor = false;
                materialButton1.UseVisualStyleBackColor = true;
                materialButton1.Click += BrowseButton_Click;
                // 
                // materialLabel6
                // 
                materialLabel6.AutoSize = true;
                materialLabel6.Depth = 0;
                materialLabel6.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
                materialLabel6.Location = new Point(584, 96);
                materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
                materialLabel6.Name = "materialLabel6";
                materialLabel6.Size = new Size(45, 19);
                materialLabel6.TabIndex = 14;
                materialLabel6.Text = "Image";
                // 
                // AddProducts
                // 
                AutoScaleDimensions = new SizeF(8F, 20F);
                AutoScaleMode = AutoScaleMode.Font;
                ClientSize = new Size(800, 450);
                Controls.Add(materialLabel6);
                Controls.Add(materialButton1);
                Controls.Add(materialLabel5);
                Controls.Add(ProductPictureBox);
                Controls.Add(PriceTextBox);
                Controls.Add(materialLabel4);
                Controls.Add(CostTextBox);
                Controls.Add(materialLabel3);
                Controls.Add(DetailMultiLineTextBox);
                Controls.Add(CategoryComboBox);
                Controls.Add(NameTextBox);
                Controls.Add(materialLabel1);
                Location = new Point(0, 0);
                Name = "AddProducts";
                Text = "Products";
                Load += AddProducts_Load;
                Controls.SetChildIndex(materialLabel1, 0);
                Controls.SetChildIndex(NameTextBox, 0);
                Controls.SetChildIndex(CategoryComboBox, 0);
                Controls.SetChildIndex(DetailMultiLineTextBox, 0);
                Controls.SetChildIndex(materialLabel3, 0);
                Controls.SetChildIndex(CostTextBox, 0);
                Controls.SetChildIndex(materialLabel4, 0);
                Controls.SetChildIndex(PriceTextBox, 0);
                Controls.SetChildIndex(ProductPictureBox, 0);
                Controls.SetChildIndex(materialLabel5, 0);
                Controls.SetChildIndex(materialButton1, 0);
                Controls.SetChildIndex(materialLabel6, 0);
                ((System.ComponentModel.ISupportInitialize)ProductPictureBox).EndInit();
                ResumeLayout(false);
                PerformLayout();
            }
			catch (KeyNotFoundException ex)
			{
				// Handle the exception
				Console.WriteLine("An error occurred: " + ex.Message);
				// Optionally, you can perform additional error handling or logging here
			}
		}

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox2 NameTextBox;
        private MaterialSkin.Controls.MaterialComboBox CategoryComboBox;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 DetailMultiLineTextBox;
        private MaterialSkin.Controls.MaterialTextBox2 CostTextBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox2 PriceTextBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private PictureBox ProductPictureBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private ComboBox comboBox1;
    }
}