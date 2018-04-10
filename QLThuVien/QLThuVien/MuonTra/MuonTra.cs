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
    public partial class MuonTra : Form
    {
        int f;
        string strConn = @"Data Source=HP\SQLEXPRESS;Initial Catalog=QLThuVien;Integrated Security=True";
        SqlConnection conn = new SqlConnection();
        private void LoadData()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * from MuonTra", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgMuonTra.DataSource = dt;
            txtPhieuMuon.DataBindings.Clear();
            txtPhieuMuon.DataBindings.Add("text", dt, "MaPM");
            
            cbMaDG.DataBindings.Clear();
            cbMaDG.DataBindings.Add("text", dt, "MaDG");
            cbMaNV.DataBindings.Clear();
            cbMaNV.DataBindings.Add("text", dt, "MaNV_GD");
            
            dateHT.DataBindings.Clear();
            dateHT.DataBindings.Add("text", dt, "HenTra");
            dateMuon.DataBindings.Clear();
            dateMuon.DataBindings.Add("text", dt, "NgayMuon");




        }
        public MuonTra()
        {
            InitializeComponent();
            conn = new SqlConnection(strConn);
            conn.Open();
            LoadData();
            Show_CboMaNV("");
            Show_CboMaDG("");
        }

       

        private void ChiTietMuonTra_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLThuVienDataSet7.MuonTra' table. You can move, or remove it, as needed.
            this.muonTraTableAdapter.Fill(this.qLThuVienDataSet7.MuonTra);
            
        }
        private void Show_CboMaDG(string MaDG)
        {
            string sql = "Select MaDG From DocGia";
            if (MaDG != "")
                sql = sql + " Where MaDG='" + MaDG + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbMaDG.DataSource = dt;
            cbMaDG.ValueMember = "MaDG";
        }
        private void Show_CboMaNV(string MaNV_GD)
        {
            string sql = "Select MaNV From NhanVien";
            if (MaNV_GD != "")
                sql = sql + " Where MaNV='" + MaNV_GD + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbMaNV.DataSource = dt;
            cbMaNV.ValueMember = "MaNV";
        }
        

        private void btnThem_Click(object sender, EventArgs e)
        {
            f = 0;
            txtPhieuMuon.ResetText();
            dateHT.ResetText();
            dateMuon.ResetText();
          
            txtPhieuMuon.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("XoaMuonTra", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p = new SqlParameter("@MaPM", txtPhieuMuon.Text);
                cmd.Parameters.Add(p);
                SqlParameter p0 = new SqlParameter("@MaDG", cbMaDG.Text);
                cmd.Parameters.Add(p0);
                SqlParameter p2 = new SqlParameter("@NgayMuon", dateMuon.Text);
                cmd.Parameters.Add(p2);
                SqlParameter p3 = new SqlParameter("@NgayTra", dateHT.Text);
                cmd.Parameters.Add(p3);
                SqlParameter p4 = new SqlParameter("@MaNV_GD", cbMaNV.Text);
                cmd.Parameters.Add(p4);
                
                int count = cmd.ExecuteNonQuery();
                if (count > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadData();
                    txtPhieuMuon.Text = "";
                    cbMaDG.Text = "";
                    cbMaNV.Text = "";
                    dateHT.Text = "";
                    dateMuon.Text = "";
                    

                }
                else MessageBox.Show("Không thể xóa bản ghi hiện thời!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            f = 1;
            txtPhieuMuon.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (f == 0)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("ThemMuonTra", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter p = new SqlParameter("@MaPM", txtPhieuMuon.Text);
                    cmd.Parameters.Add(p);
                    SqlParameter p0 = new SqlParameter("@MaDG", cbMaDG.Text);
                    cmd.Parameters.Add(p0);
                    SqlParameter p2 = new SqlParameter("@NgayMuon", dateMuon.Text);
                    cmd.Parameters.Add(p2);
                    SqlParameter p3 = new SqlParameter("@NgayTra", dateHT.Text);
                    cmd.Parameters.Add(p3);
                    SqlParameter p4 = new SqlParameter("@MaNV_GD", cbMaNV.Text);
                    cmd.Parameters.Add(p4);

                    int count = cmd.ExecuteNonQuery();
                    if (count > 0)
                    {
                        MessageBox.Show("Thêm mới thành công");
                        LoadData();
                    }
                    else MessageBox.Show("Không thể thêm mới");
                }
                catch(Exception)
                {
                }
            }
            else if (f == 1)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SuaMuonTra", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter p = new SqlParameter("@MaPM", txtPhieuMuon.Text);
                    cmd.Parameters.Add(p);
                    SqlParameter p0 = new SqlParameter("@MaDG", cbMaDG.Text);
                    cmd.Parameters.Add(p0);
                    SqlParameter p2 = new SqlParameter("@NgayMuon", dateMuon.Text);
                    cmd.Parameters.Add(p2);
                    SqlParameter p3 = new SqlParameter("@NgayTra", dateHT.Text);
                    cmd.Parameters.Add(p3);
                    SqlParameter p4 = new SqlParameter("@MaNV_GD", cbMaNV.Text);
                    cmd.Parameters.Add(p4);

                    int count = cmd.ExecuteNonQuery();
                    if (count > 0)
                    {
                        MessageBox.Show("Sửa thành công");
                        LoadData();
                    }
                    else MessageBox.Show("Không thể sửa");
                } 
                catch (Exception)
                {
                }
            }
        }

        private void btnCTMT_Click(object sender, EventArgs e)
        {
            CTMuonTra ctmt = new CTMuonTra();
            ctmt.Show();
        }

       
    }
}
