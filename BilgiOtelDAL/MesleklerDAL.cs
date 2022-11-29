using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiOtelDAL
{
    public class MesleklerDAL
    {
        //ID Getir

        public MesleklerEntity getMeslek(int id)
        {
            SqlDataReader meslek = SQLHelper.ExecuteReader($"SELECT * FROM meslekler WHERE meslekID = {id}");

            MesleklerEntity Meslek = new MesleklerEntity();

            while (meslek.Read())
            {
                Meslek.MeslekID = (int)meslek[0];
                Meslek.MeslekAd = (string)meslek[1];
                Meslek.MeslekAciklama = (string)meslek[2];
                Meslek.MeslekAktifMi = (bool)meslek[3];
            }

            return Meslek;
        }

        //Hepsini Getir
        public List<MesleklerEntity> getMeslekler()
        {
            SqlDataReader meslekler = SQLHelper.ExecuteReader("SELECT * FROM meslekler");

            List<MesleklerEntity> Meslekler = new List<MesleklerEntity>();

            while (meslekler.Read())
            {
                MesleklerEntity meslek = new MesleklerEntity();
                meslek.MeslekID = (int)meslekler[0];
                meslek.MeslekAd = (string)meslekler[1];
                meslek.MeslekAciklama = (string)meslekler[2];
                meslek.MeslekAktifMi = (bool)meslekler[3];

                Meslekler.Add(meslek);
            }

            return Meslekler;
        }

        //Insert
        public int insertMeslek(MesleklerEntity meslek)
        {
            SqlParameter[] parametreler =
            {
                new SqlParameter { ParameterName = "meslekAd", Value = meslek.MeslekAd},
                new SqlParameter { ParameterName = "meslekAciklama", Value = meslek.MeslekAciklama},
                new SqlParameter { ParameterName = "meslekAktifMi", Value = meslek.MeslekAktifMi}
            };

            int eklenenMeslekSayisi = SQLHelper.ExecuteNonQuery("INSERT INTO meslekler (meslekAd,meslekAciklama,meslekAktifMi) VALUES (@meslekAd, @meslekAciklama,@meslekAktifMi)", parametreler);


            return eklenenMeslekSayisi;
        }
        //Update

        public int updateMeslek(MesleklerEntity meslek)
        {
            SqlParameter[] parametreler =
            {
                new SqlParameter { ParameterName = "meslekID", Value = meslek.MeslekID},
                new SqlParameter { ParameterName = "meslekAd", Value = meslek.MeslekAd},
                new SqlParameter { ParameterName = "meslekAciklama", Value = meslek.MeslekAciklama},
                new SqlParameter { ParameterName = "meslekAktifMi", Value = meslek.MeslekAktifMi}
            };

            int guncellenenMeslekSayisi = SQLHelper.ExecuteNonQuery("UPDATE meslekler SET meslekAd = @meslekAd, meslekAciklama = @meslekAciklama, meslekAktifMi = @meslekAktifMi WHERE meslekID = @meslekID)", parametreler);

            return guncellenenMeslekSayisi;
        }

        //Delete
        public int deleteMeslek(int id)
        {
            int silinenMeslekSayisi = SQLHelper.ExecuteNonQuery($"UPDATE meslekler SET meslekAktifMi = 0 WHERE meslekID = {id}");

            return silinenMeslekSayisi;
        }
    }
}
