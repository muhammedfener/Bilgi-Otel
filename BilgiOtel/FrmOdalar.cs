using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgiOtel
{
    public partial class FrmOdalar : Form
    {
        public FrmOdalar()
        {
            InitializeComponent();
        }

        private void FrmOdalar_Load(object sender, EventArgs e)
        {
            Islemler.DataTableDoldur("SELECT odaNumara, odaKat, odaKisiSayisi, odaFiyat FROM odalar","Odalar");
            Islemler.LvDoldur(lvwOdaListesi, "Odalar");
        }
    }
}
