namespace QLThuVien.MuonTra
{
    partial class MuonTra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MuonTra));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cbMaNV = new System.Windows.Forms.ComboBox();
            this.cbMaDG = new System.Windows.Forms.ComboBox();
            this.dateMuon = new DevExpress.XtraEditors.DateEdit();
            this.dateHT = new DevExpress.XtraEditors.DateEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtPhieuMuon = new System.Windows.Forms.TextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.dgMuonTra = new DevExpress.XtraGrid.GridControl();
            this.muonTraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLThuVienDataSet7 = new QLThuVien.QLThuVienDataSet7();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.muonTraTableAdapter = new QLThuVien.QLThuVienDataSet7TableAdapters.MuonTraTableAdapter();
            this.btnCTMT = new DevExpress.XtraEditors.SimpleButton();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemHyperLinkEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateMuon.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateMuon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateHT.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateHT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMuonTra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.muonTraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLThuVienDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cbMaNV);
            this.panelControl1.Controls.Add(this.cbMaDG);
            this.panelControl1.Controls.Add(this.dateMuon);
            this.panelControl1.Controls.Add(this.dateHT);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.txtPhieuMuon);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Location = new System.Drawing.Point(13, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(753, 266);
            this.panelControl1.TabIndex = 0;
            // 
            // cbMaNV
            // 
            this.cbMaNV.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbMaNV.FormattingEnabled = true;
            this.cbMaNV.Location = new System.Drawing.Point(566, 26);
            this.cbMaNV.Name = "cbMaNV";
            this.cbMaNV.Size = new System.Drawing.Size(159, 21);
            this.cbMaNV.TabIndex = 104;
            // 
            // cbMaDG
            // 
            this.cbMaDG.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbMaDG.FormattingEnabled = true;
            this.cbMaDG.Location = new System.Drawing.Point(174, 26);
            this.cbMaDG.Name = "cbMaDG";
            this.cbMaDG.Size = new System.Drawing.Size(159, 21);
            this.cbMaDG.TabIndex = 103;
            // 
            // dateMuon
            // 
            this.dateMuon.EditValue = null;
            this.dateMuon.Location = new System.Drawing.Point(174, 223);
            this.dateMuon.Name = "dateMuon";
            this.dateMuon.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateMuon.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateMuon.Size = new System.Drawing.Size(244, 20);
            this.dateMuon.TabIndex = 94;
            // 
            // dateHT
            // 
            this.dateHT.EditValue = null;
            this.dateHT.Location = new System.Drawing.Point(174, 162);
            this.dateHT.Name = "dateHT";
            this.dateHT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateHT.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateHT.Size = new System.Drawing.Size(244, 20);
            this.dateHT.TabIndex = 93;
            // 
            // labelControl5
            // 
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.LineVisible = true;
            this.labelControl5.Location = new System.Drawing.Point(29, 156);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(103, 32);
            this.labelControl5.TabIndex = 37;
            this.labelControl5.Text = "Ngày hẹn trả";
            // 
            // labelControl4
            // 
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.LineVisible = true;
            this.labelControl4.Location = new System.Drawing.Point(29, 217);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(103, 32);
            this.labelControl4.TabIndex = 33;
            this.labelControl4.Text = "Ngày mượn";
            // 
            // labelControl6
            // 
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.LineVisible = true;
            this.labelControl6.Location = new System.Drawing.Point(427, 21);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(123, 32);
            this.labelControl6.TabIndex = 31;
            this.labelControl6.Text = "Mã nhân viên giao dịch";
            // 
            // txtPhieuMuon
            // 
            this.txtPhieuMuon.Location = new System.Drawing.Point(174, 88);
            this.txtPhieuMuon.Multiline = true;
            this.txtPhieuMuon.Name = "txtPhieuMuon";
            this.txtPhieuMuon.Size = new System.Drawing.Size(244, 32);
            this.txtPhieuMuon.TabIndex = 22;
            // 
            // labelControl3
            // 
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.LineVisible = true;
            this.labelControl3.Location = new System.Drawing.Point(29, 88);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(103, 32);
            this.labelControl3.TabIndex = 21;
            this.labelControl3.Text = "Mã phiếu mượn";
            // 
            // labelControl2
            // 
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.LineVisible = true;
            this.labelControl2.Location = new System.Drawing.Point(29, 21);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(103, 32);
            this.labelControl2.TabIndex = 17;
            this.labelControl2.Text = "Mã độc giả";
            // 
            // btnSua
            // 
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(13, 296);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(144, 33);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Cập nhật thông tin";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.Location = new System.Drawing.Point(325, 296);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(137, 33);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu phiếu mượn";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(174, 296);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(136, 33);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm phiếu mượn";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(482, 296);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(132, 33);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa phiếu mượn";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dgMuonTra
            // 
            this.dgMuonTra.DataSource = this.muonTraBindingSource;
            this.dgMuonTra.Location = new System.Drawing.Point(12, 345);
            this.dgMuonTra.MainView = this.gridView1;
            this.dgMuonTra.Name = "dgMuonTra";
            this.dgMuonTra.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemHyperLinkEdit1});
            this.dgMuonTra.Size = new System.Drawing.Size(754, 120);
            this.dgMuonTra.TabIndex = 5;
            this.dgMuonTra.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // muonTraBindingSource
            // 
            this.muonTraBindingSource.DataMember = "MuonTra";
            this.muonTraBindingSource.DataSource = this.qLThuVienDataSet7;
            // 
            // qLThuVienDataSet7
            // 
            this.qLThuVienDataSet7.DataSetName = "QLThuVienDataSet7";
            this.qLThuVienDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn4,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7});
            this.gridView1.GridControl = this.dgMuonTra;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "STT";
            this.gridColumn1.FieldName = "STT";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Mã phiếu mượn";
            this.gridColumn4.FieldName = "MaPM";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Mã độc giả";
            this.gridColumn2.FieldName = "MaDG";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Mã nhân viên giao dịch";
            this.gridColumn3.FieldName = "MaNV_GD";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Ngày hẹn trả";
            this.gridColumn5.FieldName = "HenTra";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Ngày mượn";
            this.gridColumn6.FieldName = "NgayMuon";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // muonTraTableAdapter
            // 
            this.muonTraTableAdapter.ClearBeforeFill = true;
            // 
            // btnCTMT
            // 
            this.btnCTMT.Image = ((System.Drawing.Image)(resources.GetObject("btnCTMT.Image")));
            this.btnCTMT.Location = new System.Drawing.Point(620, 296);
            this.btnCTMT.Name = "btnCTMT";
            this.btnCTMT.Size = new System.Drawing.Size(132, 33);
            this.btnCTMT.TabIndex = 6;
            this.btnCTMT.Text = "Chi tiết MT";
            this.btnCTMT.Click += new System.EventHandler(this.btnCTMT_Click);
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Chi tiết mượn trả";
            this.gridColumn7.ColumnEdit = this.repositoryItemHyperLinkEdit1;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            // 
            // repositoryItemHyperLinkEdit1
            // 
            this.repositoryItemHyperLinkEdit1.AutoHeight = false;
            this.repositoryItemHyperLinkEdit1.Name = "repositoryItemHyperLinkEdit1";
            // 
            // MuonTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 473);
            this.Controls.Add(this.btnCTMT);
            this.Controls.Add(this.dgMuonTra);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MuonTra";
            this.Text = "ChiTietMuonTra";
            this.Load += new System.EventHandler(this.ChiTietMuonTra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateMuon.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateMuon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateHT.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateHT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMuonTra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.muonTraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLThuVienDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.TextBox txtPhieuMuon;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraGrid.GridControl dgMuonTra;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.DateEdit dateMuon;
        private DevExpress.XtraEditors.DateEdit dateHT;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private System.Windows.Forms.ComboBox cbMaNV;
        private System.Windows.Forms.ComboBox cbMaDG;
        private QLThuVienDataSet7 qLThuVienDataSet7;
        private System.Windows.Forms.BindingSource muonTraBindingSource;
        private QLThuVienDataSet7TableAdapters.MuonTraTableAdapter muonTraTableAdapter;
        private DevExpress.XtraEditors.SimpleButton btnCTMT;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit1;
    }
}