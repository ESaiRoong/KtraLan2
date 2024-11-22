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
    public partial class MonHoc : Form
    {
        public MonHoc()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MonHoc_Load(object sender, EventArgs e)
        {
           TestServer();
           this.GetData();
        }
        void TestServer()
        {
            string connectionString = "server = PC740\\MSSQLSERVER01; database = QLDKHP; Integrated Security = true; ";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Ket noi thanh cong ");

                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ket noi that bai ");
                }
            }
        }
        void GetData()
        {
            string connectionString = "server= PC740\\MSSQLSERVER01 ; database = QLDKHP; Integrated Security = true;";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = conn.CreateCommand(); 
            cmd.CommandText = "SELECT TenCTDT FROM ChuongTrinhDT";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            conn.Open();
            adapter.Fill(dt);
            conn.Close();
            conn.Dispose();

            cbbChuongTrinhDT.DataSource = dt;
        }
        

        

        private void dgvFoodList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ngănCáchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void txtMaMH_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
           
            string connectionString = "server= PC740\\MSSQLSERVER01 ; database = QLDKHP; Integrated Security = true;";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = conn.CreateCommand();

            
        }
        private void CallMonHocInsertUpdateDelete(int action, string tenMH, int soTC, int maCT, ref int monHocID)
        {
            string connectionString = "server= PC740\\MSSQLSERVER01 ; database = QLDKHP; Integrated Security = true;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("MonHoc_InsertUpdateDelete", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

               
                        cmd.Parameters.AddWithValue("@TenMH", tenMH);       
                        cmd.Parameters.AddWithValue("@SoTC", soTC);        
                        cmd.Parameters.AddWithValue("@MaCT", maCT);         
                        cmd.Parameters.AddWithValue("@Action", action);     

                        SqlParameter monHocParam = new SqlParameter("@MonHoc", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(monHocParam);

                        cmd.ExecuteNonQuery();

     
                        monHocID = (int)monHocParam.Value;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
       
            string tenMH = txtTenMH.Text;
            int soTC = int.Parse(numSoTin.Text);
            int maCT = int.Parse(cbbChuongTrinhDT.Text);

           
            int monHocID = 0;

            
            CallMonHocInsertUpdateDelete(0, tenMH, soTC, maCT, ref monHocID);

         
            MessageBox.Show("Môn học đã được thêm. ID mới là: " + monHocID);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
         
            int monHocID = int.Parse(txtMaMH.Text);
            string tenMH = txtTenMH.Text;
            int soTC = int.Parse(numSoTin.Text);
            int maCT = int.Parse(cbbChuongTrinhDT.Text);

         
            CallMonHocInsertUpdateDelete(1, tenMH, soTC, maCT, ref monHocID);

          
            MessageBox.Show("Môn học với ID " + monHocID + " đã được cập nhật.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           
            int monHocID = int.Parse(txtMaMH.Text);

            
            CallMonHocInsertUpdateDelete(2, "", 0, 0, ref monHocID);

       
            MessageBox.Show("Môn học với ID " + monHocID + " đã được xóa.");
        }
    }

}

