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
    public partial class UCUnosKorisnika : UserControl
    {
        private UnosKorisnikaController unosKorisnikaController;

        public UCUnosKorisnika()
        {
            InitializeComponent();
            dtpDatumRodjenja.Value = DateTime.Today.Date;
        }

        public UCUnosKorisnika(UnosKorisnikaController unosKorisnikaKontroler)
        {
            InitializeComponent();
            this.unosKorisnikaController = unosKorisnikaKontroler;
        }

        private void btnSacuvajKorisnika_Click(object sender, EventArgs e)
        {
            unosKorisnikaController.SacuvajKorisnika(txtIme, txtPrezime, txtJMBG, dtpDatumRodjenja, txtAdresa);
        }

      

    }
}
