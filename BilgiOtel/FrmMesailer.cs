using BilgiOtelDAL;
using Entity;
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
    public partial class FrmMesailer : Form
    {
        MesailerDAL mesailerDAL = new MesailerDAL();

        public FrmMesailer()
        {
            InitializeComponent();
        }

        private void FrmMesailer_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 24; i++)
            {
                cmbBaslangicSaatler.Items.Add(i.ToString() + ":00");
                cmbBaslangicSaatler.SelectedIndex = 0;
                cmbBitisSaatler.Items.Add(i.ToString() + ":00");
                cmbBitisSaatler.SelectedIndex = 0;
            }

            Islemler.CmbDoldur(cmbMesaiCalisanlar, "Calisanlar", "SELECT calisanID,(calisanAd + ' ' + calisanSoyad) as CalisanAdSoyad FROM calisanlar WHERE calisanAktifMi = 1");
            Islemler.DataTableDoldur("SELECT mesaiID,(calisanAd + ' ' + calisanSoyad) as CalisanAdSoyad, mesaiBaslangicTarihi, mesaiBitisTarihi FROM mesailer JOIN calisanlar ON calisanlar.calisanID = mesailer.calisanID","Mesailer");
            Islemler.LvDoldur(lvwMesaiListe, "Mesailer");
            cmbMesaiCalisanlar.SelectedIndex = -1;
            cmbBaslangicSaatler.SelectedIndex = -1;
            cmbBitisSaatler.SelectedIndex = -1;
        }

        private void btnMesaiKaydet_Click(object sender, EventArgs e)
        {
            if (cmbMesaiCalisanlar.SelectedIndex == -1 || cmbBaslangicSaatler.SelectedIndex == -1 || cmbBitisSaatler.SelectedIndex == -1)
            {
                MessageBox.Show("Tüm Alanları Doldurmalısınız!");
                return;
            }

            MesailerEntity mesai = new MesailerEntity();

            mesai.CalisanID = cmbMesaiCalisanlar.SelectedValue.ToInt32();
            mesai.MesaiBaslangicTarihi = dtpMesaiBaslangic.Value.Date.AddHours(cmbBaslangicSaatler.SelectedText.Split(':')[0].ToInt32());
            mesai.MesaiBitisTarihi = dtpMesaiBitis.Value.Date.AddHours(cmbBitisSaatler.SelectedText.Split(':')[0].ToInt32());
        }

        private void btnMesaiTemizle_Click(object sender, EventArgs e)
        {
            Islemler.FormTemizle(this);
        }

        private void btnMesaiSec_Click(object sender, EventArgs e)
        {
            if (lvwMesaiListe.SelectedItems.Count != 1)
            {
                MessageBox.Show("Bir Mesai Seçin!");
                return;
            }

            MesailerEntity mesai = mesailerDAL.getMesai(lvwMesaiListe.SelectedItems[0].SubItems[0].Text.ToInt32());

            cmbMesaiCalisanlar.SelectedIndex = mesai.CalisanID - 1;
            dtpMesaiBaslangic.Value = mesai.MesaiBaslangicTarihi.Date;
            dtpMesaiBitis.Value = mesai.MesaiBitisTarihi.Date;
            cmbBaslangicSaatler.SelectedText = mesai.MesaiBaslangicTarihi.TimeOfDay.ToString();
            cmbBitisSaatler.SelectedText = mesai.MesaiBitisTarihi.TimeOfDay.ToString();
        }
    }
}
