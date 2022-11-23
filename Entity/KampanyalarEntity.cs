using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class KampanyalarEntity
    {
        public int KampanyaID { get; set; }
        public string KampanyaAd { get; set; }
        public decimal KampanyaIndirimOrani { get; set; }
        public DateTime KampanyaBaslangic { get; set; }
        public DateTime KampanyaBitis { get; set; }
        public string KampanyaAciklama { get; set; }
        public bool KampanyaAktifMi { get; set; }
    }
}
