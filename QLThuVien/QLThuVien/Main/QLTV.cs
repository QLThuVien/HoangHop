using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLThuVien
{
    public partial class QLTV : Form
    {
        public int i = 10;
        public QLTV()
        {
            InitializeComponent();
        }


        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=Test;Integrated Security=True");
            try
            {
                connect.Open();
                string tk = txtDangNhap.Text.Trim();
                string mk = txtPass.Text.Trim();
                string sql = "Select * from dtUsers where (User_Name = N'" + tk + "')"
                                            + "And (passWord = '" + mk + "')";
                SqlCommand sqlcm = new SqlCommand(sql, connect);
                SqlDataReader dt = sqlcm.ExecuteReader();
                if (dt.Read() == true)
                {
                    panelFrame.Controls.Clear();
                    frMain fr = new frMain();
                    fr.TopLevel = false;
                    panelFrame.Controls.Add(fr);
                    fr.Show();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đăng nhập!");
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelControl1.Left += i;
            if (labelControl1.Left >= this.Width - labelControl1.Width || labelControl1.Left<=0)
                i=-i;
        
        }


        }

        
    
}
