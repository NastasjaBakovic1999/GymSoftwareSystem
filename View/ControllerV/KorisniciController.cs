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

                if (korisnici == null | korisnici.Count == 0)
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
                    dgvKorisnici.Columns["DatumRodjenja"].DefaultCellStyle.Format = "dd.MM.yyyy";

                    dgvKorisnici.Columns["Ime"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvKorisnici.Columns["Prezime"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvKorisnici.Columns["DatumRodjenja"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem ne može da učita korisnike.\n" + ex.Message);

            }
        }

        internal void UcitajKorisnika(DataGridView dgvKorisnici, TextBox txtIme, TextBox txtPrezime, TextBox txtAdresa, TextBox txtJMBG, TextBox txtDatumRodjenja)
        {
            try
            {
                DataGridViewRow selectedRow = dgvKorisnici.SelectedRows[0];

                Korisnik korisnik = new Korisnik
                {
                    Uslov = $"k.KorisnikId={((Korisnik)selectedRow.DataBoundItem).KorisnikId}"
                };

                korisnik = Communication.Instance.UcitajKorisnika(korisnik);

                if (korisnik == null)
                {
                    MessageBox.Show("Nije moguće učitati korisnika");
                    return;
                }
                else
                {
                    txtIme.Text = korisnik.Ime;
                    txtPrezime.Text = korisnik.Prezime;
                    txtJMBG.Text = korisnik.JMBG;
                    txtAdresa.Text = korisnik.Adresa;
                    txtDatumRodjenja.Text = korisnik.DatumRodjenja.ToString("dd'.'MM'.'yyyy");

                    MessageBox.Show("Sistem je učitao odabranog korisnika!");
                }
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem ne može da učita korisnika.\n" + ex.Message);
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
                MessageBox.Show("Sistem je izbrisao odabranog korisnika!");
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show("Sistem ne može da izbriše odabranog korisnika.\n" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem ne može da izbriše odabranog korisnika.\n" + ex.Message);
                
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
                    MessageBox.Show("Sistem ne može da nađe korisnike po zadatoj vrednosti!");
                    txtPretraga.Text = "";
                } else
                {
                    dgvKorisnici.DataSource = new BindingList<Korisnik>(korisnici);
                    dgvKorisnici.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dgvKorisnici.Columns["KorisnikId"].Visible = false;
                    dgvKorisnici.Columns["JMBG"].Visible = false;
                    dgvKorisnici.Columns["JMBG"].Visible = false;

                    MessageBox.Show("Sistem je našao korisnike po zadatoj vrednosti!");

                    txtPretraga.Text = "";
                }
            } 
            catch(NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem ne može da pretraži korisnike.\n" + ex.Message);
            }
        }

        
    }
}
