using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class MesleklerEntity
    {
        public int MeslekID { get; set; }
        public string MeslekAd { get; set; }
        public string MeslekAciklama { get; set; }
        public bool MeslekAktifMi { get; set; }
    }
}
