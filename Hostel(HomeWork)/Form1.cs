﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
using System.Data.SQLite;

namespace Hostel_HomeWork_
{
    public partial class Hostel_List : Form
    {
        
        SQLiteConnection sqliteConnect = new SQLiteConnection("data source = hostel.db");
        SqliteCommand sqliteCommand = new SqliteCommand();
        public Hostel_List()
        {
            InitializeComponent();
            load_Data();
        }
        public void show_Data()
        {
            using(IDbConnection dbConnection = new SQLiteConnection(sqliteConnect))
            {
                dbConnection.Open();
                using(IDbCommand dbCommand = dbConnection.CreateCommand())
                {
                    string sqlQuery = "SELECT * FROM guests";
                    dbCommand.CommandText = sqlQuery;
                    using(IDataReader reader = dbCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            MessageBox.Show(reader["ID"] + " " + reader["Status"]);
                        }
                        dbConnection.Close();
                    }
                }
            }
        }
        
        private void load_Data()
        {
            sqliteConnect.Open();
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter("SELECT * FROM guests", sqliteConnect);
            DataSet ds = new System.Data.DataSet();
            dataAdapter.Fill(ds, "info");
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void Hostel_List_Load(object sender, EventArgs e)
        {
            Time.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Time.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 guestCard = new Form2();
            guestCard.Show();
            guestCard.txtBoxCardFIO.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            guestCard.txtBoxCardDateBirth.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
            guestCard.txtBoxCardPayment.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            guestCard.txtBoxCardDays.Text = this.dataGridView1.CurrentRow.Cells[8].Value.ToString();
            guestCard.txtBoxCardPets.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void rdBtnReserved_CheckedChanged(object sender, EventArgs e)
        {           
            SQLiteDataAdapter sqlDataAdapter = new SQLiteDataAdapter("SELECT * FROM guests WHERE Статус = 'Зарезервировано'",sqliteConnect);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void rdBtnFree_CheckedChanged(object sender, EventArgs e)
        {
            SQLiteDataAdapter sqlDataAdapter = new SQLiteDataAdapter("SELECT * FROM guests WHERE Статус = 'Свободно'", sqliteConnect);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void rdBtnOccupied_CheckedChanged(object sender, EventArgs e)
        {
            SQLiteDataAdapter sqlDataAdapter = new SQLiteDataAdapter("SELECT * FROM guests WHERE Статус = 'Занято'", sqliteConnect);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void rdBtnLeave_CheckedChanged(object sender, EventArgs e)
        {
            SQLiteDataAdapter sqlDataAdapter = new SQLiteDataAdapter("SELECT * FROM guests WHERE Статус = 'Выписываются'", sqliteConnect);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        public void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            txtBoxNumber.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtBoxStatus.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtBoxFIO.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtBoxDateIn.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtBoxDateOut.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();

            Bitmap image = new Bitmap("image\\"+ this.dataGridView1.CurrentRow.Cells[9].Value.ToString());
            pictureBox4.Image = image;

        }
        private void Search()
        {
            SQLiteDataAdapter sqlDataAdapter = new SQLiteDataAdapter("SELECT * FROM guests WHERE Номер='"+ txtBoxSearch.Text +"'", sqliteConnect);
            DataTable sqlDataTable = new DataTable();
            sqlDataAdapter.Fill(sqlDataTable);
            dataGridView1.DataSource = sqlDataTable;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }
    }
}
