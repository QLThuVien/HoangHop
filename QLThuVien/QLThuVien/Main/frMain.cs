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
    public partial class frMain : Form
    {
        public frMain()
        {
            InitializeComponent();
        }

        private void nbarNhanVien_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panel1.Controls.Clear();
            QuanLyThongTin.frNhanVien fr = new QuanLyThongTin.frNhanVien();
            fr.TopLevel = false;
            panel1.Controls.Add(fr);
            fr.Show();
        }

        private void nbarMuon_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panel1.Controls.Clear();
            MuonTra.MuonTra fr = new MuonTra.MuonTra();
            fr.TopLevel = false;
            panel1.Controls.Add(fr);
            fr.Show();
        }

        private void nbarDocGia_LinkClicked_1(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panel1.Controls.Clear();
            QuanLyThongTin.frDocGia fr = new QuanLyThongTin.frDocGia();
            fr.TopLevel = false;
            panel1.Controls.Add(fr);
            fr.Show();
        }

        private void nbarTacGia_LinkClicked_1(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panel1.Controls.Clear();
            QuanLyThongTin.frTacGia fr = new QuanLyThongTin.frTacGia();
            fr.TopLevel = false;
            panel1.Controls.Add(fr);
            fr.Show();
        }

       

        private void nbarBaoCaoSach_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panel1.Controls.Clear();
            BaoCaoThongKe.frTKSach fr = new BaoCaoThongKe.frTKSach();
            fr.TopLevel = false;
            panel1.Controls.Add(fr);
            fr.Show();
        }

        private void nbarBaoCaoDocGia_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panel1.Controls.Clear();
            BaoCaoThongKe.frListDocGia fr = new BaoCaoThongKe.frListDocGia();
            fr.TopLevel = false;
            panel1.Controls.Add(fr);
            fr.Show();
        }

        private void nbarMuonTra_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panel1.Controls.Clear();
            BaoCaoThongKe.frTKCTMuonTra fr = new BaoCaoThongKe.frTKCTMuonTra();
            fr.TopLevel = false;
            panel1.Controls.Add(fr);
            fr.Show();
        }

        private void nbarNXB_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panel1.Controls.Clear();
            QuanLyThongTin.frNXB fr = new QuanLyThongTin.frNXB();
            fr.TopLevel = false;
            panel1.Controls.Add(fr);
            fr.Show();
        }

       

        private void nbarTTSach_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panel1.Controls.Clear();
            QuanLySach.frTTSach fr = new QuanLySach.frTTSach();
            fr.TopLevel = false;
            panel1.Controls.Add(fr);
            fr.Show();
        }

        private void navBarTacPham_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panel1.Controls.Clear();
            QuanLyThongTin.fraTacPham fr = new QuanLyThongTin.fraTacPham();
            fr.TopLevel = false;
            panel1.Controls.Add(fr);
            fr.Show();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panel1.Controls.Clear();
            Main.frLoadMain fr = new Main.frLoadMain();
            fr.TopLevel = false;
            panel1.Controls.Add(fr);
            fr.Show();
        }

        private void linkChuyenMeo_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Main.frChuyenconmeo fr = new Main.frChuyenconmeo();
            fr.TopLevel = false;
            panel1.Controls.Add(fr);
            fr.Show();
        }

        private void linkLuis_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Main.frTacgiatruyen.frTgConMeo fr = new Main.frTacgiatruyen.frTgConMeo();
            fr.TopLevel = false;
            panel1.Controls.Add(fr);
            fr.Show();
        }

        private void linkTatden_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Main.frTatden fr = new Main.frTatden();
            fr.TopLevel = false;
            panel1.Controls.Add(fr);
            fr.Show();
        }

        private void linkSherlock_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Main.frSherlock fr = new Main.frSherlock();
            fr.TopLevel = false;
            panel1.Controls.Add(fr);
            fr.Show();
        }

        private void linkTruyenKieu_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Main.frTruyenkieu fr = new Main.frTruyenkieu();
            fr.TopLevel = false;
            panel1.Controls.Add(fr);
            fr.Show();
        }

        private void linkDeMen_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Main.frDemen fr = new Main.frDemen();
            fr.TopLevel = false;
            panel1.Controls.Add(fr);
            fr.Show();
        }

        private void linkChipheo_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Main.frChipheo fr = new Main.frChipheo();
            fr.TopLevel = false;
            panel1.Controls.Add(fr);
            fr.Show();
        }

        private void linkNamCao_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Main.frTacgiatruyen.frNamCao fr = new Main.frTacgiatruyen.frNamCao();
            fr.TopLevel = false;
            panel1.Controls.Add(fr);
            fr.Show();
        }

        private void linkToHoai_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Main.frTacgiatruyen.frToHoai fr = new Main.frTacgiatruyen.frToHoai();
            fr.TopLevel = false;
            panel1.Controls.Add(fr);
            fr.Show();
        }

        private void linkNguyenDu_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Main.frTacgiatruyen.frNguyenDu fr = new Main.frTacgiatruyen.frNguyenDu();
            fr.TopLevel = false;
            panel1.Controls.Add(fr);
            fr.Show();
        }

        private void linkConan_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Main.frTacgiatruyen.frSherlock fr = new Main.frTacgiatruyen.frSherlock();
            fr.TopLevel = false;
            panel1.Controls.Add(fr);
            fr.Show();
        }

        private void linkNgoTT_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Main.frTacgiatruyen.frNgoTT fr = new Main.frTacgiatruyen.frNgoTT();
            fr.TopLevel = false;
            panel1.Controls.Add(fr);
            fr.Show();
        }

        private void frMain_Load(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Main.frLoadMain fr = new Main.frLoadMain();
            fr.TopLevel = false;
            panel1.Controls.Add(fr);
            fr.Show();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Search search = new Search();
            search.Show();
        }

       

        

    }
}
