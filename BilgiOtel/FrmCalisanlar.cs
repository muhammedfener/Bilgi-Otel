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
            Islemler.DataTableDoldur("SELECT * FROM vw_calisanlarLv", "Calisanlar");
            Islemler.CmbDoldur(cmbMeslek,"Meslekler","SELECT * FROM vw_mesleklerCmb");
            Islemler.LvDoldur(lvwCalisanListesi, "Calisanlar");
        }

        private void btnCalisanSec_Click(object sender, EventArgs e)
        {
            btnCalisanTemizle.PerformClick();

            try
            {
                SeciliCalisan = calisanlarDAL.calisanGetirTC(lvwCalisanListesi.SelectedItems[0].SubItems[1].Text);

                txtAd.Text = SeciliCalisan.CalisanAd;
                txtSoyad.Text = SeciliCalisan.CalisanSoyad;
                txtTel.Text = SeciliCalisan.CalisanTelefon;
                txtTC.Text = SeciliCalisan.CalisanTCKimlik;
                rtxAdres.Text = SeciliCalisan.CalisanAdres;
                txtIrtibat.Text = SeciliCalisan.CalisanIrtibatTelefon;
                dtpIseBaslama.Value = SeciliCalisan.CalisanIseBaslamaTarihi;
                if (SeciliCalisan.CalisanIstenAyrilmaTarihi == dtpIstenAyrilma.MinDate)
                {
                    chkIseDevam.Checked = true;
                }
                else
                {
                    dtpIstenAyrilma.Value = SeciliCalisan.CalisanIstenAyrilmaTarihi;
                }
                cmbMeslek.SelectedValue = SeciliCalisan.CalisanMeslekID;
                nudSaatlikUcret.Value = SeciliCalisan.CalisanSaatlikUcret;
                chkCalisanAktifMi.Checked = SeciliCalisan.CalisanAktifMi;
            }
            catch
            {
                MessageBox.Show("Bir Hata Oluştu! Sistem Yöneticisiyle İletişime Geçin!");
            }
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
            SeciliCalisan.CalisanIstenAyrilmaTarihi = chkIseDevam.Checked ? dtpIstenAyrilma.MinDate : dtpIstenAyrilma.Value;
            SeciliCalisan.CalisanMeslekID = cmbMeslek.SelectedValue.ToInt32();
            SeciliCalisan.CalisanSaatlikUcret = nudSaatlikUcret.Value;
            SeciliCalisan.CalisanAktifMi = chkCalisanAktifMi.Checked;

            try
            {
                calisanlarDAL.calisanGuncelle(SeciliCalisan);
                Islemler.DataTableDoldur("SELECT * FROM vw_calisanlarLv", "Calisanlar", guncelle: true);
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
            if (!chkCalisanAktifMi.Checked)
            {
                MessageBox.Show("Yeni Ekleyeceğiniz Çalışan Aktif Olmalı!");
                return;
            }

            CalisanlarEntity YeniCalisan = new CalisanlarEntity();
            YeniCalisan.CalisanAd = txtAd.Text;
            YeniCalisan.CalisanSoyad = txtSoyad.Text;
            YeniCalisan.CalisanTelefon = txtTel.Text;
            YeniCalisan.CalisanTCKimlik = txtTC.Text;
            YeniCalisan.CalisanAdres = rtxAdres.Text;
            YeniCalisan.CalisanIrtibatTelefon = txtIrtibat.Text;
            YeniCalisan.CalisanIseBaslamaTarihi = dtpIseBaslama.Value;
            YeniCalisan.CalisanIstenAyrilmaTarihi = chkIseDevam.Checked ? dtpIstenAyrilma.MinDate : dtpIstenAyrilma.Value;
            YeniCalisan.CalisanMeslekID = cmbMeslek.SelectedValue.ToInt32();
            YeniCalisan.CalisanSaatlikUcret = nudSaatlikUcret.Value;
            YeniCalisan.CalisanAktifMi = chkCalisanAktifMi.Checked;
            
            try
            {
                calisanlarDAL.calisanEkle(YeniCalisan);
                Islemler.DataTableDoldur("SELECT * FROM vw_calisanlarLv", "Calisanlar", guncelle: true);
                Islemler.LvDoldur(lvwCalisanListesi, "Calisanlar");
                MessageBox.Show("Çalışan Başarıyla Eklendi!");
                Islemler.FormTemizle(this);
            }
            catch
            {
                MessageBox.Show("Çalışan Eklenirken Hata Oluştu!");
            }
        }

        private void chkIseDevam_CheckedChanged(object sender, EventArgs e)
        {
            if(chkIseDevam.Checked)
            {
                dtpIstenAyrilma.Enabled = false;
            }
            else
            {
                dtpIstenAyrilma.Enabled = true;
            }
        }

        private void yenileButon_Click(object sender, EventArgs e)
        {
            FrmCalisanlar_Load(null, EventArgs.Empty);
        }

        private void duzenleButon_Click(object sender, EventArgs e)
        {
            if (lvwCalisanListesi.SelectedItems.Count != 1)
            {
                MessageBox.Show("Lütfen Düzenlemek İçin Bir Çalışan Seçin!");
                return;
            }

            btnCalisanSec.PerformClick();
        }

        private void silButon_Click(object sender, EventArgs e)
        {
            if (lvwCalisanListesi.SelectedItems.Count != 1)
            {
                MessageBox.Show("Lütfen Silmek İçin Bir Çalışan Seçin!");
                return;
            }

            try
            {
                calisanlarDAL.calisanSilTC(lvwCalisanListesi.SelectedItems[0].SubItems[1].Text);
            }
            catch
            {
                MessageBox.Show("Çalışan Silinirken Bir Hata Oluştu!");
            }
        }
    }
}
