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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_stok_kodu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_stok_adi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_grup_kodu = new DevExpress.XtraEditors.TextEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl_stok_listesi = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_stok_kodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_stok_adi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_grup_kodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_stok_listesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.textEdit_stok_kodu);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.textEdit_stok_adi);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.textEdit_grup_kodu);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(645, 106);
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
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(5, 77);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(50, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Grup Kodu";
            // 
            // textEdit_grup_kodu
            // 
            this.textEdit_grup_kodu.Location = new System.Drawing.Point(61, 75);
            this.textEdit_grup_kodu.Name = "textEdit_grup_kodu";
            this.textEdit_grup_kodu.Size = new System.Drawing.Size(150, 20);
            this.textEdit_grup_kodu.TabIndex = 2;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControl_stok_listesi);
            this.groupControl2.Location = new System.Drawing.Point(12, 124);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(645, 276);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Stok Listesi";
            // 
            // gridControl_stok_listesi
            // 
            this.gridControl_stok_listesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_stok_listesi.Location = new System.Drawing.Point(2, 20);
            this.gridControl_stok_listesi.MainView = this.gridView1;
            this.gridControl_stok_listesi.Name = "gridControl_stok_listesi";
            this.gridControl_stok_listesi.Size = new System.Drawing.Size(641, 254);
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
            // StokListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 412);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "StokListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Listesi";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_stok_kodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_stok_adi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_grup_kodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_stok_listesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
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
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}