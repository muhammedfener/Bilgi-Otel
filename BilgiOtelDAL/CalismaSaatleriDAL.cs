using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace BilgiOtelDAL
{
    public class CalismaSaatleriDAL
    {
        //ID Getir

        public CalismaSaatleriEntity getCalismaSaati(int id)
        {
            SqlDataReader calismaSaati = SQLHelper.ExecuteReader($"SELECT * FROM calismaSaatleri WHERE id = {id}");

            CalismaSaatleriEntity CalismaSaati = new CalismaSaatleriEntity();

            while (calismaSaati.Read())
            {
                CalismaSaati.CalismaSaatleriID = (int)calismaSaati[0];
                CalismaSaati.CalisanID = (int)calismaSaati[1];
                CalismaSaati.VardiyaID = (int)calismaSaati[2];
                CalismaSaati.CalismaBaslangicTarihi = (DateTime)calismaSaati[3];
                CalismaSaati.CalismaBitisTarihi = (DateTime)calismaSaati[4];
            }

            return CalismaSaati;
        }

        //Hepsini Getir
        public List<CalismaSaatleriEntity> getCalisanlar()
        {
            SqlDataReader calismaSaatleri = SQLHelper.ExecuteReader("SELECT * FROM calismaSaatleri WHERE");

            List<CalismaSaatleriEntity> CalismaSaatleri = new List<CalismaSaatleriEntity>();

            while (calismaSaatleri.Read())
            {
                CalismaSaatleriEntity calismaSaati = new CalismaSaatleriEntity();
                calismaSaati.CalismaSaatleriID = (int)calismaSaatleri[0];
                calismaSaati.CalisanID = (int)calismaSaatleri[1];
                calismaSaati.VardiyaID = (int)calismaSaatleri[2];
                calismaSaati.CalismaBaslangicTarihi = (DateTime)calismaSaatleri[3];
                calismaSaati.CalismaBitisTarihi = (DateTime)calismaSaatleri[4];

                CalismaSaatleri.Add(calismaSaati);
            }

            return CalismaSaatleri;
        }

        //Insert
        public int insertCalismaSaati(CalismaSaatleriEntity calismaSaati)
        {
            SqlParameter[] parametreler =
            {
                new SqlParameter { ParameterName = "calisanID", Value = calismaSaati.CalisanID},
                new SqlParameter { ParameterName = "vardiyaID", Value = calismaSaati.VardiyaID},
                new SqlParameter { ParameterName = "calismaBaslangicTarihi", Value = calismaSaati.CalismaBaslangicTarihi},
                new SqlParameter { ParameterName = "calismaBitisTarihi", Value = calismaSaati.CalismaBitisTarihi},
            };

            int eklenenCalismaSaatiSayisi = SQLHelper.ExecuteNonQuery("INSERT INTO calismaSaatleri (calisanID,vardiyaID,calismaBaslangicTarihi,calismaBitisTarihi) VALUES (@calisanID, @vardiyaID,@calismaBaslangicTarihi,@calismaBitisTarihi)", System.Data.CommandType.Text, parametreler);


            return eklenenCalismaSaatiSayisi;
        }
        //Update

        public int updateCalismaSaati(CalismaSaatleriEntity calismaSaati)
        {
            SqlParameter[] parametreler =
            {
                new SqlParameter { ParameterName = "calismaSaatleriID", Value = calismaSaati.CalismaSaatleriID},
                new SqlParameter { ParameterName = "calisanID", Value = calismaSaati.CalisanID},
                new SqlParameter { ParameterName = "vardiyaID", Value = calismaSaati.VardiyaID},
                new SqlParameter { ParameterName = "calismaBaslangicTarihi", Value = calismaSaati.CalismaBaslangicTarihi},
                new SqlParameter { ParameterName = "calismaBitisTarihi", Value = calismaSaati.CalismaBitisTarihi},
            };

            int guncellenenCalismaSaatiSayisi = SQLHelper.ExecuteNonQuery("UPDATE calismaSaatleri SET calisanID = @calisanID, vardiyaID = @vardiyaID, calismaBaslangicTarihi = @calismaBaslangicTarihi, calismaBitisTarihi = @calismaBitisTarihi WHERE calismaSaatleriID = @calismaSaatleriID", System.Data.CommandType.Text, parametreler);

            return guncellenenCalismaSaatiSayisi;
        }

        //Delete
        public int deleteCalisan(int id)
        {
            int silinenCalismaSaatiSayisi = SQLHelper.ExecuteNonQuery($"DELETE FROM calismaSaatleri WHERE calismaSaatleriID = {id}");

            return silinenCalismaSaatiSayisi;
        }
    }
}
