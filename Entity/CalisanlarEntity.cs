using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class CalisanlarEntity
    {
        public int CalisanID { get; set; }
        public string CalisanAd { get; set; }
        public string CalisanSoyad { get; set; }
        public string CalisanTelefon { get; set; }
        public string CalisanTCKimlik { get; set; }
        public string CalisanAdres { get; set; }
        public string CalisanIrtibatTelefon { get; set; }
        public DateTime CalisanIseBaslamaTarihi { get; set; }
        public DateTime CalisanIstenAyrilmaTarihi { get; set; }
        public int CalisanMeslekID { get; set; }
        public decimal CalisanSaatlikUcret { get; set; }
        public bool CalisanAktifMi { get; set; }
    }
}
