using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiOtelDAL
{
    public class PaketlerDAL
    {
        //odaID'ye Göre Getir
        public PaketlerEntity getPaket(int id)
        {
            SqlDataReader paket = SQLHelper.ExecuteReader($"SELECT * FROM paketler WHERE paketID = {id}");

            PaketlerEntity Paket = new PaketlerEntity();

            while (paket.Read())
            {
                Paket.PaketID = (int)paket[0];
                Paket.PaketAdi = (string)paket[1];
                Paket.PaketFiyat = (int)paket[2];
                Paket.PaketOzellik = (string)paket[3];
                Paket.PaketAktifMi = (bool)paket[4];
            }

            return Paket;
        }

        //Hepsini Getir
        public List<PaketlerEntity> getPaketler()
        {
            SqlDataReader paketler = SQLHelper.ExecuteReader("SELECT * FROM paketler WHERE paketAktifMi = 1");

            List<PaketlerEntity> Paketler = new List<PaketlerEntity>();

            while (paketler.Read())
            {
                PaketlerEntity Paket = new PaketlerEntity();
                Paket.PaketID = (int)paketler[0];
                Paket.PaketAdi = (string)paketler[1];
                Paket.PaketFiyat = (int)paketler[2];
                Paket.PaketOzellik = (string)paketler[3];
                Paket.PaketAktifMi = (bool)paketler[4];

                Paketler.Add(Paket);
            }

            return Paketler;
        }

        //Insert
        public int insertPaket(PaketlerEntity paket)
        {
            SqlParameter[] parametreler =
            {
                new SqlParameter { ParameterName = "paketAdi", Value = paket.PaketAdi},
                new SqlParameter { ParameterName = "paketFiyat", Value = paket.PaketFiyat},
                new SqlParameter { ParameterName = "paketOzellik", Value = paket.PaketOzellik},
                new SqlParameter { ParameterName = "paketAktifMi", Value = paket.PaketAktifMi}
            };

            int eklenenPaketSayisi = SQLHelper.ExecuteNonQuery("INSERT INTO paketler (paketAdi,paketFiyat,paketOzellik,paketAktifMi) VALUES (@paketAdi,@paketFiyat,@paketOzellik,@paketAktifMi)", parametreler);

            return eklenenPaketSayisi;
        }
        //Update

        public int updatePaket(PaketlerEntity paket)
        {
            SqlParameter[] parametreler =
            {
                new SqlParameter { ParameterName = "paketID", Value = paket.PaketID},
                new SqlParameter { ParameterName = "paketAdi", Value = paket.PaketAdi},
                new SqlParameter { ParameterName = "paketFiyat", Value = paket.PaketFiyat},
                new SqlParameter { ParameterName = "paketOzellik", Value = paket.PaketOzellik},
                new SqlParameter { ParameterName = "paketAktifMi", Value = paket.PaketAktifMi}
            };

            int guncellenenPaketSayisi = SQLHelper.ExecuteNonQuery("UPDATE paketler SET paketAdi = @paketAdi, paketFiyat = @paketFiyat, paketOzellik = @paketOzellik, paketAktifMi = @paketAktifMi WHERE paketID = @paketID)", parametreler);

            return guncellenenPaketSayisi;
        }

        //Delete
        public int deleteOda(int id)
        {
            int silinenPaketSayisi = SQLHelper.ExecuteNonQuery($"UPDATE paketler SET paketAktifMi = 0 WHERE paketID = {id}");

            return silinenPaketSayisi;
        }
    }
}
