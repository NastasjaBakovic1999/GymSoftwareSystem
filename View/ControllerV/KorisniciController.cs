using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Windows.Forms;
using View.CommunicationF;
using View.Exceptions;
using View.Helpers;

namespace View.ControllerV
{
    public class KorisniciController
    {
        internal void UcitajKorisnike(DataGridView dgvKorisnici)
        {
            try
            {
                BindingList<Korisnik> korisnici = new BindingList<Korisnik>(Communication.Instance.UcitajKorisnike());

                dgvKorisnici.DataSource = korisnici;

                if (korisnici == null || korisnici.Count == 0)
                {
                    MessageBox.Show("Trenutno nema unetih korisnika.");
                    dgvKorisnici.DataSource = null;
                }
                else
                {
                    dgvKorisnici.DataSource = korisnici;
                    dgvKorisnici.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                    dgvKorisnici.Columns["KorisnikId"].Visible = false;
                    dgvKorisnici.Columns["JMBG"].Visible = false;
                    dgvKorisnici.Columns["Adresa"].Visible = false;

                    dgvKorisnici.Columns["DatumRodjenja"].HeaderText = "Datum rođenja";

                    dgvKorisnici.Columns["Ime"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvKorisnici.Columns["Prezime"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvKorisnici.Columns["DatumRodjenja"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        internal void ObrisiKorisnika(DataGridView dgvKorisnici)
        {
            if (dgvKorisnici.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste odabrali korisnika za brisanje!");
                return;
            }

            DataGridViewRow red = dgvKorisnici.SelectedRows[0];
            Korisnik korisnik = (Korisnik)red.DataBoundItem;

            try
            {
                Communication.Instance.ObrisiKorisnika(korisnik);
                MessageBox.Show("Sistem je izbrisao odabranog gosta!");
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show("Sistem ne može da izbriše odabranog gosta.\n" + ex.Message);
            }
            catch (ServerException ex)
            {
                MessageBox.Show("Sistem ne može da izbriše odabranog gosta..\n" + ex.Message);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Sistem ne može da izbriše odabranog gosta..\n" + ex.Message);
            }
        }

        internal void PretraziKorisnike(TextBox txtPretraga, DataGridView dgvKorisnici)
        {
            if (!UserControlHelpers.EmptyFieldValidation(txtPretraga))
            {
                MessageBox.Show("Polje za pretragu je prazno!");
                return;
            }

            try
            {
                Korisnik korisnik = new Korisnik
                {
                    Uslov = $"k.Ime like '%{txtPretraga.Text}%' or k.Prezime like '%{txtPretraga.Text}%'"
                };

                List<Korisnik> korisnici = Communication.Instance.PretraziKorisnike(korisnik);

                if(korisnici == null || korisnici.Count == 0)
                {
                    MessageBox.Show("Ne postoje korisnici koji odgovaraju unetim vrednosima");
                    txtPretraga.Text = "";
                } else
                {
                    dgvKorisnici.DataSource = new BindingList<Korisnik>(korisnici);
                    dgvKorisnici.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dgvKorisnici.Columns["KorisnikId"].Visible = false;
                    dgvKorisnici.Columns["JMBG"].Visible = false;
                    dgvKorisnici.Columns["JMBG"].Visible = false;

                    txtPretraga.Text = "";
                }
            } 
            catch(NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
