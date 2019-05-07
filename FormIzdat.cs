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
    /// Klasa korisničke forme koja prikazuje podatke o izdatnicama i tablicu izdanih naslova.
    /// Poziva se za unos, pregled i izmjenu podataka o izdatnicama.
    /// </summary>
    public partial class FormIzdat : Form
    {
        public FormIzdat()
        {
            InitializeComponent();
        }

        private void FormIzdat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sKLADDataSet.NASLOVI' table. You can move, or remove it, as needed.
            this.taIzdat.Fill(this.dsSklad.NASLOVI);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClan_Click(object sender, EventArgs e)
        {
            FIzbor frm = new FIzbor();

            DBSklad db = new DBSklad();
            BindingSource bs = db.DajSifarnikClanova();

            frm.lblMain.Text = " Č L A N ";
            frm.Text = "Izbor člana";

            frm.gridIzbor.Columns.Clear();
            frm.gridIzbor.AutoGenerateColumns = true;
            frm.gridIzbor.DataSource = null;
            frm.gridIzbor.DataSource = bs;
            frm.gridIzbor.Columns[0].HeaderText = "Šifra";
            frm.gridIzbor.Columns[0].FillWeight = 30;
            

            var ret = frm.ShowDialog();

            if (ret == System.Windows.Forms.DialogResult.OK)
            {
                
               
                tbIdClana.Text = frm.gridIzbor.SelectedRows[0].Cells["Sifra"].Value.ToString();
                tbImeClana.Text = frm.gridIzbor.SelectedRows[0].Cells["Naziv"].Value.ToString();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            bool ok = true;
            ok= ProvjeriUnos();

            if (ok) this.DialogResult = DialogResult.OK;
            else { MessageBox.Show("Nisu upisani svi potrebni podaci.\n(Broj izdatnice, Član, Opis)","Poruka"); }
        }

        private void FormIzdat_Shown(object sender, EventArgs e)
        {
            tbIdClana.Focus();
            tbIdClana.SelectionStart = tbIdClana.Text.Length;
            tbIdClana.SelectionLength = 0;
        }

        /// <summary>
        /// Funkcija koja provjerava jesu li sva obavezna polja unesena.
        /// </summary>
        /// <returns>Ako jesu vraća true, a ako nisu false.</returns>
        private bool ProvjeriUnos()
        {
            bool ok=true;

            if (string.IsNullOrEmpty(tbBrojIzdat.Text)) return false;
            if (string.IsNullOrEmpty(tbIdClana.Text)) return false;
            if (string.IsNullOrEmpty(tbOpis.Text)) return false;

            return ok;
        }
  
    }
}
