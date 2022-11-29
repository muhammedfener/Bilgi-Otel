using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiOtelDAL
{
    public class MusteriHarcamalarDAL
    {
        //Rezervasyon ID ile Getir

        public List<MusteriHarcamalarEntity> getMusteriHarcama(int rezervasyonID)
        {
            SqlDataReader musteriHarcamalar = SQLHelper.ExecuteReader($"SELECT * FROM musteriHarcamalar WHERE rezervasyonID = {rezervasyonID}");

            List<MusteriHarcamalarEntity> MusteriHarcamalar = new List<MusteriHarcamalarEntity>();

            while (musteriHarcamalar.Read())
            {
                MusteriHarcamalarEntity musteriHarcama = new MusteriHarcamalarEntity();
                musteriHarcama.MusteriHarcamaID = (int)musteriHarcamalar[0];
                musteriHarcama.UrunID = (int)musteriHarcamalar[1];
                musteriHarcama.UrunAdet = (int)musteriHarcamalar[2];
                musteriHarcama.MusteriID = (int)musteriHarcamalar[3];
                musteriHarcama.RezervasyonID = (int)musteriHarcamalar[4];
                musteriHarcama.UrunSatinAlmaTarihi = (DateTime)musteriHarcamalar[5];
                musteriHarcama.ToplamUcret = (decimal)musteriHarcamalar[6];
                musteriHarcama.OdendiMi = (bool)musteriHarcamalar[7];
                musteriHarcama.HarcamaAktifMi = (bool)musteriHarcamalar[8];

                MusteriHarcamalar.Add(musteriHarcama);
            }

            return MusteriHarcamalar;
        }

        //Hepsini Getir
        public List<MusteriHarcamalarEntity> getMusteriHarcamalar()
        {
            SqlDataReader musteriHarcamalar = SQLHelper.ExecuteReader("SELECT * FROM musteriHarcamalar WHERE harcamaAktifMi = 1");

            List<MusteriHarcamalarEntity> MusteriHarcamalar = new List<MusteriHarcamalarEntity>();

            while (musteriHarcamalar.Read())
            {
                MusteriHarcamalarEntity musteriHarcama = new MusteriHarcamalarEntity();
                musteriHarcama.MusteriHarcamaID = (int)musteriHarcamalar[0];
                musteriHarcama.UrunID = (int)musteriHarcamalar[1];
                musteriHarcama.UrunAdet = (int)musteriHarcamalar[2];
                musteriHarcama.MusteriID = (int)musteriHarcamalar[3];
                musteriHarcama.RezervasyonID = (int)musteriHarcamalar[4];
                musteriHarcama.UrunSatinAlmaTarihi = (DateTime)musteriHarcamalar[5];
                musteriHarcama.ToplamUcret = (decimal)musteriHarcamalar[6];
                musteriHarcama.OdendiMi = (bool)musteriHarcamalar[7];
                musteriHarcama.HarcamaAktifMi = (bool)musteriHarcamalar[8];

                MusteriHarcamalar.Add(musteriHarcama);
            }

            return MusteriHarcamalar;
        }

        //Insert
        public int insertHarcama(MusteriHarcamalarEntity harcama)
        {
            SqlParameter[] parametreler =
            {
                new SqlParameter { ParameterName = "urunID", Value = harcama.UrunID},
                new SqlParameter { ParameterName = "urunAdet", Value = harcama.UrunAdet},
                new SqlParameter { ParameterName = "musteriID", Value = harcama.MusteriID},
                new SqlParameter { ParameterName = "rezervasyonID", Value = harcama.RezervasyonID},
                new SqlParameter { ParameterName = "urunSatinAlmaTarihi", Value = harcama.UrunSatinAlmaTarihi},
                new SqlParameter { ParameterName = "toplamUcret", Value = harcama.ToplamUcret},
                new SqlParameter { ParameterName = "odendiMi", Value = harcama.OdendiMi},
                new SqlParameter { ParameterName = "harcamaAktifMi", Value = harcama.HarcamaAktifMi}
            };

            int eklenenHarcamaSayisi = SQLHelper.ExecuteNonQuery("INSERT INTO musteriHarcamalar (urunID,urunAdet,musteriID,rezervasyonID,urunSatinAlmaTarihi,toplamUcret,odendiMi,harcamaAktifMi) VALUES (@urunID,@urunAdet,@musteriID,@rezervasyonID,@urunSatinAlmaTarihi,@toplamUcret,@odendiMi,@harcamaAktifMi)", parametreler);


            return eklenenHarcamaSayisi;
        }
        //Update

        public int updateHarcama(MusteriHarcamalarEntity harcama)
        {
            SqlParameter[] parametreler =
            {
                new SqlParameter { ParameterName = "musteriHarcamaID", Value = harcama.MusteriHarcamaID},
                new SqlParameter { ParameterName = "urunID", Value = harcama.UrunID},
                new SqlParameter { ParameterName = "urunAdet", Value = harcama.UrunAdet},
                new SqlParameter { ParameterName = "musteriID", Value = harcama.MusteriID},
                new SqlParameter { ParameterName = "rezervasyonID", Value = harcama.RezervasyonID},
                new SqlParameter { ParameterName = "urunSatinAlmaTarihi", Value = harcama.UrunSatinAlmaTarihi},
                new SqlParameter { ParameterName = "toplamUcret", Value = harcama.ToplamUcret},
                new SqlParameter { ParameterName = "odendiMi", Value = harcama.OdendiMi},
                new SqlParameter { ParameterName = "harcamaAktifMi", Value = harcama.HarcamaAktifMi}
            };

            int guncellenenHarcamaSayisi = SQLHelper.ExecuteNonQuery("UPDATE musteriHarcamalar SET urunID = @urunID, urunAdet = @urunAdet, musteriID = @musteriID,rezervasyonID = @rezervasyonID, urunSatinAlmaTarihi = @urunSatinAlmaTarihi, toplamUcret = @toplamUcret, odendiMi = @odendiMi, harcamaAktifMi = @harcamaAktifMi  WHERE musteriHarcamaID = @musteriHarcamaID)", parametreler);

            return guncellenenHarcamaSayisi;
        }

        //Harcama Odendi
        public int odeHarcama(int id)
        {
            int odenenHarcamaSayisi = SQLHelper.ExecuteNonQuery($"UPDATE musteriHarcamalar SET odendiMi = 1 WHERE musteriHarcamalar = {id}");

            return odenenHarcamaSayisi;
        }

        //Delete
        public int deleteHarcama(int id)
        {
            int silinenHarcamaSayisi = SQLHelper.ExecuteNonQuery($"UPDATE musteriHarcamalar SET harcamaAktifMi = 0 WHERE musteriHarcamalar = {id}");

            return silinenHarcamaSayisi;
        }
    }
}
