using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASTDesktopApp.Models
{
    public partial class AddProducts : SampleAdd
    {
        public int id = 0;
        public int catId = 0;
        public string filepath = "";
        Byte[] imageByteArray;


        public AddProducts()
        {
            InitializeComponent();
        }
        // getter and setter for name, category, description, cost, price, and image
        
        public string getName()
        {
            return NameTextBox.Text;
        }
        public string getDetail()
        {
            return DetailMultiLineTextBox.Text;
        }
        public string getCost()
        {
            return CostTextBox.Text;
        }
        public string getPrice()
        {
            return PriceTextBox.Text;
        }
        public object getCategory()
        {
            return CategoryComboBox.SelectedValue;
        }
        public Image getImage()
        {
            return ProductPictureBox.Image;
        }
        // method to set the category, name, description, cost, price, and image
        public void setID(string ID)
        {
            id = Convert.ToInt32(ID);
        }
        public void setCatID(int ID)
        {
            catId = ID;
        }
        public void setCategory(string category)
        {
            CategoryComboBox.SelectedValue = category;
        }
        public void setName(string name)
        {
            NameTextBox.Text = name;
        }
        public void setDetail(string detail)
        {
            DetailMultiLineTextBox.Text = detail;
        }
        public void setCost(string cost)
        {
            CostTextBox.Text = cost;
        }
        public void setPrice(string price)
        {
            PriceTextBox.Text = price;
        }
        public void setImage(Image image)
        {
            ProductPictureBox.Image = image;
        }


        private void AddProducts_Load(object sender, EventArgs e)
        {
            string query = "SELECT CategoryID, Name FROM Categories";
            MainClass.FillCombo(query, CategoryComboBox, "Name", "CategoryID");
            if (id > 0)
            {
                CategoryComboBox.SelectedValue = catId;
                LoadImage();
            }

        }
        
        private void BrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files | *.jpg; *.jpeg; *.png; *.gif; *.bmp";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filepath = dialog.FileName;
                ProductPictureBox.Image = Image.FromFile(filepath);
            }
        }

        public override void CloseButton_Click(object sender, EventArgs e)
        {
            base.CloseButton_Click(sender, e);
        }
        public override void SaveButton_Click(object sender, EventArgs e)
        {
            if (MainClass.IsEntryValid(this) == false)
            {
                // there are errors in the data user entered
                MessageBox.Show("Please enter all required fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string query = "";
                string categoryName = MainClass.GetCategoryName(catId); // Get category name based on catId

                if (id == 0)
                {
                    query = @"INSERT INTO Products (Name, CategoryID, Description, Cost, Price, Image) 
                                VALUES (@Name, @CatID, @Desc, @Cost, @Price, @Image)";

                }
                else
                {
                    query = @"UPDATE Products SET Name = @Name,
                                                CategoryID = @CatID,
                                                Description = @Desc,
                                                Cost = @Cost,
                                                Price = @Price,
                                                Image = @Image
                                                WHERE ProductID = @id";
                             
                }
                Image temp = new Bitmap(ProductPictureBox.Image);
                MemoryStream ms = new MemoryStream();
                temp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                imageByteArray = ms.ToArray();

                Hashtable ht = new Hashtable();
                ht.Add("@id", id);
                ht.Add("@Name", NameTextBox.Text);
                ht.Add("@CatID", Convert.ToInt32(CategoryComboBox.SelectedValue));
                ht.Add("@Desc", DetailMultiLineTextBox.Text);
                ht.Add("@Cost", Convert.ToInt32(CostTextBox.Text));
                ht.Add("@Price", Convert.ToInt32(PriceTextBox.Text));
                ht.Add("@Image", imageByteArray);



                if (MainClass.SQL(query, ht) > 0)
                {
                    // show message of saving data closely
                    MessageBox.Show("Product saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    id = 0;
                    NameTextBox.Text = "";
                    CategoryComboBox.SelectedIndex = 0;
                    CategoryComboBox.SelectedIndex = -1;
                    DetailMultiLineTextBox.Text = "";
                    CostTextBox.Text = "";
                    PriceTextBox.Text = "";
                    ProductPictureBox.Image = ASTDesktopApp.Properties.Resources.productimage;
                    NameTextBox.Focus();
                    
                }




            }
            base.SaveButton_Click(sender, e);
        }
        private void LoadImage()
        {
            string qry = @"SELECT Image FROM Products WHERE ProductID = " + id + "";
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(qry, MainClass.Connection);
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                byte[] img = (byte[])dt.Rows[0]["Image"];
                byte[] imageByteArray = img;
                ProductPictureBox.Image = Image.FromStream(new MemoryStream(imageByteArray));
            }
        }

        




    }
}
