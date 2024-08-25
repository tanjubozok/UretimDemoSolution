namespace UretimDemo.Stoklar
{
    partial class StokGruplari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StokGruplari));
            this.gridControl_stok_listesi = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_stok_kodu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_stok_adi = new DevExpress.XtraEditors.TextEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton_kaydet = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_sil = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_stok_listesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_stok_kodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_stok_adi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl_stok_listesi
            // 
            this.gridControl_stok_listesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_stok_listesi.Location = new System.Drawing.Point(2, 20);
            this.gridControl_stok_listesi.MainView = this.gridView1;
            this.gridControl_stok_listesi.Name = "gridControl_stok_listesi";
            this.gridControl_stok_listesi.Size = new System.Drawing.Size(356, 254);
            this.gridControl_stok_listesi.TabIndex = 0;
            this.gridControl_stok_listesi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl_stok_listesi;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.textEdit_stok_kodu);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.textEdit_stok_adi);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(360, 77);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Stok Kartı Bilgileri";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(7, 25);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Stok Kodu";
            // 
            // textEdit_stok_kodu
            // 
            this.textEdit_stok_kodu.Location = new System.Drawing.Point(61, 23);
            this.textEdit_stok_kodu.Name = "textEdit_stok_kodu";
            this.textEdit_stok_kodu.Size = new System.Drawing.Size(150, 20);
            this.textEdit_stok_kodu.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(16, 51);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(39, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Stok Adı";
            // 
            // textEdit_stok_adi
            // 
            this.textEdit_stok_adi.Location = new System.Drawing.Point(61, 49);
            this.textEdit_stok_adi.Name = "textEdit_stok_adi";
            this.textEdit_stok_adi.Size = new System.Drawing.Size(150, 20);
            this.textEdit_stok_adi.TabIndex = 1;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControl_stok_listesi);
            this.groupControl2.Location = new System.Drawing.Point(12, 95);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(360, 276);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Stok Listesi";
            // 
            // simpleButton_kaydet
            // 
            this.simpleButton_kaydet.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton_kaydet.Image")));
            this.simpleButton_kaydet.Location = new System.Drawing.Point(307, 375);
            this.simpleButton_kaydet.Name = "simpleButton_kaydet";
            this.simpleButton_kaydet.Size = new System.Drawing.Size(65, 25);
            this.simpleButton_kaydet.TabIndex = 2;
            this.simpleButton_kaydet.Text = "Kaydet";
            // 
            // simpleButton_sil
            // 
            this.simpleButton_sil.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton_sil.Image")));
            this.simpleButton_sil.Location = new System.Drawing.Point(236, 375);
            this.simpleButton_sil.Name = "simpleButton_sil";
            this.simpleButton_sil.Size = new System.Drawing.Size(65, 25);
            this.simpleButton_sil.TabIndex = 3;
            this.simpleButton_sil.Text = "Sil";
            // 
            // StokGruplari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 408);
            this.Controls.Add(this.simpleButton_kaydet);
            this.Controls.Add(this.simpleButton_sil);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl2);
            this.Name = "StokGruplari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Grupları";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_stok_listesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_stok_kodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_stok_adi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl_stok_listesi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEdit_stok_kodu;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textEdit_stok_adi;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton_kaydet;
        private DevExpress.XtraEditors.SimpleButton simpleButton_sil;
    }
}