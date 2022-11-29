using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiOtelDAL
{
    public class OdalarDAL
    {
        //odaID'ye Göre Getir
        public OdalarEntity getOda(int odaid)
        {
            SqlDataReader oda = SQLHelper.ExecuteReader($"SELECT * FROM odalar WHERE odaNumara = {odaid}");

            OdalarEntity Oda = new OdalarEntity();

            while (oda.Read())
            {
                Oda.OdaNumara = (int)oda[0];
                Oda.OdaKat = (int)oda[1];
                Oda.OdaKisiSayisi = (int)oda[2];
                Oda.OdaFiyat = (decimal)oda[3];
                Oda.OdaAciklama = (string)oda[4];
                Oda.OdaDoluMu = (bool)oda[5];
                Oda.OdaAktifMi = (bool)oda[6];
            }

            return Oda;
        }

        //Hepsini Getir
        public List<OdalarEntity> getOdalar()
        {
            SqlDataReader odalar = SQLHelper.ExecuteReader("SELECT * FROM odalar");

            List<OdalarEntity> Odalar = new List<OdalarEntity>();

            while (odalar.Read())
            {
                OdalarEntity oda = new OdalarEntity();
                oda.OdaNumara = (int)odalar[0];
                oda.OdaKat = (int)odalar[1];
                oda.OdaKisiSayisi = (int)odalar[2];
                oda.OdaFiyat = (decimal)odalar[3];
                oda.OdaAciklama = (string)odalar[4];
                oda.OdaDoluMu = (bool)odalar[5];
                oda.OdaAktifMi = (bool)odalar[6];

                Odalar.Add(oda);
            }

            return Odalar;
        }

        //Insert
        public int insertOda(OdalarEntity oda)
        {
            SqlParameter[] parametreler =
            {
                new SqlParameter { ParameterName = "odaNumara", Value = oda.OdaNumara},
                new SqlParameter { ParameterName = "odaKat", Value = oda.OdaKat},
                new SqlParameter { ParameterName = "odaKisiSayisi", Value = oda.OdaKisiSayisi},
                new SqlParameter { ParameterName = "odaFiyat", Value = oda.OdaFiyat},
                new SqlParameter { ParameterName = "odaAciklama", Value = oda.OdaAciklama},
                new SqlParameter { ParameterName = "odaDoluMu", Value = oda.OdaDoluMu},
                new SqlParameter { ParameterName = "odaAktifMi", Value = oda.OdaAktifMi}
            };

            int eklenenOdaSayisi = SQLHelper.ExecuteNonQuery("INSERT INTO odalar (odaNumara,odaKat,odaKisiSayisi,odaFiyat,odaAciklama,odaDoluMu,odaAktifMi) VALUES (@odaNumara,@odaKat,@odaKisiSayisi,@odaFiyat,@odaAciklama,@odaDoluMu,@odaAktifMi)", parametreler);

            return eklenenOdaSayisi;
        }
        //Update

        public int updateOda(OdalarEntity oda,int EskiOdaNo)
        {
            SqlParameter[] parametreler =
            {
                new SqlParameter { ParameterName = "odaNumara", Value = oda.OdaNumara},
                new SqlParameter { ParameterName = "odaKat", Value = oda.OdaKat},
                new SqlParameter { ParameterName = "odaKisiSayisi", Value = oda.OdaKisiSayisi},
                new SqlParameter { ParameterName = "odaFiyat", Value = oda.OdaFiyat},
                new SqlParameter { ParameterName = "odaAciklama", Value = oda.OdaAciklama},
                new SqlParameter { ParameterName = "odaDoluMu", Value = oda.OdaDoluMu},
                new SqlParameter { ParameterName = "odaAktifMi", Value = oda.OdaAktifMi},
                new SqlParameter { ParameterName = "eskiOdaNumara", Value = EskiOdaNo}
            };

            int guncellenenOdaSayisi = SQLHelper.ExecuteNonQuery("UPDATE odalar SET odaNumara = @odaNumara, odaKat = @odaKat, odaKisiSayisi = @odaKisiSayisi, odaFiyat = @odaFiyat, odaAciklama = @odaAciklama, odaDoluMu = @odaDoluMu, odaAktifMi = @odaAktifMi  WHERE odaNumara = @eskiOdaNumara)", parametreler);

            return guncellenenOdaSayisi;
        }

        //Delete
        public int deleteOda(int id)
        {
            int silinenOdaSayisi = SQLHelper.ExecuteNonQuery($"UPDATE odalar SET odaAktifMi = 0 WHERE odaNumara = {id}");

            return silinenOdaSayisi;
        }
    }
}
