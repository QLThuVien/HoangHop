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
    public partial class frNXB : Form
    {
        int f;
        string strConn = @"Data Source=HP\SQLEXPRESS;Initial Catalog=QLThuVien;Integrated Security=True";
        SqlConnection conn = new SqlConnection();
        private void LoadData()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * from NXB", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgNXB.DataSource = dt;
            txtMaNXB.DataBindings.Clear();
            txtMaNXB.DataBindings.Add("text", dt, "MaNXB");
            txtNXB.DataBindings.Clear();
            txtNXB.DataBindings.Add("text", dt, "TenNXB");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("text", dt, "DiaChi");
            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("text", dt, "Email");
            txtTTDaiDien.DataBindings.Clear();
            txtTTDaiDien.DataBindings.Add("text", dt, "TT_DaiDien");


        }
        public frNXB()
        {
            InitializeComponent();
            conn = new SqlConnection(strConn);
            conn.Open();
            LoadData();
        }

        private void frNXB_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLThuVienDataSetNew.NXB' table. You can move, or remove it, as needed.
            this.nXBTableAdapter.Fill(this.qLThuVienDataSetNew.NXB);
            // TODO: This line of code loads data into the 'qLThuVienDataSet6.NXB' table. You can move, or remove it, as needed.

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            f = 1;
            txtDiaChi.ResetText();
            txtEmail.ResetText();
            txtNXB.ResetText();
            txtMaNXB.Text = TaoMa();
            txtTTDaiDien.ResetText();
            txtNXB.Focus();
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            f = 2;
            txtNXB.Focus();
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("XoaNXB", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p = new SqlParameter("@MaNXB", txtMaNXB.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@TenNXB", txtNXB.Text);
                cmd.Parameters.Add(p);
                SqlParameter p2 = new SqlParameter("@Diachi", txtDiaChi.Text);
                cmd.Parameters.Add(p2);
                SqlParameter p3 = new SqlParameter("@Email", txtEmail.Text);
                cmd.Parameters.Add(p3);
                SqlParameter p4 = new SqlParameter("@DaiDien", txtTTDaiDien.Text);
                cmd.Parameters.Add(p4);
                int count = cmd.ExecuteNonQuery();
                if (count > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadData();
                    txtMaNXB.Text = "";
                    txtNXB.Text = "";
                    txtDiaChi.Text = "";
                    txtEmail.Text = "";
                    txtTTDaiDien.Text = "";
                }
                else MessageBox.Show("Không thể xóa bản ghi hiện thời!");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(f==1)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("ThemNXB", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter p = new SqlParameter("@MaNXB", txtMaNXB.Text);
                    cmd.Parameters.Add(p);
                    p = new SqlParameter("@TenNXB", txtNXB.Text);
                    cmd.Parameters.Add(p);
                    SqlParameter p2 = new SqlParameter("@Diachi", txtDiaChi.Text);
                    cmd.Parameters.Add(p2);
                    SqlParameter p3 = new SqlParameter("@Email", txtEmail.Text);
                    cmd.Parameters.Add(p3);
                    SqlParameter p4 = new SqlParameter("@DaiDien", txtTTDaiDien.Text);
                    cmd.Parameters.Add(p4);
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
            else if(f==2)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SuaNXB", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter p = new SqlParameter("@MaNXB", txtMaNXB.Text);
                    cmd.Parameters.Add(p);
                    p = new SqlParameter("@TenNXB", txtNXB.Text);
                    cmd.Parameters.Add(p);
                    SqlParameter p2 = new SqlParameter("@Diachi", txtDiaChi.Text);
                    cmd.Parameters.Add(p2);
                    SqlParameter p3 = new SqlParameter("@Email", txtEmail.Text);
                    cmd.Parameters.Add(p3);
                    SqlParameter p4 = new SqlParameter("@DaiDien", txtTTDaiDien.Text);
                    cmd.Parameters.Add(p4);

                    int count = cmd.ExecuteNonQuery();
                    if (count > 0)
                    {
                        MessageBox.Show("Sửa thành công!");
                        LoadData();
                    }
                    else MessageBox.Show("Không sửa được!");
                }
                catch (Exception)
                {
                }

            }

        }
        public string TaoMa()
        {
            string ma = "";
            SqlDataAdapter da = new SqlDataAdapter("SELECT  * FROM NXB", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgNXB.DataSource = dt;
            if (dt.Rows.Count <= 0)
            {
                ma = "NXB01";
            }
            else
            {
                int k;
                ma = "NXB";
                k = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][1].ToString().Substring(3, 2));
                k = k + 1;
                ma = ma + k.ToString();
            }

            return ma;

        }
    }
}
