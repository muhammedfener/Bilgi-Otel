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
    public partial class FrmMesailer : Form
    {
        public FrmMesailer()
        {
            InitializeComponent();
        }

        private void FrmMesailer_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 24; i++)
            {
                cmbBaslangicSaatler.Items.Add(i.ToString() + ":00");
                cmbBaslangicSaatler.SelectedIndex = 0;
                cmbBitisSaatler.Items.Add(i.ToString() + ":00");
                cmbBitisSaatler.SelectedIndex = 0;
            }
        }

        private void btnMesaiKaydet_Click(object sender, EventArgs e)
        {

        }
    }
}
