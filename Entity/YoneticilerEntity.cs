using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class YoneticilerEntity
    {
        public int YoneticiID { get; set; }
        public string YoneticiAd { get; set; }
        public string YoneticiSoyad { get; set; }
        public string YoneticiTelefon { get; set; }
        public string YoneticiTCKimlik { get; set; }
        public string YoneticiAdres { get; set; }
        public string YoneticiIrtibaTelefon { get; set; }
        public DateTime YoneticiIseBaslamaTarihi { get; set; }
        public DateTime YoneticiIstenAyrilmaTarihi { get; set; }
        public int YoneticiMeslekID { get; set; }
        public decimal YoneticiMaas { get; set; }
        public bool YoneticiAktifMi { get; set; }
    }
}
