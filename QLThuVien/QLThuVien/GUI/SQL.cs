using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLThuVien.GUI
{
    public partial class SQL : Form
    {
        public SQL()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Kiem tra co dang nhap duoc khong
            try
            {
                string sHost = txtMayChu.Text.Trim();
                string sDB = txtCSDL.Text.Trim();
                string sUN = txtUN.Text.Trim();
                string sPW = txtPW.Text.Trim();

                //B1: Kiểm tra người dùng có nhập dữ liệu không?
                if (sHost == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên máy chủ");
                    ActiveControl = txtMayChu;
                    return;
                }
                if (sDB == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên cơ sở dữ liệu");
                    ActiveControl = txtCSDL;
                    return;
                }

                if (optSQL.Checked == true)
                {
                    //Nếu xác thực SQL: Buộc phải nhập 
                    if (sUN == "")
                    {
                        MessageBox.Show("Bạn chưa nhập tên đăng nhập SQL Server");
                        ActiveControl = txtUN;
                        return;
                    }
                    if (sPW == "")
                    {
                        MessageBox.Show("Bạn chưa nhập mật khẩu đăng nhập SQL Server");
                        ActiveControl = txtPW;
                        return;
                    }
                }
                //B2: Tạo chuỗi kết nối
                QLThuVien.ThamSoKetNoi.g_sDatabaseName = sDB;
                QLThuVien.ThamSoKetNoi.g_sServerName = sHost;
                QLThuVien.ThamSoKetNoi.g_bWinAuthentication = optWin.Checked;
                QLThuVien.ThamSoKetNoi.g_sUserName = sUN;
                QLThuVien.ThamSoKetNoi.g_sPassword = sPW;

                QLThuVien.ThamSoKetNoi.TaoChuoiKetNoi();    //Tạo chuỗi kết nối từ các tham số          

                //Kiểm tra xem chuỗi kết nối đúg chưa
                SqlConnection myConnect = new SqlConnection(QLThuVien.ThamSoKetNoi.g_StringConnect);
                SqlCommand myCommand = new SqlCommand();
                myCommand.CommandText = "Select * from dtUsers";
                myCommand.CommandType = CommandType.Text;
                myCommand.CommandTimeout = 30;
                myCommand.Connection = myConnect;

                myConnect.Open();
                if (myConnect.State == ConnectionState.Open)
                {
                    MessageBox.Show("Ban đã kết nối thành công");
                    this.Close();
                    this.Dispose();


                }
                else
                {
                    MessageBox.Show("không kết nối được máy chủ. Kiểm tra lại tham số");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ko đăng nhập được vào Server. Kiểm tra lại các tham số:" + ex.ToString());
                return;
            }
        }

        private void optWin_CheckedChanged(object sender, EventArgs e)
        {
            bool bIsWinAuthe = optWin.Checked;
            txtUN.Enabled = !bIsWinAuthe;
            txtPW.Enabled = !bIsWinAuthe;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            QLThuVien.ThamSoKetNoi.g_StringConnect = "";
            this.Close();
            this.Dispose();
        }
    }
}
