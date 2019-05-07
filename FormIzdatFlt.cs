using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace StripFor
{
    /// <summary>
    /// Klasa forme za filtriranje podataka o izdatnicama.
    /// </summary>
    public partial class FIzdatFlt : Form
    {
        public FIzdatFlt()
        {
            InitializeComponent();
        }
        private void FIzdat_Load(object sender, EventArgs e)
        {
            //
        }
        //------------------------------------------------------------------------------
        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
        //------------------------------------------------------------------------------
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
        //------------------------------------------------------------------------------
    }
}
