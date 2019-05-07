using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StripFor
{
    /// <summary>
    /// Klasa korisničke forme koja prikazuje podatke o članovima.
    /// Poziva se za unos, pregled i izmjenu podataka o članovima.
    /// </summary>
    public partial class FormClan : Form
    {
        public FormClan()
        {
            
            InitializeComponent();

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            bool ok = false;
            ok = ProvjeriUnos();

            if(ok) this.DialogResult = DialogResult.OK;
            else { MessageBox.Show("Nisu upisani svi potrebni podaci.\n(Prezime, Ime, Oib, Adresa)", "Poruka"); }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var dlgResult = MessageBox.Show("Želite li prekinuti unos ?", "Izlaz", MessageBoxButtons.YesNo);
            if (dlgResult == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
            }
            
        }
  

        /// <summary>
        /// Funkcija koja skriva defaultnu vrijednost kontrole, ako prava vrijednost nije unesena.
        /// Omogućuje da kontrola za prikaz datuma ne prikazuje ništa ako datum nije unesen.
        /// </summary>
        /// <param name="dt">Objekt DateTimePicker za koji treba sakriti vrijednost.</param>
        private void SakrijNullDate(DateTimePicker dt)
        {
            
            if (dt.Checked == false)
            {
                dt.CustomFormat = " ";
            }
            else
            {
                dt.CustomFormat = "dd.MM.yyyy";
            }
        }

        private void tbDatRod_ValueChanged(object sender, EventArgs e)
        {
            SakrijNullDate((DateTimePicker)sender);
        }

        private void FormClan_Shown(object sender, EventArgs e)
        {
            tbPrez.Focus();
            tbPrez.SelectionStart = tbPrez.Text.Length;
            tbPrez.SelectionLength = 0;
        }

        /// <summary>
        /// Funkcija koja provjerava jesu li sva obavezna polja unesena.
        /// </summary>
        /// <returns>Ako jesu vraća true, a ako nisu false.</returns>
        private bool ProvjeriUnos()
        {
            bool ok = true;
            if (this.Text == "Filter") return true;
            if (string.IsNullOrEmpty(tbPrez.Text)) return false;
            if (string.IsNullOrEmpty(tbIme.Text)) return false;
            if (string.IsNullOrEmpty(tbOib.Text)) return false;
            if (string.IsNullOrEmpty(tbAdresa.Text)) return false;
            
            return ok;
        }
       
        
    }
}
