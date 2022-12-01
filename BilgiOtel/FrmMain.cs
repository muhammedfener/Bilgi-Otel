using BilgiOtel.Properties;
using BilgiOtelDAL;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgiOtel
{
    public partial class FrmMain : Form
    {
        private Form AktifForm;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (pnlMenu.Width == 240)
            {
                pnlMenu.Width = 80;
                lblLogo.Visible = false;
                btnMenu.Dock = DockStyle.Top;
                btnMenu.Padding = new Padding(0, 0, 0, 0);
                btnMenu.Height = 80;
                foreach (Button button in pnlMenu.Controls.OfType<Button>())
                {
                    button.Text = "";
                    button.ImageAlign = ContentAlignment.MiddleCenter;
                }
            }
            else
            {
                pnlMenu.Width = 240;
                lblLogo.Visible = true;
                btnMenu.Dock = DockStyle.None;
                btnMenu.Padding = new Padding(0);
                btnMenu.Height = 50;
                foreach (Button button in pnlMenu.Controls.OfType<Button>())
                {
                    button.Text = button.Tag.ToString();
                }
            }
        }

        private void OpenForm(Form form)
        {
            if (AktifForm != null)
                AktifForm.Close();

            AktifForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            this.pnlForm.Controls.Add(form);
            this.pnlForm.Tag = form;
            this.Width = form.Width + pnlMenu.Width + 20;
            this.Height = form.Height + pnlHeader.Height + 30;
            form.BringToFront();
            form.Show();
            lblHeader.Text = form.Text;
        }

        private void btnOdaEkleDuzenle_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmOdalar());
        }

        private void btnCalisanEkleDuzenle_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmCalisanlar());
        }
    }
}
