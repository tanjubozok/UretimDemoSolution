using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System.Data;
using System.Windows.Forms;
using UretimDemo.Helpers;

namespace UretimDemo.Stoklar
{
    public partial class StokGruplari : Form
    {
        private Uretim urt;
        public string GrupKodu { get; set; }
        public string GrupAdi { get; set; }

        public StokGruplari()
        {
            InitializeComponent();
            urt = new Uretim();
        }

        private void StokGruplari_Load(object sender, System.EventArgs e)
        {
            GetDataList();
        }

        private void GetDataList()
        {
            string query = $"select * from grup order by grup_kodu";
            DataTable dt = urt.get_sqlserver_datatable(query);
            if (dt.Rows.Count > 0)
            {
                gridControl_stok_grup_listesi.DataSource = dt;
            }
            else
            {
                XtraMessageBox.Show(this, "Grup kodu bulunamadı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textEdit_grup_kodu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string query = "select grup_adi from grup where grup_kodu = '" + textEdit_grup_kodu.Text.Trim() + "'";
                DataTable dt = urt.get_sqlserver_datatable(query);
                if (dt.Rows.Count > 0)
                {
                    textEdit_grup_adi.Text = dt.Rows[0]["grup_adi"].ToString();
                }
                else
                {
                    textEdit_grup_adi.Text = string.Empty;
                    XtraMessageBox.Show(this, $@"{textEdit_grup_kodu.Text} grup kodu bulunamadı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void gridControl_stok_grup_listesi_Click(object sender, System.EventArgs e)
        {
            UpdateTextEdits();
        }

        private void gridControl_stok_grup_listesi_DoubleClick(object sender, System.EventArgs e)
        {
            UpdateTextEdits(true);

            this.Close();
        }

        private void UpdateTextEdits(bool updateGlobalVariables = false)
        {
            var view = gridControl_stok_grup_listesi.FocusedView as GridView;
            if (view != null)
            {
                int index = view.FocusedRowHandle;

                string grupKodu = view.GetRowCellValue(index, "grup_kodu").ToString();
                string grupAdi = view.GetRowCellValue(index, "grup_adi").ToString();

                textEdit_grup_kodu.Text = grupKodu;
                textEdit_grup_adi.Text = grupAdi;

                if (updateGlobalVariables)
                {
                    GrupKodu = grupKodu;
                    GrupAdi = grupAdi;
                }
            }
        }

        private void ClearTextEdit()
        {
            textEdit_grup_kodu.Text = string.Empty;
            textEdit_grup_adi.Text = string.Empty;

            textEdit_grup_kodu.Focus();
        }

        private void simpleButton_temizle_Click(object sender, System.EventArgs e)
        {
            ClearTextEdit();
        }

        private void simpleButton_sil_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textEdit_grup_kodu.Text))
            {
                textEdit_grup_kodu.Focus();
                XtraMessageBox.Show(this, $@"Lütfen Grup Kodu alanını doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string query = "select grup_adi from grup where grup_kodu = '" + textEdit_grup_kodu.Text.Trim() + "'";
                DataTable dt = urt.get_sqlserver_datatable(query);
                if (dt.Rows.Count > 0)
                {
                    DialogResult dr = XtraMessageBox.Show($"Grup Kodu : {textEdit_grup_kodu.Text} silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        string queryDelete = "delete from grup where grup_kodu = '" + textEdit_grup_kodu.Text.Trim() + "'";
                        int result = urt.add_sqlserver(queryDelete);
                        if (result > 0)
                        {
                            ClearTextEdit();
                            GetDataList();
                            gridControl_stok_grup_listesi.Refresh();

                            XtraMessageBox.Show(this, "Silme başarılı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            XtraMessageBox.Show(this, "Silme başarısız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    XtraMessageBox.Show(this, $@"Silme başarısız, {textEdit_grup_kodu.Text} databasede kayıtlı değildir", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                textEdit_grup_kodu.Focus();
            }
        }

        private void simpleButton_kaydet_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textEdit_grup_kodu.Text) || string.IsNullOrWhiteSpace(textEdit_grup_adi.Text))
            {
                textEdit_grup_kodu.Focus();
                XtraMessageBox.Show(this, "Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string query = "select grup_adi from grup where grup_kodu = '" + textEdit_grup_kodu.Text.Trim() + "'";
                DataTable dt = urt.get_sqlserver_datatable(query);
                if (dt.Rows.Count > 0)
                {
                    XtraMessageBox.Show(this, $"Grup Kodu : {textEdit_grup_kodu.Text} databasede kayıtlıdır, ekleme başarısız, hata oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string queryInsert = "insert into grup (grup_kodu, grup_adi) values('" + textEdit_grup_kodu.Text.Trim() + "', '" + textEdit_grup_adi.Text.Trim() + "')";
                    int result = urt.add_sqlserver(queryInsert);
                    if (result > 0)
                    {
                        ClearTextEdit();

                        GetDataList();
                        gridControl_stok_grup_listesi.Refresh();

                        XtraMessageBox.Show(this, "Kayıt başarılı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        XtraMessageBox.Show(this, "Kayıt başarısız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void textEdit_grup_kodu_Leave(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textEdit_grup_kodu.Text))
                textEdit_grup_kodu.Focus();
        }

        private void simpleButton_guncelle_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textEdit_grup_kodu.Text) || string.IsNullOrWhiteSpace(textEdit_grup_adi.Text))
            {
                textEdit_grup_kodu.Focus();
                XtraMessageBox.Show(this, "Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string query = "select grup_adi from grup where grup_kodu = '" + textEdit_grup_kodu.Text.Trim() + "'";
                DataTable dt = urt.get_sqlserver_datatable(query);
                if (dt.Rows.Count > 0)
                {
                    string queryUpdate = "update grup set grup_adi = '" + textEdit_grup_adi.Text.Trim() + "' where grup_kodu = '" + textEdit_grup_kodu.Text.Trim() + "'";
                    int result = urt.add_sqlserver(queryUpdate);
                    if (result > 0)
                    {
                        ClearTextEdit();

                        GetDataList();
                        gridControl_stok_grup_listesi.Refresh();

                        XtraMessageBox.Show(this, "Güncelleme başarılı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        XtraMessageBox.Show(this, $"Grup Kodu : {textEdit_grup_kodu.Text} databasede kayıtlı değildir, güncelleme başarısız, hata oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    XtraMessageBox.Show(this, "Kayıt başarısız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}