using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLThuVien.QuanLyThongTin
{
    public partial class fraTacPham : Form
    {

        int f;
        string strConn = @"Data Source=HP\SQLEXPRESS;Initial Catalog=QLThuVien;Integrated Security=True";
        SqlConnection conn = new SqlConnection();
        private void LoadData()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * from TacPham", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgTacPham.DataSource = dt;
            txtMasach.DataBindings.Clear();
            txtMasach.DataBindings.Add("text", dt, "MaTP");
            txtTenTP.DataBindings.Clear();
            txtTenTP.DataBindings.Add("text", dt, "TenSach");
            cbMaTG.DataBindings.Clear();
            cbMaTG.DataBindings.Add("text", dt, "MaTG");
            cbMaTL.DataBindings.Clear();
            cbMaTL.DataBindings.Add("text", dt, "MaTL");
            dateNgayDK.DataBindings.Clear();
            dateNgayDK.DataBindings.Add("text", dt, "NgayDangKy");
            cbMaNXB.DataBindings.Clear();
            cbMaNXB.DataBindings.Add("text", dt, "MaNXB");
            dateNamXB.DataBindings.Clear();
            dateNamXB.DataBindings.Add("text", dt, "NamXB");
            txtGiaTien.DataBindings.Clear();
            txtGiaTien.DataBindings.Add("text", dt, "GiaSach");
            cbMaKS.DataBindings.Clear();
            cbMaKS.DataBindings.Add("text", dt, "MaKS");
            txtSoLuong.DataBindings.Clear();
            txtSoLuong.DataBindings.Add("text", dt, "SoLuong");
           
        }
        public fraTacPham()
        {
            InitializeComponent();
            conn = new SqlConnection(strConn);
            conn.Open();
            LoadData();
            Show_CboNXB("");
            Show_CboMaTG("");
            Show_CboMaTL("");
            Show_CboMaKS("");
        }
        private void Show_CboNXB(string MaNXB)
        {
            string sql = "Select MaNXB From NXB";
            if (MaNXB != "")
                sql = sql + " Where MaNXB='" + MaNXB + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbMaNXB.DataSource = dt;
            cbMaNXB.ValueMember = "MaNXB";
        }
        private void Show_CboMaTG(string MaTG)
        {
            string sql = "Select MaTG From TacGia";
            if (MaTG != "")
                sql = sql + " Where MaTG='" + MaTG + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbMaTG.DataSource = dt;
            cbMaTG.ValueMember = "MaTG";
        }
        private void Show_CboMaTL(string MaTL)
        {
            string sql = "Select MaTL From TheLoai";
            if (MaTL != "")
                sql = sql + " Where MaTL='" + MaTL + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbMaTL.DataSource = dt;
            cbMaTL.ValueMember = "MaTL";
        }
        private void Show_CboMaKS(string MaKS)
        {
            string sql = "Select MaKS From KeSach";
            if (MaKS != "")
                sql = sql + " Where MaKS='" + MaKS + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbMaKS.DataSource = dt;
            cbMaKS.ValueMember = "MaKS";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            f = 0;
            txtGiaTien.ResetText();
            txtMasach.ResetText();
            txtSoLuong.ResetText();
            txtTenTP.ResetText();
            txtMasach.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("XoaTP", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p = new SqlParameter("@MaTP", txtMasach.Text);
                cmd.Parameters.Add(p);
                SqlParameter p0 = new SqlParameter("@TenTP", txtTenTP.Text);
                cmd.Parameters.Add(p0);
                SqlParameter p2 = new SqlParameter("@MaTG", cbMaTG.Text);
                cmd.Parameters.Add(p2);
                SqlParameter p3 = new SqlParameter("@MaTL", cbMaTL.Text);
                cmd.Parameters.Add(p3);
                SqlParameter p4 = new SqlParameter("@NgayDK", dateNgayDK.Text);
                cmd.Parameters.Add(p4);
                SqlParameter p5 = new SqlParameter("@MaNXB", cbMaNXB.Text);
                cmd.Parameters.Add(p5);
                SqlParameter p6 = new SqlParameter("@NamXB", dateNamXB.Text);
                cmd.Parameters.Add(p6);
                SqlParameter p7 = new SqlParameter("@GiaTien", txtGiaTien.Text);
                cmd.Parameters.Add(p7);
                SqlParameter p8 = new SqlParameter("@MaKS", cbMaKS.Text);
                cmd.Parameters.Add(p8);
                SqlParameter p9 = new SqlParameter("@SoLuong", txtSoLuong.Text);
                cmd.Parameters.Add(p9);
                int count = cmd.ExecuteNonQuery();
                if (count > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadData();
                    txtTenTP.Text = "";
                    txtSoLuong.Text = "";
                    txtMasach.Text = "";
                    txtGiaTien.Text = "";
                    cbMaKS.Text = "";
                    cbMaNXB.Text = "";
                    cbMaTG.Text = "";
                    cbMaTL.Text = "";
                    dateNamXB.Text = "";
                    dateNgayDK.Text = "";

                }
                else MessageBox.Show("Không thể xóa bản ghi hiện thời!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            f = 1;
            txtTenTP.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (f == 0)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("ThemTP", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter p = new SqlParameter("@MaTP", txtMasach.Text);
                    cmd.Parameters.Add(p);
                    SqlParameter p0 = new SqlParameter("@TenTP", txtTenTP.Text);
                    cmd.Parameters.Add(p0);
                    SqlParameter p2 = new SqlParameter("@MaTG", cbMaTG.Text);
                    cmd.Parameters.Add(p2);
                    SqlParameter p3 = new SqlParameter("@MaTL", cbMaTL.Text);
                    cmd.Parameters.Add(p3);
                    SqlParameter p4 = new SqlParameter("@NgayDK", dateNgayDK.Text);
                    cmd.Parameters.Add(p4);
                    SqlParameter p5 = new SqlParameter("@MaNXB", cbMaNXB.Text);
                    cmd.Parameters.Add(p5);
                    SqlParameter p6 = new SqlParameter("@NamXB", dateNamXB.Text);
                    cmd.Parameters.Add(p6);
                    SqlParameter p7 = new SqlParameter("@GiaTien", txtGiaTien.Text);
                    cmd.Parameters.Add(p7);
                    SqlParameter p8 = new SqlParameter("@MaKS", cbMaKS.Text);
                    cmd.Parameters.Add(p8);
                    SqlParameter p9 = new SqlParameter("@SoLuong", txtSoLuong.Text);
                    cmd.Parameters.Add(p9);
                    int count = cmd.ExecuteNonQuery();
                    if (count > 0)
                    {
                        MessageBox.Show("Thêm mới thành công");
                        LoadData();
                    }
                    else MessageBox.Show("Không thể thêm mới");
                }
                catch (Exception)
                {
                }
            }
            else if (f == 1)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SuaTP", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter p = new SqlParameter("@MaTP", txtMasach.Text);
                    cmd.Parameters.Add(p);
                    SqlParameter p0 = new SqlParameter("@TenTP", txtTenTP.Text);
                    cmd.Parameters.Add(p0);
                    SqlParameter p2 = new SqlParameter("@MaTG", cbMaTG.Text);
                    cmd.Parameters.Add(p2);
                    SqlParameter p3 = new SqlParameter("@MaTL", cbMaTL.Text);
                    cmd.Parameters.Add(p3);
                    SqlParameter p4 = new SqlParameter("@NgayDK", dateNgayDK.Text);
                    cmd.Parameters.Add(p4);
                    SqlParameter p5 = new SqlParameter("@MaNXB", cbMaNXB.Text);
                    cmd.Parameters.Add(p5);
                    SqlParameter p6 = new SqlParameter("@NamXB", dateNamXB.Text);
                    cmd.Parameters.Add(p6);
                    SqlParameter p7 = new SqlParameter("@GiaTien", txtGiaTien.Text);
                    cmd.Parameters.Add(p7);
                    SqlParameter p8 = new SqlParameter("@MaKS", cbMaKS.Text);
                    cmd.Parameters.Add(p8);
                    SqlParameter p9 = new SqlParameter("@SoLuong", txtSoLuong.Text);
                    cmd.Parameters.Add(p9);
                    int count = cmd.ExecuteNonQuery();
                    if (count > 0)
                    {
                        MessageBox.Show("Lưu thành công");
                        LoadData();
                    }
                    else MessageBox.Show("Không thể lưu");
                }
                catch (Exception)
                {
                }
            }
        }

        private void fraTacPham_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLThuVienDataSetNew.TacPham' table. You can move, or remove it, as needed.
            this.tacPhamTableAdapter.Fill(this.qLThuVienDataSetNew.TacPham);
         

        }

        private void cbMaTL_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        }
    
}
