using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class FrmServer : Form
    {
        private Server s;
        public FrmServer()
        {
            InitializeComponent();
            btnZaustaviServer.Enabled = false;

            txtStatus.Text = "Server nije pokrenut!";
            txtStatus.BackColor = Color.Coral;
        }

        private void btnPokreniServer_Click(object sender, EventArgs e)
        {
            try
            {
                s = new Server();
                s.Start();

                Thread nit = new Thread(s.Listen);
                nit.IsBackground = true;
                nit.Start();

                btnPokreniServer.Enabled = false;
                btnZaustaviServer.Enabled = true;

                txtStatus.Text = "Server je pokrenut!";
                txtStatus.BackColor = Color.Green;
            }
            catch (SocketException ex)
            {
                MessageBox.Show("Neuspesno pokretanje servera!" + ex.Message);
            }
        }

        private void btnZaustaviServer_Click(object sender, EventArgs e)
        {
            s.Stop();

            btnPokreniServer.Enabled = true;
            btnZaustaviServer.Enabled = false;

            txtStatus.Text = "Server nije pokrenut!";
            txtStatus.BackColor = Color.Coral;
        }

        private void FrmServer_FormClosed(object sender, FormClosedEventArgs e)
        {
            s.Stop();
        }
    }
}
