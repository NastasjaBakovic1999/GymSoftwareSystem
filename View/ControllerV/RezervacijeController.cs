using Domen;
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

namespace View.ControllerV
{
    public class RezervacijeController
    {
        internal void UcitajRezervacije(DataGridView dgvRezervacije)
        {
            try
            {
                BindingList<Rezervacija> rezervacije = new BindingList<Rezervacija>(Communication.Instance.UcitajRezervacije());

                if (rezervacije == null | rezervacije.Count == 0)
                {
                    dgvRezervacije.DataSource = null;
                    MessageBox.Show("Nema rezervacija za prikaz!");
                }
                else
                {
                    dgvRezervacije.DataSource = rezervacije;
                    dgvRezervacije.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                    dgvRezervacije.Columns["Termin"].Visible = false;
                    dgvRezervacije.Columns["Korisnik"].Visible = false;

                    dgvRezervacije.Columns.Add("Ime korisnika", "Ime korisnika");
                    dgvRezervacije.Columns.Add("Prezime korisnika", "Prezime korisnika");
                    dgvRezervacije.Columns.Add("Datum termina", "Datum termina");
                    dgvRezervacije.Columns.Add("Vreme termina", "Vreme termina");
                    dgvRezervacije.Columns.Add("Rezervisana usluga", "Rezervisana usluga");

                    foreach(Rezervacija r in rezervacije)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(dgvRezervacije);
                        row.Cells[0].Value = r.Korisnik.Ime;
                        row.Cells[1].Value = r.Korisnik.Prezime;
                        row.Cells[2].Value = r.Termin.Datum;
                        row.Cells[3].Value = r.Termin.Vreme;
                        row.Cells[4].Value = r.Termin.Usluga.Naziv;
                        dgvRezervacije.Rows.Add(row);
                    }

                    //dgvRezervacije.Columns["KorisnikId"].Visible = false;
                    //dgvRezervacije.Columns["TerminId"].Visible = false;

                    //dgvTermini.Columns["Usluga"].HeaderText = "Usluga - Trener";

                    //dgvTermini.Columns["Datum"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    //dgvTermini.Columns["Vreme"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    //dgvTermini.Columns["Kapacitet"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    //dgvTermini.Columns["Usluga"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    //dgvTermini.Columns["Sala"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        internal void ObrisiRezervaciju(DataGridView dgvRezervacije)
        {
            if (dgvRezervacije.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste odabrali rezervaciju za brisanje!");
                return;
            }

            DataGridViewRow red = dgvRezervacije.SelectedRows[0];
            Rezervacija rezervacija = (Rezervacija)red.DataBoundItem;

            try
            {
                Communication.Instance.ObrisiRezervaciju(rezervacija);
                MessageBox.Show("Sistem je izbrisao odabranu rezervaciju!");
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show("Sistem ne može da izbriše odabranu rezervaciju.\n" + ex.Message);
            }
            catch (ServerException ex)
            {
                MessageBox.Show("Sistem ne može da izbriše odabranu rezervaciju.\n" + ex.Message);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Sistem ne može da izbriše odabranu rezervaciju.\n" + ex.Message);
            }
        }
    }
}
