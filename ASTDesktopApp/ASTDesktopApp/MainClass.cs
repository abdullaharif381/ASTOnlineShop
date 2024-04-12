using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using MaterialSkin.Controls;

namespace ASTDesktopApp
{
    internal class MainClass
    {
        public static readonly string DB_NAME = "DesktopDatabase.db";
        public static readonly string CONNECTION_STRING = $"Data Source={DB_NAME};Version=3;";
        public static SQLiteConnection Connection { get; private set; }

        // Method to establish connection to the SQLite database
        public static void ConnectToDatabase()
        {
            Connection = new SQLiteConnection(CONNECTION_STRING);
            Connection.Open();
        }

        // Method to close the database connection
        public static void CloseConnection()
        {
            if (Connection != null && Connection.State != System.Data.ConnectionState.Closed)
            {
                Connection.Close();
            }
        }

        // Method to check if the user is valid or not
        public static bool IsValidUser(string username, string password)
        {
            ConnectToDatabase();
            string query = $"SELECT * FROM Users WHERE Username='{username}' AND Password='{password}'";
            SQLiteCommand command = new SQLiteCommand(query, Connection);
            SQLiteDataReader reader = command.ExecuteReader();
            bool isValid = reader.HasRows;
            reader.Close();
            CloseConnection();
            return isValid;
        }

        // Property for username
        public static string? User { get; private set; }

        public static string Username
        {
            get
            {
                if (User != null)
                {
                    return User;
                }
                else
                {
                    return "Guest";
                }
            }
            private set
            {
                User = value;
            }
        }

        // Method to get the user id
        public static int GetUserId()
        {
            ConnectToDatabase();
            string query = $"SELECT Id FROM Users WHERE Username='{Username}'";
            SQLiteCommand command = new SQLiteCommand(query, Connection);
            int userId = Convert.ToInt32(command.ExecuteScalar());
            CloseConnection();
            return userId;
        }

        // Method for CRUD operations
        public static void ExecuteQuery(string query)
        {
            ConnectToDatabase();
            SQLiteCommand command = new SQLiteCommand(query, Connection);
            command.ExecuteNonQuery();
            CloseConnection();
        }
        public static void dgv_CellFormatting(object sender, System.Windows.Forms.DataGridViewCellFormattingEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int count = 0;
            foreach (DataGridViewRow row in dgv.Rows)
            {
                count++;
                row.Cells[0].Value = count;
            }
            return;
        }
        public static void LoadData(string query, DataGridView dgv, ListBox lb)
        {
            dgv.CellFormatting += new DataGridViewCellFormattingEventHandler(dgv_CellFormatting);
            
            try
            {
                ConnectToDatabase();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, Connection);
                System.Data.DataTable dt = new System.Data.DataTable();
                adapter.Fill(dt);
                dgv.Rows.Clear();
                // use a for loop instead of for each command



                for (int i =0; i<lb.Items.Count; i++)
                {
                    string colName = ((DataGridViewColumn)lb.Items[i]).Name;
                    dgv.Columns[colName].DataPropertyName = dt.Columns[i].ToString();
                }
                dgv.DataSource = dt;
                CloseConnection();
            }
            catch (Exception ex)
            {
                CloseConnection();
                System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public static void BlurBackground(MaterialForm Model)
        {
            Form Background = new Form();
            using(Model)
            {
                Background.StartPosition = FormStartPosition.Manual;
                Background.FormBorderStyle = FormBorderStyle.None;
                Background.Opacity = 0.5;
                Background.BackColor = Color.Black;                          
                Background.Size = MainForm.Instance.Size;
                Background.Location = MainForm.Instance.Location;
                Background.ShowInTaskbar = false;
                Background.Show();
                Model.Owner = Background;
                Model.ShowDialog(Background);
                Background.Dispose();

            }
        



        }
    }
}
