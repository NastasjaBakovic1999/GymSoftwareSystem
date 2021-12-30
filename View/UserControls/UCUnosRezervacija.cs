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

        public UCUnosRezervacija()
        {
            InitializeComponent();
        }

        public UCUnosRezervacija(UnosRezervacijaController unosRezervacijaController)
        {
            InitializeComponent();
            this.unosRezervacijaController = unosRezervacijaController;
        }
    }
}
