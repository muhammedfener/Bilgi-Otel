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
        KampanyalarEntity SeciliKampanya;
        public FrmKampanyalar()
        {
            InitializeComponent();
        }

        private void FrmKampanyalar_Load(object sender, EventArgs e)
        {
            Islemler.DataTableDoldur("SELECT kampanyaAd, kampanyaIndirimOrani, kampanyaBaslangic, kampanyaBitis, kampanyaAciklama FROM kampanyalar","Kampanyalar");
            Islemler.LvDoldur(lvwKampanyalar, "Kampanyalar");
        }

        private void btnKampanyaSec_Click(object sender, EventArgs e)
        {
            KampanyalarEntity kampanya = kampanyalarDAL.getKampanya(lvwKampanyalar.SelectedItems[0].SubItems[0].Text);
            SeciliKampanya = kampanya;
            txtKampanyaAd.Text = kampanya.KampanyaAd;
            txtIndirimOrani.Text = kampanya.KampanyaIndirimOrani.ToString();
            dtpKampanyaBaslangic.Value = kampanya.KampanyaBaslangic;
            dtpKampanyaBitis.Value = kampanya.KampanyaBitis;
            rtxKampanyaAciklama.Text = kampanya.KampanyaAciklama;
            chkKampanya.Checked = kampanya.KampanyaAktifMi;
        }

        private void btnKampanyaDuzenle_Click(object sender, EventArgs e)
        {
            KampanyalarEntity kampanya = new KampanyalarEntity();
            kampanya.KampanyaID = SeciliKampanya.KampanyaID;
            kampanya.KampanyaAd = txtKampanyaAd.Text;
            kampanya.KampanyaIndirimOrani = txtIndirimOrani.Text.ToDecimal();
            kampanya.KampanyaBaslangic = dtpKampanyaBaslangic.Value;
            kampanya.KampanyaBitis = dtpKampanyaBitis.Value;
            kampanya.KampanyaAciklama = rtxKampanyaAciklama.Text;
            kampanya.KampanyaAktifMi = chkKampanya.Checked;

            kampanyalarDAL.updateKampanyalar(kampanya);
            SeciliKampanya = null;
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

            kampanyalarDAL.insertKampanya(kampanya);
        }

        private void lvwKampanyalar_DoubleClick(object sender, EventArgs e)
        {
            btnKampanyaSec.PerformClick();
        }
    }
}
