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
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

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
                btnMenu.Height = 25;
                foreach (Button button in pnlMenu.Controls.OfType<Button>())
                {
                    button.Text = button.Tag.ToString();
                }
            }
        }

        private void btnOdaEkleDuzenle_Click(object sender, EventArgs e)
        {

        }

        private void btnCalisanEkleDuzenle_Click(object sender, EventArgs e)
        {
        }
    }
}
