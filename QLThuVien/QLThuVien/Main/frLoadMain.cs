using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLThuVien.Main
{
    public partial class frLoadMain : Form
    {
        public frLoadMain()
        {
            InitializeComponent();
        }

        

        private void linkChuyenMeo_Click_1(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Main.frChuyenconmeo fr = new Main.frChuyenconmeo();
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

        private void linkLuis_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Main.frTacgiatruyen.frTgConMeo fr = new Main.frTacgiatruyen.frTgConMeo();
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

        private void linkConan_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Main.frTacgiatruyen.frSherlock fr = new Main.frTacgiatruyen.frSherlock();
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

        private void linkToHoai_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Main.frTacgiatruyen.frToHoai fr = new Main.frTacgiatruyen.frToHoai();
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
    }
}
