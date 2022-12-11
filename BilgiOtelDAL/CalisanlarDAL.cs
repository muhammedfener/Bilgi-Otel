using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BilgiOtel;
using Entity;
namespace BilgiOtelDAL
{
    public class CalisanlarDAL
    {
        //ID Getir
        public CalisanlarEntity calisanGetirID(int id)
        {
            DataTable calisan = SQLHelper.GetDataTable($"SELECT * FROM calisanlar WHERE calisanID = {id}");

            CalisanlarEntity Calisan = new CalisanlarEntity();

            foreach(DataRow dr in calisan.Rows)
            {
                Calisan.CalisanID = (int)dr[0];
                Calisan.CalisanAd = (string)dr[1];
                Calisan.CalisanSoyad = (string)dr[2];
                Calisan.CalisanTelefon = (string)dr[3];
                Calisan.CalisanTCKimlik = (string)dr[4];
                Calisan.CalisanAdres = (string)dr[5];
                Calisan.CalisanIrtibatTelefon = (string)dr[6];
                Calisan.CalisanIseBaslamaTarihi = (DateTime)dr[7];
                Calisan.CalisanIstenAyrilmaTarihi = (DateTime)dr[8];
                Calisan.CalisanMeslekID= (int)dr[9];
                Calisan.CalisanSaatlikUcret = (decimal)dr[10];
                Calisan.CalisanAktifMi = (bool)dr[11];
            }
            return Calisan;
        }

        public CalisanlarEntity calisanGetirTC(string calisanTC)
        {
            DataTable calisan = SQLHelper.GetDataTable($"SELECT * FROM calisanlar WHERE calisanTCKimlik = '{calisanTC}'");

            CalisanlarEntity Calisan = new CalisanlarEntity();

            foreach (DataRow dr in calisan.Rows)
            {
                Calisan.CalisanID = (int)dr[0];
                Calisan.CalisanAd = (string)dr[1];
                Calisan.CalisanSoyad = (string)dr[2];
                Calisan.CalisanTelefon = (string)dr[3];
                Calisan.CalisanTCKimlik = (string)dr[4];
                Calisan.CalisanAdres = (string)dr[5];
                Calisan.CalisanIrtibatTelefon = (string)dr[6];
                Calisan.CalisanIseBaslamaTarihi = dr[7].ToDateTime();
                Calisan.CalisanIstenAyrilmaTarihi = dr[8].ToDateTime();
                Calisan.CalisanMeslekID = (int)dr[9];
                Calisan.CalisanSaatlikUcret = (decimal)dr[10];
                Calisan.CalisanAktifMi = (bool)dr[11];
            }
            return Calisan;
        }

        //Hepsini Getir
        public List<CalisanlarEntity> calisanlarGetir()
        {
            DataTable calisanlar = SQLHelper.GetDataTable("SELECT * FROM calisanlar WHERE calisanAktifMi = 1");

            List<CalisanlarEntity> Calisanlar = new List<CalisanlarEntity>();

            foreach (DataRow dr in calisanlar.Rows)
            {
                CalisanlarEntity Calisan = new CalisanlarEntity();
                Calisan.CalisanID = (int)dr[0];
                Calisan.CalisanAd = (string)dr[1];
                Calisan.CalisanSoyad = (string)dr[2];
                Calisan.CalisanTelefon = (string)dr[3];
                Calisan.CalisanTCKimlik = (string)dr[4];
                Calisan.CalisanAdres = (string)dr[5];
                Calisan.CalisanIrtibatTelefon = (string)dr[6];
                Calisan.CalisanIseBaslamaTarihi = (DateTime)dr[7];
                Calisan.CalisanIstenAyrilmaTarihi = (DateTime)dr[8];
                Calisan.CalisanMeslekID = (int)dr[9];
                Calisan.CalisanSaatlikUcret = (decimal)dr[10];
                Calisan.CalisanAktifMi = (bool)dr[11];

                Calisanlar.Add(Calisan);
            }

            return Calisanlar;
        }

        //Insert
        public int calisanEkle(CalisanlarEntity calisan)
        {
            SqlParameter[] parametreler =
            {
                new SqlParameter { ParameterName = "calisanAd", Value = calisan.CalisanAd},
                new SqlParameter { ParameterName = "calisanSoyad", Value = calisan.CalisanSoyad},
                new SqlParameter { ParameterName = "calisanTelefon", Value = calisan.CalisanTelefon},
                new SqlParameter { ParameterName = "calisanTCKimlik", Value = calisan.CalisanTCKimlik},
                new SqlParameter { ParameterName = "calisanAdres", Value = calisan.CalisanAdres},
                new SqlParameter { ParameterName = "calisanIrtibatTelefon", Value = calisan.CalisanIrtibatTelefon},
                new SqlParameter { ParameterName = "calisanIseBaslamaTarihi", Value = calisan.CalisanIseBaslamaTarihi},
                new SqlParameter { ParameterName = "calisanIstenAyrilmaTarihi", Value = calisan.CalisanIstenAyrilmaTarihi},
                new SqlParameter { ParameterName = "calisanMeslekID", Value = calisan.CalisanMeslekID},
                new SqlParameter { ParameterName = "calisanSaatlikUcret", Value = calisan.CalisanSaatlikUcret},
                new SqlParameter { ParameterName = "calisanAktifMi", Value = calisan.CalisanAktifMi}
            };

            int eklenenCalisanSayisi = SQLHelper.ExecuteNonQuery("sp_calisanEkle",CommandType.StoredProcedure,parametreler);

            return eklenenCalisanSayisi;
        }
        
        //Update
        public int calisanGuncelle(CalisanlarEntity calisan)
        {
            SqlParameter[] parametreler =
            {
                new SqlParameter { ParameterName = "calisanID", Value = calisan.CalisanID},
                new SqlParameter { ParameterName = "calisanAd", Value = calisan.CalisanAd},
                new SqlParameter { ParameterName = "calisanSoyad", Value = calisan.CalisanSoyad},
                new SqlParameter { ParameterName = "calisanTelefon", Value = calisan.CalisanTelefon},
                new SqlParameter { ParameterName = "calisanTCKimlik", Value = calisan.CalisanTCKimlik},
                new SqlParameter { ParameterName = "calisanAdres", Value = calisan.CalisanAdres},
                new SqlParameter { ParameterName = "calisanIrtibatTelefon", Value = calisan.CalisanIrtibatTelefon},
                new SqlParameter { ParameterName = "calisanIseBaslamaTarihi", Value = calisan.CalisanIseBaslamaTarihi},
                new SqlParameter { ParameterName = "calisanIstenAyrilmaTarihi", Value = calisan.CalisanIstenAyrilmaTarihi},
                new SqlParameter { ParameterName = "calisanMeslekID", Value = calisan.CalisanMeslekID},
                new SqlParameter { ParameterName = "calisanSaatlikUcret", Value = calisan.CalisanSaatlikUcret},
                new SqlParameter { ParameterName = "calisanAktifMi", Value = calisan.CalisanAktifMi}
            };

            int guncellenenCalisanSayisi = SQLHelper.ExecuteNonQuery("sp_calisanGuncelle",CommandType.StoredProcedure, parametreler);

            return guncellenenCalisanSayisi;
        }

        //DeleteID
        public int calisanSilID(int id)
        {
            int silinenCalisanSayisi = SQLHelper.ExecuteNonQuery($"UPDATE calisanlar SET calisanAktifMi=0 WHERE calisanID = {id}");

            return silinenCalisanSayisi;
        }

        //DeleteTC
        public int calisanSilTC(string calisanTC)
        {
            int silinenCalisanSayisi = SQLHelper.ExecuteNonQuery($"UPDATE calisanlar SET calisanAktifMi=0 WHERE calisanTCKimlik = {calisanTC}");

            return silinenCalisanSayisi;
        }

    }
}
