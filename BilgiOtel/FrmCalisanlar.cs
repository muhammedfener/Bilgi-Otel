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
    public partial class FrmCalisanlar : Form
    {
        CalisanlarDAL calisanlarDAL = new CalisanlarDAL();
        CalisanlarEntity SeciliCalisan;
        public FrmCalisanlar()
        {
            InitializeComponent();
        }

        private void FrmCalisanlar_Load(object sender, EventArgs e)
        {
            Islemler.DataTableDoldur("SELECT (calisanAd + ' ' + calisanSoyad) as [Ad Soyad], calisanTCKimlik, calisanTelefon, meslekAd, calisanAdres, calisanSaatlikUcret FROM calisanlar JOIN meslekler ON meslekler.meslekID = calisanlar.calisanMeslekID WHERE calisanAktifMi=1", "Calisanlar");
            ComboBox[] MeslekCmbler = { cmbMeslek };
            //Islemler.CmbDoldur(MeslekCmbler,Islemler.Meslekler);
            Islemler.LvDoldur(lvwCalisanListesi, "Calisanlar");
        }

        private void btnCalisanSec_Click(object sender, EventArgs e)
        {
            btnCalisanTemizle.PerformClick();

            SeciliCalisan = calisanlarDAL.getCalisanTC(lvwCalisanListesi.SelectedItems[0].SubItems[1].Text);

            txtAd.Text = SeciliCalisan.CalisanAd;
            txtSoyad.Text = SeciliCalisan.CalisanSoyad;
            txtTel.Text = SeciliCalisan.CalisanTelefon;
            txtTC.Text = SeciliCalisan.CalisanTCKimlik;
            rtxAdres.Text = SeciliCalisan.CalisanAdres;
            txtIrtibat.Text = SeciliCalisan.CalisanIrtibatTelefon;
            dtpIseBaslama.Value = SeciliCalisan.CalisanIseBaslamaTarihi;
            dtpIstenAyrilma.Value = SeciliCalisan.CalisanIstenAyrilmaTarihi;
            cmbMeslek.SelectedValue = SeciliCalisan.CalisanMeslekID;
            nudSaatlikUcret.Value = SeciliCalisan.CalisanSaatlikUcret;
        }

        private void btnCalisanTemizle_Click(object sender, EventArgs e)
        {
            Islemler.FormTemizle(this);
        }

        private void lvwCalisanListesi_DoubleClick(object sender, EventArgs e)
        {
            btnCalisanSec.PerformClick();
        }

        private void btnCalisanDuzenle_Click(object sender, EventArgs e)
        {
            if(SeciliCalisan == null)
            {
                MessageBox.Show("Bir Çalışan Seçin!");
                return;
            }
            SeciliCalisan.CalisanAd = txtAd.Text;
            SeciliCalisan.CalisanSoyad = txtSoyad.Text;
            SeciliCalisan.CalisanTelefon = txtTel.Text;
            SeciliCalisan.CalisanTCKimlik = txtTC.Text;
            SeciliCalisan.CalisanAdres = rtxAdres.Text;
            SeciliCalisan.CalisanIrtibatTelefon = txtIrtibat.Text;
            SeciliCalisan.CalisanIseBaslamaTarihi = dtpIseBaslama.Value;
            SeciliCalisan.CalisanIstenAyrilmaTarihi = dtpIstenAyrilma.Value;
            SeciliCalisan.CalisanMeslekID = cmbMeslek.SelectedValue.ToInt32();
            SeciliCalisan.CalisanSaatlikUcret = nudSaatlikUcret.Value;

            try
            {
                calisanlarDAL.updateCalisan(SeciliCalisan);
                Islemler.DataTableDoldur("SELECT (calisanAd + ' ' + calisanSoyad) as [Ad Soyad], calisanTCKimlik, calisanTelefon, meslekAd, calisanAdres, calisanSaatlikUcret FROM calisanlar JOIN meslekler ON meslekler.meslekID = calisanlar.calisanMeslekID WHERE calisanAktifMi=1", "Calisanlar", true);
                Islemler.LvDoldur(lvwCalisanListesi, "Calisanlar");
                MessageBox.Show("Çalışan Başarıyla Güncellendi!");
                Islemler.FormTemizle(this);
                SeciliCalisan = null;
            }
            catch
            {
                MessageBox.Show("Çalışan Güncellenirken Hata Oluştu!");
            }
        }

        private void btnCalisanKaydet_Click(object sender, EventArgs e)
        {
            CalisanlarEntity YeniCalisan = new CalisanlarEntity();
            YeniCalisan.CalisanAd = txtAd.Text;
            YeniCalisan.CalisanSoyad = txtSoyad.Text;
            YeniCalisan.CalisanTelefon = txtTel.Text;
            YeniCalisan.CalisanTCKimlik = txtTC.Text;
            YeniCalisan.CalisanAdres = rtxAdres.Text;
            YeniCalisan.CalisanIrtibatTelefon = txtIrtibat.Text;
            YeniCalisan.CalisanIseBaslamaTarihi = dtpIseBaslama.Value;
            YeniCalisan.CalisanIstenAyrilmaTarihi = dtpIstenAyrilma.Value;
            YeniCalisan.CalisanMeslekID = cmbMeslek.SelectedValue.ToInt32();
            YeniCalisan.CalisanSaatlikUcret = nudSaatlikUcret.Value;
            YeniCalisan.CalisanAktifMi = true;
            
            try
            {
                calisanlarDAL.insertCalisan(YeniCalisan);
                Islemler.DataTableDoldur("SELECT (calisanAd + ' ' + calisanSoyad) as [Ad Soyad], calisanTCKimlik, calisanTelefon, meslekAd, calisanAdres, calisanSaatlikUcret FROM calisanlar JOIN meslekler ON meslekler.meslekID = calisanlar.calisanMeslekID WHERE calisanAktifMi=1", "Calisanlar", true);
                Islemler.LvDoldur(lvwCalisanListesi, "Calisanlar");
                MessageBox.Show("Çalışan Başarıyla Eklendi!");
                Islemler.FormTemizle(this);
            }
            catch
            {
                MessageBox.Show("Çalışan Eklenirken Hata Oluştu!");
            }
        }
    }
}
