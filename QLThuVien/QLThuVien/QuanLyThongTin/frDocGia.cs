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
    public partial class frDocGia : Form
    {
        int f;
        string strConn = @"Data Source=HP\SQLEXPRESS;Initial Catalog=QLThuVien;Integrated Security=True";
        SqlConnection conn = new SqlConnection();
        private void LoadData()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * from DocGia", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgDocGia.DataSource = dt;

            txtMaDocGia.DataBindings.Clear();
            txtMaDocGia.DataBindings.Add("text", dt, "MaDG");
            txtHoTen.DataBindings.Clear();
            txtHoTen.DataBindings.Add("text", dt, "HoTen");
            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("text", dt, "SDT");
            cbGioiTinh.DataBindings.Clear();
            cbGioiTinh.DataBindings.Add("text", dt, "GioiTinh");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("text", dt, "DiaChi");
            dateNS.DataBindings.Clear();
            dateNS.DataBindings.Add("text", dt, "NgaySinh");
        }
        public frDocGia()
        {
            InitializeComponent();
            conn = new SqlConnection(strConn);
            conn.Open();
            LoadData();
        }

        private void frDocGia_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLThuVienDataSetNew.DocGia' table. You can move, or remove it, as needed.
            this.docGiaTableAdapter.Fill(this.qLThuVienDataSetNew.DocGia);

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            f = 0;
            txtHoTen.ResetText();
            txtDiaChi.ResetText();
            txtSDT.ResetText();
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (f == 0)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("ThemDocGia", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter p = new SqlParameter("@MaDG", txtMaDocGia.Text);
                    cmd.Parameters.Add(p);
                    SqlParameter p1 = new SqlParameter("@HoTen", txtHoTen.Text);
                    cmd.Parameters.Add(p1);
                    SqlParameter p2 = new SqlParameter("@NgaySinh", dateNS.Text);
                    cmd.Parameters.Add(p2);
                    SqlParameter p4 = new SqlParameter("@GioiTinh", cbGioiTinh.Text);
                    cmd.Parameters.Add(p4);
                    SqlParameter p3 = new SqlParameter("@SDT", txtSDT.Text);
                    cmd.Parameters.Add(p3);
                    SqlParameter p0 = new SqlParameter("@DiaChi", txtDiaChi.Text);
                    cmd.Parameters.Add(p0);
                    
                    

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
                    SqlCommand cmd = new SqlCommand("SuaDocGia", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter p = new SqlParameter("@MaDG", txtMaDocGia.Text);
                    cmd.Parameters.Add(p);
                    SqlParameter p1 = new SqlParameter("@HoTen", txtHoTen.Text);
                    cmd.Parameters.Add(p1);
                    SqlParameter p2 = new SqlParameter("@NgaySinh", dateNS.Text);
                    cmd.Parameters.Add(p2);
                    SqlParameter p4 = new SqlParameter("@GioiTinh", cbGioiTinh.Text);
                    cmd.Parameters.Add(p4);
                    SqlParameter p3 = new SqlParameter("@SDT", txtSDT.Text);
                    cmd.Parameters.Add(p3);
                    SqlParameter p0 = new SqlParameter("@DiaChi", txtDiaChi.Text);
                    cmd.Parameters.Add(p0);
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("XoaDocGia", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p = new SqlParameter("@MaDG", txtMaDocGia.Text);
                cmd.Parameters.Add(p);
                SqlParameter p1 = new SqlParameter("@HoTen", txtHoTen.Text);
                cmd.Parameters.Add(p1);
                SqlParameter p2 = new SqlParameter("@NgaySinh", dateNS.Text);
                cmd.Parameters.Add(p2);
                SqlParameter p4 = new SqlParameter("@GioiTinh", cbGioiTinh.Text);
                cmd.Parameters.Add(p4);
                SqlParameter p3 = new SqlParameter("@SDT", txtSDT.Text);
                cmd.Parameters.Add(p3);
                SqlParameter p0 = new SqlParameter("@DiaChi", txtDiaChi.Text);
                cmd.Parameters.Add(p0);

                int count = cmd.ExecuteNonQuery();
                if (count > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadData();
                    txtMaDocGia.Text = "";
                    txtHoTen.Text = "";
                    txtSDT.Text = "";
                    txtDiaChi.Text = "";
                    dateNS.Text = "";
                    cbGioiTinh.Text = "";


                }
                else MessageBox.Show("Không thể xóa bản ghi hiện thời!");
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            f = 1;
            txtHoTen.Focus();
        }

       
    }
}
