using BilgiOtelDAL;
using Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgiOtel
{
    public static class Islemler
    {
        public static Dictionary<int, string> Meslekler = new Dictionary<int, string>();
        //public static Dictionary<string,DataTable> ListViewDatalar = new Dictionary<string,DataTable>();
        public static DataSet Listviewdata = new DataSet();
        public static void CalisanDataTableDoldur()
        {
            /*if (ListViewDatalar.ContainsKey("Calisanlar"))
            {
                ListViewDatalar.Remove(ListViewDatalar.Keys.First(x => x == "Calisanlar"));
            }*/

            DataTable dt = SQLHelper.GetDataTable("SELECT (calisanAd + ' ' + calisanSoyad) as [Ad Soyad], calisanTCKimlik, calisanTelefon, meslekAd, calisanAdres, calisanSaatlikUcret FROM calisanlar JOIN meslekler ON meslekler.meslekID = calisanlar.calisanMeslekID");
            //ListViewDatalar.Add("Calisanlar", dt);
            dt.TableName = "Calisanlar";
            Listviewdata.Tables.Add(dt);

        }

        public static void MeslekListeDoldur()
        {
            Meslekler.Clear();

            MesleklerDAL mesleklerDAL = new MesleklerDAL();
            List<MesleklerEntity> meslekler = mesleklerDAL.getMeslekler();
            foreach(MesleklerEntity meslek in meslekler)
            {
                Meslekler.Add(meslek.MeslekID, meslek.MeslekAd);
            }
        }

        public static void CmbDoldur(ComboBox[] comboboxlar,Dictionary<int,string> Dictionary)
        {
            MeslekListeDoldur();

            foreach (ComboBox combobox in comboboxlar)
            {
                combobox.DataSource = Dictionary.ToList();
                combobox.ValueMember = "Key";
                combobox.DisplayMember = "Value";
            }
        }

        public static void LvDoldur(ListView listView, string dataTableName)
        {
            CalisanDataTableDoldur();
            //DataTable dt = ListViewDatalar.First(x => x.Key == dataTableName).Value;
            DataTable dt = Listviewdata.Tables[dataTableName];
            foreach(DataRow dr in dt.Rows)
            {
                string[] satir = new string[dr.Table.Columns.Count];
                for (int i=0;i < dr.Table.Columns.Count; i++)
                {
                    satir[i] = dr[i].ToString();
                }

                var lvitem = new ListViewItem(satir);

                listView.Items.Add(lvitem);
            }

        }
    }
}
