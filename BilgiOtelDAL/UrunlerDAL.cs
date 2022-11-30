using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiOtelDAL
{
    public class UrunlerDAL
    {
        //odaID'ye Göre Getir
        public UrunlerEntity getUrun(int id)
        {
            SqlDataReader urun = SQLHelper.ExecuteReader($"SELECT * FROM urunler WHERE urunID = {id}");

            UrunlerEntity Urun = new UrunlerEntity();

            while (urun.Read())
            {
                Urun.UrunID = (int)urun[0];
                Urun.UrunAdi = (string)urun[1];
                Urun.UrunAciklama = (string)urun[2];
                Urun.UrunFiyat = (decimal)urun[3];
                Urun.UrunAktifMi = (bool)urun[4];
            }

            return Urun;
        }

        //Hepsini Getir
        public List<UrunlerEntity> getPaketler()
        {
            SqlDataReader urunler = SQLHelper.ExecuteReader("SELECT * FROM urunler WHERE urunAktifMi = 1");

            List<UrunlerEntity> Urunler = new List<UrunlerEntity>();

            while (urunler.Read())
            {
                UrunlerEntity urun = new UrunlerEntity();
                urun.UrunID = (int)urunler[0];
                urun.UrunAdi = (string)urunler[1];
                urun.UrunAciklama = (string)urunler[2];
                urun.UrunFiyat = (decimal)urunler[3];
                urun.UrunAktifMi= (bool)urunler[4];

                Urunler.Add(urun);
            }

            return Urunler;
        }

        //Insert
        public int insertUrun(UrunlerEntity urun)
        {
            SqlParameter[] parametreler =
            {
                new SqlParameter { ParameterName = "urunAdi", Value = urun.UrunAdi},
                new SqlParameter { ParameterName = "urunAciklama", Value = urun.UrunAciklama},
                new SqlParameter { ParameterName = "urunFiyat", Value = urun.UrunFiyat},
                new SqlParameter { ParameterName = "urunAktifMi", Value = urun.UrunAktifMi}
            };

            int eklenenUrunSayisi = SQLHelper.ExecuteNonQuery("INSERT INTO urunler (urunAdi,urunAciklama,urunFiyat,urunAktifMi) VALUES (@urunAdi,@urunAciklama,@urunFiyat,@urunAktifMi)", parametreler);

            return eklenenUrunSayisi;
        }
        //Update

        public int updateUrun(UrunlerEntity urun)
        {
            SqlParameter[] parametreler =
            {
                new SqlParameter { ParameterName = "urunID", Value = urun.UrunID},
                new SqlParameter { ParameterName = "urunAdi", Value = urun.UrunAdi},
                new SqlParameter { ParameterName = "urunAciklama", Value = urun.UrunAciklama},
                new SqlParameter { ParameterName = "urunFiyat", Value = urun.UrunFiyat},
                new SqlParameter { ParameterName = "urunAktifMi", Value = urun.UrunAktifMi}
            };

            int guncellenenUrunSayisi = SQLHelper.ExecuteNonQuery("UPDATE urunler SET urunAdi = @urunAdi, urunAciklama = @urunAciklama, urunFiyat = @urunFiyat, urunAktifMi = @urunAktifMi WHERE urunID = @urunID)", parametreler);

            return guncellenenUrunSayisi;
        }

        //Delete
        public int deleteUrun(int id)
        {
            int silinenUrunSayisi = SQLHelper.ExecuteNonQuery($"UPDATE urunler SET urunAktifMi = 0 WHERE urunID = {id}");

            return silinenUrunSayisi;
        }
    }
}
