using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class MusteriHarcamalarEntity
    {
        public int MusteriHarcamaID { get; set; }
        public int UrunID { get; set; }
        public int UrunAdet { get; set; }
        public int MusteriID { get; set; }
        public int RezervasyonID { get; set; }
        public DateTime UrunSatinAlmaTarihi { get; set; }
        public decimal ToplamUcret { get; set; }
        public bool OdendiMi { get; set; }
        public bool HarcamaAktifMi { get; set; }
    }
}
