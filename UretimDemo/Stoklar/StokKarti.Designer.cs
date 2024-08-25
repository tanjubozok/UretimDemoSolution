namespace UretimDemo.Stoklar
{
    partial class StokKarti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StokKarti));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_stok_kodu = new DevExpress.XtraEditors.TextEdit();
            this.textEdit_stok_adi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_grup_kodu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_fiyat = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_kdv_orani = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton_sil = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_kaydet = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_stok_listesi = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit_grup_aciklama = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton_grup_listesi = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_stok_kodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_stok_adi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_grup_kodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_fiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_kdv_orani.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_grup_aciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(7, 28);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Stok Kodu";
            // 
            // textEdit_stok_kodu
            // 
            this.textEdit_stok_kodu.Location = new System.Drawing.Point(61, 26);
            this.textEdit_stok_kodu.Name = "textEdit_stok_kodu";
            this.textEdit_stok_kodu.Size = new System.Drawing.Size(150, 20);
            this.textEdit_stok_kodu.TabIndex = 0;
            this.textEdit_stok_kodu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textEdit_stok_kodu_KeyDown);
            this.textEdit_stok_kodu.Leave += new System.EventHandler(this.textEdit_stok_kodu_Leave);
            // 
            // textEdit_stok_adi
            // 
            this.textEdit_stok_adi.Location = new System.Drawing.Point(61, 51);
            this.textEdit_stok_adi.Name = "textEdit_stok_adi";
            this.textEdit_stok_adi.Size = new System.Drawing.Size(352, 20);
            this.textEdit_stok_adi.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(16, 54);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(39, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Stok Adı";
            // 
            // textEdit_grup_kodu
            // 
            this.textEdit_grup_kodu.Location = new System.Drawing.Point(61, 78);
            this.textEdit_grup_kodu.Name = "textEdit_grup_kodu";
            this.textEdit_grup_kodu.Size = new System.Drawing.Size(150, 20);
            this.textEdit_grup_kodu.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(5, 80);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(50, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Grup Kodu";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(31, 26);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(24, 13);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Fiyat";
            // 
            // textEdit_fiyat
            // 
            this.textEdit_fiyat.Location = new System.Drawing.Point(61, 23);
            this.textEdit_fiyat.Name = "textEdit_fiyat";
            this.textEdit_fiyat.Size = new System.Drawing.Size(150, 20);
            this.textEdit_fiyat.TabIndex = 0;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(7, 52);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(48, 13);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "KDV Oranı";
            // 
            // textEdit_kdv_orani
            // 
            this.textEdit_kdv_orani.Location = new System.Drawing.Point(61, 49);
            this.textEdit_kdv_orani.Name = "textEdit_kdv_orani";
            this.textEdit_kdv_orani.Size = new System.Drawing.Size(150, 20);
            this.textEdit_kdv_orani.TabIndex = 1;
            // 
            // simpleButton_sil
            // 
            this.simpleButton_sil.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton_sil.Image")));
            this.simpleButton_sil.Location = new System.Drawing.Point(286, 198);
            this.simpleButton_sil.Name = "simpleButton_sil";
            this.simpleButton_sil.Size = new System.Drawing.Size(65, 25);
            this.simpleButton_sil.TabIndex = 3;
            this.simpleButton_sil.Text = "Sil";
            // 
            // simpleButton_kaydet
            // 
            this.simpleButton_kaydet.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton_kaydet.Image")));
            this.simpleButton_kaydet.Location = new System.Drawing.Point(357, 198);
            this.simpleButton_kaydet.Name = "simpleButton_kaydet";
            this.simpleButton_kaydet.Size = new System.Drawing.Size(65, 25);
            this.simpleButton_kaydet.TabIndex = 2;
            this.simpleButton_kaydet.Text = "Kaydet";
            // 
            // simpleButton_stok_listesi
            // 
            this.simpleButton_stok_listesi.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton_stok_listesi.Image")));
            this.simpleButton_stok_listesi.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton_stok_listesi.Location = new System.Drawing.Point(217, 23);
            this.simpleButton_stok_listesi.Name = "simpleButton_stok_listesi";
            this.simpleButton_stok_listesi.Size = new System.Drawing.Size(40, 25);
            this.simpleButton_stok_listesi.TabIndex = 1;
            this.simpleButton_stok_listesi.Click += new System.EventHandler(this.simpleButton_stok_listesi_Click);
            // 
            // textEdit_grup_aciklama
            // 
            this.textEdit_grup_aciklama.Location = new System.Drawing.Point(263, 77);
            this.textEdit_grup_aciklama.Name = "textEdit_grup_aciklama";
            this.textEdit_grup_aciklama.Size = new System.Drawing.Size(150, 20);
            this.textEdit_grup_aciklama.TabIndex = 5;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.simpleButton_grup_listesi);
            this.groupControl1.Controls.Add(this.simpleButton_stok_listesi);
            this.groupControl1.Controls.Add(this.textEdit_grup_aciklama);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.textEdit_stok_kodu);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.textEdit_stok_adi);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.textEdit_grup_kodu);
            this.groupControl1.Location = new System.Drawing.Point(2, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(420, 107);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Genel Bilgiler";
            // 
            // simpleButton_grup_listesi
            // 
            this.simpleButton_grup_listesi.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton_grup_listesi.Image")));
            this.simpleButton_grup_listesi.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton_grup_listesi.Location = new System.Drawing.Point(217, 75);
            this.simpleButton_grup_listesi.Name = "simpleButton_grup_listesi";
            this.simpleButton_grup_listesi.Size = new System.Drawing.Size(40, 25);
            this.simpleButton_grup_listesi.TabIndex = 4;
            this.simpleButton_grup_listesi.Click += new System.EventHandler(this.simpleButton_grup_listesi_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.textEdit_fiyat);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.textEdit_kdv_orani);
            this.groupControl2.Location = new System.Drawing.Point(2, 116);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(420, 76);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Fiyat Bilgileri";
            // 
            // StokKarti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 227);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.simpleButton_kaydet);
            this.Controls.Add(this.simpleButton_sil);
            this.Name = "StokKarti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Kartı";
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_stok_kodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_stok_adi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_grup_kodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_fiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_kdv_orani.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_grup_aciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEdit_stok_kodu;
        private DevExpress.XtraEditors.TextEdit textEdit_stok_adi;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textEdit_grup_kodu;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit textEdit_fiyat;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit textEdit_kdv_orani;
        private DevExpress.XtraEditors.SimpleButton simpleButton_sil;
        private DevExpress.XtraEditors.SimpleButton simpleButton_kaydet;
        private DevExpress.XtraEditors.SimpleButton simpleButton_stok_listesi;
        private DevExpress.XtraEditors.TextEdit textEdit_grup_aciklama;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton_grup_listesi;
    }
}