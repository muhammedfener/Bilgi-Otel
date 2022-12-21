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
        MesailerEntity secilenMesai = new MesailerEntity();
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

            try
            {
                MesailerEntity mesai = new MesailerEntity();

                mesai.CalisanID = cmbMesaiCalisanlar.SelectedValue.ToInt32();
                mesai.MesaiBaslangicTarihi = dtpMesaiBaslangic.Value.Date.AddHours(cmbBaslangicSaatler.Text.Split(':')[0].ToInt32());
                mesai.MesaiBitisTarihi = dtpMesaiBitis.Value.Date.AddHours(cmbBitisSaatler.Text.Split(':')[0].ToInt32());

                mesailerDAL.insertMesai(mesai);
                MessageBox.Show("Mesai Başarıyla Eklendi!");
                Islemler.DataTableDoldur("SELECT mesaiID,(calisanAd + ' ' + calisanSoyad) as CalisanAdSoyad, mesaiBaslangicTarihi, mesaiBitisTarihi FROM mesailer JOIN calisanlar ON calisanlar.calisanID = mesailer.calisanID", "Mesailer", guncelle: true);
                Islemler.LvDoldur(lvwMesaiListe, "Mesailer");
                Islemler.FormTemizle(this);
            }
            catch
            {
                MessageBox.Show("Mesai Eklenirken Hata Oluştu!");
            }
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

            secilenMesai = mesai;
            cmbMesaiCalisanlar.SelectedIndex = mesai.CalisanID - 1;
            dtpMesaiBaslangic.Value = mesai.MesaiBaslangicTarihi.Date;
            dtpMesaiBitis.Value = mesai.MesaiBitisTarihi.Date;
            cmbBaslangicSaatler.SelectedText = mesai.MesaiBaslangicTarihi.TimeOfDay.ToString();
            cmbBitisSaatler.SelectedText = mesai.MesaiBitisTarihi.TimeOfDay.ToString();
        }

        private void btnMesaiDuzenle_Click(object sender, EventArgs e)
        {
            if(secilenMesai.MesaiID == 0)
            {
                MessageBox.Show("Düzenlemek İçin Bir Mesai Seçin!");
                return;
            }
            try
            {
                MesailerEntity mesai = new MesailerEntity();
                mesai.MesaiID = secilenMesai.MesaiID;
                mesai.CalisanID = secilenMesai.CalisanID;
                mesai.MesaiBaslangicTarihi = dtpMesaiBaslangic.Value.Date.AddHours(cmbBaslangicSaatler.Text.Split(':')[0].ToInt32());
                mesai.MesaiBitisTarihi = dtpMesaiBitis.Value.Date.AddHours(cmbBitisSaatler.Text.Split(':')[0].ToInt32());

                mesailerDAL.updateMesai(mesai);
                secilenMesai = null;
                MessageBox.Show("Mesai Başarıyla Düzenlendi!");
                Islemler.DataTableDoldur("SELECT mesaiID,(calisanAd + ' ' + calisanSoyad) as CalisanAdSoyad, mesaiBaslangicTarihi, mesaiBitisTarihi FROM mesailer JOIN calisanlar ON calisanlar.calisanID = mesailer.calisanID", "Mesailer",guncelle: true);
                Islemler.LvDoldur(lvwMesaiListe, "Mesailer");
                Islemler.FormTemizle(this);
            }
            catch
            {
                MessageBox.Show("Mesai Düzenlenirken Hata Oluştu!");
            }
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(lvwMesaiListe.SelectedItems.Count != 1)
            {
                MessageBox.Show("Düzenlemek İçin Bir Mesai Seçin!");
                return;
            }

            btnMesaiSec.PerformClick();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if(lvwMesaiListe.SelectedItems.Count != 1)
            {
                MessageBox.Show("Silmek İçin Bir Mesai Seçin!");
                return;
            }

            try
            {
                mesailerDAL.deleteMesai(lvwMesaiListe.SelectedItems[0].SubItems[0].Text.ToInt32());
                MessageBox.Show("Mesai Başarıyla Silindi!");
            }
            catch
            {
                MessageBox.Show("Mesai Silinirken Hata Oluştu!");
            }
        }
    }
}
