using BilgiOtelDAL;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgiOtel
{
    public partial class FrmOdalar : Form
    {
        OdalarDAL odalarDAL = new OdalarDAL();
        OdalarEntity SeciliOda;
        public FrmOdalar()
        {
            InitializeComponent();
        }

        private void FrmOdalar_Load(object sender, EventArgs e)
        {
            Islemler.DataTableDoldur("SELECT odaNumara, odaKat, odaKisiSayisi, odaFiyat FROM odalar","Odalar");
            Islemler.LvDoldur(lvwOdaListesi, "Odalar");
        }

        private void btnOdaSec_Click(object sender, EventArgs e)
        {
            btnOdaTemizle.PerformClick();

            SeciliOda = odalarDAL.getOda(lvwOdaListesi.SelectedItems[0].SubItems[0].Text.ToInt32());

            nudOdaNumara.Value = SeciliOda.OdaNumara;
            nudOdaKat.Value = SeciliOda.OdaKat;
            nudOdaKisi.Value = SeciliOda.OdaKisiSayisi;
            nudOdaFiyat.Value = SeciliOda.OdaFiyat;
            rtxOdaAciklama.Text = SeciliOda.OdaAciklama;

            DataTable odaOzellikler = SQLHelper.GetDataTable($"SELECT * FROM odalar_odaOzellik WHERE odaNumara = '{SeciliOda.OdaNumara}'");
            foreach (DataRow dr in odaOzellikler.Rows)
            {
                switch ((int)dr["ozellikID"])
                {
                    case 1:
                        cklOzellikler.SetItemChecked(0, true);
                        break;
                    case 2:
                        cklOzellikler.SetItemChecked(1, true);
                        break;
                    case 3:
                        cklOzellikler.SetItemChecked(2, true);
                        break;
                    case 4:
                        cklOzellikler.SetItemChecked(3, true);
                        break;
                    case 5:
                        cklOzellikler.SetItemChecked(4, true);
                        break;
                    case 6:
                        cklOzellikler.SetItemChecked(5, true);
                        break;
                    default:
                        break;
                }
            }

            DataTable odaYataklar = SQLHelper.GetDataTable($"SELECT * FROM odalar_odaYataklar WHERE odaNumara = '{SeciliOda.OdaNumara}'");

            foreach (DataRow dr in odaYataklar.Rows)
            {
                switch ((int)dr["yatakID"])
                {
                    case 1:
                        nudTekKisilikYatak.Value = Convert.ToDecimal(dr["yatakAdet"]);
                        break;
                    case 2:
                        nudCiftKisilikYatak.Value = Convert.ToDecimal(dr["yatakAdet"]);
                        break;
                    case 3:
                        chkKralOdasi.Checked = true;
                        break;
                }
            }
        }

        private void btnOdaTemizle_Click(object sender, EventArgs e)
        {
            Islemler.FormTemizle(this);
        }
    }
}
