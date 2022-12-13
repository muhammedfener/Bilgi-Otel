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
    public class KampanyalarDAL
    {
        //ID Getir
        public KampanyalarEntity kampanyaGetirID(int id)
        {
            DataTable kampanya = SQLHelper.GetDataTable($"SELECT * FROM kampanyalar WHERE kampanyaID = {id}");

            KampanyalarEntity Kampanya = new KampanyalarEntity();

            foreach (DataRow row in kampanya.Rows)
            {
                Kampanya.KampanyaID = row[0].ToInt32();
                Kampanya.KampanyaAd = row[1].ToString();
                Kampanya.KampanyaIndirimOrani = row[2].ToInt32();
                Kampanya.KampanyaBaslangic = row[3].ToDateTime();
                Kampanya.KampanyaBitis = row[4].ToDateTime();
                Kampanya.KampanyaAciklama = row[5].ToString();
                Kampanya.KampanyaAktifMi = row[6].ToBoolean();
            }

            return Kampanya;
        }

        public KampanyalarEntity kampanyaGetirAD(string kampanyaAd)
        {
            DataTable kampanya = SQLHelper.GetDataTable($"SELECT * FROM kampanyalar WHERE kampanyaAd = '{kampanyaAd}'");

            KampanyalarEntity Kampanya = new KampanyalarEntity();

            foreach(DataRow row in kampanya.Rows)
            {
                Kampanya.KampanyaID = row[0].ToInt32();
                Kampanya.KampanyaAd = row[1].ToString();
                Kampanya.KampanyaIndirimOrani = row[2].ToInt32();
                Kampanya.KampanyaBaslangic = row[3].ToDateTime();
                Kampanya.KampanyaBitis = row[4].ToDateTime();
                Kampanya.KampanyaAciklama = row[5].ToString();
                Kampanya.KampanyaAktifMi = row[6].ToBoolean();
            }

            return Kampanya;
        }

        //Hepsini Getir
        public List<KampanyalarEntity> kampanyalarGetir()
        {
            DataTable kampanyalar = SQLHelper.GetDataTable("SELECT * FROM kampanyalar WHERE kampanyaAktifMi = 1");

            List<KampanyalarEntity> Kampanyalar = new List<KampanyalarEntity>();

            foreach (DataRow row in kampanyalar.Rows)
            {
                KampanyalarEntity kampanya = new KampanyalarEntity();
                kampanya.KampanyaID = row[0].ToInt32();
                kampanya.KampanyaAd = row[1].ToString();
                kampanya.KampanyaIndirimOrani = row[2].ToInt32();
                kampanya.KampanyaBaslangic = row[3].ToDateTime();
                kampanya.KampanyaBitis = row[4].ToDateTime();
                kampanya.KampanyaAciklama = row[5].ToString();
                kampanya.KampanyaAktifMi = row[6].ToBoolean();

                Kampanyalar.Add(kampanya);
            }

            return Kampanyalar;
        }

        //Insert
        public int kampanyaEkle(KampanyalarEntity kampanya)
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

        public int kampanyaGuncelle(KampanyalarEntity kampanya)
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
        public int kampanyaSil(int id)
        {
            int silinenKampanyaSayisi = SQLHelper.ExecuteNonQuery($"UPDATE kampanyalar SET kampanyaAktifMi = 0 WHERE kampanyaID = {id}");

            return silinenKampanyaSayisi;
        }
    }
}
