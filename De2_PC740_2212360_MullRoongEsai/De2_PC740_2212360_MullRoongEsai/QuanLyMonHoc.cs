using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace De2_PC740_2212360_MullRoongEsai
{
    public partial class QuanLyMonHoc : Form
    {
        public QuanLyMonHoc()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void QuanLyMonHoc_Load(object sender, EventArgs e)
        {
            rbAll.Checked = true;
            GetData();
        }
        void GetData()
        {

            string connectionString = "server= PC740\\MSSQLSERVER01 ; database = QLDKHP; Integrated Security = true;";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT* FROM MonHoc";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dsmh = new DataTable();
            conn.Open();

            adapter.Fill(dsmh);
            dsMonHoc.DataSource = dsmh;
           
            conn.Close();
            conn.Dispose();

           
        }

        private void rb2015_CheckedChanged(object sender, EventArgs e)
        {
            rdCheck(1);
        }
        void rdCheck(int n)
        {

            string connectionString = "server= PC740\\MSSQLSERVER01 ; database = QLDKHP; Integrated Security = true;";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT* FROM MonHoc WHERE MaCTĐT = " + n ;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dsmh = new DataTable();
            conn.Open();

            adapter.Fill(dsmh);
            dsMonHoc.DataSource = dsmh;

            conn.Close();
            conn.Dispose();
        }
        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string connectionString = "server= PC740\\MSSQLSERVER01 ; database = QLDKHP; Integrated Security = true;";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM MonHoc WHERE ID = " + dsMonHoc.SelectedColumns[0].ToString();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dsmh = new DataTable();
            conn.Open();

            adapter.Fill(dsmh);
            dsMonHoc.DataSource = dsmh;

            conn.Close();
            conn.Dispose();
        }

        private void rb2017_CheckedChanged(object sender, EventArgs e)
        {
            rdCheck(2);
        }

        private void rb2020_CheckedChanged(object sender, EventArgs e)
        {
            rdCheck(3);
        }

        private void rbAll_CheckedChanged(object sender, EventArgs e)
        {
            GetData();
        }
    }
}
