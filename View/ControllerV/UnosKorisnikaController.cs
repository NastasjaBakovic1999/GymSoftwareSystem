﻿using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.CommunicationF;
using View.Exceptions;
using View.Helpers;

namespace View.ControllerV
{
    public class UnosKorisnikaController
    {

        internal void SacuvajKorisnika(TextBox txtIme, TextBox txtPrezime, TextBox txtJMBG, DateTimePicker dtpDatumRodjenja, TextBox txtAdresa)
        {
            if (!UserControlHelpers.EmptyFieldValidation(txtIme) |
                 !UserControlHelpers.EmptyFieldValidation(txtPrezime) |
                 !UserControlHelpers.EmptyFieldValidation(txtJMBG) | 
                 !UserControlHelpers.EmptyFieldValidation(txtAdresa))
            {
                MessageBox.Show("Sva polja moraju biti popunjena!");
                return;
            }

            if (!UserControlHelpers.JMBGValidation(txtJMBG))
            {
                MessageBox.Show("Uneti JMBG nije validan!");
                return;
            }

            try
            {
                Korisnik korisnik = new Korisnik
                {
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    Adresa = txtAdresa.Text,
                    JMBG = txtJMBG.Text,
                    DatumRodjenja = dtpDatumRodjenja.Value.Date
                };

                Communication.Instance.UnesiKorisnika(korisnik);
                MessageBox.Show("Korisnik je uspešno sačuvan!");
                txtIme.Text = "";
                txtPrezime.Text = "";
                txtAdresa.Text = "";
                txtJMBG.Text = "";
                dtpDatumRodjenja.Value = DateTime.Today;
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    
}