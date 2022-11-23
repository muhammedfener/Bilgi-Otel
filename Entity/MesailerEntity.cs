using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class MesailerEntity
    {
        public int MesaiID { get; set; }
        public int CalisanID { get; set; }
        public DateTime MesaiBaslangicTarihi { get; set; }
        public DateTime MesaiBitisTarihi { get; set; }
    }
}
