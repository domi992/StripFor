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
    /// Klasa forme za upis, pregled i izmjenu šifarnika.
    /// Koristi se za šifarnik junaka i izdavača.
    /// </summary>
    public partial class FormSif : Form
    {
        public FormSif()
        {
            
            InitializeComponent();

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            bool ok = false;
            ok = ProvjeriUnos();

            if(ok) this.DialogResult = DialogResult.OK;
            else { MessageBox.Show("Nisu upisani svi potrebni podaci.\n(Šifra, Naziv)", "Poruka"); }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            
            
        }

        private void FUnos_Shown(object sender, EventArgs e)
        {
            tbSif.Focus();
            tbSif.SelectionStart = tbSif.Text.Length;
            tbSif.SelectionLength = 0;
        }

        /// <summary>
        /// Funkcija koja provjerava jesu li sva obavezna polja unesena.
        /// </summary>
        /// <returns>Ako jesu vraća true, a ako nisu false.</returns>
        private bool ProvjeriUnos()
        {
            bool ok = true;
            if (this.Text == "Filter") return true;
            if (string.IsNullOrEmpty(tbSif.Text)) return false;
            if (string.IsNullOrEmpty(tbNaz.Text)) return false;
            
            return ok;
        }
    }
}
