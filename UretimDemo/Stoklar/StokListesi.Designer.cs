namespace UretimDemo.Stoklar
{
    partial class StokListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StokListesi));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton_stok_listesi = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_stok_kodu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_stok_adi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_grup_adi = new DevExpress.XtraEditors.TextEdit();
            this.textEdit_grup_kodu = new DevExpress.XtraEditors.TextEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl_stok_listesi = new DevExpress.XtraGrid.GridControl();
            this.gridView_stok_listesi = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.stok_kodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.stok_adi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grup_kodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.kdv_orani = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grup_adi = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_stok_kodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_stok_adi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_grup_adi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_grup_kodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_stok_listesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_stok_listesi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.simpleButton_stok_listesi);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.textEdit_stok_kodu);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.textEdit_stok_adi);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.textEdit_grup_adi);
            this.groupControl1.Controls.Add(this.textEdit_grup_kodu);
            this.groupControl1.Location = new System.Drawing.Point(2, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1092, 124);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Stok Kartı Bilgileri";
            // 
            // simpleButton_stok_listesi
            // 
            this.simpleButton_stok_listesi.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton_stok_listesi.Image")));
            this.simpleButton_stok_listesi.Location = new System.Drawing.Point(217, 23);
            this.simpleButton_stok_listesi.Name = "simpleButton_stok_listesi";
            this.simpleButton_stok_listesi.Size = new System.Drawing.Size(81, 41);
            this.simpleButton_stok_listesi.TabIndex = 5;
            this.simpleButton_stok_listesi.Text = "Liste";
            this.simpleButton_stok_listesi.Click += new System.EventHandler(this.simpleButton_stok_listesi_Click);
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
            this.textEdit_stok_kodu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textEdit_stok_kodu_KeyDown);
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
            this.textEdit_stok_adi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textEdit_stok_adi_KeyDown);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(14, 102);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(41, 13);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Grup Adı";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(5, 77);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(50, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Grup Kodu";
            // 
            // textEdit_grup_adi
            // 
            this.textEdit_grup_adi.Location = new System.Drawing.Point(61, 99);
            this.textEdit_grup_adi.Name = "textEdit_grup_adi";
            this.textEdit_grup_adi.Size = new System.Drawing.Size(150, 20);
            this.textEdit_grup_adi.TabIndex = 2;
            this.textEdit_grup_adi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textEdit_grup_adi_KeyDown);
            // 
            // textEdit_grup_kodu
            // 
            this.textEdit_grup_kodu.Location = new System.Drawing.Point(61, 75);
            this.textEdit_grup_kodu.Name = "textEdit_grup_kodu";
            this.textEdit_grup_kodu.Size = new System.Drawing.Size(150, 20);
            this.textEdit_grup_kodu.TabIndex = 2;
            this.textEdit_grup_kodu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textEdit_grup_kodu_KeyDown);
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.gridControl_stok_listesi);
            this.groupControl2.Location = new System.Drawing.Point(2, 133);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1092, 544);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Stok Listesi";
            // 
            // gridControl_stok_listesi
            // 
            this.gridControl_stok_listesi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl_stok_listesi.Location = new System.Drawing.Point(2, 20);
            this.gridControl_stok_listesi.MainView = this.gridView_stok_listesi;
            this.gridControl_stok_listesi.Name = "gridControl_stok_listesi";
            this.gridControl_stok_listesi.Size = new System.Drawing.Size(1088, 522);
            this.gridControl_stok_listesi.TabIndex = 0;
            this.gridControl_stok_listesi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_stok_listesi});
            this.gridControl_stok_listesi.DoubleClick += new System.EventHandler(this.gridControl_stok_listesi_DoubleClick);
            // 
            // gridView_stok_listesi
            // 
            this.gridView_stok_listesi.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.stok_kodu,
            this.stok_adi,
            this.grup_kodu,
            this.fiyat,
            this.kdv_orani,
            this.grup_adi});
            this.gridView_stok_listesi.GridControl = this.gridControl_stok_listesi;
            this.gridView_stok_listesi.Name = "gridView_stok_listesi";
            this.gridView_stok_listesi.OptionsBehavior.Editable = false;
            this.gridView_stok_listesi.OptionsView.ShowGroupPanel = false;
            // 
            // stok_kodu
            // 
            this.stok_kodu.Caption = "Stok Kodu";
            this.stok_kodu.FieldName = "stok_kodu";
            this.stok_kodu.Name = "stok_kodu";
            this.stok_kodu.Visible = true;
            this.stok_kodu.VisibleIndex = 0;
            // 
            // stok_adi
            // 
            this.stok_adi.Caption = "Stok Adı";
            this.stok_adi.FieldName = "stok_adi";
            this.stok_adi.Name = "stok_adi";
            this.stok_adi.Visible = true;
            this.stok_adi.VisibleIndex = 1;
            // 
            // grup_kodu
            // 
            this.grup_kodu.Caption = "Grup Kodu";
            this.grup_kodu.FieldName = "grup_kodu";
            this.grup_kodu.Name = "grup_kodu";
            this.grup_kodu.Visible = true;
            this.grup_kodu.VisibleIndex = 2;
            // 
            // fiyat
            // 
            this.fiyat.Caption = "Fiyatı";
            this.fiyat.FieldName = "fiyat";
            this.fiyat.Name = "fiyat";
            this.fiyat.Visible = true;
            this.fiyat.VisibleIndex = 4;
            // 
            // kdv_orani
            // 
            this.kdv_orani.Caption = "KDV";
            this.kdv_orani.FieldName = "kdv_orani";
            this.kdv_orani.Name = "kdv_orani";
            this.kdv_orani.Visible = true;
            this.kdv_orani.VisibleIndex = 5;
            // 
            // grup_adi
            // 
            this.grup_adi.Caption = "Grup Adı";
            this.grup_adi.FieldName = "grup_adi";
            this.grup_adi.Name = "grup_adi";
            this.grup_adi.Visible = true;
            this.grup_adi.VisibleIndex = 3;
            // 
            // StokListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 681);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "StokListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Listesi";
            this.Load += new System.EventHandler(this.StokListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_stok_kodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_stok_adi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_grup_adi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_grup_kodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_stok_listesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_stok_listesi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEdit_stok_kodu;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textEdit_stok_adi;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textEdit_grup_kodu;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridControl_stok_listesi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_stok_listesi;
        private DevExpress.XtraGrid.Columns.GridColumn stok_kodu;
        private DevExpress.XtraGrid.Columns.GridColumn stok_adi;
        private DevExpress.XtraGrid.Columns.GridColumn grup_kodu;
        private DevExpress.XtraGrid.Columns.GridColumn fiyat;
        private DevExpress.XtraGrid.Columns.GridColumn kdv_orani;
        private DevExpress.XtraEditors.SimpleButton simpleButton_stok_listesi;
        private DevExpress.XtraGrid.Columns.GridColumn grup_adi;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit textEdit_grup_adi;
    }
}