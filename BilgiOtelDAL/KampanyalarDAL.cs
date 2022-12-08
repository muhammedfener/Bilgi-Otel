using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiOtelDAL
{
    public class KampanyalarDAL
    {
        //ID Getir

        public KampanyalarEntity getKampanya(int id)
        {
            SqlDataReader kampanya = SQLHelper.ExecuteReader($"SELECT * FROM kampanyalar WHERE kampanyaID = {id}");

            KampanyalarEntity Kampanya = new KampanyalarEntity();

            while (kampanya.Read())
            {
                Kampanya.KampanyaID = (int)kampanya[0];
                Kampanya.KampanyaAd = (string)kampanya[1];
                Kampanya.KampanyaIndirimOrani = (int)kampanya[2];
                Kampanya.KampanyaBaslangic = (DateTime)kampanya[3];
                Kampanya.KampanyaBitis = (DateTime)kampanya[4];
                Kampanya.KampanyaAciklama = (string)kampanya[5];
                Kampanya.KampanyaAktifMi = (bool)kampanya[6];
            }

            return Kampanya;
        }

        public KampanyalarEntity getKampanya(string kampanyaAd)
        {
            SqlDataReader kampanya = SQLHelper.ExecuteReader($"SELECT * FROM kampanyalar WHERE kampanyaAd = '{kampanyaAd}'");

            KampanyalarEntity Kampanya = new KampanyalarEntity();

            while (kampanya.Read())
            {
                Kampanya.KampanyaID = (int)kampanya[0];
                Kampanya.KampanyaAd = (string)kampanya[1];
                Kampanya.KampanyaIndirimOrani = (int)kampanya[2];
                Kampanya.KampanyaBaslangic = (DateTime)kampanya[3];
                Kampanya.KampanyaBitis = (DateTime)kampanya[4];
                Kampanya.KampanyaAciklama = (string)kampanya[5];
                Kampanya.KampanyaAktifMi = (bool)kampanya[6];
            }

            return Kampanya;
        }

        //Hepsini Getir
        public List<KampanyalarEntity> getKampanyalar()
        {
            SqlDataReader kampanyalar = SQLHelper.ExecuteReader("SELECT * FROM kampanyalar WHERE kampanyaAktifMi = 1");

            List<KampanyalarEntity> Kampanyalar = new List<KampanyalarEntity>();

            while (kampanyalar.Read())
            {
                KampanyalarEntity kampanya = new KampanyalarEntity();
                kampanya.KampanyaID = (int)kampanyalar[0];
                kampanya.KampanyaAd = (string)kampanyalar[1];
                kampanya.KampanyaIndirimOrani = (int)kampanyalar[2];
                kampanya.KampanyaBaslangic = (DateTime)kampanyalar[3];
                kampanya.KampanyaBitis = (DateTime)kampanyalar[4];
                kampanya.KampanyaAciklama = (string)kampanyalar[5];
                kampanya.KampanyaAktifMi = (bool)kampanyalar[6];

                Kampanyalar.Add(kampanya);
            }

            return Kampanyalar;
        }

        //Insert
        public int insertKampanya(KampanyalarEntity kampanya)
        {
            SqlParameter[] parametreler =
            {
                new SqlParameter { ParameterName = "kampanyaAd", Value = kampanya.KampanyaAd},
                new SqlParameter { ParameterName = "kampanyaIndirimOrani", Value = kampanya.KampanyaIndirimOrani},
                new SqlParameter { ParameterName = "kampanyaBaslangic", Value = kampanya.KampanyaBaslangic},
                new SqlParameter { ParameterName = "kampanyaBitis", Value = kampanya.KampanyaBitis},
                new SqlParameter { ParameterName = "kampanyaAciklama", Value = kampanya.KampanyaAciklama},
                new SqlParameter { ParameterName = "kampanyaAktifMi", Value = kampanya.KampanyaAktifMi}
            };

            int eklenenKampanyaSayisi = SQLHelper.ExecuteNonQuery("INSERT INTO kampanyanlar (kampanyaAd,kampanyaIndirimOrani,kampanyaBaslangic,kampanyaBitis,kampanyaAciklama,kampanyaAktifMi) VALUES (@kampanyaAd, @kampanyaIndirimOrani,@kampanyaBaslangic,@kampanyaBitis,@kampanyaAciklama,@kampanyaAktifMi)", parametreler);


            return eklenenKampanyaSayisi;
        }
        //Update

        public int updateKampanyalar(KampanyalarEntity kampanya)
        {
            SqlParameter[] parametreler =
            {
                new SqlParameter { ParameterName = "kampanyaID", Value = kampanya.KampanyaID},
                new SqlParameter { ParameterName = "kampanyaAd", Value = kampanya.KampanyaAd},
                new SqlParameter { ParameterName = "kampanyaIndirimOrani", Value = kampanya.KampanyaIndirimOrani},
                new SqlParameter { ParameterName = "kampanyaBaslangic", Value = kampanya.KampanyaBaslangic},
                new SqlParameter { ParameterName = "kampanyaBitis", Value = kampanya.KampanyaBitis},
                new SqlParameter { ParameterName = "kampanyaAciklama", Value = kampanya.KampanyaAciklama},
                new SqlParameter { ParameterName = "kampanyaAktifMi", Value = kampanya.KampanyaAktifMi}
            };

            int guncellenenKampanyaSayisi = SQLHelper.ExecuteNonQuery("UPDATE kampanyalar SET kampanyaAd = @kampanyaAd, kampanyaIndirimOrani = @kampanyaIndirimOrani, kampanyaBaslangic = @kampanyaBaslangic, kampanyaBitis = @kampanyaBitis, kampanyaAciklama = @kampanyaAciklama, kampanyaAktifMi = @kampanyaAktifMi WHERE kampanyaID = @kampanyaID", parametreler);

            return guncellenenKampanyaSayisi;
        }

        //Delete
        public int deleteKampanya(int id)
        {
            int silinenKampanyaSayisi = SQLHelper.ExecuteNonQuery($"UPDATE kampanyalar SET kampanyaAktifMi = 0 WHERE kampanyaID = {id}");

            return silinenKampanyaSayisi;
        }
    }
}
