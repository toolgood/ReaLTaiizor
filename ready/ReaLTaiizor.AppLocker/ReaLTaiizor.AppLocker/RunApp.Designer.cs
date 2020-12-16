﻿
namespace ReaLTaiizor.AppLocker
{
    partial class RunApp
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.NAME = new ReaLTaiizor.Controls.NightLabel();
            this.DIRECTORY = new System.Windows.Forms.PictureBox();
            this.LOCK = new System.Windows.Forms.PictureBox();
            this.ICO = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DIRECTORY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LOCK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ICO)).BeginInit();
            this.SuspendLayout();
            // 
            // NAME
            // 
            this.NAME.AutoEllipsis = true;
            this.NAME.BackColor = System.Drawing.Color.Transparent;
            this.NAME.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.NAME.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NAME.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(118)))), ((int)(((byte)(127)))));
            this.NAME.Location = new System.Drawing.Point(27, 5);
            this.NAME.Name = "NAME";
            this.NAME.Size = new System.Drawing.Size(200, 15);
            this.NAME.TabIndex = 1;
            this.NAME.Text = "NAME - TITLE";
            // 
            // DIRECTORY
            // 
            this.DIRECTORY.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DIRECTORY.Image = global::ReaLTaiizor.AppLocker.Properties.Resources.eye_96px;
            this.DIRECTORY.Location = new System.Drawing.Point(257, 0);
            this.DIRECTORY.Margin = new System.Windows.Forms.Padding(0);
            this.DIRECTORY.Name = "DIRECTORY";
            this.DIRECTORY.Size = new System.Drawing.Size(24, 24);
            this.DIRECTORY.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DIRECTORY.TabIndex = 3;
            this.DIRECTORY.TabStop = false;
            this.DIRECTORY.Click += new System.EventHandler(this.DIRECTORY_Click);
            // 
            // LOCK
            // 
            this.LOCK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LOCK.Image = global::ReaLTaiizor.AppLocker.Properties.Resources.prisoner_96px;
            this.LOCK.Location = new System.Drawing.Point(230, 0);
            this.LOCK.Margin = new System.Windows.Forms.Padding(0);
            this.LOCK.Name = "LOCK";
            this.LOCK.Size = new System.Drawing.Size(24, 24);
            this.LOCK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LOCK.TabIndex = 2;
            this.LOCK.TabStop = false;
            this.LOCK.Click += new System.EventHandler(this.LOCK_Click);
            // 
            // ICO
            // 
            this.ICO.Image = global::ReaLTaiizor.AppLocker.Properties.Resources.application_window_96px;
            this.ICO.Location = new System.Drawing.Point(0, 0);
            this.ICO.Margin = new System.Windows.Forms.Padding(0);
            this.ICO.Name = "ICO";
            this.ICO.Size = new System.Drawing.Size(24, 24);
            this.ICO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ICO.TabIndex = 0;
            this.ICO.TabStop = false;
            // 
            // RunApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.DIRECTORY);
            this.Controls.Add(this.LOCK);
            this.Controls.Add(this.NAME);
            this.Controls.Add(this.ICO);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "RunApp";
            this.Size = new System.Drawing.Size(281, 24);
            ((System.ComponentModel.ISupportInitialize)(this.DIRECTORY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LOCK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ICO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ICO;
        private Controls.NightLabel NAME;
        private System.Windows.Forms.PictureBox LOCK;
        private System.Windows.Forms.PictureBox DIRECTORY;
    }
}
