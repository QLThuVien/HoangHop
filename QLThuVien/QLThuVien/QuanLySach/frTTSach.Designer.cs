namespace QLThuVien.QuanLySach
{
    partial class frTTSach
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode3 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode4 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frTTSach));
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dgKeSach = new DevExpress.XtraGrid.GridControl();
            this.keSachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLThuVienDataSet6 = new QLThuVien.QLThuVienDataSet6();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaKe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Tenke = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dgTheLoai = new DevExpress.XtraGrid.GridControl();
            this.theLoaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaTL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenTL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.KeSach = new DevExpress.XtraTab.XtraTabPage();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtMaKe = new System.Windows.Forms.TextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenKe = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TheLoai = new DevExpress.XtraTab.XtraTabPage();
            this.btnXoaTL = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemTL = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuuTL = new DevExpress.XtraEditors.SimpleButton();
            this.btnSuaTL = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.txtMaTL = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenTL = new System.Windows.Forms.TextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.keSachTableAdapter = new QLThuVien.QLThuVienDataSet6TableAdapters.KeSachTableAdapter();
            this.theLoaiTableAdapter = new QLThuVien.QLThuVienDataSet6TableAdapters.TheLoaiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgKeSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keSachBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLThuVienDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTheLoai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theLoaiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.KeSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.TheLoai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.dgKeSach;
            this.gridView2.Name = "gridView2";
            // 
            // dgKeSach
            // 
            this.dgKeSach.DataSource = this.keSachBindingSource;
            gridLevelNode1.LevelTemplate = this.gridView2;
            gridLevelNode1.RelationName = "Level1";
            gridLevelNode2.RelationName = "Level2";
            this.dgKeSach.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1,
            gridLevelNode2});
            this.dgKeSach.Location = new System.Drawing.Point(7, 257);
            this.dgKeSach.MainView = this.gridView1;
            this.dgKeSach.Name = "dgKeSach";
            this.dgKeSach.Size = new System.Drawing.Size(754, 147);
            this.dgKeSach.TabIndex = 62;
            this.dgKeSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
            // 
            // keSachBindingSource
            // 
            this.keSachBindingSource.DataMember = "KeSach";
            this.keSachBindingSource.DataSource = this.qLThuVienDataSet6;
            // 
            // qLThuVienDataSet6
            // 
            this.qLThuVienDataSet6.DataSetName = "QLThuVienDataSet6";
            this.qLThuVienDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.STT,
            this.MaKe,
            this.Tenke});
            this.gridView1.GridControl = this.dgKeSach;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // STT
            // 
            this.STT.Caption = "STT";
            this.STT.FieldName = "STT";
            this.STT.Name = "STT";
            this.STT.Visible = true;
            this.STT.VisibleIndex = 0;
            // 
            // MaKe
            // 
            this.MaKe.Caption = "Mã kệ sách";
            this.MaKe.FieldName = "MaKS";
            this.MaKe.Name = "MaKe";
            this.MaKe.Visible = true;
            this.MaKe.VisibleIndex = 1;
            // 
            // Tenke
            // 
            this.Tenke.Caption = "Tên kệ sách";
            this.Tenke.FieldName = "TenKe";
            this.Tenke.Name = "Tenke";
            this.Tenke.Visible = true;
            this.Tenke.VisibleIndex = 2;
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.dgTheLoai;
            this.gridView3.Name = "gridView3";
            // 
            // dgTheLoai
            // 
            this.dgTheLoai.DataSource = this.theLoaiBindingSource;
            gridLevelNode3.LevelTemplate = this.gridView3;
            gridLevelNode3.RelationName = "Level1";
            gridLevelNode4.RelationName = "Level2";
            this.dgTheLoai.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode3,
            gridLevelNode4});
            this.dgTheLoai.Location = new System.Drawing.Point(8, 260);
            this.dgTheLoai.MainView = this.gridView4;
            this.dgTheLoai.Name = "dgTheLoai";
            this.dgTheLoai.Size = new System.Drawing.Size(754, 176);
            this.dgTheLoai.TabIndex = 68;
            this.dgTheLoai.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4,
            this.gridView3});
            // 
            // theLoaiBindingSource
            // 
            this.theLoaiBindingSource.DataMember = "TheLoai";
            this.theLoaiBindingSource.DataSource = this.qLThuVienDataSet6;
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.MaTL,
            this.TenTL});
            this.gridView4.GridControl = this.dgTheLoai;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "STT";
            this.gridColumn1.FieldName = "STT";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // MaTL
            // 
            this.MaTL.Caption = "Mã thể loại";
            this.MaTL.FieldName = "MaTL";
            this.MaTL.Name = "MaTL";
            this.MaTL.Visible = true;
            this.MaTL.VisibleIndex = 1;
            // 
            // TenTL
            // 
            this.TenTL.Caption = "Tên thể loại";
            this.TenTL.FieldName = "TenTL";
            this.TenTL.Name = "TenTL";
            this.TenTL.Visible = true;
            this.TenTL.VisibleIndex = 2;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.xtraTabControl1.Appearance.Options.UseBackColor = true;
            this.xtraTabControl1.Location = new System.Drawing.Point(2, 2);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.KeSach;
            this.xtraTabControl1.Size = new System.Drawing.Size(775, 470);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.KeSach,
            this.TheLoai});
            // 
            // KeSach
            // 
            this.KeSach.Controls.Add(this.dgKeSach);
            this.KeSach.Controls.Add(this.btnXoa);
            this.KeSach.Controls.Add(this.btnThem);
            this.KeSach.Controls.Add(this.btnLuu);
            this.KeSach.Controls.Add(this.btnSua);
            this.KeSach.Controls.Add(this.panelControl1);
            this.KeSach.Image = ((System.Drawing.Image)(resources.GetObject("KeSach.Image")));
            this.KeSach.Name = "KeSach";
            this.KeSach.Size = new System.Drawing.Size(769, 423);
            this.KeSach.Text = "Kệ sách";
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(597, 208);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(98, 33);
            this.btnXoa.TabIndex = 61;
            this.btnXoa.Text = "Xóa kệ";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(241, 208);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(111, 33);
            this.btnThem.TabIndex = 60;
            this.btnThem.Text = "Thêm kệ";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.Location = new System.Drawing.Point(410, 208);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(120, 33);
            this.btnLuu.TabIndex = 59;
            this.btnLuu.Text = "Lưu kệ";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(50, 208);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(136, 33);
            this.btnSua.TabIndex = 58;
            this.btnSua.Text = "Cập nhật thông tin";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.txtMaKe);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.txtTenKe);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Location = new System.Drawing.Point(8, 3);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(753, 186);
            this.panelControl1.TabIndex = 57;
            // 
            // txtMaKe
            // 
            this.txtMaKe.Location = new System.Drawing.Point(152, 36);
            this.txtMaKe.Multiline = true;
            this.txtMaKe.Name = "txtMaKe";
            this.txtMaKe.Size = new System.Drawing.Size(159, 32);
            this.txtMaKe.TabIndex = 100;
            // 
            // labelControl3
            // 
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.LineVisible = true;
            this.labelControl3.Location = new System.Drawing.Point(43, 36);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(103, 32);
            this.labelControl3.TabIndex = 99;
            this.labelControl3.Text = "Mã kệ";
            // 
            // txtTenKe
            // 
            this.txtTenKe.Location = new System.Drawing.Point(540, 36);
            this.txtTenKe.Multiline = true;
            this.txtTenKe.Name = "txtTenKe";
            this.txtTenKe.Size = new System.Drawing.Size(159, 32);
            this.txtTenKe.TabIndex = 26;
            // 
            // labelControl2
            // 
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.LineVisible = true;
            this.labelControl2.Location = new System.Drawing.Point(431, 36);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(103, 32);
            this.labelControl2.TabIndex = 25;
            this.labelControl2.Text = "Tên kệ";
            // 
            // TheLoai
            // 
            this.TheLoai.Controls.Add(this.dgTheLoai);
            this.TheLoai.Controls.Add(this.btnXoaTL);
            this.TheLoai.Controls.Add(this.btnThemTL);
            this.TheLoai.Controls.Add(this.btnLuuTL);
            this.TheLoai.Controls.Add(this.btnSuaTL);
            this.TheLoai.Controls.Add(this.panelControl2);
            this.TheLoai.Image = ((System.Drawing.Image)(resources.GetObject("TheLoai.Image")));
            this.TheLoai.Name = "TheLoai";
            this.TheLoai.Size = new System.Drawing.Size(769, 423);
            this.TheLoai.Text = "Thể loại";
            // 
            // btnXoaTL
            // 
            this.btnXoaTL.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaTL.Image")));
            this.btnXoaTL.Location = new System.Drawing.Point(597, 211);
            this.btnXoaTL.Name = "btnXoaTL";
            this.btnXoaTL.Size = new System.Drawing.Size(110, 33);
            this.btnXoaTL.TabIndex = 67;
            this.btnXoaTL.Text = "Xóa thể loại";
            this.btnXoaTL.Click += new System.EventHandler(this.btnXoaTL_Click);
            // 
            // btnThemTL
            // 
            this.btnThemTL.Image = ((System.Drawing.Image)(resources.GetObject("btnThemTL.Image")));
            this.btnThemTL.Location = new System.Drawing.Point(241, 211);
            this.btnThemTL.Name = "btnThemTL";
            this.btnThemTL.Size = new System.Drawing.Size(111, 33);
            this.btnThemTL.TabIndex = 66;
            this.btnThemTL.Text = "Thêm thể loại";
            this.btnThemTL.Click += new System.EventHandler(this.btnThemTL_Click);
            // 
            // btnLuuTL
            // 
            this.btnLuuTL.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuTL.Image")));
            this.btnLuuTL.Location = new System.Drawing.Point(410, 211);
            this.btnLuuTL.Name = "btnLuuTL";
            this.btnLuuTL.Size = new System.Drawing.Size(120, 33);
            this.btnLuuTL.TabIndex = 65;
            this.btnLuuTL.Text = "Lưu thể loại";
            this.btnLuuTL.Click += new System.EventHandler(this.btnLuuTL_Click);
            // 
            // btnSuaTL
            // 
            this.btnSuaTL.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaTL.Image")));
            this.btnSuaTL.Location = new System.Drawing.Point(50, 211);
            this.btnSuaTL.Name = "btnSuaTL";
            this.btnSuaTL.Size = new System.Drawing.Size(136, 33);
            this.btnSuaTL.TabIndex = 64;
            this.btnSuaTL.Text = "Cập nhật thông tin";
            this.btnSuaTL.Click += new System.EventHandler(this.btnSuaTL_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.txtMaTL);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this.txtTenTL);
            this.panelControl2.Controls.Add(this.labelControl4);
            this.panelControl2.Location = new System.Drawing.Point(8, 3);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(753, 189);
            this.panelControl2.TabIndex = 63;
            // 
            // txtMaTL
            // 
            this.txtMaTL.Location = new System.Drawing.Point(152, 43);
            this.txtMaTL.Multiline = true;
            this.txtMaTL.Name = "txtMaTL";
            this.txtMaTL.Size = new System.Drawing.Size(159, 32);
            this.txtMaTL.TabIndex = 100;
            // 
            // labelControl1
            // 
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.LineVisible = true;
            this.labelControl1.Location = new System.Drawing.Point(43, 43);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(103, 32);
            this.labelControl1.TabIndex = 99;
            this.labelControl1.Text = "Mã thể loại";
            // 
            // txtTenTL
            // 
            this.txtTenTL.Location = new System.Drawing.Point(540, 43);
            this.txtTenTL.Multiline = true;
            this.txtTenTL.Name = "txtTenTL";
            this.txtTenTL.Size = new System.Drawing.Size(159, 32);
            this.txtTenTL.TabIndex = 26;
            // 
            // labelControl4
            // 
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.LineVisible = true;
            this.labelControl4.Location = new System.Drawing.Point(431, 43);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(103, 32);
            this.labelControl4.TabIndex = 25;
            this.labelControl4.Text = "Tên thể loại";
            // 
            // keSachTableAdapter
            // 
            this.keSachTableAdapter.ClearBeforeFill = true;
            // 
            // theLoaiTableAdapter
            // 
            this.theLoaiTableAdapter.ClearBeforeFill = true;
            // 
            // frTTSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 473);
            this.Controls.Add(this.xtraTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frTTSach";
            this.Text = "frTTSach";
            this.Load += new System.EventHandler(this.frTTSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgKeSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keSachBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLThuVienDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTheLoai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theLoaiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.KeSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.TheLoai.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage KeSach;
        private DevExpress.XtraTab.XtraTabPage TheLoai;
        private DevExpress.XtraGrid.GridControl dgKeSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraGrid.Columns.GridColumn MaKe;
        private DevExpress.XtraGrid.Columns.GridColumn Tenke;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.TextBox txtMaKe;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.TextBox txtTenKe;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.GridControl dgTheLoai;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.SimpleButton btnXoaTL;
        private DevExpress.XtraEditors.SimpleButton btnThemTL;
        private DevExpress.XtraEditors.SimpleButton btnLuuTL;
        private DevExpress.XtraEditors.SimpleButton btnSuaTL;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.TextBox txtMaTL;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox txtTenTL;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.Columns.GridColumn MaTL;
        private DevExpress.XtraGrid.Columns.GridColumn TenTL;
        private QLThuVienDataSet6 qLThuVienDataSet6;
        private System.Windows.Forms.BindingSource keSachBindingSource;
        private QLThuVienDataSet6TableAdapters.KeSachTableAdapter keSachTableAdapter;
        private System.Windows.Forms.BindingSource theLoaiBindingSource;
        private QLThuVienDataSet6TableAdapters.TheLoaiTableAdapter theLoaiTableAdapter;
    }
}