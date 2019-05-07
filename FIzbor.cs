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
    /// Klasa korisničke forme koja sadrži tablicu šifarnika i omogućuje
    /// izbor podataka iz šifarnika.
    /// </summary>
    public partial class FIzbor : Form
    {
        public string sifra="", naziv="";


        public FIzbor()
        {
            
            InitializeComponent();

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var bs = (BindingSource)gridIzbor.DataSource;
            selectedRow = (DataRowView) bs.Current;
            this.DialogResult = DialogResult.OK;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var dlgResult = MessageBox.Show("Želite li prekinuti unos ?", "Izlaz", MessageBoxButtons.YesNo);
            if (dlgResult == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
            }
            
        }

        private void FIzbor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsSklad.SIF_IZDAVACI' table. You can move, or remove it, as needed.
            this.taIzdavaci.Fill(this.dsSklad.SIF_IZDAVACI);
            // TODO: This line of code loads data into the 'sKLADDataSet.SIF_JUNACI' table. You can move, or remove it, as needed.
            this.taJunaci.Fill(this.dsSklad.SIF_JUNACI);
            
        }


        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            string flt = "";
            string naziv = tbFilter.Text;
            if(gridIzbor.DataSource==bsIzdavaci)
            {
                flt = string.Format("Izdavac LIKE '%{0}%'", naziv);
            }
            if (gridIzbor.DataSource == bsJunaci)
            {
                flt = string.Format("Junak LIKE '%{0}%'", naziv);
            }
            
            var bs = (BindingSource)gridIzbor.DataSource;
            bs.Filter = flt;
        }

        private void gridIzbor_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var bs = (BindingSource)gridIzbor.DataSource;
            selectedRow = (DataRowView)bs.Current;
            this.DialogResult = DialogResult.OK;
        }

        private void FIzbor_Shown(object sender, EventArgs e)
        {
            tbFilter.Focus();
            tbFilter.SelectionStart = tbFilter.Text.Length;
            tbFilter.SelectionLength = 0;
        }

      

       
        
        
    }
}
