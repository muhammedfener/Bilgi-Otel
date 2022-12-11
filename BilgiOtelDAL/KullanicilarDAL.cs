using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiOtelDAL
{
    public class KullanicilarDAL
    {
        public KullanicilarEntity kullaniciGetirID(int id)
        {
            DataTable kullanici = SQLHelper.GetDataTable($"SELECT * FROM kullanicilar WHERE kullaniciID = {id}");

            KullanicilarEntity Kullanici = new KullanicilarEntity();

            foreach(DataRow row in kullanici.Rows)
            {
                Kullanici.KullaniciID = row[0].ToInt32();
                Kullanici.KullaniciAdi = row[1].ToString();
                Kullanici.KullaniciSifre = row[2].ToString();
                Kullanici.KullaniciMail = row[3].ToString();
                Kullanici.KullaniciKayitTarihi = row[4].ToDateTime();
                Kullanici.KullaniciCalisanID = row[5].ToInt32();
                Kullanici.KullaniciYoneticiID = row[6].ToInt32();
                Kullanici.KullaniciAktifMi = row[7].ToBoolean();
            }

            return Kullanici;
        }

        public KullanicilarEntity kullaniciGetirMail(string kullaniciMail)
        {
            DataTable kullanici = SQLHelper.GetDataTable($"SELECT * FROM kullanicilar WHERE kullaniciMail = '{kullaniciMail}'");

            KullanicilarEntity Kullanici = new KullanicilarEntity();

            foreach (DataRow row in kullanici.Rows)
            {
                Kullanici.KullaniciID = row[0].ToInt32();
                Kullanici.KullaniciAdi = row[1].ToString();
                Kullanici.KullaniciSifre = row[2].ToString();
                Kullanici.KullaniciMail = row[3].ToString();
                Kullanici.KullaniciKayitTarihi = row[4].ToDateTime();
                Kullanici.KullaniciCalisanID = row[5].ToInt32();
                Kullanici.KullaniciYoneticiID = row[6].ToInt32();
                Kullanici.KullaniciAktifMi = row[7].ToBoolean();
            }

            return Kullanici;
        }

        //Hepsini Getir
        public List<KullanicilarEntity> kullanicilariGetir()
        {
            DataTable kullanicilar = SQLHelper.GetDataTable("SELECT * FROM kullanicilar WHERE kullaniciAktifMi=1");

            List<KullanicilarEntity> Kullanicilar = new List<KullanicilarEntity>();

            foreach(DataRow row in kullanicilar.Rows)
            {
                KullanicilarEntity Kullanici = new KullanicilarEntity();
                Kullanici.KullaniciID = row[0].ToInt32();
                Kullanici.KullaniciAdi = row[1].ToString();
                Kullanici.KullaniciSifre = row[2].ToString();
                Kullanici.KullaniciMail = row[3].ToString();
                Kullanici.KullaniciKayitTarihi = row[4].ToDateTime();
                Kullanici.KullaniciCalisanID = row[5].ToInt32();
                Kullanici.KullaniciYoneticiID = row[6].ToInt32();
                Kullanici.KullaniciAktifMi = row[7].ToBoolean();

                Kullanicilar.Add(Kullanici);
            }

            return Kullanicilar;
        }

        //Insert
        public int kullaniciEkle(KullanicilarEntity kullanici)
        {
            SqlParameter[] parametreler =
            {
                new SqlParameter { ParameterName = "kullaniciAdi", Value = kullanici.KullaniciAdi},
                new SqlParameter { ParameterName = "kullaniciSifre", Value = kullanici.KullaniciSifre},
                new SqlParameter { ParameterName = "kullaniciMail", Value = kullanici.KullaniciMail},
                new SqlParameter { ParameterName = "kullaniciKayitTarihi", Value = kullanici.KullaniciKayitTarihi},
                new SqlParameter { ParameterName = "kullaniciCalisanID", Value = kullanici.KullaniciCalisanID},
                new SqlParameter { ParameterName = "kullaniciYoneticiID", Value = kullanici.KullaniciYoneticiID},
                new SqlParameter { ParameterName = "kullaniciAktifMi", Value = kullanici.KullaniciAktifMi}
            };

            int eklenenKullaniciSayisi = SQLHelper.ExecuteNonQuery("INSERT INTO kullanicilar (kullaniciAdi,kullaniciSifre,kullaniciMail,kullaniciKayitTarihi,kullaniciCalisanID,kullaniciYoneticiID,kullaniciAktifMi) VALUES (@kullaniciAdi, @kullaniciSifre,@kullaniciMail,@kullaniciKayitTarihi,@kullaniciCalisanID,@kullaniciYoneticiID,@kullaniciAktifMi)", parametreler);

            return eklenenKullaniciSayisi;
        }
        //Update

        public int kullaniciGuncelle(KullanicilarEntity kullanici)
        {
            SqlParameter[] parametreler =
            {
                new SqlParameter { ParameterName = "kullaniciID", Value = kullanici.KullaniciID},
                new SqlParameter { ParameterName = "kullaniciAdi", Value = kullanici.KullaniciAdi},
                new SqlParameter { ParameterName = "kullaniciSifre", Value = kullanici.KullaniciSifre},
                new SqlParameter { ParameterName = "kullaniciMail", Value = kullanici.KullaniciMail},
                new SqlParameter { ParameterName = "kullaniciKayitTarihi", Value = kullanici.KullaniciKayitTarihi},
                new SqlParameter { ParameterName = "kullaniciCalisanID", Value = kullanici.KullaniciCalisanID},
                new SqlParameter { ParameterName = "kullaniciYoneticiID", Value = kullanici.KullaniciYoneticiID},
                new SqlParameter { ParameterName = "kullaniciAktifMi", Value = kullanici.KullaniciAktifMi}
            };

            int guncellenenKullaniciSayisi = SQLHelper.ExecuteNonQuery("UPDATE kullanicilar SET kullaniciAdi = @kullaniciAdi, kullaniciSifre = @kullaniciSifre, kullaniciMail = @kullaniciMail, kullaniciKayitTarihi = @kullaniciKayitTarihi, kullaniciCalisanID = @kullaniciCalisanID, kullaniciYoneticiID = @kullaniciYoneticiID, kullaniciAktifMi = @kullaniciAktifMi WHERE kullaniciID = @kullaniciID", parametreler);

            return guncellenenKullaniciSayisi;
        }

        //Delete
        public int kullaniciSil(string kullaniciMail)
        {
            int silinenKullaniciSayisi = SQLHelper.ExecuteNonQuery($"UPDATE kullanicilar SET kullaniciAktifMi = 0 WHERE kullaniciMail = '{kullaniciMail}'");

            return silinenKullaniciSayisi;
        }
    }
}
