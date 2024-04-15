namespace ASTDesktopApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            CentrePanel = new Panel();
            MiddlePanel = new Panel();
            ReportButton = new MaterialSkin.Controls.MaterialButton();
            CustomersButton = new MaterialSkin.Controls.MaterialButton();
            CategoryButton = new MaterialSkin.Controls.MaterialButton();
            SaleButton = new MaterialSkin.Controls.MaterialButton();
            HomeButton = new MaterialSkin.Controls.MaterialButton();
            PurchaseButton = new MaterialSkin.Controls.MaterialButton();
            ProductsButton = new MaterialSkin.Controls.MaterialButton();
            UsersButton = new MaterialSkin.Controls.MaterialButton();
            LeftPanel = new Panel();
            SuppliersButton = new MaterialSkin.Controls.MaterialButton();
            HiLabel1 = new Label();
            CentrePanel.SuspendLayout();
            LeftPanel.SuspendLayout();
            SuspendLayout();
            // 
            // CentrePanel
            // 
            CentrePanel.AutoSize = true;
            CentrePanel.Controls.Add(MiddlePanel);
            CentrePanel.Dock = DockStyle.Fill;
            CentrePanel.Location = new Point(309, 64);
            CentrePanel.Name = "CentrePanel";
            CentrePanel.Size = new Size(888, 683);
            CentrePanel.TabIndex = 1;
            // 
            // MiddlePanel
            // 
            MiddlePanel.AutoSize = true;
            MiddlePanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MiddlePanel.BackColor = Color.FromArgb(238, 238, 238);
            MiddlePanel.Dock = DockStyle.Fill;
            MiddlePanel.Location = new Point(0, 0);
            MiddlePanel.Name = "MiddlePanel";
            MiddlePanel.Size = new Size(888, 683);
            MiddlePanel.TabIndex = 0;
            MiddlePanel.Paint += MiddlePanel_Paint;
            // 
            // ReportButton
            // 
            ReportButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ReportButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ReportButton.BackColor = Color.DarkGray;
            ReportButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ReportButton.Depth = 0;
            ReportButton.ForeColor = Color.White;
            ReportButton.HighEmphasis = false;
            ReportButton.Icon = Properties.Resources.report;
            ReportButton.Location = new Point(37, 579);
            ReportButton.Margin = new Padding(0);
            ReportButton.MouseState = MaterialSkin.MouseState.HOVER;
            ReportButton.Name = "ReportButton";
            ReportButton.NoAccentTextColor = Color.Empty;
            ReportButton.Size = new Size(113, 36);
            ReportButton.TabIndex = 12;
            ReportButton.Text = "Reports";
            ReportButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            ReportButton.UseAccentColor = false;
            ReportButton.UseVisualStyleBackColor = false;
            ReportButton.Click += ReportButton_Click;
            // 
            // CustomersButton
            // 
            CustomersButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CustomersButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CustomersButton.BackColor = Color.DarkGray;
            CustomersButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            CustomersButton.Depth = 0;
            CustomersButton.ForeColor = Color.White;
            CustomersButton.HighEmphasis = false;
            CustomersButton.Icon = Properties.Resources.customer1;
            CustomersButton.Location = new Point(37, 391);
            CustomersButton.Margin = new Padding(0);
            CustomersButton.MouseState = MaterialSkin.MouseState.HOVER;
            CustomersButton.Name = "CustomersButton";
            CustomersButton.NoAccentTextColor = Color.Empty;
            CustomersButton.Size = new Size(136, 36);
            CustomersButton.TabIndex = 11;
            CustomersButton.Text = "Customers";
            CustomersButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            CustomersButton.UseAccentColor = false;
            CustomersButton.UseVisualStyleBackColor = false;
            CustomersButton.Click += CustomersButton_Click;
            // 
            // CategoryButton
            // 
            CategoryButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CategoryButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CategoryButton.BackColor = Color.DarkGray;
            CategoryButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            CategoryButton.Depth = 0;
            CategoryButton.ForeColor = Color.White;
            CategoryButton.HighEmphasis = false;
            CategoryButton.Icon = Properties.Resources.category;
            CategoryButton.Location = new Point(37, 200);
            CategoryButton.Margin = new Padding(0);
            CategoryButton.MouseState = MaterialSkin.MouseState.HOVER;
            CategoryButton.Name = "CategoryButton";
            CategoryButton.NoAccentTextColor = Color.Empty;
            CategoryButton.Size = new Size(124, 36);
            CategoryButton.TabIndex = 8;
            CategoryButton.Text = "Category";
            CategoryButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            CategoryButton.UseAccentColor = false;
            CategoryButton.UseVisualStyleBackColor = false;
            CategoryButton.Click += CategoryButton_Click;
            // 
            // SaleButton
            // 
            SaleButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SaleButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            SaleButton.BackColor = Color.DarkGray;
            SaleButton.BackgroundImageLayout = ImageLayout.None;
            SaleButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            SaleButton.Depth = 0;
            SaleButton.ForeColor = Color.White;
            SaleButton.HighEmphasis = false;
            SaleButton.Icon = Properties.Resources.sales;
            SaleButton.Location = new Point(37, 513);
            SaleButton.Margin = new Padding(0);
            SaleButton.MouseState = MaterialSkin.MouseState.HOVER;
            SaleButton.Name = "SaleButton";
            SaleButton.NoAccentTextColor = Color.Empty;
            SaleButton.Size = new Size(93, 36);
            SaleButton.TabIndex = 13;
            SaleButton.Text = "Sales";
            SaleButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            SaleButton.UseAccentColor = false;
            SaleButton.UseVisualStyleBackColor = false;
            SaleButton.Click += SaleButton_Click;
            // 
            // HomeButton
            // 
            HomeButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            HomeButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            HomeButton.BackColor = Color.DarkGray;
            HomeButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            HomeButton.Depth = 0;
            HomeButton.ForeColor = Color.White;
            HomeButton.HighEmphasis = false;
            HomeButton.Icon = Properties.Resources.home;
            HomeButton.Location = new Point(37, 131);
            HomeButton.Margin = new Padding(0);
            HomeButton.MouseState = MaterialSkin.MouseState.HOVER;
            HomeButton.Name = "HomeButton";
            HomeButton.NoAccentTextColor = Color.Empty;
            HomeButton.Size = new Size(91, 36);
            HomeButton.TabIndex = 7;
            HomeButton.Text = "Home";
            HomeButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            HomeButton.UseAccentColor = false;
            HomeButton.UseVisualStyleBackColor = false;
            HomeButton.Click += HomeButton_Click;
            // 
            // PurchaseButton
            // 
            PurchaseButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PurchaseButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PurchaseButton.BackColor = Color.DarkGray;
            PurchaseButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            PurchaseButton.Depth = 0;
            PurchaseButton.ForeColor = Color.White;
            PurchaseButton.HighEmphasis = false;
            PurchaseButton.Icon = Properties.Resources.purchase;
            PurchaseButton.Location = new Point(37, 322);
            PurchaseButton.Margin = new Padding(0);
            PurchaseButton.MouseState = MaterialSkin.MouseState.HOVER;
            PurchaseButton.Name = "PurchaseButton";
            PurchaseButton.NoAccentTextColor = Color.Empty;
            PurchaseButton.Size = new Size(125, 36);
            PurchaseButton.TabIndex = 10;
            PurchaseButton.Text = "Purchase";
            PurchaseButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            PurchaseButton.UseAccentColor = false;
            PurchaseButton.UseVisualStyleBackColor = false;
            PurchaseButton.Click += PurchaseButton_Click;
            // 
            // ProductsButton
            // 
            ProductsButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ProductsButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ProductsButton.BackColor = Color.DarkGray;
            ProductsButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ProductsButton.Depth = 0;
            ProductsButton.ForeColor = Color.White;
            ProductsButton.HighEmphasis = false;
            ProductsButton.Icon = Properties.Resources.product;
            ProductsButton.Location = new Point(37, 254);
            ProductsButton.Margin = new Padding(0);
            ProductsButton.MouseState = MaterialSkin.MouseState.HOVER;
            ProductsButton.Name = "ProductsButton";
            ProductsButton.NoAccentTextColor = Color.Empty;
            ProductsButton.Size = new Size(125, 36);
            ProductsButton.TabIndex = 9;
            ProductsButton.Text = "Products";
            ProductsButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            ProductsButton.UseAccentColor = false;
            ProductsButton.UseVisualStyleBackColor = false;
            ProductsButton.Click += ProductsButton_Click;
            // 
            // UsersButton
            // 
            UsersButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            UsersButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            UsersButton.BackColor = Color.DarkGray;
            UsersButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            UsersButton.Depth = 0;
            UsersButton.ForeColor = Color.White;
            UsersButton.HighEmphasis = false;
            UsersButton.Icon = (Image)resources.GetObject("UsersButton.Icon");
            UsersButton.Location = new Point(37, 639);
            UsersButton.Margin = new Padding(0);
            UsersButton.MouseState = MaterialSkin.MouseState.HOVER;
            UsersButton.Name = "UsersButton";
            UsersButton.NoAccentTextColor = Color.Empty;
            UsersButton.Size = new Size(94, 36);
            UsersButton.TabIndex = 14;
            UsersButton.Text = "Users";
            UsersButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            UsersButton.UseAccentColor = false;
            UsersButton.UseVisualStyleBackColor = false;
            UsersButton.Click += UsersButton_Click;
            // 
            // LeftPanel
            // 
            LeftPanel.AutoSize = true;
            LeftPanel.BackColor = Color.SkyBlue;
            LeftPanel.Controls.Add(SuppliersButton);
            LeftPanel.Controls.Add(HiLabel1);
            LeftPanel.Controls.Add(UsersButton);
            LeftPanel.Controls.Add(ProductsButton);
            LeftPanel.Controls.Add(PurchaseButton);
            LeftPanel.Controls.Add(HomeButton);
            LeftPanel.Controls.Add(SaleButton);
            LeftPanel.Controls.Add(CategoryButton);
            LeftPanel.Controls.Add(CustomersButton);
            LeftPanel.Controls.Add(ReportButton);
            LeftPanel.Dock = DockStyle.Left;
            LeftPanel.Location = new Point(3, 64);
            LeftPanel.Name = "LeftPanel";
            LeftPanel.Size = new Size(306, 683);
            LeftPanel.TabIndex = 0;
            LeftPanel.Paint += LeftPanel_Paint;
            // 
            // SuppliersButton
            // 
            SuppliersButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SuppliersButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            SuppliersButton.BackColor = Color.DarkGray;
            SuppliersButton.BackgroundImageLayout = ImageLayout.None;
            SuppliersButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            SuppliersButton.Depth = 0;
            SuppliersButton.ForeColor = Color.White;
            SuppliersButton.HighEmphasis = false;
            SuppliersButton.Icon = Properties.Resources.supplier;
            SuppliersButton.Location = new Point(38, 453);
            SuppliersButton.Margin = new Padding(0);
            SuppliersButton.MouseState = MaterialSkin.MouseState.HOVER;
            SuppliersButton.Name = "SuppliersButton";
            SuppliersButton.NoAccentTextColor = Color.Empty;
            SuppliersButton.Size = new Size(125, 36);
            SuppliersButton.TabIndex = 16;
            SuppliersButton.Text = "Suppliers";
            SuppliersButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            SuppliersButton.UseAccentColor = false;
            SuppliersButton.UseVisualStyleBackColor = false;
            SuppliersButton.Click += SuppliersButton_Click_1;
            // 
            // HiLabel1
            // 
            HiLabel1.BackColor = Color.FromArgb(0, 173, 181);
            HiLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HiLabel1.ForeColor = Color.FromArgb(238, 238, 238);
            HiLabel1.Location = new Point(37, 24);
            HiLabel1.Name = "HiLabel1";
            HiLabel1.Size = new Size(184, 81);
            HiLabel1.TabIndex = 15;
            HiLabel1.Text = "label1";
            HiLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 750);
            Controls.Add(CentrePanel);
            Controls.Add(LeftPanel);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            Load += MainForm_Load;
            CentrePanel.ResumeLayout(false);
            CentrePanel.PerformLayout();
            LeftPanel.ResumeLayout(false);
            LeftPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private Panel CentrePanel;
        private MaterialSkin.Controls.MaterialButton ReportButton;
        private MaterialSkin.Controls.MaterialButton CustomersButton;
        private MaterialSkin.Controls.MaterialButton CategoryButton;
        private MaterialSkin.Controls.MaterialButton SaleButton;
        private MaterialSkin.Controls.MaterialButton HomeButton;
        private MaterialSkin.Controls.MaterialButton PurchaseButton;
        private MaterialSkin.Controls.MaterialButton ProductsButton;
        private MaterialSkin.Controls.MaterialButton UsersButton;
        private Panel LeftPanel;
        private Panel MiddlePanel;
        private Label HiLabel;
        private Label HiLabel1;
        private MaterialSkin.Controls.MaterialButton SuppliersButton;
    }
}