using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.CommunicationF;
using View.Exceptions;
using View.Helpers;
using View.UserControls;

namespace View.ControllerV
{
    public class UnosRezervacijaController
    {
        internal void UcitajTermine(ComboBox cmbTermini)
        {
            try
            {
                cmbTermini.DataSource = Communication.Instance.UcitajTermine();
                cmbTermini.SelectedIndex = -1;
                cmbTermini.Text = "Odaberi termin";
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        internal void UcitajKorisnike(ComboBox cmbKorisnici)
        {
            try
            {
                cmbKorisnici.DataSource = Communication.Instance.UcitajKorisnike();
                cmbKorisnici.SelectedIndex = -1;
                cmbKorisnici.Text = "Odaberi korisnika";
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        internal void UnesiRezervaciju(ComboBox cmbKorisnici, ComboBox cmbTermini, UCUnosRezervacija uCUnosRezervacija)
        {
            if(!UserControlHelpers.ComboBoxValidation(cmbTermini) | !UserControlHelpers.ComboBoxValidation(cmbKorisnici))
            {
                MessageBox.Show("Niste odabrali termin ili korisnika!");
                return;
            }

            Rezervacija rezervacija = new Rezervacija
            {
                Korisnik = (Korisnik)cmbKorisnici.SelectedItem,
                Termin = (Termin)cmbTermini.SelectedItem
            };

            if (Communication.Instance.UcitajRezervacije()
                 .Any(rez=>rez.Termin.TerminId==rezervacija.Termin.TerminId && rez.Korisnik.KorisnikId == rezervacija.Korisnik.KorisnikId))
            {
                MessageBox.Show("Sistem ne može da unese rezervaciju jer se ona već nalazi u bazi!");
                return;
            }

            if (uCUnosRezervacija.rezervacije.Any(rez => rez.Termin.TerminId == rezervacija.Termin.TerminId && rez.Korisnik.KorisnikId == rezervacija.Korisnik.KorisnikId))
            {
                MessageBox.Show("Sistem ne može da unese rzeervaciju jer se ona već nalazi u listi rezervacija za čuvanje!");
                return;
            }

            uCUnosRezervacija.rezervacije.Add(rezervacija);

            cmbTermini.SelectedIndex = -1;
            cmbKorisnici.SelectedIndex = -1;
            cmbTermini.Text = "Odaberi termin";
            cmbKorisnici.Text = "Odaberi korisnika";
        }

        internal void UcitajRezervacije(DataGridView dgvRezervacije, UCUnosRezervacija uCUnosRezervacija)
        {
            if (uCUnosRezervacija.rezervacije == null | uCUnosRezervacija.rezervacije.Count == 0)
            {
                dgvRezervacije.DataSource = null;
                return;
            }

            dgvRezervacije.DataSource = uCUnosRezervacija.rezervacije;

            dgvRezervacije.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvRezervacije.Columns["Korisnik"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvRezervacije.Columns["Termin"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        internal void ObrisiRezervaciju(DataGridView dgvRezervacije, UCUnosRezervacija uCUnosRezervacija)
        {
            if(dgvRezervacije.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste odabrali rezervaciju za brisanje!");
                return;
            }

            DataGridViewRow red = dgvRezervacije.SelectedRows[0];
            Rezervacija rezervacija = (Rezervacija)red.DataBoundItem;

            uCUnosRezervacija.rezervacije.Remove(rezervacija);
            MessageBox.Show("Rezervacija je obrisana!");
        }

        internal void SacuvajRezervacije(DataGridView dgvRezervacije, UCUnosRezervacija uCUnosRezervacija)
        {
            if (uCUnosRezervacija.rezervacije == null | uCUnosRezervacija.rezervacije.Count == 0)
            {
                MessageBox.Show("Nema rezervacija za čuvanje! Unesite rezervacije koje želite da sačuvate!");
                return;
            }

            try
            {
                Communication.Instance.UnesiRezervacije(uCUnosRezervacija.rezervacije.ToList());
                MessageBox.Show("Nove rezervacije su uspešno sačuvane!");
                uCUnosRezervacija.rezervacije.Clear();
                dgvRezervacije.DataSource = null;


            }
            catch (SystemOperationException)
            {
                MessageBox.Show("Greska prilikom čuvanja novih reyervacija!");
            }
        }
    }
}
