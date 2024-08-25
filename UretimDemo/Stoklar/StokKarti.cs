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
        public StokKarti()
        {
            InitializeComponent();
            urt = new Uretim();
        }

        private void simpleButton_stok_listesi_Click(object sender, EventArgs e)
        {
            StokListesi stokListesi = new StokListesi();
            stokListesi.ShowDialog();
        }

        private void simpleButton_grup_listesi_Click(object sender, EventArgs e)
        {
            StokGruplari stokGruplari = new StokGruplari();
            stokGruplari.ShowDialog();
        }

        private void textEdit_stok_kodu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string query = $"select * from stok where stok_kodu = '" + textEdit_stok_kodu.Text + "'";
                DataTable dt = urt.get_pgsql_datatable(query);
                if (dt.Rows.Count > 0)
                {
                    textEdit_stok_adi.Text = dt.Rows[0]["stok_adi"].ToString();
                    textEdit_grup_kodu.Text = dt.Rows[0]["grup_kodu"].ToString();
                    textEdit_fiyat.Text = dt.Rows[0]["fiyat"].ToString();
                    textEdit_kdv_orani.Text = dt.Rows[0]["kdv_orani"].ToString();
                }
                else
                {
                    XtraMessageBox.Show(this, $"{textEdit_stok_kodu.Text} stok kodu bulunamadı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void textEdit_stok_kodu_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textEdit_stok_kodu.Text.Trim()))
                textEdit_stok_kodu.Focus();
        }
    }
}
