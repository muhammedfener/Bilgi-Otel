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
    public partial class FrmKampanyalar : Form
    {
        KampanyalarDAL kampanyalarDAL = new KampanyalarDAL();
        int seciliKampanyaID;
        public FrmKampanyalar()
        {
            InitializeComponent();
        }

        private void FrmKampanyalar_Load(object sender, EventArgs e)
        {
            Islemler.DataTableDoldur("SELECT * FROM vw_kampanyalarLv","Kampanyalar");
            Islemler.LvDoldur(lvwKampanyalar, "Kampanyalar");
        }

        private void btnKampanyaSec_Click(object sender, EventArgs e)
        {
            try
            {
                KampanyalarEntity kampanya = kampanyalarDAL.kampanyaGetirID(lvwKampanyalar.SelectedItems[0].SubItems[0].Text.ToInt32());
                seciliKampanyaID = kampanya.KampanyaID;
                txtKampanyaAd.Text = kampanya.KampanyaAd;
                txtIndirimOrani.Text = kampanya.KampanyaIndirimOrani.ToString();
                dtpKampanyaBaslangic.Value = kampanya.KampanyaBaslangic;
                dtpKampanyaBitis.Value = kampanya.KampanyaBitis;
                rtxKampanyaAciklama.Text = kampanya.KampanyaAciklama;
                chkKampanya.Checked = kampanya.KampanyaAktifMi;
            }
            catch
            {
                MessageBox.Show("Kampanya Getirilirken Hata Oluştu!");
            }
        }

        private void btnKampanyaDuzenle_Click(object sender, EventArgs e)
        {
            if(seciliKampanyaID == 0)
            {
                MessageBox.Show("Düzenlemek İçin Bir Kampanya Seçin!");
                return;
            }

            KampanyalarEntity kampanya = new KampanyalarEntity();
            kampanya.KampanyaID = seciliKampanyaID;
            kampanya.KampanyaAd = txtKampanyaAd.Text;
            kampanya.KampanyaIndirimOrani = txtIndirimOrani.Text.ToDecimal();
            kampanya.KampanyaBaslangic = dtpKampanyaBaslangic.Value;
            kampanya.KampanyaBitis = dtpKampanyaBitis.Value;
            kampanya.KampanyaAciklama = rtxKampanyaAciklama.Text;
            kampanya.KampanyaAktifMi = chkKampanya.Checked;
            try
            {
                kampanyalarDAL.kampanyaGuncelle(kampanya);
                seciliKampanyaID = 0;
            }
            catch
            {
                MessageBox.Show("Kampanya Güncellenirken Hata Oluştu!");
            }
        }

        private void btnKampanyaKaydet_Click(object sender, EventArgs e)
        {
            KampanyalarEntity kampanya = new KampanyalarEntity();
            kampanya.KampanyaAd = txtKampanyaAd.Text;
            kampanya.KampanyaIndirimOrani = txtIndirimOrani.Text.ToDecimal();
            kampanya.KampanyaBaslangic = dtpKampanyaBaslangic.Value;
            kampanya.KampanyaBitis = dtpKampanyaBitis.Value;
            kampanya.KampanyaAciklama = rtxKampanyaAciklama.Text;
            kampanya.KampanyaAktifMi = chkKampanya.Checked;

            try
            {
                kampanyalarDAL.kampanyaEkle(kampanya);

            }
            catch
            {
                MessageBox.Show("Kampanya Eklenirken Hata Oluştu!");
            }
        }

        private void lvwKampanyalar_DoubleClick(object sender, EventArgs e)
        {
            btnKampanyaSec.PerformClick();
        }

        private void yenileButon_Click(object sender, EventArgs e)
        {
            FrmKampanyalar_Load(null, EventArgs.Empty);
        }

        private void duzenleButon_Click(object sender, EventArgs e)
        {
            if(lvwKampanyalar.SelectedItems.Count != 1)
            {
                MessageBox.Show("Düzenlemek İçin Bir Kampanya Seçin!");
                return;
            }
            btnKampanyaSec.PerformClick();
        }

        private void silButon_Click(object sender, EventArgs e)
        {
            if (lvwKampanyalar.SelectedItems.Count != 1)
            {
                MessageBox.Show("Silmek İçin Bir Kampanya Seçin!");
                return;
            }

            try
            {
                kampanyalarDAL.kampanyaSil(lvwKampanyalar.SelectedItems[0].SubItems[0].Text.ToInt32());
            }
            catch
            {
                MessageBox.Show("Kampanya Silinirken Hata Oluştu!");
            }
        }
    }
}
