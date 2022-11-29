using BilgiOtelDAL;
using Entity;
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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (pnlMenu.Width == 200)
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
                pnlMenu.Width = 200;
                lblLogo.Visible = true;
                btnMenu.Dock = DockStyle.None;
                btnMenu.Padding = new Padding(0);
                btnMenu.Height = 25;
                foreach (Button button in pnlMenu.Controls.OfType<Button>())
                {
                    button.Text = button.Tag.ToString();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MesleklerDAL mesleklerDAL = new MesleklerDAL();
            MesleklerEntity meslekler = new MesleklerEntity();
            meslekler.MeslekID = 1;
            meslekler.MeslekAciklama = "Tekniker";

        }
    }
}
