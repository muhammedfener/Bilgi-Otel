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
    public class CalismaSaatleriDAL
    {

        //ID Getir
        public CalismaSaatleriEntity calismaSaatiGetir(int id)
        {
            DataTable calismaSaati = SQLHelper.GetDataTable($"SELECT * FROM calismaSaatleri WHERE calismaSaatleriID = {id}");

            CalismaSaatleriEntity CalismaSaati = new CalismaSaatleriEntity();

            foreach(DataRow dr in calismaSaati.Rows)
            {
                CalismaSaati.CalismaSaatleriID = dr[0].ToInt32();
                CalismaSaati.CalisanID = dr[1].ToInt32();
                CalismaSaati.VardiyaID = dr[2].ToInt32();
                CalismaSaati.CalismaBaslangicTarihi = dr[3].ToDateTime();
                CalismaSaati.CalismaBitisTarihi = dr[4].ToDateTime();
            }

            return CalismaSaati;
        }

        //Hepsini Getir
        public List<CalismaSaatleriEntity> calismaSaatleriGetir()
        {
            DataTable calismaSaatleri = SQLHelper.GetDataTable("SELECT * FROM calismaSaatleri");

            List<CalismaSaatleriEntity> CalismaSaatleri = new List<CalismaSaatleriEntity>();

            foreach (DataRow dr in calismaSaatleri.Rows)
            {
                CalismaSaatleriEntity calismaSaati = new CalismaSaatleriEntity();
                calismaSaati.CalismaSaatleriID = dr[0].ToInt32();
                calismaSaati.CalisanID = dr[1].ToInt32();
                calismaSaati.VardiyaID = dr[2].ToInt32();
                calismaSaati.CalismaBaslangicTarihi = dr[3].ToDateTime();
                calismaSaati.CalismaBitisTarihi = dr[4].ToDateTime();

                CalismaSaatleri.Add(calismaSaati);
            }

            return CalismaSaatleri;
        }

        //Insert
        public int calismaSaatiEkle(CalismaSaatleriEntity calismaSaati)
        {
            SqlParameter[] parametreler =
            {
                new SqlParameter { ParameterName = "calisanID", Value = calismaSaati.CalisanID},
                new SqlParameter { ParameterName = "vardiyaID", Value = calismaSaati.VardiyaID},
                new SqlParameter { ParameterName = "calismaBaslangicTarihi", Value = calismaSaati.CalismaBaslangicTarihi},
                new SqlParameter { ParameterName = "calismaBitisTarihi", Value = calismaSaati.CalismaBitisTarihi}
            };

            int eklenenCalismaSaatiSayisi = SQLHelper.ExecuteNonQuery("INSERT INTO calismaSaatleri (calisanID,vardiyaID,calismaBaslangicTarihi,calismaBitisTarihi) VALUES (@calisanID, @vardiyaID,@calismaBaslangicTarihi,@calismaBitisTarihi)", parametreler);


            return eklenenCalismaSaatiSayisi;
        }

        //Update
        public int calismaSaatiGuncelle(CalismaSaatleriEntity calismaSaati)
        {
            SqlParameter[] parametreler =
            {
                new SqlParameter { ParameterName = "calismaSaatleriID", Value = calismaSaati.CalismaSaatleriID},
                new SqlParameter { ParameterName = "calisanID", Value = calismaSaati.CalisanID},
                new SqlParameter { ParameterName = "vardiyaID", Value = calismaSaati.VardiyaID},
                new SqlParameter { ParameterName = "calismaBaslangicTarihi", Value = calismaSaati.CalismaBaslangicTarihi},
                new SqlParameter { ParameterName = "calismaBitisTarihi", Value = calismaSaati.CalismaBitisTarihi}
            };

            int guncellenenCalismaSaatiSayisi = SQLHelper.ExecuteNonQuery("UPDATE calismaSaatleri SET calisanID = @calisanID, vardiyaID = @vardiyaID, calismaBaslangicTarihi = @calismaBaslangicTarihi, calismaBitisTarihi = @calismaBitisTarihi WHERE calismaSaatleriID = @calismaSaatleriID", parametreler);

            return guncellenenCalismaSaatiSayisi;
        }

        //Delete
        public int calismaSaatiSil(int id)
        {
            int silinenCalismaSaatiSayisi = SQLHelper.ExecuteNonQuery($"DELETE FROM calismaSaatleri WHERE calismaSaatleriID = {id}");

            return silinenCalismaSaatiSayisi;
        }
    }
}
