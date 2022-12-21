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
    public class MesailerDAL
    {
        //ID Getir

        public MesailerEntity getMesai(int id)
        {
            DataTable mesai = SQLHelper.GetDataTable($"SELECT * FROM mesailer WHERE mesaiID = {id}");

            MesailerEntity Mesai = new MesailerEntity();

            foreach(DataRow dr in mesai.Rows)
            {
                Mesai.MesaiID = dr[0].ToInt32();
                Mesai.CalisanID = dr[1].ToInt32();
                Mesai.MesaiBaslangicTarihi = dr[2].ToDateTime();
                Mesai.MesaiBitisTarihi = dr[3].ToDateTime();
            }

            return Mesai;
        }

        //Hepsini Getir
        public List<MesailerEntity> getMesailer()
        {
            DataTable mesailer = SQLHelper.GetDataTable("SELECT * FROM medenihal WHERE kampanyaAktifMi = 1");

            List<MesailerEntity> Mesailer = new List<MesailerEntity>();

            foreach (DataRow dr in mesailer.Rows)
            {
                MesailerEntity mesai = new MesailerEntity();
                mesai.MesaiID = dr[0].ToInt32();
                mesai.CalisanID = dr[1].ToInt32();
                mesai.MesaiBaslangicTarihi = dr[2].ToDateTime();
                mesai.MesaiBitisTarihi = dr[3].ToDateTime();

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
