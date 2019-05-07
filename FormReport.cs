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
    /// Klasa forme koja sadrži kontrolu za pregled izvješća.
    /// Poziva se prilikom izrade svih izvješća.
    /// </summary>
    public partial class FormReport : Form
    {
        public FormReport()
        {
            InitializeComponent();
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'SKLADDataSet.NASLOVI' table. You can move, or remove it, as needed.
            this.NASLOVITableAdapter.Fill(this.SKLADDataSet.NASLOVI);

            this.Report1.RefreshReport();
        }
    }
}
