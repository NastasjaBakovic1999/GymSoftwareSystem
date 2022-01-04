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
    public partial class UCUsluge : UserControl
    {
        private UslugeController uslugeController;

        public UCUsluge()
        {
            InitializeComponent();
        }

        public UCUsluge(UslugeController uslugeController)
        {
            InitializeComponent();
            this.uslugeController = uslugeController;
            uslugeController.UcitajUsluge(dgvUsluge);
            uslugeController.UcitajTrenere(cmbTrener);
        }

        private void btnSacuvajUslugu_Click(object sender, EventArgs e)
        {
            uslugeController.SacuvajUslugu(txtNazivUsluge, cmbTrener);
            dgvUsluge.DataSource = null;
            uslugeController.UcitajUsluge(dgvUsluge);
        }

        private void btnObrisiUslugu_Click(object sender, EventArgs e)
        {
            uslugeController.ObrisiUslugu(dgvUsluge);
            dgvUsluge.DataSource = null;
            uslugeController.UcitajUsluge(dgvUsluge);
        }
    }
}
