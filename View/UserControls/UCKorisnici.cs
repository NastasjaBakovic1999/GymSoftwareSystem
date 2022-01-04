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
    public partial class UCKorisnici : UserControl
    {
        private KorisniciController korisniciController;

        public UCKorisnici()
        {
            InitializeComponent();
        }

        public UCKorisnici(KorisniciController korisniciController)
        {
            InitializeComponent();
            this.korisniciController = korisniciController;
            korisniciController.UcitajKorisnike(dgvKorisnici);
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            korisniciController.PretraziKorisnike(txtPretraga, dgvKorisnici);
        }

        private void btnObrisiKorisnika_Click(object sender, EventArgs e)
        {
            korisniciController.ObrisiKorisnika(dgvKorisnici);
            dgvKorisnici.DataSource = null;
            korisniciController.UcitajKorisnike(dgvKorisnici);
        }

        private void btnSviKorisnici_Click(object sender, EventArgs e)
        {
            dgvKorisnici.DataSource = null;
            korisniciController.UcitajKorisnike(dgvKorisnici);
        }

        private void btnPrikaziDetalje_Click(object sender, EventArgs e)
        {
            korisniciController.UcitajKorisnika(dgvKorisnici, txtIme, txtPrezime, txtAdresa, txtJMBG, dtpDatumRodjenja);
        }

        //private void UCKorisnici_Load(object sender, EventArgs e)
        //{
        //    dgvKorisnici = null;
        //    korisniciController.UcitajKorisnike(dgvKorisnici);
        //}
    }
}
