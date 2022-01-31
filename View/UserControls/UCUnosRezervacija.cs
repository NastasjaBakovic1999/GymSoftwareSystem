using Domen;
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

namespace View.UserControls
{
    public partial class UCUnosRezervacija : UserControl
    {
        private UnosRezervacijaController unosRezervacijaController;
        public BindingList<Rezervacija> rezervacije = new BindingList<Rezervacija>();

        public UCUnosRezervacija()
        {
            InitializeComponent();
        }

        public UCUnosRezervacija(UnosRezervacijaController unosRezervacijaController)
        {
            InitializeComponent();
            this.unosRezervacijaController = unosRezervacijaController;
            unosRezervacijaController.UcitajKorisnike(cmbKorisnici);
            unosRezervacijaController.UcitajTermine(cmbTermini);
        }

        private void btnDodajRezervaciju_Click(object sender, EventArgs e)
        {
            unosRezervacijaController.UnesiRezervaciju(cmbKorisnici, cmbTermini, this);
            dgvRezervacije.DataSource = null;
            unosRezervacijaController.UcitajRezervacije(dgvRezervacije, this);
        }

        private void btnObrisiRezervaciju_Click(object sender, EventArgs e)
        {
            unosRezervacijaController.ObrisiRezervaciju(dgvRezervacije, this);
            dgvRezervacije.DataSource = null;
            unosRezervacijaController.UcitajRezervacije(dgvRezervacije, this);
        }

        private void btnSacuvajRezervacije_Click(object sender, EventArgs e)
        {
            unosRezervacijaController.SacuvajRezervacije(dgvRezervacije, this, cmbKorisnici, cmbTermini);
        }
    }
}
