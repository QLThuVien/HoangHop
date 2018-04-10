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
    public partial class frTacGia : Form
    {
        public int flag;
        string strConn = @"Data Source=HP\SQLEXPRESS;Initial Catalog=QLThuVien;Integrated Security=True";
        SqlConnection conn = new SqlConnection();
        private void LoadData()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * from TacGia", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgTacGia.DataSource = dt;
            txtMaTG.DataBindings.Clear();
            txtMaTG.DataBindings.Add("text", dt, "MaTG");
            txtHoTen.DataBindings.Clear();
            txtHoTen.DataBindings.Add("text", dt, "HoTen");
            txtQueQuan.DataBindings.Clear();
            txtQueQuan.DataBindings.Add("text", dt, "QueQuan");
            txtGhiChu.DataBindings.Clear();
            txtGhiChu.DataBindings.Add("text", dt, "GhiChu");
            dateNS.DataBindings.Clear();
            dateNS.DataBindings.Add("text", dt, "NamSinh");
           
        }
        public frTacGia()
        {
            InitializeComponent();
            conn = new SqlConnection(strConn);
            conn.Open();
            LoadData();
            
        }

        private void frTacGia_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLThuVienDataSetNew.TacGia' table. You can move, or remove it, as needed.
            this.tacGiaTableAdapter.Fill(this.qLThuVienDataSetNew.TacGia);
            // TODO: This line of code loads data into the 'qLThuVienDataSet8.TacGia' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'qLThuVienDataSet6.TacGia' table. You can move, or remove it, as needed.
            SqlDataAdapter da = new SqlDataAdapter("SELECT * from TacGia", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgTacGia.DataSource = dt;
            txtMaTG.DataBindings.Clear();
            txtMaTG.DataBindings.Add("text", dt, "MaTG");
            txtHoTen.DataBindings.Clear();
            txtHoTen.DataBindings.Add("text", dt, "HoTen");
            txtQueQuan.DataBindings.Clear();
            txtQueQuan.DataBindings.Add("text", dt, "QueQuan");
            txtGhiChu.DataBindings.Clear();
            txtGhiChu.DataBindings.Add("text", dt, "GhiChu");
            dateNS.DataBindings.Clear();
            dateNS.DataBindings.Add("text", dt, "NamSinh");

        }

        

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 0;

            txtHoTen.ResetText();
            txtMaTG.ResetText();
            txtGhiChu.ResetText();
            txtQueQuan.ResetText();
            txtHoTen.Focus();
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 1;
            txtMaTG.Focus();
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                SqlCommand cmd = new SqlCommand("XoaTacGia", conn); 
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p = new SqlParameter("@MaTG", txtMaTG.Text);
                cmd.Parameters.Add(p);
                SqlParameter p0 = new SqlParameter("@TenTG", txtHoTen.Text);
                cmd.Parameters.Add(p0);
                SqlParameter p2 = new SqlParameter("@Que", txtQueQuan.Text);
                cmd.Parameters.Add(p2);
                SqlParameter p3 = new SqlParameter("@Ghichu", txtGhiChu.Text);
                cmd.Parameters.Add(p3);
                SqlParameter p4 = new SqlParameter("@Namsinh", dateNS.Text);
                cmd.Parameters.Add(p4);
                int count = cmd.ExecuteNonQuery();
                if (count > 0)
                {
                MessageBox.Show("Xóa thành công!");
                LoadData();
                txtGhiChu.Text="";
                txtHoTen.Text = ""; 
                txtMaTG.Text="";
                txtQueQuan.Text = "";
                dateNS.Text = "";
                
                }
                else MessageBox.Show("Không thể xóa bản ghi hiện thời!");
                }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("ThemTacGia", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter p = new SqlParameter("@MaTG", txtMaTG.Text);
                    cmd.Parameters.Add(p);
                    SqlParameter p0 = new SqlParameter("@TenTG", txtHoTen.Text);
                    cmd.Parameters.Add(p0);
                    SqlParameter p2 = new SqlParameter("@Que", txtQueQuan.Text);
                    cmd.Parameters.Add(p2);
                    SqlParameter p3 = new SqlParameter("@Ghichu", txtGhiChu.Text);
                    cmd.Parameters.Add(p3);
                    SqlParameter p4 = new SqlParameter("@Namsinh", dateNS.Text);
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
                //conn.Close();
            }
            else if (flag == 1)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SuaTacGia", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter p = new SqlParameter("@MaTG", txtMaTG.Text);
                    cmd.Parameters.Add(p);
                    p = new SqlParameter("@TenTG", txtHoTen.Text);
                    cmd.Parameters.Add(p);
                    SqlParameter p2 = new SqlParameter("@Que", txtQueQuan.Text);
                    cmd.Parameters.Add(p2);
                    SqlParameter p3 = new SqlParameter("@Ghichu", txtGhiChu.Text);
                    cmd.Parameters.Add(p3);
                    SqlParameter p4 = new SqlParameter("@Namsinh", dateNS.Text);
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
                    MessageBox.Show("Đã tồn tại, vui lòng nhập lại", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
               // conn.Close();
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        public string TaoMa()
        {
            string ma = "";
            SqlDataAdapter da = new SqlDataAdapter("SELECT  * FROM TacGia", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgTacGia.DataSource = dt;
            if (dt.Rows.Count <= 0)
            {
                ma = "TG01";
            }
            else
            {
                int k;
                ma = "TG";
                k = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][1].ToString().Substring(2, 2));
                k = k + 1;
                ma = ma + k.ToString();
            }

            return ma;

        }

        private void dgTacGia_MouseClick(object sender, MouseEventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * from TacGia", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgTacGia.DataSource = dt;
            txtMaTG.DataBindings.Clear();
            txtMaTG.DataBindings.Add("text", dt, "MaTG");
            txtHoTen.DataBindings.Clear();
            txtHoTen.DataBindings.Add("text", dt, "HoTen");
            txtQueQuan.DataBindings.Clear();
            txtQueQuan.DataBindings.Add("text", dt, "QueQuan");
            txtGhiChu.DataBindings.Clear();
            txtGhiChu.DataBindings.Add("text", dt, "GhiChu");
            dateNS.DataBindings.Clear();
            dateNS.DataBindings.Add("text", dt, "NamSinh");
        }

    }
}
