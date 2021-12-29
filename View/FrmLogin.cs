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
    public partial class FrmLogin : Form
    {
        private LoginController loginController;

        public FrmLogin()
        {
            InitializeComponent();
        }

        public FrmLogin(LoginController loginController)
        {
            InitializeComponent();
            this.loginController=loginController;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
