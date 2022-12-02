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
    public partial class FrmCalisanlar : Form
    {
        public FrmCalisanlar()
        {
            InitializeComponent();
        }

        private void FrmCalisanlar_Load(object sender, EventArgs e)
        {
            ComboBox[] MeslekCmbler = { cmbMeslek };
            Islemler.CmbDoldur(MeslekCmbler,Islemler.Meslekler);
            Islemler.LvDoldur(lvwCalisanListesi, "Calisanlar");
        }
    }
}
