using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiOtel
{
    public static class GenelIslemler
    {
        public static int ToInt32(this object sayi)
        {
            try
            {
                if (sayi == null) throw new Exception();
                int x = Convert.ToInt32(sayi);
                return x;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public static DateTime ToDateTime(this object tarih)
        {
            try
            {
                DateTime dt = Convert.ToDateTime(tarih);
                return dt;
            }
            catch
            {
                return DateTime.Now;
            }
        }

        public static Decimal ToDecimal(this object sayi)
        {
            try
            {
                decimal x = Convert.ToDecimal(sayi);
                return x;
            }
            catch
            {
                return 0;
            }
        }
    }
}
