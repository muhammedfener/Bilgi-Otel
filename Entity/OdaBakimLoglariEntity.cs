using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class OdaBakimLoglariEntity
    {
        public int BakimID { get; set; }
        public int OdaNumara { get; set; }
        public string BakimAciklama { get; set; }
        public DateTime BakimBaslangicTarihi { get; set; }
        public DateTime BakimBitisTarihi { get; set; }
        public bool BakimBittiMi { get; set; }
    }
}
