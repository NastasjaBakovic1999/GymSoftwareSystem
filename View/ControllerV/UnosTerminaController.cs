using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public class UnosTerminaController
    {

        internal void UcitajUsluge(ComboBox cmbUsluge)
        {
            try
            {
                cmbUsluge.DataSource = Communication.Instance.UcitajUsluge();
                cmbUsluge.SelectedIndex = -1;
                cmbUsluge.Text = "Odaberi uslugu";
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        internal void UcitajSale(ComboBox cmbSale)
        {
            try
            {
                cmbSale.DataSource = Communication.Instance.UcitajSale();
                cmbSale.SelectedIndex = -1;
                cmbSale.Text = "Odaberi salu";
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        internal void UcitajTermine(DataGridView dgvTermini, UCUnosTermina uCUnosTermina)
        {
            if(uCUnosTermina.termini==null | uCUnosTermina.termini.Count == 0)
            {
                dgvTermini.DataSource = null;
                return;
            }

            dgvTermini.DataSource = uCUnosTermina.termini;

            dgvTermini.Columns["TerminId"].Visible = false;

            dgvTermini.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvTermini.Columns["Datum"].DefaultCellStyle.Format = "dd.MM.yyyy";
            dgvTermini.Columns["Vreme"].DefaultCellStyle.Format = @"hh\:mm";

            dgvTermini.Columns["Datum"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvTermini.Columns["Vreme"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvTermini.Columns["Kapacitet"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvTermini.Columns["Sala"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvTermini.Columns["Usluga"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        internal void UnesiTermin(ComboBox cmbUsluge, ComboBox cmbSale, NumericUpDown nudKapacitet, DateTimePicker dtpDatum, DataGridView dgvTermini, TextBox txtSati, TextBox txtMinuti, UCUnosTermina uCUnosTermina)
        {
            if(!UserControlHelpers.ComboBoxValidation(cmbUsluge) | !UserControlHelpers.ComboBoxValidation(cmbSale))
            {
                MessageBox.Show("Niste odabrali salu ili uslugu!");
                return;
            }

            if (!UserControlHelpers.DateValidation(dtpDatum))
            {
                MessageBox.Show("Ne mozete izabrati datum u proslosti!");
                return;
            }

            if (!UserControlHelpers.TimeValidation(txtSati, txtMinuti) | !UserControlHelpers.EmptyFieldValidation(txtSati) | !UserControlHelpers.EmptyFieldValidation(txtMinuti)) 
            {
                MessageBox.Show("Pogrešan unos vremena! Možete uneti samo brojeve i vreme u 24-časovnom formatu!");
                return;
            }

            if (!UserControlHelpers.NumberPickerValidation(nudKapacitet))
            {
                MessageBox.Show("Kapacitet ne moze biti ispod 20 ili preko 100!");
                return;
            }

            Termin termin = new Termin
            {
                Datum = dtpDatum.Value.Date,
                Vreme = new TimeSpan(int.Parse(txtSati.Text), int.Parse(txtMinuti.Text), 0),
                Kapacitet = (int)nudKapacitet.Value,
                Sala = (Sala)cmbSale.SelectedItem,
                Usluga = (Usluga)cmbUsluge.SelectedItem
            };

            if(Communication.Instance.UcitajTermine()
                .Any(ter=>ter.Usluga.Naziv==termin.Usluga.Naziv && ter.Sala.BrojSale==termin.Sala.BrojSale && ter.Datum == termin.Datum && ter.Vreme == ter.Vreme))
            {
                MessageBox.Show("Sistem ne može da unese termin jer se on već nalazi u bazi!");
                return;
            }

            if (uCUnosTermina.termini.Any(ter => ter.Usluga.Naziv == termin.Usluga.Naziv && ter.Sala.BrojSale == termin.Sala.BrojSale && ter.Datum == termin.Datum && ter.Vreme == ter.Vreme))
            {
                MessageBox.Show("Sistem ne može da unese termin jer se on već nalazi u listi termina za čuvanje!");
                return;
            }

            uCUnosTermina.termini.Add(termin);

            dtpDatum.Value = DateTime.Today;
            txtSati.Text = "";
            txtMinuti.Text = "";
            nudKapacitet.Value = 0;
            cmbSale.SelectedIndex = -1;
            cmbUsluge.SelectedIndex = -1;
            cmbSale.Text = "Odaberi salu";
            cmbUsluge.Text = "Odaberi uslugu";
        }

        internal void ObrisiTermin(DataGridView dgvTermini, UCUnosTermina uCUnosTermina)
        {
            if (dgvTermini.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste odabrali termin za brisanje!");
                return;
            }

            DataGridViewRow red = dgvTermini.SelectedRows[0];
            Termin termin = (Termin)red.DataBoundItem;

            uCUnosTermina.termini.Remove(termin);
            MessageBox.Show("Termin je obrisan!");
        }

        internal void SacuvajTermine(DataGridView dgvTermini, UCUnosTermina uCUnosTermina)
        {
            if(uCUnosTermina.termini==null | uCUnosTermina.termini.Count == 0)
            {
                MessageBox.Show("Nema termina za čuvanje! Unesite termine koje želite da sačuvate!");
                return;
            }

            try
            {
                Communication.Instance.UnesiTermine(uCUnosTermina.termini.ToList());
                MessageBox.Show("Novi termini su uspešno sačuvani!");
                uCUnosTermina.termini.Clear();
                dgvTermini.DataSource = null;


            }
            catch (SystemOperationException)
            {
                MessageBox.Show("Greska prilikom čuvanja novih termina!");
            }

        }
    }
}
