using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.ControllerV;

namespace View
{
    public partial class FrmMain : Form
    {
        private MainController mainController;

        public FrmMain()
        {
            InitializeComponent();
        }

        public FrmMain(MainController mainController)
        {
            InitializeComponent();
            this.mainController = mainController;
        }

        public void SetPanel(UserControl userControl)
        {
            pnlMain.Controls.Clear();
            pnlMain.BackgroundImage = null;
            userControl.Parent = pnlMain; // PROBATI STA SE DESI AKO STAVIMO pnlMain.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
        }

        private void korisniciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ne treba nista da se desi
        }

        private void uslugeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ne treba nista da se desi
        }

        private void sveUslugeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OpenUCUsluge(this);
        }

        private void terminiUslugaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OpenUCTermini(this);
        }

        private void dodajNoveTermineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OpenUCUnosTermina(this);
        }

        private void rezervacijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ne treba nista da se desi
        }

        private void sveRezervacijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OpenUCRezervacije(this);
        }

        private void dodajNoveRezervacijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OpenUCUnosRezervacija(this);
        }

        private void sviKorisniciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OpenUCKorisnici(this);
        }

        private void dodajNovogKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OpenUCUnosKorisnika(this);
        }
    }
}
