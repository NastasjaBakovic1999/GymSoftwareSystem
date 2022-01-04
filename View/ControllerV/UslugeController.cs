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
using View.Helpers;

namespace View.ControllerV
{
    public class UslugeController
    {
        internal void UcitajUsluge(DataGridView dgvUsluge)
        {
            try
            {
                BindingList<Usluga> usluge = new BindingList<Usluga>(Communication.Instance.UcitajUsluge());

                if (usluge == null | usluge.Count == 0)
                {
                    MessageBox.Show("Trenutno nema unetih usluga.");
                    dgvUsluge.DataSource = null;
                }
                else
                {
                    dgvUsluge.DataSource = usluge;
                    dgvUsluge.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                    dgvUsluge.Columns["UslugaId"].Visible = false;

                    dgvUsluge.Columns["Naziv"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvUsluge.Columns["Trener"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        internal void ObrisiUslugu(DataGridView dgvUsluge)
        {
            if (dgvUsluge.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste odabrali uslugu za brisanje!");
                return;
            }

            DataGridViewRow red = dgvUsluge.SelectedRows[0];
            Usluga usluga = (Usluga)red.DataBoundItem;

            try
            {
                Communication.Instance.ObrisiUslugu(usluga);
                MessageBox.Show("Sistem je izbrisao odabranu uslugu!");
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show("Sistem ne može da izbriše odabranu uslugu.\n" + ex.Message);
            }
            catch (ServerException ex)
            {
                MessageBox.Show("Sistem ne može da izbriše odabranu uslugu.\n" + ex.Message);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Sistem ne može da izbriše odabranu uslugu.\n" + ex.Message);
            }
        }

        internal void UcitajTrenere(ComboBox cmbTrener)
        {

            try
            {
                cmbTrener.DataSource = Communication.Instance.UcitajTrenere();
                cmbTrener.SelectedIndex = -1;
                cmbTrener.Text = "Odaberi trenera";
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        internal void SacuvajUslugu(TextBox txtNazivUsluge, ComboBox cmbTrener)
        {
            if (!UserControlHelpers.EmptyFieldValidation(txtNazivUsluge))
            {
                MessageBox.Show("Sva polja moraju biti popunjena!");
                return;
            }

            if (!UserControlHelpers.ComboBoxValidation(cmbTrener))
            {
                MessageBox.Show("Niste odabrali trenera!");
                return;
            }

            try
            {
                Usluga usluga = new Usluga
                {
                   Naziv=txtNazivUsluge.Text,
                   Trener = (Trener)cmbTrener.SelectedItem
                };

                if (Communication.Instance.UcitajUsluge().Any(usl => usl.Naziv == usluga.Naziv))
                {
                    MessageBox.Show("Sistem ne može da sačuva uslugu jer se ona već nalazi u bazi podataka.");
                    return;
                }

                Communication.Instance.UnesiUslugu(usluga);
                MessageBox.Show("Usluga je uspešno sačuvana!");
                txtNazivUsluge.Text = "";
                cmbTrener.SelectedIndex = -1;
                cmbTrener.Text = "Odaberi trenera";
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

    
}
