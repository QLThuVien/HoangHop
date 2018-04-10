namespace QLThuVien.GUI
{
    partial class SQL
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
            this.txtCSDL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.chkSaveInfor = new System.Windows.Forms.CheckBox();
            this.txtPW = new System.Windows.Forms.TextBox();
            this.txtUN = new System.Windows.Forms.TextBox();
            this.optSQL = new System.Windows.Forms.RadioButton();
            this.optWin = new System.Windows.Forms.RadioButton();
            this.txtMayChu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCSDL
            // 
            this.txtCSDL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCSDL.Location = new System.Drawing.Point(121, 225);
            this.txtCSDL.Multiline = true;
            this.txtCSDL.Name = "txtCSDL";
            this.txtCSDL.Size = new System.Drawing.Size(193, 25);
            this.txtCSDL.TabIndex = 21;
            this.txtCSDL.Text = "Test";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Tên CSDL";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(228, 292);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(86, 38);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(55, 292);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(91, 38);
            this.btnLogin.TabIndex = 15;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // chkSaveInfor
            // 
            this.chkSaveInfor.AutoSize = true;
            this.chkSaveInfor.Checked = true;
            this.chkSaveInfor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSaveInfor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSaveInfor.ForeColor = System.Drawing.Color.Red;
            this.chkSaveInfor.Location = new System.Drawing.Point(87, 269);
            this.chkSaveInfor.Name = "chkSaveInfor";
            this.chkSaveInfor.Size = new System.Drawing.Size(210, 20);
            this.chkSaveInfor.TabIndex = 19;
            this.chkSaveInfor.Text = "Lưu lại trên máy chủ đăng nhập";
            this.chkSaveInfor.UseVisualStyleBackColor = true;
            // 
            // txtPW
            // 
            this.txtPW.Location = new System.Drawing.Point(209, 185);
            this.txtPW.Multiline = true;
            this.txtPW.Name = "txtPW";
            this.txtPW.Size = new System.Drawing.Size(148, 25);
            this.txtPW.TabIndex = 18;
            // 
            // txtUN
            // 
            this.txtUN.Location = new System.Drawing.Point(209, 140);
            this.txtUN.Multiline = true;
            this.txtUN.Name = "txtUN";
            this.txtUN.Size = new System.Drawing.Size(148, 27);
            this.txtUN.TabIndex = 17;
            // 
            // optSQL
            // 
            this.optSQL.AutoSize = true;
            this.optSQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optSQL.Location = new System.Drawing.Point(121, 105);
            this.optSQL.Name = "optSQL";
            this.optSQL.Size = new System.Drawing.Size(311, 20);
            this.optSQL.TabIndex = 14;
            this.optSQL.Text = "Xác thực SQL (Authentication SQL Server)";
            this.optSQL.UseVisualStyleBackColor = true;
            // 
            // optWin
            // 
            this.optWin.AutoSize = true;
            this.optWin.Checked = true;
            this.optWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optWin.Location = new System.Drawing.Point(121, 63);
            this.optWin.Name = "optWin";
            this.optWin.Size = new System.Drawing.Size(311, 20);
            this.optWin.TabIndex = 12;
            this.optWin.TabStop = true;
            this.optWin.Text = "Xác thực Window (Authentication Window)";
            this.optWin.UseVisualStyleBackColor = true;
            // 
            // txtMayChu
            // 
            this.txtMayChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMayChu.Location = new System.Drawing.Point(121, 18);
            this.txtMayChu.Multiline = true;
            this.txtMayChu.Name = "txtMayChu";
            this.txtMayChu.Size = new System.Drawing.Size(236, 27);
            this.txtMayChu.TabIndex = 13;
            this.txtMayChu.Text = "HP\\SQLEXPRESS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tên máy chủ";
            // 
            // SQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 348);
            this.Controls.Add(this.txtCSDL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.chkSaveInfor);
            this.Controls.Add(this.txtPW);
            this.Controls.Add(this.txtUN);
            this.Controls.Add(this.optSQL);
            this.Controls.Add(this.optWin);
            this.Controls.Add(this.txtMayChu);
            this.Controls.Add(this.label1);
            this.Name = "SQL";
            this.Text = "SQL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCSDL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.CheckBox chkSaveInfor;
        private System.Windows.Forms.TextBox txtPW;
        private System.Windows.Forms.TextBox txtUN;
        private System.Windows.Forms.RadioButton optSQL;
        private System.Windows.Forms.RadioButton optWin;
        private System.Windows.Forms.TextBox txtMayChu;
        private System.Windows.Forms.Label label1;
    }
}