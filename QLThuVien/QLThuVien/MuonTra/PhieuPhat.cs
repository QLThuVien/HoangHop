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
    public partial class PhieuPhat : Form
    {
        int f;
        string strConn = @"Data Source=HP\SQLEXPRESS;Initial Catalog=QLThuVien;Integrated Security=True";
        SqlConnection conn = new SqlConnection();
        private void LoadData()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * from Phat", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgPhieuPhat.DataSource = dt;
            txtMaPP.DataBindings.Clear();
            txtMaPP.DataBindings.Add("text", dt, "MaPP");
            txtGhiChu.DataBindings.Clear();
            txtGhiChu.DataBindings.Add("text", dt, "GhiChu");

            cbMaSach.DataBindings.Clear();
            cbMaSach.DataBindings.Add("text", dt, "MaSach");
            cbPhieuMuon.DataBindings.Clear();
            cbPhieuMuon.DataBindings.Add("text", dt, "MaPM");

            cbCapDo.DataBindings.Clear();
            cbCapDo.DataBindings.Add("text", dt, "CapDo");

            txtThanhTien.DataBindings.Clear();
            txtThanhTien.DataBindings.Add("text", dt, "ThanhTien");

        }
        public PhieuPhat()
        {
            InitializeComponent();
            conn = new SqlConnection(strConn);
            conn.Open();
            LoadData();
            Show_CboMaSach("");
            Show_CboMaPM("");
        }

        private void PhieuPhat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLThuVienDataSet9.Phat' table. You can move, or remove it, as needed.
            this.phatTableAdapter.Fill(this.qLThuVienDataSet9.Phat);
            // TODO: This line of code loads data into the 'qLThuVienDataSet7.Phat' table. You can move, or remove it, as needed.

        }
        private void Show_CboMaSach(string MaSach)
        {
            string sql = "Select MaSach From Sach";
            if (MaSach != "")
                sql = sql + " Where MaSach='" + MaSach + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbMaSach.DataSource = dt;
            cbMaSach.ValueMember = "MaSach";
        }
        private void Show_CboMaPM(string MaPM)
        {
            string sql = "Select MaPM From MuonTra";
            if (MaPM != "")
                sql = sql + " Where MaPM='" + MaPM + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbPhieuMuon.DataSource = dt;
            cbPhieuMuon.ValueMember = "MaPM";
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            f = 0;
            txtMaPP.ResetText();
            txtGhiChu.ResetText();
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            f = 1;
           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("XoaPP", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p = new SqlParameter("@MaPP", txtMaPP.Text);
                cmd.Parameters.Add(p);
                SqlParameter p1 = new SqlParameter("@MaSach", cbMaSach.Text);
                cmd.Parameters.Add(p1);
                SqlParameter p0 = new SqlParameter("@MaPM", cbPhieuMuon.Text);
                cmd.Parameters.Add(p0);
                SqlParameter p2 = new SqlParameter("@CapDo", cbCapDo.Text);
                cmd.Parameters.Add(p2);
                SqlParameter p3 = new SqlParameter("@GhiChu", txtGhiChu.Text);
                cmd.Parameters.Add(p3);
                SqlParameter p4 = new SqlParameter("@ThanhTien", txtThanhTien.Text);
                cmd.Parameters.Add(p4);

                int count = cmd.ExecuteNonQuery();
                if (count > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadData();
                    txtMaPP.Text = "";
                    txtGhiChu.Text = "";
                    cbMaSach.Text = "";
                    cbPhieuMuon.Text = "";
                    cbCapDo.Text = "";
                    txtThanhTien.Text = "";


                }
                else MessageBox.Show("Không thể xóa bản ghi hiện thời!");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(f==0)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("ThemPhat", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter p = new SqlParameter("@MaPP", txtMaPP.Text);
                    cmd.Parameters.Add(p);
                    SqlParameter p0 = new SqlParameter("@MaSach", cbMaSach.Text);
                    cmd.Parameters.Add(p0);
                    SqlParameter p2 = new SqlParameter("@MaPM", cbPhieuMuon.Text);
                    cmd.Parameters.Add(p2);
                    SqlParameter p3 = new SqlParameter("@CapDo", cbCapDo.Text);
                    cmd.Parameters.Add(p3);
                    SqlParameter p4 = new SqlParameter("@GhiChu", txtGhiChu.Text);
                    cmd.Parameters.Add(p4);
                    SqlParameter p5 = new SqlParameter("@ThanhTien", txtThanhTien.Text);
                    cmd.Parameters.Add(p5);
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
            else if(f==1)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SuaPP", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter p = new SqlParameter("@MaPP", txtMaPP.Text);
                    cmd.Parameters.Add(p);
                    SqlParameter p0 = new SqlParameter("@MaSach", cbMaSach.Text);
                    cmd.Parameters.Add(p0);
                    SqlParameter p2 = new SqlParameter("@MaPM", cbPhieuMuon.Text);
                    cmd.Parameters.Add(p2);
                    SqlParameter p3 = new SqlParameter("@CapDo", cbCapDo.Text);
                    cmd.Parameters.Add(p3);
                    SqlParameter p4 = new SqlParameter("@GhiChu", txtGhiChu.Text);
                    cmd.Parameters.Add(p4);
                    SqlParameter p5 = new SqlParameter("@ThanhTien", txtThanhTien.Text);
                    cmd.Parameters.Add(p5);
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
    }
}
