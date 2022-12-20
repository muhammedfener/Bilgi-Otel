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
    public partial class FrmCalismaSaatleri : Form
    { 
        CalismaSaatleriDAL calismaSaatleriDAL = new CalismaSaatleriDAL();
        int calismaSaatiID = 0;
        public FrmCalismaSaatleri()
        {
            InitializeComponent();
        }

        private void FrmCalismaSaatleri_Load(object sender, EventArgs e)
        {
            Islemler.CmbDoldur(cmbCalisanlar, "Calisanlar", "SELECT calisanID, (calisanAd + ' ' + calisanSoyad) as CalisanAdSoyad FROM calisanlar WHERE calisanAktifMi = 1");
            Islemler.CmbDoldur(cmbVardiyalar, "Vardiyalar", "SELECT vardiyaID, vardiyaAralik FROM vardiyalar");
            Islemler.DataTableDoldur("SELECT calismaSaatleriID,(calisanAd + ' ' + calisanSoyad) as CalisanAdSoyad, vardiyaAralik, calismaBaslangicTarihi, calismaBitisTarihi FROM calismaSaatleri JOIN calisanlar ON calisanlar.calisanID = calismaSaatleri.calisanID JOIN vardiyalar ON vardiyalar.vardiyaID = calismaSaatleri.vardiyaID WHERE DATEPART(mm,calismaBaslangicTarihi) > DATEPART(mm,GETDATE())-2", "CalismaSaatleri");
            Islemler.LvDoldur(lvwCalismaSaatleri, "CalismaSaatleri", true);
            cmbCalisanlar.SelectedIndex = -1;
            cmbVardiyalar.SelectedIndex = -1;
        }

        private void btnCalismaSaatiSec_Click(object sender, EventArgs e)
        {
            if(lvwCalismaSaatleri.SelectedItems.Count != 1)
            {
                MessageBox.Show("Bir Çalışma Saati Seçin!");
                return;
            }

            try
            {
                CalismaSaatleriEntity calismaSaati = calismaSaatleriDAL.calismaSaatiGetir(lvwCalismaSaatleri.SelectedItems[0].SubItems[0].Text.ToInt32());
                calismaSaatiID = calismaSaati.CalismaSaatleriID;
                cmbCalisanlar.SelectedValue = calismaSaati.CalisanID;
                cmbVardiyalar.SelectedValue = calismaSaati.VardiyaID;
                dtpCalismaBaslangic.Value = calismaSaati.CalismaBaslangicTarihi;
                dtpCalismaBitis.Value = calismaSaati.CalismaBitisTarihi;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Çalışma Saati Seçilirken Hata Oluştu!" + ex.Message);
            }
        }

        private void btnCalismaGuncelle_Click(object sender, EventArgs e)
        {
            if(calismaSaatiID == 0)
            {
                MessageBox.Show("Güncellemek İçin Önce Bir Çalışma Saati Seçin!");
                return;
            }

            if (dtpCalismaBitis.Value.Subtract(dtpCalismaBaslangic.Value).TotalDays > 5)
            {
                MessageBox.Show("Çalışma Aralığı 6 Günden Fazla Olamaz!");
                return;
            }

            try
            {
                CalismaSaatleriEntity calismaSaati = new CalismaSaatleriEntity();
                calismaSaati.CalismaSaatleriID = calismaSaatiID;
                calismaSaati.CalisanID = cmbCalisanlar.SelectedValue.ToInt32();
                calismaSaati.VardiyaID = cmbVardiyalar.SelectedValue.ToInt32();
                calismaSaati.CalismaBaslangicTarihi = dtpCalismaBaslangic.Value;
                calismaSaati.CalismaBitisTarihi = dtpCalismaBitis.Value;

                calismaSaatleriDAL.calismaSaatiGuncelle(calismaSaati);
                MessageBox.Show("Çalışma Saati Başarıyla Güncellendi!");
                Islemler.DataTableDoldur("SELECT calismaSaatleriID,(calisanAd + ' ' + calisanSoyad) as CalisanAdSoyad, vardiyaAralik, calismaBaslangicTarihi, calismaBitisTarihi FROM calismaSaatleri JOIN calisanlar ON calisanlar.calisanID = calismaSaatleri.calisanID JOIN vardiyalar ON vardiyalar.vardiyaID = calismaSaatleri.vardiyaID WHERE DATEPART(mm,calismaBaslangicTarihi) > DATEPART(mm,GETDATE())-2", "CalismaSaatleri", guncelle: true);
                Islemler.LvDoldur(lvwCalismaSaatleri, "CalismaSaatleri", true);
                Islemler.FormTemizle(this);
                calismaSaatiID = 0;
            }
            catch
            {
                MessageBox.Show("Çalışma Saati Güncellenirken Hata Oluştu!");
            }
        }

        private void btnCalismaKaydet_Click(object sender, EventArgs e)
        {
            if (dtpCalismaBitis.Value.Subtract(dtpCalismaBaslangic.Value).TotalDays > 5)
            {
                MessageBox.Show("Çalışma Aralığı 6 Günden Fazla Olamaz!");
                return;
            }

            try
            {
                CalismaSaatleriEntity calismaSaati = new CalismaSaatleriEntity();
                calismaSaati.CalismaSaatleriID = calismaSaatiID;
                calismaSaati.CalisanID = cmbCalisanlar.SelectedValue.ToInt32();
                calismaSaati.VardiyaID = cmbVardiyalar.SelectedValue.ToInt32();
                calismaSaati.CalismaBaslangicTarihi = dtpCalismaBaslangic.Value;
                calismaSaati.CalismaBitisTarihi = dtpCalismaBitis.Value;

                calismaSaatleriDAL.calismaSaatiEkle(calismaSaati);
                MessageBox.Show("Çalışma Saati Başarıyla Eklendi!");
                Islemler.DataTableDoldur("SELECT calismaSaatleriID,(calisanAd + ' ' + calisanSoyad) as CalisanAdSoyad, vardiyaAralik, calismaBaslangicTarihi, calismaBitisTarihi FROM calismaSaatleri JOIN calisanlar ON calisanlar.calisanID = calismaSaatleri.calisanID JOIN vardiyalar ON vardiyalar.vardiyaID = calismaSaatleri.vardiyaID WHERE DATEPART(mm,calismaBaslangicTarihi) > DATEPART(mm,GETDATE())-2", "CalismaSaatleri", guncelle: true);
                Islemler.LvDoldur(lvwCalismaSaatleri, "CalismaSaatleri", true);
                Islemler.FormTemizle(this);
                calismaSaatiID = 0;
            }
            catch
            {
                MessageBox.Show("Çalışma Saati Eklenirken Hata Oluştu!");
            }
        }

        private void btnCalismaSaatiTemizle_Click(object sender, EventArgs e)
        {
            Islemler.FormTemizle(this);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(lvwCalismaSaatleri.SelectedItems.Count != 1)
            {
                MessageBox.Show("Düzenlemek İçin Bir Çalışma Saati Seçin!");
                return;
            }

            btnCalismaSaatiSec.PerformClick();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (lvwCalismaSaatleri.SelectedItems.Count != 1)
            {
                MessageBox.Show("Silmek İçin Bir Çalışma Saati Seçin!");
                return;
            }

            try
            {
                calismaSaatleriDAL.calismaSaatiSil(lvwCalismaSaatleri.SelectedItems[0].SubItems[0].Text.ToInt32());
                MessageBox.Show("Çalışma Saati Başarıyla Silindi!");
                Islemler.DataTableDoldur("SELECT calismaSaatleriID,(calisanAd + ' ' + calisanSoyad) as CalisanAdSoyad, vardiyaAralik, calismaBaslangicTarihi, calismaBitisTarihi FROM calismaSaatleri JOIN calisanlar ON calisanlar.calisanID = calismaSaatleri.calisanID JOIN vardiyalar ON vardiyalar.vardiyaID = calismaSaatleri.vardiyaID WHERE DATEPART(mm,calismaBaslangicTarihi) > DATEPART(mm,GETDATE())-2", "CalismaSaatleri", guncelle: true);
                Islemler.LvDoldur(lvwCalismaSaatleri, "CalismaSaatleri", true);
            }
            catch
            {
                MessageBox.Show("Çalışma Saati Silinirken Bir Hata Oluştu!");
            }
        }
    }
}
