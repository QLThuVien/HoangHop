﻿namespace QLThuVien.Main
{
    partial class frSherlock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frSherlock));
            this.pictureEdit6 = new DevExpress.XtraEditors.PictureEdit();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit6.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureEdit6
            // 
            this.pictureEdit6.EditValue = ((object)(resources.GetObject("pictureEdit6.EditValue")));
            this.pictureEdit6.Location = new System.Drawing.Point(53, 39);
            this.pictureEdit6.Name = "pictureEdit6";
            this.pictureEdit6.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit6.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit6.Size = new System.Drawing.Size(230, 317);
            this.pictureEdit6.TabIndex = 4;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(335, 106);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(404, 250);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(335, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nội dung:";
            // 
            // frSherlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 473);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pictureEdit6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frSherlock";
            this.Text = "frSherlock";
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit6.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit pictureEdit6;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
    }
}