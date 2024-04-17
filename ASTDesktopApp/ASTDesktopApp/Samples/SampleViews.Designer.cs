namespace ASTDesktopApp
{
    partial class SampleViews
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
            AddNewButton = new MaterialSkin.Controls.MaterialButton();
            SearchTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            TopViewPanel = new Panel();
            SearchButton = new MaterialSkin.Controls.MaterialButton();
            TopViewPanel.SuspendLayout();
            SuspendLayout();
            // 
            // AddNewButton
            // 
            AddNewButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AddNewButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            AddNewButton.Depth = 0;
            AddNewButton.HighEmphasis = true;
            AddNewButton.Icon = Properties.Resources.add;
            AddNewButton.Location = new Point(25, 36);
            AddNewButton.Margin = new Padding(4, 6, 4, 6);
            AddNewButton.MouseState = MaterialSkin.MouseState.HOVER;
            AddNewButton.Name = "AddNewButton";
            AddNewButton.NoAccentTextColor = Color.Empty;
            AddNewButton.Size = new Size(114, 36);
            AddNewButton.TabIndex = 0;
            AddNewButton.Text = "Add New";
            AddNewButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            AddNewButton.UseAccentColor = false;
            AddNewButton.UseVisualStyleBackColor = true;
            AddNewButton.Click += AddNewButton_Click;
            // 
            // SearchTextBox
            // 
            SearchTextBox.AnimateReadOnly = false;
            SearchTextBox.AutoCompleteMode = AutoCompleteMode.None;
            SearchTextBox.AutoCompleteSource = AutoCompleteSource.None;
            SearchTextBox.BackgroundImageLayout = ImageLayout.None;
            SearchTextBox.CharacterCasing = CharacterCasing.Normal;
            SearchTextBox.Depth = 0;
            SearchTextBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchTextBox.HideSelection = true;
            SearchTextBox.LeadingIcon = null;
            SearchTextBox.Location = new Point(370, 24);
            SearchTextBox.MaxLength = 32767;
            SearchTextBox.MouseState = MaterialSkin.MouseState.OUT;
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.PasswordChar = '\0';
            SearchTextBox.PrefixSuffixText = null;
            SearchTextBox.ReadOnly = false;
            SearchTextBox.RightToLeft = RightToLeft.No;
            SearchTextBox.SelectedText = "";
            SearchTextBox.SelectionLength = 0;
            SearchTextBox.SelectionStart = 0;
            SearchTextBox.ShortcutsEnabled = true;
            SearchTextBox.Size = new Size(311, 48);
            SearchTextBox.TabIndex = 1;
            SearchTextBox.TabStop = false;
            SearchTextBox.TextAlign = HorizontalAlignment.Left;
            SearchTextBox.TrailingIcon = null;
            SearchTextBox.UseSystemPasswordChar = false;
            SearchTextBox.TextChanged += SearchTextBox_TextChanged;
            // 
            // TopViewPanel
            // 
            TopViewPanel.Controls.Add(SearchButton);
            TopViewPanel.Controls.Add(SearchTextBox);
            TopViewPanel.Controls.Add(AddNewButton);
            TopViewPanel.Dock = DockStyle.Top;
            TopViewPanel.Location = new Point(3, 64);
            TopViewPanel.Name = "TopViewPanel";
            TopViewPanel.Size = new Size(794, 105);
            TopViewPanel.TabIndex = 3;
            // 
            // SearchButton
            // 
            SearchButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            SearchButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            SearchButton.Depth = 0;
            SearchButton.HighEmphasis = true;
            SearchButton.Icon = null;
            SearchButton.Location = new Point(701, 36);
            SearchButton.Margin = new Padding(4, 6, 4, 6);
            SearchButton.MouseState = MaterialSkin.MouseState.HOVER;
            SearchButton.Name = "SearchButton";
            SearchButton.NoAccentTextColor = Color.Empty;
            SearchButton.Size = new Size(78, 36);
            SearchButton.TabIndex = 2;
            SearchButton.Text = "Search";
            SearchButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            SearchButton.UseAccentColor = false;
            SearchButton.UseVisualStyleBackColor = true;
            // 
            // SampleViews
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TopViewPanel);
            Name = "SampleViews";
            Load += SampleViews_Load;
            TopViewPanel.ResumeLayout(false);
            TopViewPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        public MaterialSkin.Controls.MaterialButton AddNewButton;
        public MaterialSkin.Controls.MaterialTextBox2 SearchTextBox;
        public Panel TopViewPanel;
        private MaterialSkin.Controls.MaterialButton SearchButton;
    }
}