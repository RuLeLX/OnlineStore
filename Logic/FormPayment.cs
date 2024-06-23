﻿using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace OnlineStore
{
    public partial class FormPayment : Form
    {
        private NpgsqlConnection con;
        private DataTable dt;
        private DataSet ds;

        public FormPayment(NpgsqlConnection con)
        {
            InitializeComponent();
            this.con = con;
            LoadData();
        }

        private void LoadData()
        {
            string sql = "SELECT * FROM Payments";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con);
            ds = new DataSet();
            da.Fill(ds);
            dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["paymentid"].HeaderText = "Номер";
            dataGridView1.Columns["contractid"].HeaderText = "ID Договора";
            dataGridView1.Columns["paymentdate"].HeaderText = "Дата оплаты";
            dataGridView1.Columns["amount"].HeaderText = "Сумма";
            dataGridView1.Columns["paymenttype"].HeaderText = "Тип оплаты";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            FormAddEditPayment formAddEditPayment = new FormAddEditPayment(con);
            formAddEditPayment.ShowDialog();
            LoadData();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = (int)dataGridView1.SelectedRows[0].Cells["paymentid"].Value;
                string sql = "DELETE FROM Payments WHERE PaymentID = @PaymentID";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@PaymentID", id);
                cmd.ExecuteNonQuery();
                LoadData();
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = (int)dataGridView1.SelectedRows[0].Cells["paymentid"].Value;
                FormAddEditPayment formAddEditPayment = new FormAddEditPayment(con, id);
                formAddEditPayment.ShowDialog();
                LoadData();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
