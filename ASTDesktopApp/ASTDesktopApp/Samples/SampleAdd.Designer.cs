namespace ASTDesktopApp
{
    partial class SampleAdd
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
            BottomPanel = new Panel();
            CloseButton = new MaterialSkin.Controls.MaterialButton();
            SaveButton = new MaterialSkin.Controls.MaterialButton();
            BottomPanel.SuspendLayout();
            SuspendLayout();
            // 
            // BottomPanel
            // 
            BottomPanel.Controls.Add(CloseButton);
            BottomPanel.Controls.Add(SaveButton);
            BottomPanel.Dock = DockStyle.Bottom;
            BottomPanel.Location = new Point(3, 363);
            BottomPanel.Name = "BottomPanel";
            BottomPanel.Size = new Size(374, 84);
            BottomPanel.TabIndex = 1;
            // 
            // CloseButton
            // 
            CloseButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CloseButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            CloseButton.Depth = 0;
            CloseButton.HighEmphasis = true;
            CloseButton.Icon = null;
            CloseButton.Location = new Point(121, 24);
            CloseButton.Margin = new Padding(4, 6, 4, 6);
            CloseButton.MouseState = MaterialSkin.MouseState.HOVER;
            CloseButton.Name = "CloseButton";
            CloseButton.NoAccentTextColor = Color.Empty;
            CloseButton.Size = new Size(66, 36);
            CloseButton.TabIndex = 1;
            CloseButton.Text = "Close";
            CloseButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            CloseButton.UseAccentColor = true;
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            SaveButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            SaveButton.Depth = 0;
            SaveButton.HighEmphasis = true;
            SaveButton.Icon = null;
            SaveButton.Location = new Point(22, 24);
            SaveButton.Margin = new Padding(4, 6, 4, 6);
            SaveButton.MouseState = MaterialSkin.MouseState.HOVER;
            SaveButton.Name = "SaveButton";
            SaveButton.NoAccentTextColor = Color.Empty;
            SaveButton.Size = new Size(64, 36);
            SaveButton.TabIndex = 0;
            SaveButton.Text = "Save";
            SaveButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            SaveButton.UseAccentColor = false;
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // SampleAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 450);
            Controls.Add(BottomPanel);
            Name = "SampleAdd";
            StartPosition = FormStartPosition.CenterScreen;
            BottomPanel.ResumeLayout(false);
            BottomPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel BottomPanel;
        private MaterialSkin.Controls.MaterialButton CloseButton;
        private MaterialSkin.Controls.MaterialButton SaveButton;
    }
}