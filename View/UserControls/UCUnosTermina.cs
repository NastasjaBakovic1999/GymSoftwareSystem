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
    public partial class UCUnosTermina : UserControl
    {
        private UnosTerminaController unosTerminaController;
        public BindingList<Termin> termini = new BindingList<Termin>();

        public UCUnosTermina()
        {
            InitializeComponent();
            dtpDatum.Value = DateTime.Today.Date;
        }

        public UCUnosTermina(UnosTerminaController unosTerminaController)
        {
            InitializeComponent();
            this.unosTerminaController = unosTerminaController;
            unosTerminaController.UcitajUsluge(cmbUsluge);
            unosTerminaController.UcitajSale(cmbSale);
            dtpDatum.Value = DateTime.Today.Date;
        }

        private void btnDodajTermin_Click(object sender, EventArgs e)
        {
            unosTerminaController.UnesiTermin(cmbUsluge, cmbSale, nudKapacitet, dtpDatum,dgvTermini,txtSati,txtMinuti, this);
            dgvTermini.DataSource = null;
            unosTerminaController.UcitajTermine(dgvTermini, this);
        }

        private void btnObrisiTermin_Click(object sender, EventArgs e)
        {
            unosTerminaController.ObrisiTermin(dgvTermini, this);
            dgvTermini.DataSource = null;
            unosTerminaController.UcitajTermine(dgvTermini, this);
        }

        private void btnSacuvajTermine_Click(object sender, EventArgs e)
        {
            unosTerminaController.SacuvajTermine(dgvTermini, this);
        }
    }
}
