using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiOtelDAL
{
    public class MusterilerDAL
    {
        //ID ile Getir

        public MusterilerEntity getMusteri(int id)
        {
            SqlDataReader musteri = SQLHelper.ExecuteReader($"SELECT * FROM musteriler WHERE musteriID = {id}");

            MusterilerEntity Musteri = new MusterilerEntity();

            while (musteri.Read())
            {
                Musteri.MusteriID = (int)musteri[0];
                Musteri.MusteriAd = (string)musteri[1];
                Musteri.MusteriSoyad = (string)musteri[2];
                Musteri.MusteriTCKimlik = (string)musteri[3];
                Musteri.MusteriTelefon = (string)musteri[4];
                Musteri.MusteriMedeniHal = (int)musteri[5];
                Musteri.MusteriMail = (string)musteri[6];
                Musteri.MusteriSifre = (string)musteri[7];
                Musteri.MusteriAktifMi = (bool)musteri[8];
            }

            return Musteri;
        }

        //Hepsini Getir
        public List<MusterilerEntity> getMusteriler()
        {
            SqlDataReader musteriler = SQLHelper.ExecuteReader("SELECT * FROM musteriler WHERE musteriAktifMi = 1");

            List<MusterilerEntity> Musteriler = new List<MusterilerEntity>();

            while (musteriler.Read())
            {
                MusterilerEntity musteri = new MusterilerEntity();
                musteri.MusteriID = (int)musteriler[0];
                musteri.MusteriAd = (string)musteriler[1];
                musteri.MusteriSoyad = (string)musteriler[2];
                musteri.MusteriTCKimlik = (string)musteriler[3];
                musteri.MusteriTelefon = (string)musteriler[4];
                musteri.MusteriMedeniHal = (int)musteriler[5];
                musteri.MusteriMail = (string)musteriler[6];
                musteri.MusteriSifre = (string)musteriler[7];
                musteri.MusteriAktifMi = (bool)musteriler[8];

                Musteriler.Add(musteri);
            }

            return Musteriler;
        }

        //Insert
        public int insertMusteri(MusterilerEntity musteri)
        {
            SqlParameter[] parametreler =
            {
                new SqlParameter { ParameterName = "musteriAd", Value = musteri.MusteriAd},
                new SqlParameter { ParameterName = "musteriSoyad", Value = musteri.MusteriSoyad},
                new SqlParameter { ParameterName = "musteriTCKimlik", Value = musteri.MusteriTCKimlik},
                new SqlParameter { ParameterName = "musteriTelefon", Value = musteri.MusteriTelefon},
                new SqlParameter { ParameterName = "musteriMedeniHal", Value = musteri.MusteriMedeniHal},
                new SqlParameter { ParameterName = "musteriMail", Value = musteri.MusteriMail},
                new SqlParameter { ParameterName = "musteriSifre", Value = musteri.MusteriSifre},
                new SqlParameter { ParameterName = "musteriAktifMi", Value = musteri.MusteriAktifMi}
            };

            int eklenenMusteriSayisi = SQLHelper.ExecuteNonQuery("INSERT INTO musteriler (musteriAd,musteriSoyad,musteriTCKimlik,musteriTelefon,musteriMedeniHal,musteriMail,musteriSifre,musteriAktifMi) VALUES (@musteriAd,@musteriSoyad,@musteriTCKimlik,@musteriTelefon,@musteriMedeniHal,@musteriMail,@musteriSifre,@musteriAktifMi)", parametreler);


            return eklenenMusteriSayisi;
        }
        //Update

        public int updateMusteri(MusterilerEntity musteri)
        {
            SqlParameter[] parametreler =
            {
                new SqlParameter { ParameterName = "musteriID", Value = musteri.MusteriID},
                new SqlParameter { ParameterName = "musteriAd", Value = musteri.MusteriAd},
                new SqlParameter { ParameterName = "musteriSoyad", Value = musteri.MusteriSoyad},
                new SqlParameter { ParameterName = "musteriTCKimlik", Value = musteri.MusteriTCKimlik},
                new SqlParameter { ParameterName = "musteriTelefon", Value = musteri.MusteriTelefon},
                new SqlParameter { ParameterName = "musteriMedeniHal", Value = musteri.MusteriMedeniHal},
                new SqlParameter { ParameterName = "musteriMail", Value = musteri.MusteriMail},
                new SqlParameter { ParameterName = "musteriSifre", Value = musteri.MusteriSifre},
                new SqlParameter { ParameterName = "musteriAktifMi", Value = musteri.MusteriAktifMi}
            };

            int guncellenenMusteriSayisi = SQLHelper.ExecuteNonQuery("UPDATE musteriler SET musteriAd = @musteriAd, musteriSoyad = @musteriSoyad, musteriTCKimlik = @musteriTCKimlik, musteriTelefon = @musteriTelefon, musteriMedeniHal = @musteriMedeniHal, musteriMail = @musteriMail, musteriSifre = @musteriSifre, musteriAktifMi = @musteriAktifMi  WHERE musteriID = @musteriID)", parametreler);

            return guncellenenMusteriSayisi;
        }

        //Delete
        public int deleteMusteri(int id)
        {
            int silinenMusteri = SQLHelper.ExecuteNonQuery($"UPDATE musteriler SET musteriAktifMi = 0 WHERE musteriID = {id}");

            return silinenMusteri;
        }
    }
}
