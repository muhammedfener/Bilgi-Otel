using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class UrunlerEntity
    {
        public int UrunID { get; set; }
        public string UrunAdi { get; set; }
        public string UrunAciklama { get; set; }
        public decimal UrunFiyat { get; set; }
        public bool UrunAktifMi { get; set; }
    }
}
