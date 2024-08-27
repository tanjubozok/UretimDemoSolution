using DevExpress.XtraEditors.Controls;
using System.Windows.Forms;
using UretimDemo.Helpers;
using UretimDemo.Stoklar;

namespace UretimDemo
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void btnAnaFormStokKartiKayitlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            StokKarti stokKarti = new StokKarti();
            stokKarti.Show();
        }

        private void AnaForm_Load(object sender, System.EventArgs e)
        {
            Localizer.Active = new CustomXtraMessageBoxLocalizer();
        }
    }
}
