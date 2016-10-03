using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Reflection.Emit;
using System.Resources;
using System.Windows.Forms;

namespace Broodjeszaak
{
    public partial class frmBroodjes : Form
    {
        private string keuzebroodje;

        public frmBroodjes()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblPrijs.Text = "";

            /*Btn uit zetten - mogen enkel werken indien de eerste keuze is opgegeven*/
            btnAjuin.Enabled = false;
            btnMayo.Enabled = false;
            btnKetchup.Enabled = false;
            btnKlein.Enabled = false;
            btnMiddel.Enabled = false;
            btnGroot.Enabled = false;
        }

        private void ActivateBtns()
        {
            btnAjuin.Enabled = true;
            btnMayo.Enabled = true;
            btnKetchup.Enabled = true;
            btnKlein.Enabled = true;
            btnMiddel.Enabled = true;
            btnGroot.Enabled = true;
        }

        /*private void Clicking(object sender, EventArgs e)
        {
            switch (((Button) sender).Text)
            {
                case "Martino":
                    Broodjes rx = new Martino();
                    keuzebroodje = "rx";
                    break;
                case "Smos":
                    Broodjes rx = new Smos();
                    keuzebroodje = "rx2";
                    break;
                case "Gebraden Kip":
                    Broodjes rx3 = new GebradenKip();
                    keuzebroodje = "rx3";
                    break;

            }

            
        }*/

        private void Resettxt()
        {
            lblPrijs.ResetText();
            txtresult.ResetText();
            ActivateBtns();
        }

        public void btnMartino_Click(object sender, EventArgs e)
        {
            Resettxt();
            Broodjes rx = new Martino();
            txtresult.Text += rx.GeefBeschrijving();
            lblPrijs.Text += rx.Kost();
        }

        private void btnSmos_Click(object sender, EventArgs e)
        {
            Resettxt();
            Broodjes rx = new Smos();
            txtresult.Text += rx.GeefBeschrijving();
            lblPrijs.Text += rx.Kost();
        }

        private void btnGebradenKip_Click(object sender, EventArgs e)
        {
            Resettxt();
            Broodjes rx = new GebradenKip();
            txtresult.Text += rx.GeefBeschrijving();
            lblPrijs.Text += rx.Kost();
        }

        private void btnKlein_Click(object sender, EventArgs e)
        {
           
        }

        private void btnMiddel_Click(object sender, EventArgs e)
        {

        }

        private void btnGroot_Click(object sender, EventArgs e)
        {

        }

        private void NewClick(object sender, EventArgs e)
        {
            /*Type t = typeof(Broodjes);*/
            MethodInfo m = GetType().GetMethod(((Button)sender).Text, BindingFlags.Instance | BindingFlags.Public);
            /*object rx = (object)m.Invoke(typeof(Broodjes));*/
            /*m.Invoke(rx, null);*/

            /* txtresult.Text += rx.GeefBeschrijving();
            lblPrijs.Text += rx.Kost();*/


        }

    }
}
