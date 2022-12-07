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
    public class OdalarDAL
    {
        //odaID'ye Göre Getir
        public OdalarEntity getOda(int odaid)
        {
            DataTable oda = SQLHelper.GetDataTable($"SELECT * FROM odalar WHERE odaNumara = {odaid}");

            OdalarEntity Oda = new OdalarEntity();

            foreach (DataRow dr in oda.Rows)
            {
                Oda.OdaNumara = (int)dr[0];
                Oda.OdaKat = (int)dr[1];
                Oda.OdaKisiSayisi = (int)dr[2];
                Oda.OdaFiyat = (decimal)dr[3];
                Oda.OdaAciklama = (string)dr[4];
                Oda.OdaDoluMu = (bool)dr[5];
                Oda.OdaAktifMi = (bool)dr[6];
            }

            return Oda;
        }

        //Hepsini Getir
        public List<OdalarEntity> getOdalar()
        {
            DataTable odalar = SQLHelper.GetDataTable("SELECT * FROM odalar");

            List<OdalarEntity> Odalar = new List<OdalarEntity>();

            foreach (DataRow dr in odalar.Rows)
            {
                OdalarEntity Oda = new OdalarEntity();
                Oda.OdaNumara = (int)dr[0];
                Oda.OdaKat = (int)dr[1];
                Oda.OdaKisiSayisi = (int)dr[2];
                Oda.OdaFiyat = (decimal)dr[3];
                Oda.OdaAciklama = (string)dr[4];
                Oda.OdaDoluMu = (bool)dr[5];
                Oda.OdaAktifMi = (bool)dr[6];

                Odalar.Add(Oda);
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

            int guncellenenOdaSayisi = SQLHelper.ExecuteNonQuery("UPDATE odalar SET odaNumara = @odaNumara, odaKat = @odaKat, odaKisiSayisi = @odaKisiSayisi, odaFiyat = @odaFiyat, odaAciklama = @odaAciklama, odaDoluMu = @odaDoluMu, odaAktifMi = @odaAktifMi  WHERE odaNumara = @eskiOdaNumara", parametreler);

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
