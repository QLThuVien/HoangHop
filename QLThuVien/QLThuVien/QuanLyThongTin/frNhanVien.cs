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
    public partial class frNhanVien : Form
    {
        public int flag;
        DataView data;
        string strConn = @"Data Source=HP\SQLEXPRESS;Initial Catalog=QLThuVien;Integrated Security=True";
        SqlConnection conn = new SqlConnection();
        public frNhanVien()
        {
            InitializeComponent();
            conn = new SqlConnection(strConn);
            conn.Open();
            LoadData();
        }

        private void LoadData()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * from NhanVien", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgNhanVien.DataSource = dt;
            txtMaNhanVien.DataBindings.Clear();
            txtMaNhanVien.DataBindings.Add("text", dt, "MaNV");
            txtHoTen.DataBindings.Clear();
            txtHoTen.DataBindings.Add("text", dt, "HoTen");
            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("text", dt, "SDT");
            cbGioiTinh.DataBindings.Clear();
            cbGioiTinh.DataBindings.Add("text", dt, "GioiTinh");
            dateNS.DataBindings.Clear();
            dateNS.DataBindings.Add("text", dt, "NgaySinh");
            

        }

        private void frNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLThuVienDataSetNew.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter1.Fill(this.qLThuVienDataSetNew.NhanVien);
            

        }
        public string TaoMa()
        {
            string ma = "";
            SqlDataAdapter da = new SqlDataAdapter("SELECT  * FROM NhanVien", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgNhanVien.DataSource = dt;
            if (dt.Rows.Count <= 0)
            {
                ma = "NV001";
            }
            else
            {
                int k;
                ma = "NV";
                k = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][1].ToString().Substring(2, 3));
                k = k + 1;
                ma = ma + k.ToString();
            }

            return ma;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 0;
            txtMaNhanVien.Text = TaoMa();
            txtHoTen.ResetText();
            txtSDT.ResetText();
            dateNS.ResetText();
            txtHoTen.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("XoaNV", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p = new SqlParameter("@MaNV", txtMaNhanVien.Text);
                cmd.Parameters.Add(p);
                SqlParameter p0 = new SqlParameter("@TenNV", txtHoTen.Text);
                cmd.Parameters.Add(p0);
                SqlParameter p2 = new SqlParameter("@SDT", txtSDT.Text);
                cmd.Parameters.Add(p2);
                SqlParameter p3 = new SqlParameter("@GioiTinh", cbGioiTinh.Text);
                cmd.Parameters.Add(p3);
                SqlParameter p4 = new SqlParameter("@Ngaysinh", dateNS.Text);
                cmd.Parameters.Add(p4);
                int count = cmd.ExecuteNonQuery();
                if (count > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadData();
                    txtMaNhanVien.Text = "";
                    txtHoTen.Text = "";
                    txtSDT.Text = "";
                    cbGioiTinh.Text = "";
                    dateNS.Text = "";
                }
                else MessageBox.Show("Không thể xóa bản ghi hiện thời!");
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            flag = 1;
            txtHoTen.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("ThemNV", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter p = new SqlParameter("@MaNV", txtMaNhanVien.Text);
                    cmd.Parameters.Add(p);
                    SqlParameter p0 = new SqlParameter("@TenNV", txtHoTen.Text);
                    cmd.Parameters.Add(p0);
                    SqlParameter p2 = new SqlParameter("@SDT", txtSDT.Text);
                    cmd.Parameters.Add(p2);
                    SqlParameter p3 = new SqlParameter("@GioiTinh", cbGioiTinh.Text);
                    cmd.Parameters.Add(p3);
                    SqlParameter p4 = new SqlParameter("@Ngaysinh", dateNS.Text);
                    cmd.Parameters.Add(p4);
                    int count = cmd.ExecuteNonQuery();
                    if (count > 0)
                    {
                        MessageBox.Show("Lưu thành công");
                        LoadData();
                    }
                    else MessageBox.Show("Không thể thêm mới");
                }
                catch (Exception)
                {
                    MessageBox.Show("Đã tồn tại, vui lòng nhập lại", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else if (flag == 1)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SuaNV", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter p = new SqlParameter("@MaNV", txtMaNhanVien.Text);
                    cmd.Parameters.Add(p);
                    SqlParameter p0 = new SqlParameter("@TenNV", txtHoTen.Text);
                    cmd.Parameters.Add(p0);
                    SqlParameter p2 = new SqlParameter("@SDT", txtSDT.Text);
                    cmd.Parameters.Add(p2);
                    SqlParameter p3 = new SqlParameter("@GioiTinh", cbGioiTinh.Text);
                    cmd.Parameters.Add(p3);
                    SqlParameter p4 = new SqlParameter("@Ngaysinh", dateNS.Text);
                    cmd.Parameters.Add(p4);
                    int count = cmd.ExecuteNonQuery();
                    if (count > 0)
                    {
                        MessageBox.Show("Lưu thành công!");
                        LoadData();
                    }
                    else MessageBox.Show("Không sửa được!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Đã tồn tại, vui lòng nhập lại", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            
            if (cboNhanVien.SelectedText == "Tên nhân viên")
            {
                string tennv = txtTimKiem.Text;
                SqlDataAdapter da = new SqlDataAdapter("SELECT  * FROM NhanVien Where HoTen like N'%"+tennv+"%'", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                data = new DataView(dt);
                dgNhanVien.DataSource = data;
                
                
            }
            else if (cboNhanVien.SelectedText == "Mã nhân viên")
            {
                string manv = txtMaNhanVien.Text;
                SqlDataAdapter da = new SqlDataAdapter("SELECT  * FROM NhanVien Where MaNV like N'%" + manv + "%'", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                data = new DataView(dt);
                dgNhanVien.DataSource = data;
            }
            else if (cboNhanVien.SelectedText == "SĐT")
            {
                string sdt = txtSDT.Text;
                SqlDataAdapter da = new SqlDataAdapter("SELECT  * FROM NhanVien Where SDT like N'%" + sdt + "%'", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                data = new DataView(dt);
                dgNhanVien.DataSource = data;
            }
        }

        
    }
}
