using asprise_ocr_api;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASTDesktopApp.Views
{
	public partial class OcrView : SampleViews
	{
		public OcrView()
		{
			InitializeComponent();
		}

		private void OcrView_Load(object sender, EventArgs e)
		{

		}
		string selectedFilePath;

		private void AddNewButton_Click_2(object sender, EventArgs e)
		{

			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Image Files (.png;.jpg;.jpeg;.bmp)|.png;.jpg;.jpeg;.bmp|All files (.)|.";

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				selectedFilePath = openFileDialog.FileName;
				this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
				pictureBox1.Image = new Bitmap(selectedFilePath);
			}
		}

		private void pictureBox1_Click_1(object sender, EventArgs e)
		{

		}

		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{ // Save the image from pictureBox2 to a temporary file
			  //string tempFilePath = Path.Combine(Path.GetTempPath(), "tempImage.jpg");
			  //pictureBox2.Image.Save(tempFilePath, System.Drawing.Imaging.ImageFormat.Jpeg); // Corrected line
				AspriseOCR.SetUp();
				AspriseOCR ocr = new AspriseOCR();
				ocr.StartEngine("eng", AspriseOCR.SPEED_FASTEST);

				// Ensure selectedFilePath is not null or empty
				if (string.IsNullOrEmpty(selectedFilePath))
				{
					MessageBox.Show("Please select an image first.");

					return;
				}

				string s = ocr.Recognize(selectedFilePath, -1, -1, -1, -1, -1,
					AspriseOCR.RECOGNIZE_TYPE_ALL, AspriseOCR.OUTPUT_FORMAT_PLAINTEXT);

				// Display the recognized text in a dialog box
				richTextBox1.Text = s;

				ocr.StopEngine();
			}
			catch (Exception ex)
			{
				MessageBox.Show("OCR failed: " + ex.Message);
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Image Files | *.jpg; *.jpeg; *.png; *.gif; *.bmp";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				selectedFilePath = openFileDialog.FileName;
				this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
				pictureBox1.Image = new Bitmap(selectedFilePath);
			}
		}

		private void richTextBox1_TextChanged_1(object sender, EventArgs e)
		{

		}

		private void button1_Click_1(object sender, EventArgs e)
		{

			try
			{ // Save the image from pictureBox2 to a temporary file
			  //string tempFilePath = Path.Combine(Path.GetTempPath(), "tempImage.jpg");
			  //pictureBox2.Image.Save(tempFilePath, System.Drawing.Imaging.ImageFormat.Jpeg); // Corrected line
				AspriseOCR.SetUp();
				AspriseOCR ocr = new AspriseOCR();
				ocr.StartEngine("eng", AspriseOCR.SPEED_FASTEST);

				// Ensure selectedFilePath is not null or empty
				if (string.IsNullOrEmpty(selectedFilePath))
				{
					MessageBox.Show("Please select an image first.");

					return;
				}

				string s = ocr.Recognize(selectedFilePath, -1, -1, -1, -1, -1,
					AspriseOCR.RECOGNIZE_TYPE_ALL, AspriseOCR.OUTPUT_FORMAT_PLAINTEXT);

				// Display the recognized text in a dialog box
				richTextBox1.Text = s;
				MessageBox.Show(s);

				ocr.StopEngine();
			}
			catch (Exception ex)
			{
				MessageBox.Show("OCR failed: " + ex.Message);
			}
		}
	}
}
