using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLThuVien.QuanLySach
{
    public partial class frTTSach : Form
    {
        int f,f1;
        string strConn = @"Data Source=HP\SQLEXPRESS;Initial Catalog=QLThuVien;Integrated Security=True";
        SqlConnection conn = new SqlConnection();
        private void LoadData1()
        {
            SqlDataAdapter da1 = new SqlDataAdapter("SELECT * from KeSach", conn);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            dgKeSach.DataSource = dt1;
            txtMaKe.DataBindings.Clear();
            txtMaKe.DataBindings.Add("text", dt1, "MaKS");
            txtTenKe.DataBindings.Clear();
            txtTenKe.DataBindings.Add("text", dt1, "TenKe");
          


        }
        private void LoadData2()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * from TheLoai", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgTheLoai.DataSource = dt;
            txtMaTL.DataBindings.Clear();
            txtMaTL.DataBindings.Add("text", dt, "MaTL");
            txtTenTL.DataBindings.Clear();
            txtTenTL.DataBindings.Add("text", dt, "TenTL");



        }
        public frTTSach()
        {
            InitializeComponent();
            conn = new SqlConnection(strConn);
            conn.Open();
            LoadData1();
            LoadData2();
        }

        private void frTTSach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLThuVienDataSet6.TheLoai' table. You can move, or remove it, as needed.
            this.theLoaiTableAdapter.Fill(this.qLThuVienDataSet6.TheLoai);
            // TODO: This line of code loads data into the 'qLThuVienDataSet6.KeSach' table. You can move, or remove it, as needed.
            this.keSachTableAdapter.Fill(this.qLThuVienDataSet6.KeSach);
           // LoadData1();
            //LoadData2();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            f = 0;
            txtMaKe.Text = TaoMaKS();
            txtTenKe.ResetText();
            txtMaKe.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            f = 1;
            txtTenKe.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("XoaKS", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p = new SqlParameter("@MaKS", txtMaKe.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@TenKS", txtTenKe.Text);
                cmd.Parameters.Add(p);
              
                int count = cmd.ExecuteNonQuery();
                if (count > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadData1();
                    txtMaKe.Text = "";
                    txtTenKe.Text = "";
                    
                }
                else MessageBox.Show("Không thể xóa bản ghi hiện thời!");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (f == 0)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("ThemKS", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter p = new SqlParameter("@MaKS", txtMaKe.Text);
                    cmd.Parameters.Add(p);
                    p = new SqlParameter("@TenKS", txtTenKe.Text);
                    cmd.Parameters.Add(p);
                    int count = cmd.ExecuteNonQuery();
                    if (count > 0)
                    {
                        MessageBox.Show("Thêm mới thành công");
                        LoadData1();
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
                    SqlCommand cmd = new SqlCommand("SuaKS", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter p = new SqlParameter("@MaKS", txtMaKe.Text);
                    cmd.Parameters.Add(p);
                    p = new SqlParameter("@TenKS", txtTenKe.Text);
                    cmd.Parameters.Add(p);
                    int count = cmd.ExecuteNonQuery();
                    if (count > 0)
                    {
                        MessageBox.Show("Sửa thành công");
                        LoadData1();
                    }
                    else MessageBox.Show("Không thể sửa");
                }
                catch (Exception)
                {
                }
            }
            
        }

        private void btnThemTL_Click(object sender, EventArgs e)
        {
            f1 = 0;
            txtMaTL.Text = TaoMaTL();
            txtTenTL.ResetText();
            txtMaTL.Focus();
        }

        private void btnSuaTL_Click(object sender, EventArgs e)
        {
            f1 = 1;
            txtTenTL.Focus();

        }

        private void btnLuuTL_Click(object sender, EventArgs e)
        {
            if (f1 == 0)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("ThemTL", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter p = new SqlParameter("@MaTL", txtMaTL.Text);
                    cmd.Parameters.Add(p);
                    p = new SqlParameter("@TenTL", txtTenTL.Text);
                    cmd.Parameters.Add(p);
                    int count = cmd.ExecuteNonQuery();
                    if (count > 0)
                    {
                        MessageBox.Show("Thêm mới thành công");
                        LoadData2();
                    }
                    else MessageBox.Show("Không thể thêm mới");
                }
                catch (Exception)
                {
                }
            }
            else if (f1 == 1)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SuaTL", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter p = new SqlParameter("@MaTL", txtMaTL.Text);
                    cmd.Parameters.Add(p);
                    p = new SqlParameter("@TenTL", txtTenTL.Text);
                    cmd.Parameters.Add(p);
                    int count = cmd.ExecuteNonQuery();
                    if (count > 0)
                    {
                        MessageBox.Show("Lưu thành công");
                        LoadData2();
                    }
                    else MessageBox.Show("Không thể lưu");
                }
                catch (Exception)
                {
                }
            }
            
        }

        public string TaoMaKS()
        {
            string ma = "";
            SqlDataAdapter da = new SqlDataAdapter("SELECT  * FROM KeSach", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgKeSach.DataSource = dt;
            if (dt.Rows.Count <= 0)
            {
                ma = "KS01";
            }
            else
            {
                int k;
                ma = "KS";
                k = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][1].ToString().Substring(2, 2));
                k = k + 1;
                ma = ma + k.ToString();
            }

            return ma;

        }
        public string TaoMaTL()
        {
            string ma = "";
            SqlDataAdapter da = new SqlDataAdapter("SELECT  * FROM TheLoai", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgTheLoai.DataSource = dt;
            if (dt.Rows.Count <= 0)
            {
                ma = "TL01";
            }
            else
            {
                int k;
                ma = "TL";
                k = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][1].ToString().Substring(3, 2));
                k = k + 1;
                ma = ma + k.ToString();
            }

            return ma;

        }

        private void btnXoaTL_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("XoaTL", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p = new SqlParameter("@MaTL", txtMaTL.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@TenTL", txtTenTL.Text);
                cmd.Parameters.Add(p);

                int count = cmd.ExecuteNonQuery();
                if (count > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadData2();
                    txtMaTL.Text = "";
                    txtTenTL.Text = "";

                }
                else MessageBox.Show("Không thể xóa bản ghi hiện thời!");
            }
        }

       
    }
}
