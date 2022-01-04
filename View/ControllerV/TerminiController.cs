using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.CommunicationF;
using View.Exceptions;
using ServerException = View.Exceptions.ServerException;

namespace View.ControllerV
{
    public class TerminiController
    {
        internal void UcitajTermine(DataGridView dgvTermini)
        {
            try
            {
                BindingList<Termin> termini = new BindingList<Termin>(Communication.Instance.UcitajTermine());

                if (termini == null | termini.Count == 0)
                {
                    dgvTermini.DataSource = null;
                    MessageBox.Show("Nema termina za prikaz!");
                }
                else
                {
                    dgvTermini.DataSource = termini;
                    dgvTermini.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                    dgvTermini.Columns["TerminId"].Visible = false;

                    dgvTermini.Columns["Usluga"].HeaderText = "Usluga - Trener";

                    dgvTermini.Columns["Datum"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dgvTermini.Columns["Vreme"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dgvTermini.Columns["Kapacitet"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dgvTermini.Columns["Usluga"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvTermini.Columns["Sala"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        internal void ObrisiTermin(DataGridView dgvTermini)
        {
            if (dgvTermini.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste odabrali termin za brisanje!");
                return;
            }

            DataGridViewRow red = dgvTermini.SelectedRows[0];
            Termin termin = (Termin)red.DataBoundItem;

            try
            {
                Communication.Instance.ObrisiTermin(termin);
                MessageBox.Show("Sistem je izbrisao odabrani termin!");
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show("Sistem ne može da izbriše odabrani termin.\n" + ex.Message);
            }
            catch (ServerException ex)
            {
                MessageBox.Show("Sistem ne može da izbriše odabrani termin.\n" + ex.Message);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Sistem ne može da izbriše odabrani termin.\n" + ex.Message);
            }
        }
    }
}
