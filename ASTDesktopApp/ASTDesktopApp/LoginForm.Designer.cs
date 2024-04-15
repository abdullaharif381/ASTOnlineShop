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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
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
            UsernameTextBox.Location = new Point(432, 200);
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
            PasswordTextBox.Location = new Point(432, 293);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(432, 106);
            label1.Name = "label1";
            label1.Size = new Size(167, 41);
            label1.TabIndex = 8;
            label1.Text = "Chem Ease";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(432, 172);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 9;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(432, 265);
            label3.Name = "label3";
            label3.Size = new Size(92, 25);
            label3.TabIndex = 10;
            label3.Text = "Password";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private Label label1;
        private Label label2;
        private Label label3;
    }
}