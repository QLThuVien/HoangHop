namespace QLThuVien.QuanLyThongTin
{
    partial class fraTacPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fraTacPham));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtTenTP = new System.Windows.Forms.TextBox();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.cbMaTL = new System.Windows.Forms.ComboBox();
            this.cbMaTG = new System.Windows.Forms.ComboBox();
            this.cbMaKS = new System.Windows.Forms.ComboBox();
            this.cbMaNXB = new System.Windows.Forms.ComboBox();
            this.dateNamXB = new DevExpress.XtraEditors.DateEdit();
            this.dateNgayDK = new DevExpress.XtraEditors.DateEdit();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtGiaTien = new System.Windows.Forms.TextBox();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtMasach = new System.Windows.Forms.TextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.colMaNXB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayDangKy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNamXB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiaSach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaTL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaTG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaKS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenSach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dgTacPham = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaTP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.qLThuVienDataSetNew = new QLThuVien.QLThuVienDataSetNew();
            this.tacPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tacPhamTableAdapter = new QLThuVien.QLThuVienDataSetNewTableAdapters.TacPhamTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateNamXB.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNamXB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayDK.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayDK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTacPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLThuVienDataSetNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacPhamBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtTenTP);
            this.panelControl1.Controls.Add(this.labelControl11);
            this.panelControl1.Controls.Add(this.cbMaTL);
            this.panelControl1.Controls.Add(this.cbMaTG);
            this.panelControl1.Controls.Add(this.cbMaKS);
            this.panelControl1.Controls.Add(this.cbMaNXB);
            this.panelControl1.Controls.Add(this.dateNamXB);
            this.panelControl1.Controls.Add(this.dateNgayDK);
            this.panelControl1.Controls.Add(this.txtSoLuong);
            this.panelControl1.Controls.Add(this.labelControl10);
            this.panelControl1.Controls.Add(this.txtGiaTien);
            this.panelControl1.Controls.Add(this.labelControl9);
            this.panelControl1.Controls.Add(this.labelControl8);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.labelControl7);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.txtMasach);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Location = new System.Drawing.Point(13, 11);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(753, 278);
            this.panelControl1.TabIndex = 117;
            // 
            // txtTenTP
            // 
            this.txtTenTP.Location = new System.Drawing.Point(133, 58);
            this.txtTenTP.Multiline = true;
            this.txtTenTP.Name = "txtTenTP";
            this.txtTenTP.Size = new System.Drawing.Size(159, 32);
            this.txtTenTP.TabIndex = 103;
            // 
            // labelControl11
            // 
            this.labelControl11.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl11.LineVisible = true;
            this.labelControl11.Location = new System.Drawing.Point(24, 58);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(103, 32);
            this.labelControl11.TabIndex = 102;
            this.labelControl11.Text = "Tên TP";
            // 
            // cbMaTL
            // 
            this.cbMaTL.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbMaTL.FormattingEnabled = true;
            this.cbMaTL.Location = new System.Drawing.Point(543, 64);
            this.cbMaTL.Name = "cbMaTL";
            this.cbMaTL.Size = new System.Drawing.Size(159, 21);
            this.cbMaTL.TabIndex = 101;
            this.cbMaTL.SelectedIndexChanged += new System.EventHandler(this.cbMaTL_SelectedIndexChanged);
            // 
            // cbMaTG
            // 
            this.cbMaTG.FormattingEnabled = true;
            this.cbMaTG.Location = new System.Drawing.Point(543, 11);
            this.cbMaTG.Name = "cbMaTG";
            this.cbMaTG.Size = new System.Drawing.Size(159, 21);
            this.cbMaTG.TabIndex = 100;
            // 
            // cbMaKS
            // 
            this.cbMaKS.FormattingEnabled = true;
            this.cbMaKS.Location = new System.Drawing.Point(133, 172);
            this.cbMaKS.Name = "cbMaKS";
            this.cbMaKS.Size = new System.Drawing.Size(159, 21);
            this.cbMaKS.TabIndex = 99;
            // 
            // cbMaNXB
            // 
            this.cbMaNXB.FormattingEnabled = true;
            this.cbMaNXB.Location = new System.Drawing.Point(133, 117);
            this.cbMaNXB.Name = "cbMaNXB";
            this.cbMaNXB.Size = new System.Drawing.Size(159, 21);
            this.cbMaNXB.TabIndex = 98;
            // 
            // dateNamXB
            // 
            this.dateNamXB.EditValue = null;
            this.dateNamXB.Location = new System.Drawing.Point(543, 117);
            this.dateNamXB.Name = "dateNamXB";
            this.dateNamXB.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNamXB.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNamXB.Size = new System.Drawing.Size(159, 20);
            this.dateNamXB.TabIndex = 93;
            // 
            // dateNgayDK
            // 
            this.dateNgayDK.EditValue = null;
            this.dateNgayDK.Location = new System.Drawing.Point(133, 238);
            this.dateNgayDK.Name = "dateNgayDK";
            this.dateNgayDK.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayDK.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayDK.Size = new System.Drawing.Size(159, 20);
            this.dateNgayDK.TabIndex = 92;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(543, 226);
            this.txtSoLuong.Multiline = true;
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(159, 32);
            this.txtSoLuong.TabIndex = 90;
            // 
            // labelControl10
            // 
            this.labelControl10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl10.LineVisible = true;
            this.labelControl10.Location = new System.Drawing.Point(434, 226);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(103, 32);
            this.labelControl10.TabIndex = 89;
            this.labelControl10.Text = "Số lượng";
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.Location = new System.Drawing.Point(543, 172);
            this.txtGiaTien.Multiline = true;
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.Size = new System.Drawing.Size(159, 32);
            this.txtGiaTien.TabIndex = 88;
            // 
            // labelControl9
            // 
            this.labelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl9.LineVisible = true;
            this.labelControl9.Location = new System.Drawing.Point(434, 172);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(103, 32);
            this.labelControl9.TabIndex = 87;
            this.labelControl9.Text = "Giá tiền";
            // 
            // labelControl8
            // 
            this.labelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl8.LineVisible = true;
            this.labelControl8.Location = new System.Drawing.Point(434, 111);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(103, 32);
            this.labelControl8.TabIndex = 86;
            this.labelControl8.Text = "Năm XB";
            // 
            // labelControl6
            // 
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.LineVisible = true;
            this.labelControl6.Location = new System.Drawing.Point(24, 172);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(103, 32);
            this.labelControl6.TabIndex = 83;
            this.labelControl6.Text = "Mã kệ sách";
            // 
            // labelControl7
            // 
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl7.LineVisible = true;
            this.labelControl7.Location = new System.Drawing.Point(24, 111);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(103, 32);
            this.labelControl7.TabIndex = 81;
            this.labelControl7.Text = "Mã NXB";
            // 
            // labelControl4
            // 
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.LineVisible = true;
            this.labelControl4.Location = new System.Drawing.Point(434, 58);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(103, 32);
            this.labelControl4.TabIndex = 79;
            this.labelControl4.Text = "Mã Thể loại";
            // 
            // labelControl2
            // 
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.LineVisible = true;
            this.labelControl2.Location = new System.Drawing.Point(434, 5);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(103, 32);
            this.labelControl2.TabIndex = 77;
            this.labelControl2.Text = "Mã tác giả";
            // 
            // labelControl5
            // 
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.LineVisible = true;
            this.labelControl5.Location = new System.Drawing.Point(22, 232);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(103, 32);
            this.labelControl5.TabIndex = 73;
            this.labelControl5.Text = "Ngày đăng ký";
            // 
            // txtMasach
            // 
            this.txtMasach.Location = new System.Drawing.Point(133, 5);
            this.txtMasach.Multiline = true;
            this.txtMasach.Name = "txtMasach";
            this.txtMasach.Size = new System.Drawing.Size(159, 32);
            this.txtMasach.TabIndex = 72;
            // 
            // labelControl3
            // 
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.LineVisible = true;
            this.labelControl3.Location = new System.Drawing.Point(24, 5);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(103, 32);
            this.labelControl3.TabIndex = 71;
            this.labelControl3.Text = "Mã TP";
            // 
            // colMaNXB
            // 
            this.colMaNXB.FieldName = "MaNXB";
            this.colMaNXB.Name = "colMaNXB";
            this.colMaNXB.Visible = true;
            this.colMaNXB.VisibleIndex = 6;
            // 
            // colNgayDangKy
            // 
            this.colNgayDangKy.FieldName = "NgayDangKy";
            this.colNgayDangKy.Name = "colNgayDangKy";
            this.colNgayDangKy.Visible = true;
            this.colNgayDangKy.VisibleIndex = 5;
            // 
            // colNamXB
            // 
            this.colNamXB.FieldName = "NamXB";
            this.colNamXB.Name = "colNamXB";
            this.colNamXB.Visible = true;
            this.colNamXB.VisibleIndex = 7;
            // 
            // colGiaSach
            // 
            this.colGiaSach.FieldName = "GiaSach";
            this.colGiaSach.Name = "colGiaSach";
            this.colGiaSach.Visible = true;
            this.colGiaSach.VisibleIndex = 8;
            // 
            // colMaTL
            // 
            this.colMaTL.FieldName = "MaTL";
            this.colMaTL.Name = "colMaTL";
            this.colMaTL.Visible = true;
            this.colMaTL.VisibleIndex = 4;
            // 
            // colMaTG
            // 
            this.colMaTG.FieldName = "MaTG";
            this.colMaTG.Name = "colMaTG";
            this.colMaTG.Visible = true;
            this.colMaTG.VisibleIndex = 3;
            // 
            // colMaKS
            // 
            this.colMaKS.FieldName = "MaKS";
            this.colMaKS.Name = "colMaKS";
            this.colMaKS.Visible = true;
            this.colMaKS.VisibleIndex = 9;
            // 
            // colSoLuong
            // 
            this.colSoLuong.FieldName = "SoLuong";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.Visible = true;
            this.colSoLuong.VisibleIndex = 10;
            // 
            // STT
            // 
            this.STT.Caption = "STT";
            this.STT.FieldName = "STT";
            this.STT.Name = "STT";
            this.STT.Visible = true;
            this.STT.VisibleIndex = 0;
            // 
            // colTenSach
            // 
            this.colTenSach.FieldName = "TenSach";
            this.colTenSach.Name = "colTenSach";
            this.colTenSach.Visible = true;
            this.colTenSach.VisibleIndex = 2;
            // 
            // dgTacPham
            // 
            this.dgTacPham.DataSource = this.tacPhamBindingSource;
            this.dgTacPham.Location = new System.Drawing.Point(12, 334);
            this.dgTacPham.MainView = this.gridView1;
            this.dgTacPham.Name = "dgTacPham";
            this.dgTacPham.Size = new System.Drawing.Size(754, 128);
            this.dgTacPham.TabIndex = 122;
            this.dgTacPham.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaTP,
            this.colTenSach,
            this.colMaTG,
            this.colMaTL,
            this.colNgayDangKy,
            this.colMaNXB,
            this.colNamXB,
            this.colGiaSach,
            this.colMaKS,
            this.colSoLuong,
            this.STT});
            this.gridView1.GridControl = this.dgTacPham;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.STT, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colMaTP
            // 
            this.colMaTP.FieldName = "MaTP";
            this.colMaTP.Name = "colMaTP";
            this.colMaTP.Visible = true;
            this.colMaTP.VisibleIndex = 1;
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(236, 295);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(122, 33);
            this.btnThem.TabIndex = 120;
            this.btnThem.Text = "Thêm tác phẩm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.Location = new System.Drawing.Point(417, 295);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(113, 33);
            this.btnLuu.TabIndex = 119;
            this.btnLuu.Text = "Lưu tác phẩm";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(604, 295);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(111, 33);
            this.btnXoa.TabIndex = 121;
            this.btnXoa.Text = "Xóa tác phẩm";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(49, 295);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(138, 33);
            this.btnSua.TabIndex = 118;
            this.btnSua.Text = "Cập nhật thông tin";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // qLThuVienDataSetNew
            // 
            this.qLThuVienDataSetNew.DataSetName = "QLThuVienDataSetNew";
            this.qLThuVienDataSetNew.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tacPhamBindingSource
            // 
            this.tacPhamBindingSource.DataMember = "TacPham";
            this.tacPhamBindingSource.DataSource = this.qLThuVienDataSetNew;
            // 
            // tacPhamTableAdapter
            // 
            this.tacPhamTableAdapter.ClearBeforeFill = true;
            // 
            // fraTacPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 473);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.dgTacPham);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fraTacPham";
            this.Text = "fraTacPham";
            this.Load += new System.EventHandler(this.fraTacPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateNamXB.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNamXB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayDK.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayDK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTacPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLThuVienDataSetNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacPhamBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cbMaTL;
        private System.Windows.Forms.ComboBox cbMaTG;
        private System.Windows.Forms.ComboBox cbMaKS;
        private System.Windows.Forms.ComboBox cbMaNXB;
        private DevExpress.XtraEditors.DateEdit dateNamXB;
        private DevExpress.XtraEditors.DateEdit dateNgayDK;
        private System.Windows.Forms.TextBox txtSoLuong;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private System.Windows.Forms.TextBox txtGiaTien;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.TextBox txtMasach;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNXB;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayDangKy;
        private DevExpress.XtraGrid.Columns.GridColumn colNamXB;
        private DevExpress.XtraGrid.Columns.GridColumn colGiaSach;
        private DevExpress.XtraGrid.Columns.GridColumn colMaTL;
        private DevExpress.XtraGrid.Columns.GridColumn colMaTG;
        private DevExpress.XtraGrid.Columns.GridColumn colMaKS;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraGrid.Columns.GridColumn colTenSach;
        private DevExpress.XtraGrid.GridControl dgTacPham;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaTP;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private System.Windows.Forms.TextBox txtTenTP;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private QLThuVienDataSetNew qLThuVienDataSetNew;
        private System.Windows.Forms.BindingSource tacPhamBindingSource;
        private QLThuVienDataSetNewTableAdapters.TacPhamTableAdapter tacPhamTableAdapter;
    }
}