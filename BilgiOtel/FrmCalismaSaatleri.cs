using BilgiOtelDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgiOtel
{
    public partial class FrmCalismaSaatleri : Form
    { 
        CalismaSaatleriDAL calismaSaatleriDAL = new CalismaSaatleriDAL();
        public FrmCalismaSaatleri()
        {
            InitializeComponent();
        }

        private void FrmCalismaSaatleri_Load(object sender, EventArgs e)
        {
            Islemler.CmbDoldur(cmbCalisanlar, "Calisanlar", "SELECT calisanID, (calisanAd + ' ' + calisanSoyad) as CalisanAdSoyad FROM calisanlar WHERE calisanAktifMi = 1");
            Islemler.CmbDoldur(cmbVardiyalar, "Vardiyalar", "SELECT vardiyaID, vardiyaAralik FROM vardiyalar");
            Islemler.DataTableDoldur("SELECT * FROM calismaSaatleri", "CalismaSaatleri");
            Islemler.LvDoldur(lvwCalismaSaatleri, "CalismaSaatleri");
            cmbCalisanlar.SelectedIndex = -1;
            cmbVardiyalar.SelectedIndex = -1;
        }
    }
}
