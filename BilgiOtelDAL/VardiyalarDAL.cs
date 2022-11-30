using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiOtelDAL
{
    public class VardiyalarDAL
    {
        //odaID'ye Göre Getir
        public VardiyalarEntity getVardiya(int id)
        {
            SqlDataReader vardiya = SQLHelper.ExecuteReader($"SELECT * FROM vardiyalar WHERE vardiyaID = {id}");

            VardiyalarEntity Vardiya = new VardiyalarEntity();

            while (vardiya.Read())
            {
                Vardiya.VardiyaID = (int)vardiya[0];
                Vardiya.VardiyaAralik = (string)vardiya[1];
            }

            return Vardiya;
        }

        //Hepsini Getir
        public List<VardiyalarEntity> getPaketler()
        {
            SqlDataReader vardiyalar = SQLHelper.ExecuteReader("SELECT * FROM vardiyalar");

            List<VardiyalarEntity> Vardiyalar = new List<VardiyalarEntity>();

            while (vardiyalar.Read())
            {
                VardiyalarEntity Vardiya = new VardiyalarEntity();
                Vardiya.VardiyaID = (int)vardiyalar[0];
                Vardiya.VardiyaAralik = (string)vardiyalar[1];

                Vardiyalar.Add(Vardiya);
            }

            return Vardiyalar;
        }

        //Insert
        public int insertVardiya(VardiyalarEntity vardiya)
        {
            SqlParameter[] parametreler =
            {
                new SqlParameter { ParameterName = "vardiyaAralik", Value = vardiya.VardiyaAralik}
            };

            int eklenenVardiyaSayisi = SQLHelper.ExecuteNonQuery("INSERT INTO vardiyalar (vardiyaAralik) VALUES (@vardiyaAralik)", parametreler);

            return eklenenVardiyaSayisi;
        }
        //Update

        public int updateVardiya(VardiyalarEntity vardiya)
        {
            SqlParameter[] parametreler =
            {
                new SqlParameter { ParameterName = "vardiyaID", Value = vardiya.VardiyaID},
                new SqlParameter { ParameterName = "vardiyaAralik", Value = vardiya.VardiyaAralik}
            };

            int guncellenenVardiyaSayisi = SQLHelper.ExecuteNonQuery("UPDATE vardiyalar SET vardiyaAralik = @vardiyaAralik WHERE vardiyaID = @vardiyaID)", parametreler);

            return guncellenenVardiyaSayisi;
        }

        //Delete
        public int deleteVardiya(int id)
        {
            int silinenVardiyaSayisi = SQLHelper.ExecuteNonQuery($"DELETE FROM vardiyalar WHERE vardiyaID = {id}");

            return silinenVardiyaSayisi;
        }
    }
}
