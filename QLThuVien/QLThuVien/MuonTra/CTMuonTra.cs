using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLThuVien.MuonTra
{
    public partial class CTMuonTra : Form
    {
        int f;
        string strConn = @"Data Source=HP\SQLEXPRESS;Initial Catalog=QLThuVien;Integrated Security=True";
        SqlConnection conn = new SqlConnection();
        private void LoadData()
        {
       
            SqlDataAdapter da = new SqlDataAdapter("SELECT ctmt.STT, mt.MaPM,ctmt.MaSach,mt.HenTra from MuonTra mt, CTMuonTra ctmt where ctmt.MaPM= mt.MaPM ", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgCTMuontra.DataSource = dt;

           }
        public CTMuonTra()
        {
            InitializeComponent();
            conn = new SqlConnection(strConn);
            conn.Open();
            LoadData();

          
        }

        private void CTMuonTra_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLThuVienDataSetNew.CTMuonTra' table. You can move, or remove it, as needed.
            this.cTMuonTraTableAdapter.Fill(this.qLThuVienDataSetNew.CTMuonTra);
            // TODO: This line of code loads data into the 'qLThuVienDataSet8.CTMuonTra' table. You can move, or remove it, as needed.
           // this.cTMuonTraTableAdapter.Fill(this.qLThuVienDataSet8.CTMuonTra);
            // TODO: This line of code loads data into the 'qLThuVienDataSet6.CTMuonTra' table. You can move, or remove it, as needed.
        }
        

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("XoaCTMuontra", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p = new SqlParameter();
                cmd.Parameters.Add(p);
                 int count = cmd.ExecuteNonQuery();
                if (count > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadData();
                    

                  }
                else MessageBox.Show("Không thể xóa bản ghi hiện thời!");
            }
        }

        
       

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            PhieuPhat pp = new PhieuPhat();
            pp.Show();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        
    }
}
