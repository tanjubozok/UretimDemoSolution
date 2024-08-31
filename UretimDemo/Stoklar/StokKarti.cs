using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Windows.Forms;
using UretimDemo.Helpers;

namespace UretimDemo.Stoklar
{
    public partial class StokKarti : Form
    {
        private Uretim urt;
        public string StokKodu { get; set; }

        public StokKarti()
        {
            InitializeComponent();
            urt = new Uretim();

            //textEdit_grup_aciklama.Properties.ReadOnly = true;
            textEdit_grup_aciklama.Enabled = false;
        }

        private void simpleButton_stok_listesi_Click(object sender, EventArgs e)
        {
            StokListesi stokListesi = new StokListesi();
            stokListesi.ShowDialog();
            textEdit_stok_kodu.Text = stokListesi.StokKodu;

            GetDataListWithStokKodu();
        }

        private void simpleButton_grup_listesi_Click(object sender, EventArgs e)
        {
            StokGruplari stokGruplari = new StokGruplari();
            stokGruplari.ShowDialog();

            textEdit_grup_kodu.Text = stokGruplari.GrupKodu;
            textEdit_grup_aciklama.Text = stokGruplari.GrupAdi;
        }

        private void GetDataListWithStokKodu()
        {
            string query = $"select * from stok where stok_kodu = '" + textEdit_stok_kodu.Text + "'";
            DataTable dt = urt.get_sqlserver_datatable(query);
            if (dt.Rows.Count > 0)
            {
                textEdit_stok_adi.Text = dt.Rows[0]["stok_adi"].ToString();
                textEdit_grup_kodu.Text = dt.Rows[0]["grup_kodu"].ToString();
                textEdit_fiyat.Text = dt.Rows[0]["fiyat"].ToString();
                textEdit_kdv_orani.Text = dt.Rows[0]["kdv_orani"].ToString();

                GetGrupKodu();
            }
            else
            {
                ClearTextEdit(false);
                XtraMessageBox.Show(this, $"{textEdit_stok_kodu.Text} stok kodu bulunamadı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ClearTextEdit(bool true_stok_kodu)
        {
            if (true_stok_kodu)
                textEdit_stok_kodu.Text = string.Empty;

            textEdit_stok_adi.Text = string.Empty;
            textEdit_grup_kodu.Text = string.Empty;
            textEdit_grup_aciklama.Text = string.Empty;
            textEdit_fiyat.Text = string.Empty;
            textEdit_kdv_orani.Text = string.Empty;
        }

        private void textEdit_stok_kodu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GetDataListWithStokKodu();
            }
        }

        private void textEdit_stok_kodu_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textEdit_stok_kodu.Text.Trim()))
                textEdit_stok_kodu.Focus();
        }

        private void StokKarti_Load(object sender, EventArgs e)
        {

        }        

        private void GetGrupKodu()
        {
            string query = "select grup_adi from grup where grup_kodu = '" + textEdit_grup_kodu.Text.Trim() + "'";
            DataTable dt = urt.get_sqlserver_datatable(query);
            if (dt.Rows.Count > 0)
            {
                textEdit_grup_aciklama.Text = dt.Rows[0]["grup_adi"].ToString();
            }
            else
            {
                textEdit_grup_aciklama.Text = string.Empty;
                XtraMessageBox.Show(this, $"{textEdit_grup_kodu.Text} grup kodu bulunamadı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textEdit_grup_kodu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GetGrupKodu();
            }
        }

        private void simpleButton_kaydet_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton_sil_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton_temizle_Click(object sender, EventArgs e)
        {
            ClearTextEdit(true);
            textEdit_stok_kodu.Focus();
        }

        private void simpleButton_kaydet_Click(object sender, EventArgs e)
        {
            string stok_kodu = textEdit_stok_kodu.Text.Trim();
            string stok_adi = textEdit_stok_adi.Text.Trim();
            string grup_kodu = textEdit_grup_kodu.Text.Trim();
            string fiyat = textEdit_fiyat.Text.Trim();
            string kdv_orani = textEdit_kdv_orani.Text.Trim();


            string query = "";
            int result = urt.add_sqlserver(query);
            if (result > 0)
            {

            }
            else
            {

            }
        }

        private void simpleButton_sil_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton_guncelle_Click(object sender, EventArgs e)
        {

        }
    }
}