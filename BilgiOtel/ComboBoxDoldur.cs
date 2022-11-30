using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgiOtel
{
    public class ComboBoxDoldur
    {
        public static Dictionary<int, string> CalisanAdSoyadlar = new Dictionary<int, string>();

        public void CalisanCmbDoldur(ComboBox[] comboboxlar)
        {
            CalisanAdSoyadlar.Clear();

           foreach(ComboBox combobox in comboboxlar)
            {
                combobox.DataSource = ComboBoxDoldur.CalisanAdSoyadlar;
                combobox.ValueMember = "Key";
                combobox.DisplayMember = "Value";
            }
        }
    }
}
