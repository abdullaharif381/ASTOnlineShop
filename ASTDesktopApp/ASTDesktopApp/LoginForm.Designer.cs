namespace ASTDesktopApp
{
    partial class LoginForm
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
            pictureBox1 = new PictureBox();
            UsernameTextBox = new MaterialSkin.Controls.MaterialTextBox();
            PasswordTextBox = new MaterialSkin.Controls.MaterialTextBox();
            LoginButton = new MaterialSkin.Controls.MaterialButton();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_small_icon_only_inverted;
            pictureBox1.Location = new Point(42, 106);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(299, 301);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.AnimateReadOnly = true;
            UsernameTextBox.BorderStyle = BorderStyle.None;
            UsernameTextBox.Depth = 0;
            UsernameTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            UsernameTextBox.LeadingIcon = null;
            UsernameTextBox.Location = new Point(432, 188);
            UsernameTextBox.MaxLength = 50;
            UsernameTextBox.MouseState = MaterialSkin.MouseState.OUT;
            UsernameTextBox.Multiline = false;
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(310, 50);
            UsernameTextBox.TabIndex = 2;
            UsernameTextBox.Text = "";
            UsernameTextBox.TrailingIcon = null;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.AnimateReadOnly = false;
            PasswordTextBox.BorderStyle = BorderStyle.None;
            PasswordTextBox.Depth = 0;
            PasswordTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            PasswordTextBox.LeadingIcon = null;
            PasswordTextBox.Location = new Point(432, 273);
            PasswordTextBox.MaxLength = 50;
            PasswordTextBox.MouseState = MaterialSkin.MouseState.OUT;
            PasswordTextBox.Multiline = false;
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Password = true;
            PasswordTextBox.Size = new Size(310, 50);
            PasswordTextBox.TabIndex = 3;
            PasswordTextBox.Text = "";
            PasswordTextBox.TrailingIcon = null;
            // 
            // LoginButton
            // 
            LoginButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            LoginButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            LoginButton.Depth = 0;
            LoginButton.HighEmphasis = true;
            LoginButton.Icon = null;
            LoginButton.Location = new Point(678, 371);
            LoginButton.Margin = new Padding(4, 6, 4, 6);
            LoginButton.MouseState = MaterialSkin.MouseState.HOVER;
            LoginButton.Name = "LoginButton";
            LoginButton.NoAccentTextColor = Color.Empty;
            LoginButton.Size = new Size(68, 36);
            LoginButton.TabIndex = 4;
            LoginButton.Text = " Login";
            LoginButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            LoginButton.UseAccentColor = false;
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            materialLabel2.Location = new Point(432, 168);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(66, 17);
            materialLabel2.TabIndex = 5;
            materialLabel2.Text = "Username";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            materialLabel3.Location = new Point(432, 253);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(63, 17);
            materialLabel3.TabIndex = 6;
            materialLabel3.Text = "Password";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            materialLabel1.Location = new Point(432, 106);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(257, 29);
            materialLabel1.TabIndex = 7;
            materialLabel1.Text = "Welcome to Chem Ease";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(materialLabel1);
            Controls.Add(materialLabel3);
            Controls.Add(materialLabel2);
            Controls.Add(LoginButton);
            Controls.Add(PasswordTextBox);
            Controls.Add(UsernameTextBox);
            Controls.Add(pictureBox1);
            Name = "LoginForm";
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialTextBox UsernameTextBox;
        private MaterialSkin.Controls.MaterialTextBox PasswordTextBox;
        private MaterialSkin.Controls.MaterialButton LoginButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}