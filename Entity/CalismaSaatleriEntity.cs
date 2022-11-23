using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class CalismaSaatleriEntity
    {
        public int CalismaSaatleriID { get; set; }
        public int CalisanID { get; set; }
        public int VardiyaID { get; set; }
        public DateTime CalismaBaslangicTarihi { get; set; }
        public DateTime CalismaBitisTarihi { get; set; }
    }
}
