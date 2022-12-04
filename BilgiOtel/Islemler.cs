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
        public static void DataTableDoldur(string sqlkod, string dataTableName, bool Guncelle = false)
        {
            if (Listviewdata.Tables.Contains(dataTableName) && !Guncelle)
            {
                return;
            }
            if (Guncelle)
            {
                Listviewdata.Tables.Remove(dataTableName);
            }
            DataTable dt = SQLHelper.GetDataTable(sqlkod);
            dt.TableName = dataTableName;
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
            listView.Items.Clear();

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