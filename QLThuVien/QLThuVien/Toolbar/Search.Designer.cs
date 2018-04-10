namespace QLThuVien
{
    partial class Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.searchLookUpEdit1 = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.searchLookUpEdit2 = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.searchLookUpEdit3 = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.searchLookUpEdit4 = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.searchLookUpEdit5 = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tacGiaTableAdapter = new QLThuVien.QLThuVienDataSet7TableAdapters.TacGiaTableAdapter();
            this.nhanVienTableAdapter = new QLThuVien.QLThuVienDataSet7TableAdapters.NhanVienTableAdapter();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.qLThuVienDataSetNew = new QLThuVien.QLThuVienDataSetNew();
            this.sachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sachTableAdapter = new QLThuVien.QLThuVienDataSetNewTableAdapters.SachTableAdapter();
            this.tacGiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tacGiaTableAdapter1 = new QLThuVien.QLThuVienDataSetNewTableAdapters.TacGiaTableAdapter();
            this.tacPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tacPhamTableAdapter = new QLThuVien.QLThuVienDataSetNewTableAdapters.TacPhamTableAdapter();
            this.docGiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.docGiaTableAdapter = new QLThuVien.QLThuVienDataSetNewTableAdapters.DocGiaTableAdapter();
            this.docGiaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLThuVienDataSetNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sachBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacGiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacPhamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docGiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docGiaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(32, 29);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(130, 29);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tìm kiếm sách";
            // 
            // searchLookUpEdit1
            // 
            this.searchLookUpEdit1.EditValue = "Sách";
            this.searchLookUpEdit1.Location = new System.Drawing.Point(288, 35);
            this.searchLookUpEdit1.Name = "searchLookUpEdit1";
            this.searchLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpEdit1.Properties.DataSource = this.sachBindingSource;
            this.searchLookUpEdit1.Properties.View = this.searchLookUpEdit1View;
            this.searchLookUpEdit1.Size = new System.Drawing.Size(108, 20);
            this.searchLookUpEdit1.TabIndex = 5;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // searchLookUpEdit2
            // 
            this.searchLookUpEdit2.EditValue = "";
            this.searchLookUpEdit2.Location = new System.Drawing.Point(291, 89);
            this.searchLookUpEdit2.Name = "searchLookUpEdit2";
            this.searchLookUpEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpEdit2.Properties.DataSource = this.tacGiaBindingSource;
            this.searchLookUpEdit2.Properties.View = this.gridView1;
            this.searchLookUpEdit2.Size = new System.Drawing.Size(105, 20);
            this.searchLookUpEdit2.TabIndex = 6;
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(32, 83);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(148, 29);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Tìm kiếm tác giả";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(32, 145);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(167, 29);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "Tìm kiếm tác phẩm";
            // 
            // searchLookUpEdit3
            // 
            this.searchLookUpEdit3.EditValue = "";
            this.searchLookUpEdit3.Location = new System.Drawing.Point(291, 151);
            this.searchLookUpEdit3.Name = "searchLookUpEdit3";
            this.searchLookUpEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpEdit3.Properties.DataSource = this.tacPhamBindingSource;
            this.searchLookUpEdit3.Properties.View = this.gridView2;
            this.searchLookUpEdit3.Size = new System.Drawing.Size(105, 20);
            this.searchLookUpEdit3.TabIndex = 8;
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.Location = new System.Drawing.Point(32, 204);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(167, 29);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "Tìm kiếm độc giả";
            // 
            // searchLookUpEdit4
            // 
            this.searchLookUpEdit4.EditValue = "";
            this.searchLookUpEdit4.Location = new System.Drawing.Point(291, 210);
            this.searchLookUpEdit4.Name = "searchLookUpEdit4";
            this.searchLookUpEdit4.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpEdit4.Properties.DataSource = this.docGiaBindingSource;
            this.searchLookUpEdit4.Properties.View = this.gridView3;
            this.searchLookUpEdit4.Size = new System.Drawing.Size(105, 20);
            this.searchLookUpEdit4.TabIndex = 10;
            // 
            // gridView3
            // 
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.Location = new System.Drawing.Point(32, 259);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(167, 29);
            this.labelControl5.TabIndex = 13;
            this.labelControl5.Text = "Tìm kiếm nhân viên";
            // 
            // searchLookUpEdit5
            // 
            this.searchLookUpEdit5.EditValue = "";
            this.searchLookUpEdit5.Location = new System.Drawing.Point(291, 265);
            this.searchLookUpEdit5.Name = "searchLookUpEdit5";
            this.searchLookUpEdit5.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpEdit5.Properties.DataSource = this.docGiaBindingSource1;
            this.searchLookUpEdit5.Properties.View = this.gridView4;
            this.searchLookUpEdit5.Size = new System.Drawing.Size(105, 20);
            this.searchLookUpEdit5.TabIndex = 12;
            // 
            // gridView4
            // 
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // tacGiaTableAdapter
            // 
            this.tacGiaTableAdapter.ClearBeforeFill = true;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.Location = new System.Drawing.Point(495, 283);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(111, 33);
            this.btnLuu.TabIndex = 52;
            this.btnLuu.Text = "Thoát";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // qLThuVienDataSetNew
            // 
            this.qLThuVienDataSetNew.DataSetName = "QLThuVienDataSetNew";
            this.qLThuVienDataSetNew.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sachBindingSource
            // 
            this.sachBindingSource.DataMember = "Sach";
            this.sachBindingSource.DataSource = this.qLThuVienDataSetNew;
            // 
            // sachTableAdapter
            // 
            this.sachTableAdapter.ClearBeforeFill = true;
            // 
            // tacGiaBindingSource
            // 
            this.tacGiaBindingSource.DataMember = "TacGia";
            this.tacGiaBindingSource.DataSource = this.qLThuVienDataSetNew;
            // 
            // tacGiaTableAdapter1
            // 
            this.tacGiaTableAdapter1.ClearBeforeFill = true;
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
            // docGiaBindingSource
            // 
            this.docGiaBindingSource.DataMember = "DocGia";
            this.docGiaBindingSource.DataSource = this.qLThuVienDataSetNew;
            // 
            // docGiaTableAdapter
            // 
            this.docGiaTableAdapter.ClearBeforeFill = true;
            // 
            // docGiaBindingSource1
            // 
            this.docGiaBindingSource1.DataMember = "DocGia";
            this.docGiaBindingSource1.DataSource = this.qLThuVienDataSetNew;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 328);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.searchLookUpEdit5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.searchLookUpEdit4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.searchLookUpEdit3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.searchLookUpEdit2);
            this.Controls.Add(this.searchLookUpEdit1);
            this.Controls.Add(this.labelControl1);
            this.Name = "Search";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLThuVienDataSetNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sachBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacGiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacPhamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docGiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docGiaBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpEdit2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpEdit3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpEdit4;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpEdit5;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private QLThuVienDataSet7TableAdapters.TacGiaTableAdapter tacGiaTableAdapter;
        private QLThuVienDataSet7TableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private QLThuVienDataSetNew qLThuVienDataSetNew;
        private System.Windows.Forms.BindingSource sachBindingSource;
        private QLThuVienDataSetNewTableAdapters.SachTableAdapter sachTableAdapter;
        private System.Windows.Forms.BindingSource tacGiaBindingSource;
        private QLThuVienDataSetNewTableAdapters.TacGiaTableAdapter tacGiaTableAdapter1;
        private System.Windows.Forms.BindingSource tacPhamBindingSource;
        private QLThuVienDataSetNewTableAdapters.TacPhamTableAdapter tacPhamTableAdapter;
        private System.Windows.Forms.BindingSource docGiaBindingSource;
        private QLThuVienDataSetNewTableAdapters.DocGiaTableAdapter docGiaTableAdapter;
        private System.Windows.Forms.BindingSource docGiaBindingSource1;
    }
}