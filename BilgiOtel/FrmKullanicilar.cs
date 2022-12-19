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
    public partial class FrmKullanicilar : Form
    {
        

        public FrmKullanicilar()
        {
            InitializeComponent();
        }

        private void FrmKullanicilar_Load(object sender, EventArgs e)
        {
            Islemler.CmbDoldur(cmbKullaniciCalisan, "CalisanlarCmb", "Select * from vw_calisanlarCmb");
            Islemler.CmbDoldur(cmbKullaniciYonetici, "YoneticilerCmb", "Select * from vw_yoneticilerCmb");
            Islemler.DataTableDoldur("SELECT * FROM vw_kulllanicilarLv", "Kullanicilar");
            Islemler.LvDoldur(lvwKullaniciListe, "Kullanicilar");
        }

        private void btnKullaniciEkle_Click(object sender, EventArgs e)
        {

        }
    }
}
