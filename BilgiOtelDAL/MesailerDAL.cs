using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiOtelDAL
{
    public class MesailerDAL
    {
        //ID Getir

        public MesailerEntity getMesai(int id)
        {
            SqlDataReader mesai = SQLHelper.ExecuteReader($"SELECT * FROM mesailer WHERE mesaiID = {id}");

            MesailerEntity Mesai = new MesailerEntity();

            while (mesai.Read())
            {
                Mesai.MesaiID = (int)mesai[0];
                Mesai.CalisanID = (int)mesai[1];
                Mesai.MesaiBaslangicTarihi = (DateTime)mesai[2];
                Mesai.MesaiBitisTarihi = (DateTime)mesai[3];
            }

            return Mesai;
        }

        //Hepsini Getir
        public List<MesailerEntity> getMesailer()
        {
            SqlDataReader mesailer = SQLHelper.ExecuteReader("SELECT * FROM medenihal WHERE kampanyaAktifMi = 1");

            List<MesailerEntity> Mesailer = new List<MesailerEntity>();

            while (mesailer.Read())
            {
                MesailerEntity mesai = new MesailerEntity();
                mesai.MesaiID = (int)mesailer[0];
                mesai.CalisanID = (int)mesailer[1];
                mesai.MesaiBaslangicTarihi = (DateTime)mesailer[2];
                mesai.MesaiBitisTarihi = (DateTime)mesailer[3];

                Mesailer.Add(mesai);
            }

            return Mesailer;
        }

        //Insert
        public int insertMesai(MesailerEntity mesai)
        {
            SqlParameter[] parametreler =
            {
                new SqlParameter { ParameterName = "calisanID", Value = mesai.CalisanID},
                new SqlParameter { ParameterName = "mesaiBaslangicTarihi", Value = mesai.MesaiBaslangicTarihi},
                new SqlParameter { ParameterName = "mesaiBitisTarihi", Value = mesai.MesaiBitisTarihi}
            };

            int eklenenMesaiSayisi = SQLHelper.ExecuteNonQuery("INSERT INTO mesailer (calisanID, mesaiBaslangicTarihi, mesaiBitisTarihi) VALUES (@calisanID, @mesaiBaslangicTarihi, @mesaiBitisTarihi)", parametreler);

            return eklenenMesaiSayisi;
        }
        //Update

        public int updateMesai(MesailerEntity mesai)
        {
            SqlParameter[] parametreler =
            {
                new SqlParameter { ParameterName = "mesaiID", Value = mesai.MesaiID},
                new SqlParameter { ParameterName = "calisanID", Value = mesai.CalisanID},
                new SqlParameter { ParameterName = "mesaiBaslangicTarihi", Value = mesai.MesaiBaslangicTarihi},
                new SqlParameter { ParameterName = "mesaiBitisTarihi", Value = mesai.MesaiBitisTarihi}
            };

            int guncellenenMesaiSayisi = SQLHelper.ExecuteNonQuery("UPDATE mesailer SET calisanID = @calisanID, mesaiBaslangicTarihi = @mesaiBaslangicTarihi, mesaiBitisTarihi = @mesaiBitisTarihi WHERE mesaiID = @mesaiID", parametreler);

            return guncellenenMesaiSayisi;
        }

        //Delete
        public int deleteMesai(int id)
        {
            int silinenMesaiSayisi = SQLHelper.ExecuteNonQuery($"DELETE FROM mesailer WHERE mesaiID = {id}");

            return silinenMesaiSayisi;
        }
    }
}
