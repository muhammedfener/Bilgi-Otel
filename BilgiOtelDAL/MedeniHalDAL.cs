using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiOtelDAL
{
    public class MedeniHalDAL
    { 
        //ID Getir

        public MedeniHalEntity getMedeniHal(int id)
        {
            SqlDataReader medeniHal = SQLHelper.ExecuteReader($"SELECT * FROM medeniHal WHERE id = {id}");

            MedeniHalEntity MedeniHal = new MedeniHalEntity();

            while (medeniHal.Read())
            {
                MedeniHal.MedeniHalID = (int)medeniHal[0];
                MedeniHal.MedeniHalAd = (string)medeniHal[1];
                MedeniHal.MedeniHalAktifMi = (bool)medeniHal[2];
            }

            return MedeniHal;
        }

        //Hepsini Getir
        public List<MedeniHalEntity> getMedeniHaller()
        {
            SqlDataReader medeniHaller = SQLHelper.ExecuteReader("SELECT * FROM medenihal WHERE kampanyaAktifMi = 1");

            List<MedeniHalEntity> MedeniHaller = new List<MedeniHalEntity>();

            while (medeniHaller.Read())
            {
                MedeniHalEntity medeniHal = new MedeniHalEntity();
                medeniHal.MedeniHalID = (int)medeniHaller[0];
                medeniHal.MedeniHalAd = (string)medeniHaller[1];
                medeniHal.MedeniHalAktifMi = (bool)medeniHaller[2];

                MedeniHaller.Add(medeniHal);
            }

            return MedeniHaller;
        }

        //Insert
        public int insertMedeniHal(MedeniHalEntity medeniHal)
        {
            SqlParameter[] parametreler =
            {
                new SqlParameter { ParameterName = "medeniHalAd", Value = medeniHal.MedeniHalAd},
                new SqlParameter { ParameterName = "medeniHalAktifMi", Value = medeniHal.MedeniHalAktifMi}
            };

            int eklenenMedeniHalSayisi = SQLHelper.ExecuteNonQuery("INSERT INTO medeniHal (medeniHalAd, medeniHalAktifMi) VALUES (@medeniHalAd, @medeniHalAktifMi)", parametreler);
            
            return eklenenMedeniHalSayisi;
        }
        //Update

        public int updateMedeniHal(MedeniHalEntity medeniHal)
        {
            SqlParameter[] parametreler =
            {
                new SqlParameter { ParameterName = "medeniHalID", Value = medeniHal.MedeniHalID},
                new SqlParameter { ParameterName = "medeniHalAd", Value = medeniHal.MedeniHalAd},
                new SqlParameter { ParameterName = "medeniHalAktifMi", Value = medeniHal.MedeniHalAktifMi}
            };

            int guncellenenMedeniHalSayisi = SQLHelper.ExecuteNonQuery("UPDATE medeniHal SET medenihalAd = @medeniHalAd, medeniHalAktifMi = @medeniHalAktifMi WHERE medeniHalID = @medeniHalID", parametreler);

            return guncellenenMedeniHalSayisi;
        }

        //Delete
        public int deleteMedeniHal(int id)
        {
            int silinenMedeniHalSayisi = SQLHelper.ExecuteNonQuery($"UPDATE medeniHal SET medeniHalAktifMi = 0 WHERE medeniHalID = {id}");

            return silinenMedeniHalSayisi;
        }
    }
}
