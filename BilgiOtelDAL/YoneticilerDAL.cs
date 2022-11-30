using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiOtelDAL
{
    public class YoneticilerDAL
    {
        //odaID'ye Göre Getir
        public YoneticilerEntity getYonetici(int id)
        {
            SqlDataReader yonetici = SQLHelper.ExecuteReader($"SELECT * FROM yoneticiler WHERE yoneticiID = {id}");

            YoneticilerEntity Yonetici = new YoneticilerEntity();

            while (yonetici.Read())
            {
                Yonetici.YoneticiID = (int)yonetici[0];
                Yonetici.YoneticiAd = (string)yonetici[1];
                Yonetici.YoneticiSoyad = (string)yonetici[2];
                Yonetici.YoneticiTelefon = (string)yonetici[3];
                Yonetici.YoneticiTCKimlik = (string)yonetici[4];
                Yonetici.YoneticiAdres = (string)yonetici[5];
                Yonetici.YoneticiIrtibaTelefon = (string)yonetici[6];
                Yonetici.YoneticiIseBaslamaTarihi = (DateTime)yonetici[7];
                Yonetici.YoneticiIstenAyrilmaTarihi = (DateTime)yonetici[8];
                Yonetici.YoneticiMeslekID = (int)yonetici[9];
                Yonetici.YoneticiMaas = (int)yonetici[10];
                Yonetici.YoneticiAktifMi = (bool)yonetici[11];
            }

            return Yonetici;
        }

        //Hepsini Getir
        public List<YoneticilerEntity> getYoneticiler()
        {
            SqlDataReader yoneticiler = SQLHelper.ExecuteReader("SELECT * FROM yoneticiler WHERE yoneticiAktifMi = 1");

            List<YoneticilerEntity> Yoneticiler = new List<YoneticilerEntity>();

            while (yoneticiler.Read())
            {
                YoneticilerEntity Yonetici = new YoneticilerEntity();
                Yonetici.YoneticiID = (int)yoneticiler[0];
                Yonetici.YoneticiAd = (string)yoneticiler[1];
                Yonetici.YoneticiSoyad = (string)yoneticiler[2];
                Yonetici.YoneticiTelefon = (string)yoneticiler[3];
                Yonetici.YoneticiTCKimlik = (string)yoneticiler[4];
                Yonetici.YoneticiAdres = (string)yoneticiler[5];
                Yonetici.YoneticiIrtibaTelefon = (string)yoneticiler[6];
                Yonetici.YoneticiIseBaslamaTarihi = (DateTime)yoneticiler[7];
                Yonetici.YoneticiIstenAyrilmaTarihi = (DateTime)yoneticiler[8];
                Yonetici.YoneticiMeslekID = (int)yoneticiler[9];
                Yonetici.YoneticiMaas = (int)yoneticiler[10];
                Yonetici.YoneticiAktifMi = (bool)yoneticiler[11];

                Yoneticiler.Add(Yonetici);
            }

            return Yoneticiler;
        }

        //Insert
        public int insertYonetici(YoneticilerEntity yonetici)
        {
            SqlParameter[] parametreler =
            {
                new SqlParameter { ParameterName = "yoneticiAd", Value = yonetici.YoneticiAd},
                new SqlParameter { ParameterName = "yoneticiSoyad", Value = yonetici.YoneticiSoyad},
                new SqlParameter { ParameterName = "yoneticiTelefon", Value = yonetici.YoneticiTelefon},
                new SqlParameter { ParameterName = "yoneticiTCKimlik", Value = yonetici.YoneticiTCKimlik},
                new SqlParameter { ParameterName = "yoneticiAdres", Value = yonetici.YoneticiAdres},
                new SqlParameter { ParameterName = "yoneticiIrtibatTelefon", Value = yonetici.YoneticiIrtibaTelefon},
                new SqlParameter { ParameterName = "yoneticiIseBaslamaTarihi", Value = yonetici.YoneticiIstenAyrilmaTarihi},
                new SqlParameter { ParameterName = "yoneticiIstenAyrilmaTarihi", Value = yonetici.YoneticiIstenAyrilmaTarihi},
                new SqlParameter { ParameterName = "yoneticiMeslekID", Value = yonetici.YoneticiMeslekID},
                new SqlParameter { ParameterName = "yoneticiMaas", Value = yonetici.YoneticiMaas},
                new SqlParameter { ParameterName = "yoneticiAktifMi", Value = yonetici.YoneticiAktifMi}
            };

            int eklenenYoneticiSayisi = SQLHelper.ExecuteNonQuery("INSERT INTO yoneticiler (yoneticiAd,yoneticiSoyad,yoneticiTelefon,yoneticiTCKimlik,yoneticiAdres,yoneticiIrtibatTelefon,yoneticiIseBaslamaTarihi,yoneticiIstenAyrilmaTarihi,yoneticiMeslekID,yoneticiMaas,yoneticiAktifMi) VALUES (@yoneticiAd,@yoneticiSoyad,@yoneticiTelefon,@yoneticiTCKimlik,@yoneticiAdres,@yoneticiIrtibatTelefon,@yoneticiIseBaslamaTarihi,@yoneticiIstenAyrilmaTarihi,@yoneticiMeslekID,@yoneticiMaas,@yoneticiAktifMi)", parametreler);

            return eklenenYoneticiSayisi;
        }
        //Update

        public int updateYonetici(YoneticilerEntity yonetici)
        {
            SqlParameter[] parametreler =
            {
                new SqlParameter { ParameterName = "yoneticiID", Value = yonetici.YoneticiID},
                new SqlParameter { ParameterName = "yoneticiAd", Value = yonetici.YoneticiAd},
                new SqlParameter { ParameterName = "yoneticiSoyad", Value = yonetici.YoneticiSoyad},
                new SqlParameter { ParameterName = "yoneticiTelefon", Value = yonetici.YoneticiTelefon},
                new SqlParameter { ParameterName = "yoneticiTCKimlik", Value = yonetici.YoneticiTCKimlik},
                new SqlParameter { ParameterName = "yoneticiAdres", Value = yonetici.YoneticiAdres},
                new SqlParameter { ParameterName = "yoneticiIrtibatTelefon", Value = yonetici.YoneticiIrtibaTelefon},
                new SqlParameter { ParameterName = "yoneticiIseBaslamaTarihi", Value = yonetici.YoneticiIstenAyrilmaTarihi},
                new SqlParameter { ParameterName = "yoneticiIstenAyrilmaTarihi", Value = yonetici.YoneticiIstenAyrilmaTarihi},
                new SqlParameter { ParameterName = "yoneticiMeslekID", Value = yonetici.YoneticiMeslekID},
                new SqlParameter { ParameterName = "yoneticiMaas", Value = yonetici.YoneticiMaas},
                new SqlParameter { ParameterName = "yoneticiAktifMi", Value = yonetici.YoneticiAktifMi}
            };

            int guncellenenYoneticiSayisi = SQLHelper.ExecuteNonQuery("UPDATE yoneticiler SET yoneticiAd = @yoneticiAd, yoneticiSoyad = @yoneticiSoyad , yoneticiTelefon = @yoneticiTelefon , yoneticiTCKimlik = @yoneticiTCKimlik , yoneticiAdres = @yoneticiAdres , yoneticiIrtibatTelefon = @yoneticiIrtibatTelefon , yoneticiIseBaslamaTarihi = @yoneticiIseBaslamaTarihi , yoneticiIstenAyrilmaTarihi = @yoneticiIstenAyrilmaTarihi , yoneticiMeslekID = @yoneticiMeslekID , yoneticiMaas = @yoneticiMaas , yoneticiAktifMi = @yoneticiAktifMi , WHERE yoneticiID = @yoneticiID)", parametreler);

            return guncellenenYoneticiSayisi;
        }

        //Delete
        public int deleteYonetici(int id)
        {
            int silinenYoneticiSayisi = SQLHelper.ExecuteNonQuery($"UPDATE yoneticiler SET yoneticiAktifMi = 0 WHERE yoneticiID = {id}");

            return silinenYoneticiSayisi;
        }
    }
}
