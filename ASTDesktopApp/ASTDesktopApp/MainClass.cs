using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using MaterialSkin.Controls;
using System.Drawing;
using System.Diagnostics;
using System.Collections;

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
        public static int SQL(string query, Hashtable ht)
        {
            int res = 0;
            try
            {
                ConnectToDatabase();
                SQLiteCommand command = new SQLiteCommand(query, Connection);
                foreach (DictionaryEntry item in ht)
                {
                    command.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                }
                res = command.ExecuteNonQuery();
                CloseConnection();
                return res;
            }
            catch (Exception ex)
            {
                CloseConnection();
                MaterialMessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, true);
                return res;
            }
        }

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
                DataTable dt = new DataTable();
                adapter.Fill(dt);


                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    dgv.Columns[((DataGridViewColumn)lb.Items[j]).Name].DataPropertyName = dt.Columns[j].ToString();
                }

                dgv.DataSource = dt;
                CloseConnection();
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                CloseConnection();
            }
        }

        public static void BlurBackground(MaterialForm Model)
        {
            Form Background = new Form();
            using (Model)
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

        // Method to check if the user is valid or not
        public static bool IsValidUser(string username, string password)
        {
            ConnectToDatabase();
            string query = $"SELECT * FROM Users WHERE Username='{username}' AND Password='{password}'";
            SQLiteCommand command = new SQLiteCommand(query, Connection);
            SQLiteDataReader reader = command.ExecuteReader();

            bool isValid = reader.HasRows;
            if (isValid)
            {
                while (reader.Read())
                {
                    Username = reader["Username"].ToString();
                }

            }
            reader.Close();
            CloseConnection();

            return isValid;
        }

        public static bool IsEntryValid(MaterialForm MF)
        {
            int count = 0;
            foreach (Control c in MF.Controls)
            {
                string cTag = Convert.ToString(c.Tag);
                if (cTag != " " && cTag != null)
                {
                    if (c is MaterialSkin.Controls.MaterialTextBox2)
                    {
                        MaterialSkin.Controls.MaterialTextBox2 tb = (MaterialSkin.Controls.MaterialTextBox2)c;
                        if (tb.Text.Trim() == "")
                        {
                            tb.BackColor = Color.Red;
                            count++;
                        }
                        else
                        {
                            tb.BackColor = Color.White;
                        }

                    }
                }
            }
            return count == 0;
        }
    }
}
