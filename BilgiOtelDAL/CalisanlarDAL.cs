using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
namespace BilgiOtelDAL
{
    public class CalisanlarDAL
    {
        //ID Getir

        public CalisanlarEntity getCalisan(int id)
        {
            SqlDataReader calisan = SQLHelper.ExecuteReader($"SELECT * FROM calisanlar WHERE id = {id}");

            CalisanlarEntity Calisan = new CalisanlarEntity();

            while(calisan.Read())
            {
                Calisan.CalisanID = (int)calisan[0];
                Calisan.CalisanAd = (string)calisan[1];
                Calisan.CalisanSoyad = (string)calisan[2];
                Calisan.CalisanTelefon = (string)calisan[3];
                Calisan.CalisanTCKimlik = (string)calisan[4];
                Calisan.CalisanAdres = (string)calisan[5];
                Calisan.CalisanIrtibatTelefon = (string)calisan[6];
                Calisan.CalisanIseBaslamaTarihi = (DateTime)calisan[7];
                Calisan.CalisanIstenAyrilmaTarihi = (DateTime)calisan[8];
                Calisan.CalisanMeslekID= (int)calisan[9];
                Calisan.CalisanSaatlikUcret = (decimal)calisan[10];
                Calisan.CalisanAktifMi = (bool)calisan[11];
            }

            return Calisan;
        }

        //Hepsini Getir
        public List<CalisanlarEntity> getCalisanlar()
        {
            SqlDataReader calisan = SQLHelper.ExecuteReader("SELECT * FROM calisanlar WHERE calisanAktifMi = 1");

            List<CalisanlarEntity> Calisanlar = new List<CalisanlarEntity>();

            while (calisan.Read())
            {
                CalisanlarEntity Calisan = new CalisanlarEntity();
                Calisan.CalisanID = (int)calisan[0];
                Calisan.CalisanAd = (string)calisan[1];
                Calisan.CalisanSoyad = (string)calisan[2];
                Calisan.CalisanTelefon = (string)calisan[3];
                Calisan.CalisanTCKimlik = (string)calisan[4];
                Calisan.CalisanAdres = (string)calisan[5];
                Calisan.CalisanIrtibatTelefon = (string)calisan[6];
                Calisan.CalisanIseBaslamaTarihi = (DateTime)calisan[7];
                Calisan.CalisanIstenAyrilmaTarihi = (DateTime)calisan[8];
                Calisan.CalisanMeslekID = (int)calisan[9];
                Calisan.CalisanSaatlikUcret = (decimal)calisan[10];
                Calisan.CalisanAktifMi = (bool)calisan[11];

                Calisanlar.Add(Calisan);
            }

            return Calisanlar;
        }

        //Insert
        public int insertCalisan(CalisanlarEntity calisan)
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

            int eklenenCalisanSayisi = SQLHelper.ExecuteNonQuery("INSERT INTO calisanlar (calisanAd,calisanSoyad,calisanTelefon,calisanTCKimlik,calisanAdres,calisanIrtibatTelefon,calisanIseBaslamaTarihi,calisanIstenAyrilmaTarihi,calisanMeslekID,calisanSaatlikUcret,calisanAktifMi) VALUES (@calisanAd,@calisanSoyad,@calisanTelefon,@calisanTCKimlik,@calisanAdres,@calisanIrtibatTelefon,@calisanIseBaslamaTarihi,@calisanIstenAyrilmaTarihi,@calisanMeslekID,@calisanSaatlikUcret,@calisanAktifMi)", System.Data.CommandType.Text,parametreler);


            return eklenenCalisanSayisi;
        }
        //Update

        public int updateCalisan(CalisanlarEntity calisan)
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

            int guncellenenCalisanSayisi = SQLHelper.ExecuteNonQuery("UPDATE calisanlar SET calisanAd = @calisanAd, calisanSoyad = @calisanSoyad, calisanTelefon = @calisanTelefon,calisanTCKimlik = @calisanTCKimlik, calisanAdres = @calisanAdres, calisanIrtibatTelefon=@calisanIrtibatTelefon, calisanIseBaslamaTarihi=@calisanIseBaslamaTarihi, calisanIstenAyrilmaTarihi = @calisanIstenAyrilmaTarihi, calisanMeslekID=@calisanMeslekID, calisanSaatlikUcret = @calisanSaatlikUcret, calisanAktifMi=@calisanAktifMi WHERE calisanID = @calisanID", System.Data.CommandType.Text, parametreler);

            return guncellenenCalisanSayisi;
        }

        //Delete
        public int deleteCalisan(int id)
        {
            int silinenCalisanSayisi = SQLHelper.ExecuteNonQuery($"UPDATE calisanlar SET calisanAktifMi=0 WHERE calisanID = {id}");

            return silinenCalisanSayisi;
        }

    }
}
