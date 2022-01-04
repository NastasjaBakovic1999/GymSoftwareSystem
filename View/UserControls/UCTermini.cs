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
    public partial class UCTermini : UserControl
    {
        private TerminiController terminiController;

        public UCTermini()
        {
            InitializeComponent();
        }

        public UCTermini(TerminiController terminiController)
        {
            InitializeComponent();
            this.terminiController = terminiController;
            terminiController.UcitajTermine(dgvTermini);
        }

        private void btnObrisiTermin_Click(object sender, EventArgs e)
        {
            terminiController.ObrisiTermin(dgvTermini);
            dgvTermini.DataSource = null;
            terminiController.UcitajTermine(dgvTermini);
        }
    }
}
