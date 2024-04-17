using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ASTDesktopApp.Models;
using MaterialSkin.Controls;

namespace ASTDesktopApp
{
    public partial class SampleViews : MaterialForm
    {
        public SampleViews()
        {
            InitializeComponent();
        }


        public virtual void SampleViews_Load(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        public virtual void AddNewButton_Click(object sender, EventArgs e)
        {
            // open the AddUsers.cs form when this button is clicked:
            MainClass.BlurBackground(new AddUsers());
            AddUsers add = new AddUsers();
            add.Show();



        }

        public virtual void SearchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        public virtual void SearchButton_Click(object sender, EventArgs e)
        {

        }
    }
}
