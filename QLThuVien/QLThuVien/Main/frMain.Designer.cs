namespace QLThuVien
{
    partial class frMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frMain));
            DevExpress.Utils.Animation.PushTransition pushTransition1 = new DevExpress.Utils.Animation.PushTransition();
            this.panel1 = new System.Windows.Forms.Panel();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barWorkspaceMenuItem1 = new DevExpress.XtraBars.BarWorkspaceMenuItem();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbarNhanVien = new DevExpress.XtraNavBar.NavBarItem();
            this.nbarDocGia = new DevExpress.XtraNavBar.NavBarItem();
            this.nbarTacGia = new DevExpress.XtraNavBar.NavBarItem();
            this.nbarNXB = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarTacPham = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup5 = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbarTTSach = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbarMuon = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup3 = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbarBaoCaoSach = new DevExpress.XtraNavBar.NavBarItem();
            this.nbarBaoCaoDocGia = new DevExpress.XtraNavBar.NavBarItem();
            this.nbarMuonTra = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup4 = new DevExpress.XtraNavBar.NavBarGroup();
            this.workspaceManager1 = new DevExpress.Utils.WorkspaceManager();
            this.nbarSach = new DevExpress.XtraNavBar.NavBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(143, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 473);
            this.panel1.TabIndex = 4;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barWorkspaceMenuItem1,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 5;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem4)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Trang chủ";
            this.barButtonItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.Glyph")));
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Lịch đóng, mở thư viện";
            this.barButtonItem2.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.Glyph")));
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Thông tin chi tiết";
            this.barButtonItem3.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.Glyph")));
            this.barButtonItem3.Id = 3;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Tìm kiếm";
            this.barButtonItem4.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.Glyph")));
            this.barButtonItem4.Id = 4;
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(919, 69);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 498);
            this.barDockControlBottom.Size = new System.Drawing.Size(919, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 69);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 429);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(919, 69);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 429);
            // 
            // barWorkspaceMenuItem1
            // 
            this.barWorkspaceMenuItem1.Caption = "barWorkspaceMenuItem1";
            this.barWorkspaceMenuItem1.Id = 0;
            this.barWorkspaceMenuItem1.Name = "barWorkspaceMenuItem1";
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.navBarControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.navBarControl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup5,
            this.navBarGroup2,
            this.navBarGroup3,
            this.navBarGroup4});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.nbarNhanVien,
            this.nbarDocGia,
            this.nbarTacGia,
            this.nbarMuon,
            this.nbarBaoCaoSach,
            this.nbarBaoCaoDocGia,
            this.nbarMuonTra,
            this.nbarNXB,
            this.nbarTTSach,
            this.navBarTacPham});
            this.navBarControl1.Location = new System.Drawing.Point(2, 41);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 143;
            this.navBarControl1.Size = new System.Drawing.Size(143, 477);
            this.navBarControl1.TabIndex = 3;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Quản lý thông tin";
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbarNhanVien),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbarDocGia),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbarTacGia),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbarNXB),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarTacPham)});
            this.navBarGroup1.Name = "navBarGroup1";
            this.navBarGroup1.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup1.SmallImage")));
            // 
            // nbarNhanVien
            // 
            this.nbarNhanVien.Caption = "Nhân viên";
            this.nbarNhanVien.Name = "nbarNhanVien";
            this.nbarNhanVien.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbarNhanVien.SmallImage")));
            this.nbarNhanVien.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbarNhanVien_LinkClicked);
            // 
            // nbarDocGia
            // 
            this.nbarDocGia.Caption = "Độc giả";
            this.nbarDocGia.Name = "nbarDocGia";
            this.nbarDocGia.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbarDocGia.SmallImage")));
            this.nbarDocGia.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbarDocGia_LinkClicked_1);
            // 
            // nbarTacGia
            // 
            this.nbarTacGia.Caption = "Tác giả";
            this.nbarTacGia.Name = "nbarTacGia";
            this.nbarTacGia.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbarTacGia.SmallImage")));
            this.nbarTacGia.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbarTacGia_LinkClicked_1);
            // 
            // nbarNXB
            // 
            this.nbarNXB.Caption = "Nhà xuất bản";
            this.nbarNXB.Name = "nbarNXB";
            this.nbarNXB.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbarNXB.SmallImage")));
            this.nbarNXB.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbarNXB_LinkClicked);
            // 
            // navBarTacPham
            // 
            this.navBarTacPham.Caption = "Tác Phẩm";
            this.navBarTacPham.Name = "navBarTacPham";
            this.navBarTacPham.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarTacPham.SmallImage")));
            this.navBarTacPham.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarTacPham_LinkClicked);
            // 
            // navBarGroup5
            // 
            this.navBarGroup5.Caption = "Quản lý sách";
            this.navBarGroup5.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbarTTSach)});
            this.navBarGroup5.Name = "navBarGroup5";
            this.navBarGroup5.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup5.SmallImage")));
            // 
            // nbarTTSach
            // 
            this.nbarTTSach.Caption = "Thông tin sách";
            this.nbarTTSach.Name = "nbarTTSach";
            this.nbarTTSach.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbarTTSach.SmallImage")));
            this.nbarTTSach.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbarTTSach_LinkClicked);
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "Mượn, trả sách";
            this.navBarGroup2.Expanded = true;
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbarMuon)});
            this.navBarGroup2.Name = "navBarGroup2";
            this.navBarGroup2.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup2.SmallImage")));
            // 
            // nbarMuon
            // 
            this.nbarMuon.Caption = "Mượn, trả";
            this.nbarMuon.Name = "nbarMuon";
            this.nbarMuon.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbarMuon.SmallImage")));
            this.nbarMuon.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbarMuon_LinkClicked);
            // 
            // navBarGroup3
            // 
            this.navBarGroup3.Caption = "Báo cáo thống kê";
            this.navBarGroup3.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbarBaoCaoSach),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbarBaoCaoDocGia),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbarMuonTra)});
            this.navBarGroup3.Name = "navBarGroup3";
            this.navBarGroup3.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup3.SmallImage")));
            // 
            // nbarBaoCaoSach
            // 
            this.nbarBaoCaoSach.Caption = "Sách";
            this.nbarBaoCaoSach.Name = "nbarBaoCaoSach";
            this.nbarBaoCaoSach.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbarBaoCaoSach.SmallImage")));
            this.nbarBaoCaoSach.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbarBaoCaoSach_LinkClicked);
            // 
            // nbarBaoCaoDocGia
            // 
            this.nbarBaoCaoDocGia.Caption = "Độc giả";
            this.nbarBaoCaoDocGia.Name = "nbarBaoCaoDocGia";
            this.nbarBaoCaoDocGia.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbarBaoCaoDocGia.SmallImage")));
            this.nbarBaoCaoDocGia.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbarBaoCaoDocGia_LinkClicked);
            // 
            // nbarMuonTra
            // 
            this.nbarMuonTra.Caption = "Mượn, trả";
            this.nbarMuonTra.Name = "nbarMuonTra";
            this.nbarMuonTra.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbarMuonTra.SmallImage")));
            this.nbarMuonTra.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbarMuonTra_LinkClicked);
            // 
            // navBarGroup4
            // 
            this.navBarGroup4.Caption = "Thông tin liên hệ";
            this.navBarGroup4.Expanded = true;
            this.navBarGroup4.Name = "navBarGroup4";
            this.navBarGroup4.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup4.SmallImage")));
            // 
            // workspaceManager1
            // 
            this.workspaceManager1.TargetControl = this;
            this.workspaceManager1.TransitionType = pushTransition1;
            // 
            // nbarSach
            // 
            this.nbarSach.Caption = "Sách";
            this.nbarSach.Name = "nbarSach";
            this.nbarSach.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbarSach.SmallImage")));
            // 
            // frMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 521);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.navBarControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frMain";
            this.Text = "frMain";
            this.Load += new System.EventHandler(this.frMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem nbarNhanVien;
        private DevExpress.XtraNavBar.NavBarItem nbarDocGia;
        private DevExpress.XtraNavBar.NavBarItem nbarTacGia;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarItem nbarMuon;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup3;
        private DevExpress.XtraNavBar.NavBarItem nbarBaoCaoSach;
        private DevExpress.XtraNavBar.NavBarItem nbarBaoCaoDocGia;
        private DevExpress.XtraNavBar.NavBarItem nbarMuonTra;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup4;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarWorkspaceMenuItem barWorkspaceMenuItem1;
        private DevExpress.Utils.WorkspaceManager workspaceManager1;
        private DevExpress.XtraNavBar.NavBarItem nbarNXB;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup5;
        private DevExpress.XtraNavBar.NavBarItem nbarTTSach;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraNavBar.NavBarItem nbarSach;
        private DevExpress.XtraNavBar.NavBarItem navBarTacPham;
    }
}