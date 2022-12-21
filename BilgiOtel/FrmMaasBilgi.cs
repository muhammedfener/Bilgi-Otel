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
    public partial class FrmMaasBilgi : Form
    {
        public FrmMaasBilgi()
        {
            InitializeComponent();
        }

        private void FrmMaasBilgi_Load(object sender, EventArgs e)
        {
            YoneticiMaasGetir();
        }

        private void YoneticiMaasGetir()
        {
            DataTable dt = SQLHelper.GetDataTable("SELECT (yoneticiAd + ' ' + yoneticiSoyad) as yoneticiAdSoyad, yoneticiTCKimlik, meslekAd, yoneticiMaas  FROM yoneticiler JOIN meslekler ON meslekler.meslekID = yoneticiler.yoneticiMeslekID");

            foreach (DataRow dr in dt.Rows)
            {
                string[] satir = { dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), "", "", "", dr[3].IsDBNull() ? "" : dr[3].ToString() + " TL" };
                ListViewItem item = new ListViewItem(satir);
                lvwMaasBilgi.Items.Add(item);
            }
        }

        private void CalisanMaasGetir()
        {
            DataTable dt = SQLHelper.GetDataTable("SELECT (calisanAd + ' ' + calisanSoyad) as calisanAdSoyad, calisanTCKimlik, meslekAd, calisanSaatlikUcret, ");
        }

    }
}
