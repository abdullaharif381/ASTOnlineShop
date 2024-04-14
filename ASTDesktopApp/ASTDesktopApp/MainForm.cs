using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ASTDesktopApp.Views;
using MaterialSkin;
using MaterialSkin.Controls;
using MaterialSkin.Properties;

namespace ASTDesktopApp
{
    public partial class MainForm : MaterialForm
    {

        static MainForm? _instance;
        public static MainForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MainForm();
                }
                return _instance;
            }
        }



        public MainForm()
        {
            InitializeComponent();
            //var materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage(this);
            //materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            //materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey400, Primary.Grey100, Primary.Teal100, Accent.Amber100, TextShade.BLACK);
        }
        public void AddControlsToPanel(MaterialForm c)
        {
            MiddlePanel.Controls.Clear();
            c.Dock = DockStyle.Fill;
            c.TopLevel = false;
            MiddlePanel.Controls.Add(c);
            c.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _instance = this;
            HiLabel1.Text = "Welcome, " + MainClass.Username;
            

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void HomeButton_Click(object sender, EventArgs e)
        {

        }



        private void CenterPanel_Paint(object sender, PaintEventArgs e)
        {

        }



        private void UsersButton_Click(object sender, EventArgs e)
        {
            //connect with usersview open other file to add users
            AddControlsToPanel(new UsersView());




        }



        private void ProductsButton_Click(object sender, EventArgs e)
        {

        }

        private void CategoryButton_Click(object sender, EventArgs e)
        {

        }

        private void PurchaseButton_Click(object sender, EventArgs e)
        {

        }

        private void SaleButton_Click(object sender, EventArgs e)
        {

        }

        private void ReportButton_Click(object sender, EventArgs e)
        {

        }

        private void HomeButton_Click_1(object sender, EventArgs e)
        {

        }

        private void MiddlePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LeftPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
