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
            Islemler.DataTableDoldur("SELECT * FROM vw_odalarLv","Odalar");
            Islemler.LvDoldur(lvwOdaListesi, "Odalar");
        }

        private void btnOdaSec_Click(object sender, EventArgs e)
        {
            btnOdaTemizle.PerformClick();

            SeciliOda = odalarDAL.odaGetirID(lvwOdaListesi.SelectedItems[0].SubItems[0].Text.ToInt32());

            nudOdaNumara.Value = SeciliOda.OdaNumara;
            nudOdaKat.Value = SeciliOda.OdaKat;
            nudOdaKisi.Value = SeciliOda.OdaKisiSayisi;
            nudOdaFiyat.Value = SeciliOda.OdaFiyat;
            rtxOdaAciklama.Text = SeciliOda.OdaAciklama;
            chkOdaAktifMi.Checked = SeciliOda.OdaDoluMu;

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

        private void btnOdaDuzenle_Click(object sender, EventArgs e)
        {
            try
            {
                OdalarEntity oda = new OdalarEntity();
                oda.OdaNumara = nudOdaNumara.Value.ToInt32();
                oda.OdaKat = nudOdaKat.Value.ToInt32();
                oda.OdaKisiSayisi = nudOdaKisi.Value.ToInt32();
                oda.OdaFiyat = nudOdaFiyat.Value;
                oda.OdaAciklama = rtxOdaAciklama.Text;
                oda.OdaDoluMu = false;
                oda.OdaAktifMi = chkOdaAktifMi.Checked;

                odalarDAL.odaDuzenle(oda, SeciliOda.OdaNumara);

                string commandstring = $"DELETE FROM odalar_odaYataklar WHERE odaNumara = {SeciliOda.OdaNumara}";
                SQLHelper.ExecuteNonQuery(commandstring);

                if (chkKralOdasi.Checked)
                {
                    commandstring = $"INSERT INTO odalar_odaYataklar (odaNumara,yatakID,yatakAdet) VALUES ({oda.OdaNumara},3,1)";
                }
                else
                {
                    commandstring = $"INSERT INTO odalar_odaYataklar (odaNumara,yatakID,yatakAdet) VALUES({oda.OdaNumara},1,{nudTekKisilikYatak.Value.ToInt32()}),({oda.OdaNumara},2,{nudCiftKisilikYatak.Value.ToInt32()})";
                }
                SQLHelper.ExecuteNonQuery(commandstring);

                commandstring = $"DELETE FROM odalar_odaOzellik WHERE odaNumara ={SeciliOda.OdaNumara};";
                SQLHelper.ExecuteNonQuery(commandstring);

                List<int> ozellikler = new List<int>();
                foreach (int itemIndices in cklOzellikler.CheckedIndices)
                {
                    ozellikler.Add(itemIndices + 1);
                }

                commandstring = "INSERT INTO odalar_odaOzellik (odaNumara,ozellikID) VALUES";
                int sonozellik = ozellikler.Last();
                foreach (int ozellik in ozellikler)
                {
                    if (ozellik.Equals(sonozellik))
                    {
                        commandstring += $"({oda.OdaNumara},{ozellik})";
                    }
                    else
                    {
                        commandstring += $"({oda.OdaNumara},{ozellik}),";
                    }
                }
                commandstring += ";";

                SQLHelper.ExecuteNonQuery(commandstring);

                Islemler.DataTableDoldur("SELECT * FROM vw_odalarLv", "Odalar", guncelle: true);
                Islemler.LvDoldur(lvwOdaListesi, "Odalar");
            }
            catch
            {
                MessageBox.Show("Oda Düzenlenirken Hata Oluştu!");

            }
        }

        private void btnOdaEkle_Click(object sender, EventArgs e)
        {
            try
            {
                OdalarEntity oda = new OdalarEntity();
                oda.OdaNumara = nudOdaNumara.Value.ToInt32();
                oda.OdaKat = nudOdaKat.Value.ToInt32();
                oda.OdaKisiSayisi = nudOdaKisi.Value.ToInt32();
                oda.OdaFiyat = nudOdaFiyat.Value;
                oda.OdaAciklama = rtxOdaAciklama.Text;
                oda.OdaDoluMu = false;
                oda.OdaAktifMi = chkOdaAktifMi.Checked;

                odalarDAL.odaEkle(oda);

                string commandstring;

                if (chkKralOdasi.Checked)
                {
                    commandstring = $"INSERT INTO odalar_odaYataklar (odaNumara,yatakID,yatakAdet) VALUES ({oda.OdaNumara},3,1)";
                }
                else
                {
                    commandstring = $"INSERT INTO odalar_odaYataklar (odaNumara,yatakID,yatakAdet) VALUES({oda.OdaNumara},1,{nudTekKisilikYatak.Value.ToInt32()}),({oda.OdaNumara},2,{nudCiftKisilikYatak.Value.ToInt32()})";
                }
                SQLHelper.ExecuteNonQuery(commandstring);

                List<int> ozellikler = new List<int>();
                foreach (int itemIndices in cklOzellikler.CheckedIndices)
                {
                    ozellikler.Add(itemIndices + 1);
                }

                commandstring = "INSERT INTO odalar_odaOzellik (odaNumara,ozellikID) VALUES";
                int sonozellik = ozellikler.Last();
                foreach (int ozellik in ozellikler)
                {
                    if (ozellik.Equals(sonozellik))
                    {
                        commandstring += $"({oda.OdaNumara},{ozellik})";
                    }
                    else
                    {
                        commandstring += $"({oda.OdaNumara},{ozellik}),";
                    }
                }
                commandstring += ";";

                SQLHelper.ExecuteNonQuery(commandstring);

                Islemler.DataTableDoldur("SELECT * FROM vw_odalarLv", "Odalar", guncelle: true);
                Islemler.LvDoldur(lvwOdaListesi, "Odalar");
            }
            catch
            {
                MessageBox.Show("Oda Eklenirken Hata Oluştu!");
            }
        }

        private void lvwOdaListesi_DoubleClick(object sender, EventArgs e)
        {
            btnOdaSec.PerformClick();
        }

        private void yenileButon_Click(object sender, EventArgs e)
        {
            FrmOdalar_Load(null, EventArgs.Empty);
        }

        private void duzenleButon_Click(object sender, EventArgs e)
        {
            if(lvwOdaListesi.SelectedItems.Count != 1)
            {
                MessageBox.Show("Düzenlemek İçin Bir Oda Seçin!");
                return;
            }

            btnOdaSec.PerformClick();
        }

        private void silButon_Click(object sender, EventArgs e)
        {
            if (lvwOdaListesi.SelectedItems.Count != 1)
            {
                MessageBox.Show("Silmek İçin Bir Oda Seçin!");
                return;
            }

            try
            {
                odalarDAL.odaSil(lvwOdaListesi.SelectedItems[0].SubItems[0].Text.ToInt32());
                FrmOdalar_Load(null, EventArgs.Empty);
            }
            catch
            {
                MessageBox.Show("Oda Silinirken Hata Oluştu!");
            }
        }
    }
}
