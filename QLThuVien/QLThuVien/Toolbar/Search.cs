using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLThuVien
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void Search_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLThuVienDataSetNew.DocGia' table. You can move, or remove it, as needed.
            this.docGiaTableAdapter.Fill(this.qLThuVienDataSetNew.DocGia);
            // TODO: This line of code loads data into the 'qLThuVienDataSetNew.TacPham' table. You can move, or remove it, as needed.
            this.tacPhamTableAdapter.Fill(this.qLThuVienDataSetNew.TacPham);
            // TODO: This line of code loads data into the 'qLThuVienDataSetNew.TacGia' table. You can move, or remove it, as needed.
            this.tacGiaTableAdapter1.Fill(this.qLThuVienDataSetNew.TacGia);
            // TODO: This line of code loads data into the 'qLThuVienDataSetNew.Sach' table. You can move, or remove it, as needed.
            this.sachTableAdapter.Fill(this.qLThuVienDataSetNew.Sach);
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
