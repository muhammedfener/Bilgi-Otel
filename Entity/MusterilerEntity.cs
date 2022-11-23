using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class MusterilerEntity
    {
        public int MusteriID { get; set; }
        public string MusteriAd { get; set; }
        public string MusteriSoyad { get; set; }
        public string MusteriTCKimlik { get; set; }
        public string MusteriTelefon { get; set; }
        public int MusteriMedeniHal { get; set; }
        public string MusteriMail { get; set; }
        public string MusteriSifre { get; set; }
        public bool MusteriAktifMi { get; set; }
    }
}
