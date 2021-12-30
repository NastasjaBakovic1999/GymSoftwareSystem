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
        }
    }
}
