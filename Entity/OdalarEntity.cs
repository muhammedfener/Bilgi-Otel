using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class OdalarEntity
    {
        public int OdaNumara { get; set; }
        public int OdaKat { get; set; }
        public int OdaKisiSayisi { get; set; }
        public decimal OdaFiyat { get; set; }
        public string OdaAciklama { get; set; }
        public bool OdaDoluMu { get; set; }
        public bool OdaAktifMi { get; set; }
    }
}
