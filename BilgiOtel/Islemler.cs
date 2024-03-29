﻿using BilgiOtelDAL;
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
        public static List<KeyValuePair<string, Dictionary<int, string>>> Listeler = new List<KeyValuePair<string, Dictionary<int, string>>>();
        public static Dictionary<int, string> Meslekler = new Dictionary<int, string>();
        public static DataSet Listviewdata = new DataSet();
        public static void DataTableDoldur(string sqlkod, string dataTableName, bool storeProcedure = false, bool guncelle = false)
        {
            if (Listviewdata.Tables.Contains(dataTableName) && !guncelle)
            {
                return;
            }
            if (guncelle)
            {
                Listviewdata.Tables.Remove(dataTableName);
            }
            DataTable dt;
            if (storeProcedure)
            {
                dt = SQLHelper.GetDataTable(sqlkod,CommandType.StoredProcedure,null);
            }
            else
            {
                dt = SQLHelper.GetDataTable(sqlkod);
            }
            dt.TableName = dataTableName;
            Listviewdata.Tables.Add(dt);
        }

        private static void CmbListeDoldur(string listeAdi,string sqlCommand)
        {
            if(!Listeler.FirstOrDefault(x=> x.Key == listeAdi).Equals(default(KeyValuePair<string, Dictionary<int, string>>)))
            {
                Listeler.Remove(Listeler.First(x => x.Key == listeAdi));
            }

            DataTable dt = SQLHelper.GetDataTable(sqlCommand);
            Dictionary<int,string> dict = new Dictionary<int, string>();

            foreach(DataRow dr in dt.Rows)
            {
                dict.Add(dr[0].ToInt32(), dr[1].ToString());
            }
            Listeler.Add(new KeyValuePair<string,Dictionary<int,string>>(listeAdi, dict));

        }

        public static void CmbDoldur(ComboBox combobox,string listeAdi,string sqlCommand)
        {
            CmbListeDoldur(listeAdi,sqlCommand);

            combobox.DataSource = Listeler.First(x=> x.Key == listeAdi).Value.ToList();
            combobox.ValueMember = "Key";
            combobox.DisplayMember = "Value";
        }

        public static void LvDoldur(ListView listView, string dataTableName, bool onlyDate = false)
        {
            listView.Items.Clear();

            DataTable dt = Listviewdata.Tables[dataTableName];
            foreach(DataRow dr in dt.Rows)
            {
                string[] satir = new string[dr.Table.Columns.Count];
                for (int i=0;i < dr.Table.Columns.Count; i++)
                {
                    if (onlyDate)
                    {
                        if (dr.Table.Columns[i].DataType == typeof(DateTime))
                        {
                            satir[i] = dr[i].ToDateTime().ToString("dd.MM.yyyy");
                        }
                        else
                        {
                            satir[i] = dr[i].ToString();
                        }
                        continue;
                    }
                    satir[i] = dr[i].ToString();
                }

                var lvitem = new ListViewItem(satir);

                listView.Items.Add(lvitem);
            }
        }

        public static void FormTemizle(Form form)
        {
            foreach(var control in form.Controls)
            {
                if (control is NumericUpDown)
                {
                    NumericUpDown nud = (NumericUpDown)control;
                    nud.Value = 0;
                }

                if (control is CheckedListBox)
                {
                    CheckedListBox ckl = (CheckedListBox)control;
                    for (int i = 0; i < ckl.Items.Count; i++)
                    {
                        ckl.SetItemCheckState(i, CheckState.Unchecked);
                    }
                }

                if (control is TextBox)
                {
                    TextBox txt = (TextBox)control;
                    txt.Text = "";
                }

                if (control is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)control;
                    dtp.Value = DateTime.Now;
                }

                if (control is RichTextBox)
                {
                    RichTextBox rtx = (RichTextBox)control;
                    rtx.Text = "";
                }

                if (control is CheckBox)
                {
                    CheckBox cb = (CheckBox)control;
                    cb.Checked = false;
                }

                if (control is ComboBox)
                {
                    ComboBox cmb = (ComboBox)control;
                    cmb.SelectedIndex = -1;
                }
            }
        }
    }
}
