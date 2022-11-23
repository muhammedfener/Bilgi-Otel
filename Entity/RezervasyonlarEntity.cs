using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class RezervasyonlarEntity
    {
        public int RezervasyonID { get; set; }
        public int MusteriID { get; set; }
        public int KacKisi { get; set; }
        public int OdaNumara { get; set; }
        public int PaketID { get; set; }
        public DateTime RezervasyonYapilmaTarihi { get; set; }
        public DateTime RezervasyonBaslangicTarihi { get; set; }
        public DateTime RezervasyonCikisTarihi { get; set; }
        public decimal RezervasyonUcreti { get; set; }
        public bool GirisYapildiMi { get; set; }
        public bool RezervasyonIptalMi { get; set; }
        public bool RezervasyonInternettenMi { get; set; }
        public bool CikisYapildiMi { get; set; }
    }
}
