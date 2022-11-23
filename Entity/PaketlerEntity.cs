using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class PaketlerEntity
    {
        public int PaketID { get; set; }
        public string PaketAdi { get; set; }
        public decimal PaketFiyat { get; set; }
        public string PaketOzellik { get; set; }
        public bool PaketAktifMi { get; set; }
    }
}
