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
            this.gridControl_stok_grup_listesi = new DevExpress.XtraGrid.GridControl();
            this.gridView_stok_grup_listesi = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grup_kodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grup_adi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_grup_kodu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_grup_adi = new DevExpress.XtraEditors.TextEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton_kaydet = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_sil = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_temizle = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_stok_grup_listesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_stok_grup_listesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_grup_kodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_grup_adi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl_stok_grup_listesi
            // 
            this.gridControl_stok_grup_listesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_stok_grup_listesi.Location = new System.Drawing.Point(2, 20);
            this.gridControl_stok_grup_listesi.MainView = this.gridView_stok_grup_listesi;
            this.gridControl_stok_grup_listesi.Name = "gridControl_stok_grup_listesi";
            this.gridControl_stok_grup_listesi.Size = new System.Drawing.Size(356, 262);
            this.gridControl_stok_grup_listesi.TabIndex = 0;
            this.gridControl_stok_grup_listesi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_stok_grup_listesi});
            this.gridControl_stok_grup_listesi.Click += new System.EventHandler(this.gridControl_stok_grup_listesi_Click);
            this.gridControl_stok_grup_listesi.DoubleClick += new System.EventHandler(this.gridControl_stok_grup_listesi_DoubleClick);
            // 
            // gridView_stok_grup_listesi
            // 
            this.gridView_stok_grup_listesi.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grup_kodu,
            this.grup_adi});
            this.gridView_stok_grup_listesi.GridControl = this.gridControl_stok_grup_listesi;
            this.gridView_stok_grup_listesi.Name = "gridView_stok_grup_listesi";
            this.gridView_stok_grup_listesi.OptionsBehavior.Editable = false;
            this.gridView_stok_grup_listesi.OptionsView.ShowGroupPanel = false;
            // 
            // grup_kodu
            // 
            this.grup_kodu.Caption = "Grup Kodu";
            this.grup_kodu.FieldName = "grup_kodu";
            this.grup_kodu.Name = "grup_kodu";
            this.grup_kodu.Visible = true;
            this.grup_kodu.VisibleIndex = 0;
            // 
            // grup_adi
            // 
            this.grup_adi.Caption = "Grup Adı";
            this.grup_adi.FieldName = "grup_adi";
            this.grup_adi.Name = "grup_adi";
            this.grup_adi.Visible = true;
            this.grup_adi.VisibleIndex = 1;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.textEdit_grup_kodu);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.textEdit_grup_adi);
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(360, 76);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Grup Bilgileri";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(7, 25);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(50, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Grup Kodu";
            // 
            // textEdit_grup_kodu
            // 
            this.textEdit_grup_kodu.Location = new System.Drawing.Point(63, 23);
            this.textEdit_grup_kodu.Name = "textEdit_grup_kodu";
            this.textEdit_grup_kodu.Size = new System.Drawing.Size(150, 20);
            this.textEdit_grup_kodu.TabIndex = 0;
            this.textEdit_grup_kodu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textEdit_grup_kodu_KeyDown);
            this.textEdit_grup_kodu.Leave += new System.EventHandler(this.textEdit_grup_kodu_Leave);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(16, 51);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(41, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Grup Adı";
            // 
            // textEdit_grup_adi
            // 
            this.textEdit_grup_adi.Location = new System.Drawing.Point(63, 49);
            this.textEdit_grup_adi.Name = "textEdit_grup_adi";
            this.textEdit_grup_adi.Size = new System.Drawing.Size(150, 20);
            this.textEdit_grup_adi.TabIndex = 1;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControl_stok_grup_listesi);
            this.groupControl2.Location = new System.Drawing.Point(3, 85);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(360, 284);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Grup Listesi";
            // 
            // simpleButton_kaydet
            // 
            this.simpleButton_kaydet.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton_kaydet.Image")));
            this.simpleButton_kaydet.Location = new System.Drawing.Point(296, 373);
            this.simpleButton_kaydet.Name = "simpleButton_kaydet";
            this.simpleButton_kaydet.Size = new System.Drawing.Size(65, 25);
            this.simpleButton_kaydet.TabIndex = 2;
            this.simpleButton_kaydet.Text = "Kaydet";
            this.simpleButton_kaydet.Click += new System.EventHandler(this.simpleButton_kaydet_Click);
            // 
            // simpleButton_sil
            // 
            this.simpleButton_sil.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton_sil.Image")));
            this.simpleButton_sil.Location = new System.Drawing.Point(225, 373);
            this.simpleButton_sil.Name = "simpleButton_sil";
            this.simpleButton_sil.Size = new System.Drawing.Size(65, 25);
            this.simpleButton_sil.TabIndex = 3;
            this.simpleButton_sil.Text = "Sil";
            this.simpleButton_sil.Click += new System.EventHandler(this.simpleButton_sil_Click);
            // 
            // simpleButton_temizle
            // 
            this.simpleButton_temizle.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton_temizle.Image")));
            this.simpleButton_temizle.Location = new System.Drawing.Point(154, 373);
            this.simpleButton_temizle.Name = "simpleButton_temizle";
            this.simpleButton_temizle.Size = new System.Drawing.Size(65, 25);
            this.simpleButton_temizle.TabIndex = 5;
            this.simpleButton_temizle.Text = "Temizle";
            this.simpleButton_temizle.Click += new System.EventHandler(this.simpleButton_temizle_Click);
            // 
            // StokGruplari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 402);
            this.Controls.Add(this.simpleButton_temizle);
            this.Controls.Add(this.simpleButton_kaydet);
            this.Controls.Add(this.simpleButton_sil);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl2);
            this.Name = "StokGruplari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Grupları";
            this.Load += new System.EventHandler(this.StokGruplari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_stok_grup_listesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_stok_grup_listesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_grup_kodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_grup_adi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl_stok_grup_listesi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_stok_grup_listesi;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEdit_grup_kodu;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textEdit_grup_adi;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton_kaydet;
        private DevExpress.XtraEditors.SimpleButton simpleButton_sil;
        private DevExpress.XtraGrid.Columns.GridColumn grup_kodu;
        private DevExpress.XtraGrid.Columns.GridColumn grup_adi;
        private DevExpress.XtraEditors.SimpleButton simpleButton_temizle;
    }
}