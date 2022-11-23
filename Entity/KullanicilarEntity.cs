using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class KullanicilarEntity
    {
        public int KullaniciID { get; set; }
        public string KullaniciAdi { get; set; }
        public string KullaniciSifre { get; set; }
        public string KullaniciMail { get; set; }
        public DateTime KullaniciKayitTarihi { get; set; }
        public int KullaniciCalisanID { get; set; }
        public int KullaniciYoneticiID { get; set; }
        public bool KullaniciAktifMi { get; set; }

    }
}
