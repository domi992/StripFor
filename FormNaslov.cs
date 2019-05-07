using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace StripFor
{
    /// <summary>
    /// Klasa korisničke forme koja prikazuje podatke o naslovima.
    /// Poziva se za unos, pregled i izmjenu podataka o naslovima.
    /// </summary>
    public partial class FormNaslov : Form
    {
        public FormNaslov()
        {
            
            InitializeComponent();

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            bool ok = false;
            ok = ProvjeriUnos();

            if(ok) this.DialogResult = DialogResult.OK;
            else { MessageBox.Show("Nisu upisani svi potrebni podaci.\n(Godina izdanja, Broj izdanja, Izdavač, Junak, Naslov, Količina)", "Poruka"); }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var dlgResult = MessageBox.Show("Želite li prekinuti unos ?", "Izlaz", MessageBoxButtons.YesNo);
            if (dlgResult == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
            }
            
        }

        private void btnIzdavac_Click(object sender, EventArgs e)
        {
            FIzbor frm = new FIzbor();
            frm.lblMain.Text="I Z D A V A Č";
            frm.gridIzbor.AutoGenerateColumns = true;
            frm.gridIzbor.Columns.Clear();
            frm.gridIzbor.DataSource = null;
            frm.gridIzbor.DataSource = frm.bsIzdavaci;
            frm.gridIzbor.Columns[0].HeaderText = "Šifra";
            frm.gridIzbor.Columns[1].HeaderText = "Izdavač";
            var rez=frm.ShowDialog();

           if(frm.DialogResult==DialogResult.OK)
           {
               tbSifIzd.Text = frm.selectedRow[0].ToString();
               tbIzdavac.Text = frm.selectedRow[1].ToString();
           }

        }

        private void btnJunak_Click(object sender, EventArgs e)
        {
            FIzbor frm = new FIzbor();
            frm.lblMain.Text = "J U N A K";
            frm.gridIzbor.AutoGenerateColumns = true;
            frm.gridIzbor.Columns.Clear();
            frm.gridIzbor.DataSource = null;
            frm.gridIzbor.DataSource = frm.bsJunaci;
            frm.gridIzbor.Columns[0].HeaderText = "Šifra";
            frm.gridIzbor.Columns[1].HeaderText = "Junak";
            var rez = frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                tbSifJun.Text = frm.selectedRow[0].ToString();
                tbJunak.Text = frm.selectedRow[1].ToString();
            }
        }

        private void FormNaslov_Shown(object sender, EventArgs e)
        {
            tbGodIzd.Focus();
            tbGodIzd.SelectionStart = tbGodIzd.Text.Length;
            tbGodIzd.SelectionLength = 0;
        }


        /// <summary>
        /// Funkcija koja otvara dijalog za izbor slike omota.
        /// Postavlja sliku omota naslova.
        /// Ako u folderu aplikacije ne postoji podfolder OMOTI - kreira ga.
        /// </summary>
        /// <param name="sender">Kontrola koja je pokrenula događaj.</param>
        /// <param name="e">Podaci o događaju.</param>
        private void btnIzborOmot_Click(object sender, EventArgs e)
        {
            String imgpath = Application.StartupPath + "\\OMOTI\\";

            if (!Directory.Exists(imgpath))
            {
                System.IO.Directory.CreateDirectory(imgpath);
            }

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Slike|*.jpg;*.jpeg;*.png;*.gif;*.tif;*.bmp";
            dialog.InitialDirectory = imgpath;
            dialog.Title = "Izbor slike omota";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                tbSlika.Text = Path.GetFileName(dialog.FileName);
                Image img = Image.FromFile(dialog.FileName);
                pbOmot.Image = img;
            }            
        }

        private void pbOmot_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            String imgpath = Application.StartupPath + "\\OMOTI\\";
            imgpath = imgpath + tbSlika.Text;
            if (File.Exists(imgpath)) System.Diagnostics.Process.Start(imgpath);
        }

        /// <summary>
        /// Funkcija koja provjerava jesu li sva obavezna polja unesena.
        /// </summary>
        /// <returns>Ako jesu vraća true, a ako nisu false.</returns>
        private bool ProvjeriUnos()
        {
            bool ok = true;
            if (this.Text == "Filter") return true;
            if (string.IsNullOrEmpty(tbGodIzd.Text)) return false;
            if (string.IsNullOrEmpty(tbBrIzd.Text)) return false;
            if (string.IsNullOrEmpty(tbSifIzd.Text)) return false;
            if (string.IsNullOrEmpty(tbSifJun.Text)) return false;
            if (string.IsNullOrEmpty(tbNaslov.Text)) return false;
            if (string.IsNullOrEmpty(tbKol.Text)) return false;
            

            return ok;
        }

        

        
    }
}
