using Domen;
using System;
using System.Net.Sockets;
using System.Windows.Forms;
using View.CommunicationF;
using View.Exceptions;
using View.Helpers;

namespace View.ControllerV
{
    public class LoginController
    {
        internal bool Connect()
        {
            try
            {
                Communication.Instance.Connect();
                return true;
            }
            catch (SocketException)
            {
                MessageBox.Show("Greska prilikom povezivanja na server!");
                return false;
            }
        }

        internal void Login(TextBox txtKorisnickoIme, TextBox txtSifra, FrmLogin frmLogin)
        {
            if (!UserControlHelpers.EmptyFieldValidation(txtKorisnickoIme) || !UserControlHelpers.EmptyFieldValidation(txtSifra))
            {
                return;
            }

            try
            {
                Administrator admin = new Administrator
                {
                    KorisnickoIme = txtKorisnickoIme.Text,
                    Sifra = txtSifra.Text
                };
                admin = Communication.Instance.Login(admin);
                if (admin != null)
                {
                    MainCoordinator.Instance.Administrator = admin;
                    MessageBox.Show("Uspešna prijava!");
                    MainCoordinator.Instance.OpenMainForm();
                    frmLogin.Dispose();
                }
                else
                {
                    throw new SystemNotFoundException();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
