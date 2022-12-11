using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
                return new DateTime(1753,1,1);
            }
        }

        public static decimal ToDecimal(this object sayi)
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

        public static bool ToBoolean(this object ifade)
        {
            try
            {
                bool x = Convert.ToBoolean(ifade);
                return x;
            }
            catch
            {
                return false;
            }
        }
    }
}
