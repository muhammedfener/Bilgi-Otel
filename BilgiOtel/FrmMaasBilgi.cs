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
            DataTable dt = SQLHelper.GetDataTable("SELECT (yoneticiAd + ' ' + yoneticiSoyad) as yoneticiAdSoyad, yoneticiTCKimlik, meslekAd, yoneticiMaas  FROM yoneticiler JOIN meslekler ON meslekler.meslekID = yoneticiler.yoneticiMeslekID WHERE yoneticiAktifMi=1");

            foreach (DataRow dr in dt.Rows)
            {
                string[] satir = { dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), "", "", "", dr[3].IsDBNull() ? "" : dr[3].ToString() + " TL" };
                ListViewItem item = new ListViewItem(satir);
                lvwMaasBilgi.Items.Add(item);
            }
        }

        private void CalisanMaasGetir(int Ay)
        {
            DataTable calisanIDs = SQLHelper.GetDataTable("SELECT calisanID, (calisanAd + ' ' + calisanSoyad) as calisanAdSoyad,calisanTCKimlik, meslekAd, calisanSaatlikUcret FROM calisanlar JOIN meslekler ON meslekler.meslekID = calisanlar.calisanMeslekID WHERE calisanAktifMi=1");

            DataTable CalismaSaatleri = SQLHelper.GetDataTable($"SELECT calisanID, calismaBaslangicTarihi, calismaBitisTarihi, calismaSuresi FROM calismaSaatleri JOIN calisanlar ON calisanlar.calisanID = calismaSaatleri.calisanID WHERE DATEPART(month,calismaBitisTarihi) = {Ay} OR DATEPART(month,calismaBaslangicTarihi) = {Ay}");

            DataTable VardiyaSaatleri = SQLHelper.GetDataTable($"SELECT calisanID, mesaiBaslangicTarihi, mesaiBitisTarihi, mesaiSuresi FROM mesailer WHERE DATEPART(month,mesaiBitisTarihi) = {Ay} OR DATEPART(month,mesaiBaslangicTarihi) = {Ay}");

            foreach (DataRow calisan in calisanIDs.Rows)
            {
                string sorgu = "calisanID = " + calisan[0].ToString();
                DataRow[] calisanSaatler = CalismaSaatleri.Select(sorgu);

                string calisanAdSoyad = calisan["calisanAdSoyad"].ToString(), tckimlik = calisan["calisanTCKimlik"].ToString(), meslekAd = calisan["meslekAd"].ToString();
                decimal saatlikUcret = calisan["calisanSaatlikUcret"].ToDecimal(), aylikMesaiUcreti = 0, aylikToplamUcret = 0;
                int calismaGunSayisi = 0, mesaiSaatSayisi = 0;

                foreach (DataRow calismaSaati in calisanSaatler)
                {
                    if (calismaSaati["calismaBaslangicTarihi"].ToDateTime().Date.Month == Ay && calismaSaati["calismaBitisTarihi"].ToDateTime().Date.Month == Ay)
                    {
                        calismaGunSayisi += calismaSaati["calismaSuresi"].ToInt32();
                    }
                    else if(calismaSaati["calismaBaslangicTarihi"].ToDateTime().Date.Month != Ay && calismaSaati["calismaBitisTarihi"].ToDateTime().Date.Month == Ay)
                    {
                        DateTime date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                        int fark = calismaSaati["calismaBitisTarihi"].ToDateTime().Subtract(date).TotalDays.ToInt32();
                        calismaGunSayisi += fark;
                    }
                    else if(calismaSaati["calismaBaslangicTarihi"].ToDateTime().Date.Month == Ay && calismaSaati["calismaBitisTarihi"].ToDateTime().Date.Month != Ay)
                    {
                        DateTime date = new DateTime(DateTime.Now.Year, Ay, DateTime.DaysInMonth(DateTime.Now.Year, Ay));
                        int fark = date.Subtract(calismaSaati["calismaBaslangicTarihi"].ToDateTime()).TotalDays.ToInt32();
                        calismaGunSayisi += fark;
                    }
                    else
                    {
                        continue;
                    }
                }

                DataRow[] vardiyaSaatler = VardiyaSaatleri.Select(sorgu);
                foreach(DataRow vardiyaSaat in vardiyaSaatler)
                {
                    if (vardiyaSaat["calismaBaslangicTarihi"].ToDateTime().Date.Month == Ay && vardiyaSaat["calismaBitisTarihi"].ToDateTime().Date.Month == Ay)
                    {
                        calismaGunSayisi += vardiyaSaat["calismaSuresi"].ToInt32();
                    }
                    else if (vardiyaSaat["calismaBaslangicTarihi"].ToDateTime().Date.Month != Ay && vardiyaSaat["calismaBitisTarihi"].ToDateTime().Date.Month == Ay)
                    {
                        DateTime date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                        int fark = vardiyaSaat["calismaBitisTarihi"].ToDateTime().Subtract(date).TotalDays.ToInt32();
                        calismaGunSayisi += fark;
                    }
                    else if (vardiyaSaat["calismaBaslangicTarihi"].ToDateTime().Date.Month == Ay && vardiyaSaat["calismaBitisTarihi"].ToDateTime().Date.Month != Ay)
                    {
                        DateTime date = new DateTime(DateTime.Now.Year, Ay, DateTime.DaysInMonth(DateTime.Now.Year, Ay));
                        int fark = date.Subtract(vardiyaSaat["calismaBaslangicTarihi"].ToDateTime()).TotalDays.ToInt32();
                        calismaGunSayisi += fark;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }
    }
}
