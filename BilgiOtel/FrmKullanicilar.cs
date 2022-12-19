using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BilgiOtelDAL;
using Entity;

namespace BilgiOtel
{
    public partial class FrmKullanicilar : Form
    {
        KullanicilarDAL kullanicilarDAL = new KullanicilarDAL();
        int secilenKullaniciID = 0;

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
            cmbKullaniciCalisan.SelectedIndex = -1;
            cmbKullaniciYonetici.SelectedIndex = -1;
        }

        private void btnKullaniciEkle_Click(object sender, EventArgs e)
        {
            if (cmbKullaniciCalisan.SelectedIndex == -1 && cmbKullaniciYonetici.SelectedIndex == -1)
            {
                MessageBox.Show("Kullanıcı Hem Yönetici veya Çalışan Olamaz!");
                Islemler.FormTemizle(this);
                return;
            }

            try
            {

                KullanicilarEntity kullanici = new KullanicilarEntity();

                kullanici.KullaniciAdi = txtKullaniciAd.Text;
                kullanici.KullaniciSifre = txtKullaniciSifre.Text;
                kullanici.KullaniciMail = txtKullaniciMail.Text;
                kullanici.KullaniciCalisanID = cmbKullaniciCalisan.SelectedIndex == -1 ? 0 : cmbKullaniciCalisan.SelectedValue.ToInt32();
                kullanici.KullaniciYoneticiID = cmbKullaniciYonetici.SelectedIndex == -1 ? 0 : cmbKullaniciYonetici.SelectedValue.ToInt32();
                kullanici.KullaniciKayitTarihi = DateTime.Now;
                kullanici.KullaniciAktifMi = chkKullaniciAktifMi.Checked;
                kullanicilarDAL.kullaniciEkle(kullanici);
                MessageBox.Show("Kullanıcı Başarıyla Eklendi!");
                Islemler.FormTemizle(this);
                Islemler.DataTableDoldur("SELECT * FROM vw_kulllanicilarLv", "Kullanicilar", guncelle: true);
                Islemler.LvDoldur(lvwKullaniciListe, "Kullanicilar");
            }
            catch
            {
                MessageBox.Show("Kullanıcı Eklenirken Hata Oluştu!");
            }
        }

        private void btnKullaniciDuzenle_Click(object sender, EventArgs e)
        {
            if(cmbKullaniciCalisan.SelectedIndex == -1 && cmbKullaniciYonetici.SelectedIndex == -1)
            {
                MessageBox.Show("Kullanıcı Hem Yönetici veya Çalışan Olamaz!");
                Islemler.FormTemizle(this);
                return;
            }
            if(secilenKullaniciID == 0)
            {
                MessageBox.Show("Önce Bir Kullanıcı Seçin!");
                return;
            }
            try
            {
                KullanicilarEntity kullanici = new KullanicilarEntity();
                kullanici.KullaniciID = secilenKullaniciID;
                kullanici.KullaniciAdi = txtKullaniciAd.Text;
                kullanici.KullaniciSifre = txtKullaniciAd.Text;
                kullanici.KullaniciMail = txtKullaniciMail.Text;
                kullanici.KullaniciCalisanID = cmbKullaniciCalisan.SelectedIndex == -1 ? 0 : cmbKullaniciCalisan.SelectedValue.ToInt32();
                kullanici.KullaniciYoneticiID = cmbKullaniciYonetici.SelectedIndex == -1 ? 0 : cmbKullaniciYonetici.SelectedValue.ToInt32();
                kullanici.KullaniciAktifMi = chkKullaniciAktifMi.Checked;

                kullanicilarDAL.kullaniciGuncelle(kullanici);
                MessageBox.Show("Kullanıcı Başarıyla Güncellendi!");
                Islemler.FormTemizle(this);
                Islemler.DataTableDoldur("SELECT * FROM vw_kulllanicilarLv", "Kullanicilar",guncelle: true);
                Islemler.LvDoldur(lvwKullaniciListe, "Kullanicilar");
                secilenKullaniciID = 0;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Kullanıcı Düzenlenirken Hata Oluştu!" + ex.Message);
            }
        }

        private void btnKullaniciSec_Click(object sender, EventArgs e)
        {
            if(lvwKullaniciListe.SelectedItems.Count != 1)
            {
                MessageBox.Show("Bir Kullanıcı Seçin!");
                return;
            }
            try
            {
                Islemler.FormTemizle(this);
                KullanicilarEntity kullanici = kullanicilarDAL.kullaniciGetirMail(lvwKullaniciListe.SelectedItems[0].SubItems[2].Text);
                secilenKullaniciID = kullanici.KullaniciID;
                txtKullaniciAd.Text = kullanici.KullaniciAdi;
                txtKullaniciSifre.Text = kullanici.KullaniciSifre;
                txtKullaniciMail.Text = kullanici.KullaniciMail;
                cmbKullaniciCalisan.SelectedIndex = kullanici.KullaniciCalisanID == 0 ? -1 : kullanici.KullaniciCalisanID-1;
                cmbKullaniciYonetici.SelectedIndex = kullanici.KullaniciYoneticiID == 0 ? -1 : kullanici.KullaniciYoneticiID-1;
                chkKullaniciAktifMi.Checked = kullanici.KullaniciAktifMi;
            }
            catch
            {
                MessageBox.Show("Kullanıcı Seçilirken Bir Hata Oluştu!");
            }
        }

        private void lvwKullaniciListe_DoubleClick(object sender, EventArgs e)
        {
            btnKullaniciSec.PerformClick();
        }

        private void btnKullaniciTemizle_Click(object sender, EventArgs e)
        {
            Islemler.FormTemizle(this);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (lvwKullaniciListe.SelectedItems.Count != 1)
            {
                MessageBox.Show("Düzenlemek İçin Bir Kullanıcı Seçin!");
                return;
            }

            btnKullaniciSec.PerformClick();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if(lvwKullaniciListe.SelectedItems.Count != 1)
            {
                MessageBox.Show("Silmek İçin Bir Kullanıcı Seçin!");
                return;
            }

            try
            {
                kullanicilarDAL.kullaniciSil(lvwKullaniciListe.SelectedItems[0].SubItems[2].Text);
                MessageBox.Show("Kullanıcı Başarıyla Silindi!");
                Islemler.DataTableDoldur("SELECT * FROM vw_kulllanicilarLv", "Kullanicilar", guncelle: true);
                Islemler.LvDoldur(lvwKullaniciListe, "Kullanicilar");
            }
            catch
            {
                MessageBox.Show("Kullanıcı Silinirken Hata Oluştu!");
            }
        }
    }
}
