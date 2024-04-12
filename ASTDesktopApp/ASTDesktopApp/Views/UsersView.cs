﻿using System;
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
using MaterialSkin.Properties;

namespace ASTDesktopApp.Views
{
    public partial class UsersView : SampleViews
    {
        public UsersView()
        {
            InitializeComponent();
        }

        private void UsersView_Load(object sender, EventArgs e)
        {
            // Load the data from the database
            LoadData();
        }
        /*CREATE TABLE IF NOT EXISTS Users (
    UserID INTEGER PRIMARY KEY AUTOINCREMENT,
    Username TEXT UNIQUE NOT NULL,
    Password TEXT NOT NULL,
    Role TEXT NOT NULL
);*/
        public void LoadData()
        {
            // Clear the existing data
            ListBox lb = new ListBox();
            lb.Items.Add(dgvID);
            lb.Items.Add(dgvUsername);
            lb.Items.Add(dgvPassword);
            lb.Items.Add(dgvRole);
            string query = "SELECT UserID, Username, Role  FROM Users WHERE Username like '%" + SearchTextBox.Text + "%' ORDER BY UserID";
            MainClass.LoadData(query, UserDataGridView, lb);


        }

        private void UserDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public override void AddNewButton_Click(object sender, EventArgs e)
        {
            // open the AddUsers.cs form when this button is clicked:
            AddUsers add = new AddUsers();
            add.Show();



        }

        public override void SearchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchTextBox_Click_1(object sender, EventArgs e)
        {

        }
    }
}