namespace ASTDesktopApp.Views
{
	partial class OcrView
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
			richTextBox1 = new RichTextBox();
			button1 = new Button();
			button2 = new Button();
			TopViewPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// AddNewButton
			// 
			AddNewButton.Location = new Point(35, 36);
			AddNewButton.Size = new Size(108, 36);
			AddNewButton.Text = "Browse";
			AddNewButton.Click += AddNewButton_Click;
			// 
			// TopViewPanel
			// 
			TopViewPanel.Size = new Size(1093, 105);
			// 
			// pictureBox1
			// 
			pictureBox1.BackColor = SystemColors.Info;
			pictureBox1.Location = new Point(38, 228);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(386, 250);
			pictureBox1.TabIndex = 4;
			pictureBox1.TabStop = false;
			pictureBox1.Click += pictureBox1_Click_1;
			// 
			// richTextBox1
			// 
			richTextBox1.Location = new Point(585, 219);
			richTextBox1.Name = "richTextBox1";
			richTextBox1.Size = new Size(440, 259);
			richTextBox1.TabIndex = 5;
			richTextBox1.Text = "";
			richTextBox1.TextChanged += richTextBox1_TextChanged_1;
			// 
			// button1
			// 
			button1.Location = new Point(585, 184);
			button1.Name = "button1";
			button1.Size = new Size(94, 29);
			button1.TabIndex = 6;
			button1.Text = "OCR";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click_1;
			// 
			// button2
			// 
			button2.Location = new Point(38, 193);
			button2.Name = "button2";
			button2.Size = new Size(94, 29);
			button2.TabIndex = 7;
			button2.Text = "Browse";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// OcrView
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1099, 500);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(richTextBox1);
			Controls.Add(pictureBox1);
			Location = new Point(0, 0);
			Name = "OcrView";
			Text = "OcrView";
			Load += OcrView_Load;
			Controls.SetChildIndex(TopViewPanel, 0);
			Controls.SetChildIndex(pictureBox1, 0);
			Controls.SetChildIndex(richTextBox1, 0);
			Controls.SetChildIndex(button1, 0);
			Controls.SetChildIndex(button2, 0);
			TopViewPanel.ResumeLayout(false);
			TopViewPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private PictureBox pictureBox1;
		private RichTextBox richTextBox1;
		private Button button1;
		private Button button2;
	}
}