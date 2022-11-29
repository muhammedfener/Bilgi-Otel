using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiOtelDAL
{
    public class OdaBakimLoglariDAL
    {
        //bakimID'ye Göre Getir
        public OdaBakimLoglariEntity getOdaBakimwithBakimID(int bakimid)
        {
            SqlDataReader odaBakimlar = SQLHelper.ExecuteReader($"SELECT * FROM odaBakimLoglari WHERE bakimID = {bakimid}");

            OdaBakimLoglariEntity odaBakim = new OdaBakimLoglariEntity();

            while (odaBakimlar.Read())
            {
                odaBakim.BakimID = (int)odaBakimlar[0];
                odaBakim.OdaNumara = (int)odaBakimlar[1];
                odaBakim.BakimAciklama = (string)odaBakimlar[2];
                odaBakim.BakimBaslangicTarihi = (DateTime)odaBakimlar[3];
                odaBakim.BakimBitisTarihi = (DateTime)odaBakimlar[4];
                odaBakim.BakimBittiMi = (bool)odaBakimlar[5];
            }

            return odaBakim;
        }

        //odaID'ye Göre Getir
        public OdaBakimLoglariEntity getOdaBakimWithOdaID(int odaid)
        {
            SqlDataReader odaBakimlar = SQLHelper.ExecuteReader($"SELECT * FROM odaBakimLoglari WHERE odaNumara = {odaid}");

            OdaBakimLoglariEntity odaBakim = new OdaBakimLoglariEntity();

            while (odaBakimlar.Read())
            {
                odaBakim.BakimID = (int)odaBakimlar[0];
                odaBakim.OdaNumara = (int)odaBakimlar[1];
                odaBakim.BakimAciklama = (string)odaBakimlar[2];
                odaBakim.BakimBaslangicTarihi = (DateTime)odaBakimlar[3];
                odaBakim.BakimBitisTarihi = (DateTime)odaBakimlar[4];
                odaBakim.BakimBittiMi = (bool)odaBakimlar[5];
            }

            return odaBakim;
        }

        //Hepsini Getir
        public List<OdaBakimLoglariEntity> getOdaBakimlar()
        {
            SqlDataReader odaBakimlar = SQLHelper.ExecuteReader("SELECT * FROM odaBakimLoglari WHERE odaBakimBittiMi = 0");

            List<OdaBakimLoglariEntity> OdaBakimlar = new List<OdaBakimLoglariEntity>();

            while (odaBakimlar.Read())
            {
                OdaBakimLoglariEntity odaBakim = new OdaBakimLoglariEntity();
                odaBakim.BakimID = (int)odaBakimlar[0];
                odaBakim.OdaNumara = (int)odaBakimlar[1];
                odaBakim.BakimAciklama = (string)odaBakimlar[2];
                odaBakim.BakimBaslangicTarihi = (DateTime)odaBakimlar[3];
                odaBakim.BakimBitisTarihi = (DateTime)odaBakimlar[4];
                odaBakim.BakimBittiMi = (bool)odaBakimlar[5];

                OdaBakimlar.Add(odaBakim);
            }

            return OdaBakimlar;
        }

        //Insert
        public int insertOdaBakim(OdaBakimLoglariEntity odaBakim)
        {
            SqlParameter[] parametreler =
            {
                new SqlParameter { ParameterName = "odaNumara", Value = odaBakim.OdaNumara},
                new SqlParameter { ParameterName = "bakimAciklama", Value = odaBakim.BakimAciklama},
                new SqlParameter { ParameterName = "bakimBaslangicTarihi", Value = odaBakim.BakimBaslangicTarihi},
                new SqlParameter { ParameterName = "bakimBitisTarihi", Value = odaBakim.BakimBitisTarihi},
                new SqlParameter { ParameterName = "bakimBittiMi", Value = odaBakim.BakimBittiMi}
            };

            int eklenenOdaBakimSayisi = SQLHelper.ExecuteNonQuery("INSERT INTO odaBakimLoglari (odaNumara,bakimAciklama,bakimBaslangicTarihi,bakimBitisTarihi,bakimBittiMi) VALUES (@odaNumara,@bakimAciklama,@bakimBaslangicTarihi,@bakimBitisTarihi,@bakimBittiMi)", parametreler);


            return eklenenOdaBakimSayisi;
        }
        //Update

        public int updateOdaBakim(OdaBakimLoglariEntity odaBakim)
        {
            SqlParameter[] parametreler =
            {
                new SqlParameter { ParameterName = "bakimID", Value = odaBakim.BakimID},
                new SqlParameter { ParameterName = "odaNumara", Value = odaBakim.OdaNumara},
                new SqlParameter { ParameterName = "bakimAciklama", Value = odaBakim.BakimAciklama},
                new SqlParameter { ParameterName = "bakimBaslangicTarihi", Value = odaBakim.BakimBaslangicTarihi},
                new SqlParameter { ParameterName = "bakimBitisTarihi", Value = odaBakim.BakimBitisTarihi},
                new SqlParameter { ParameterName = "bakimBittiMi", Value = odaBakim.BakimBittiMi}
            };

            int guncellenenBakimSayisi = SQLHelper.ExecuteNonQuery("UPDATE odaBakimLoglari SET odaNumara = @odaNumara, bakimAciklama = @bakimAciklama, bakimBaslangicTarihi = @bakimBaslangicTarihi, bakimBitisTarihi = @bakimBitisTarihi, bakimBittiMi = @bakimBittiMi WHERE bakimID = @bakimID)", parametreler);

            return guncellenenBakimSayisi;
        }

        //Delete
        public int deleteOdaBakim(int id)
        {
            int silinenOdaBakimSayisi = SQLHelper.ExecuteNonQuery($"UPDATE odaBakimLoglari SET bakimBittiMi = 1 WHERE bakimID = {id}");

            return silinenOdaBakimSayisi;
        }
    }
}
