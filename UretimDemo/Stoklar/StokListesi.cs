using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System.Data;
using System.Windows.Forms;
using UretimDemo.Helpers;

namespace UretimDemo.Stoklar
{
    public partial class StokListesi : Form
    {
        private Uretim urt;
        public string StokKodu { get; set; }

        public StokListesi()
        {
            InitializeComponent();
            urt = new Uretim();
        }

        private void StokListesi_Load(object sender, System.EventArgs e)
        {
            FullData();
        }

        private void FullData()
        {
            string query = "select * from stok order by stok_kodu";
            DataTable dt = urt.get_pgsql_datatable(query);
            if (dt.Rows.Count > 0)
            {
                gridControl_stok_listesi.DataSource = dt;
            }
            else
            {
                XtraMessageBox.Show(this, "Stok bulunamadı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SearchData()
        {
            string stok_kodu = textEdit_stok_kodu.Text.Trim();
            string stok_adi = textEdit_stok_adi.Text.Trim();
            string grup_kodu = textEdit_grup_kodu.Text.Trim();

            string query = $@"select * from stok where stok_kodu ilike '%" + stok_kodu + "%' and stok_adi ilike '%" + stok_adi + "%' and grup_kodu ilike '%" + grup_kodu + "%' order by stok_kodu";
            DataTable dt = urt.get_pgsql_datatable(query);

            gridControl_stok_listesi.DataSource = dt;
            gridControl_stok_listesi.Refresh();

            if (dt.Rows.Count < 1)
            {
                XtraMessageBox.Show(this, "Stok bulunamadı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ClearTextEdit()
        {
            textEdit_stok_kodu.Text = string.Empty;
            textEdit_stok_adi.Text = string.Empty;
            textEdit_grup_kodu.Text = string.Empty;
        }

        private void textEdit_stok_kodu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchData();
            }
        }

        private void textEdit_stok_adi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchData();
            }
        }

        private void textEdit_grup_kodu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchData();
            }
        }

        private void simpleButton_stok_listesi_Click(object sender, System.EventArgs e)
        {
            ClearTextEdit();
            FullData();
        }

        private void gridControl_stok_listesi_DoubleClick(object sender, System.EventArgs e)
        {
            var view = gridControl_stok_listesi.FocusedView as GridView;
            if (view != null)
            {
                int index = view.FocusedRowHandle;
                string stok_kodu = view.GetRowCellValue(index, "stok_kodu").ToString();
                StokKodu = stok_kodu;

                this.Close();
            }
        }
    }
}
