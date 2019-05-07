using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.IO;

namespace StripFor
{
    /// <summary>
    /// Klasa glavne forme aplikacije.
    /// Glavna forma sadrži izbornik i metode za upis, pregled, 
    /// izmjenu podataka i ispis izvješća.
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //-------------------------------------------------------------------------------
        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            
            this.Close(); 
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var dlgResult = MessageBox.Show("Izlaz ?", "StripFor", MessageBoxButtons.YesNo);
            if (dlgResult == DialogResult.No)
            {
                e.Cancel = true;
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsSklad.QIZDATNICA' table. You can move, or remove it, as needed.
            this.taQIzdatnica.Fill(this.dsSklad.QIZDATNICA);
            // TODO: This line of code loads data into the 'dsSklad.IZDATNICA' table. You can move, or remove it, as needed.
            this.taIzdatnica.Fill(this.dsSklad.IZDATNICA);
            // TODO: This line of code loads data into the 'sKLADDataSet.SIF_JUNACI' table. You can move, or remove it, as needed.
            this.taJunaci.Fill(this.dsSklad.SIF_JUNACI);
            // TODO: This line of code loads data into the 'sKLADDataSet.SIF_IZDAVACI' table. You can move, or remove it, as needed.
            this.taIzdavaci.Fill(this.dsSklad.SIF_IZDAVACI);
            // TODO: This line of code loads data into the 'sKLADDataSet.CLANOVI' table. You can move, or remove it, as needed.
            this.taClanovi.Fill(this.dsSklad.CLANOVI);
            // TODO: This line of code loads data into the 'sKLADDataSet.NASLOVI' table. You can move, or remove it, as needed.
            this.taNaslovi.Fill(this.dsSklad.NASLOVI);
            btnAbout.Parent = picture1;
            lblAbout1.Parent = picAbout;
            lblAbout2.Parent = picAbout;
            lblAbout3.Parent = picAbout;
            lblAbout4.Parent = picAbout;
            lblAbout5.Parent = picAbout;
            lblAbout6.Parent = picAbout;
            btnHome.Parent = picAbout;
            lblIzbornik.Parent = picture1;
            
        }

        private void btnJunaci_Click(object sender, EventArgs e)
        {
            bsJunaci.Filter = "";
            gridSifarnici.AutoGenerateColumns = true;
            gridSifarnici.Columns.Clear();
            gridSifarnici.DataSource = null;
            gridSifarnici.DataSource = bsJunaci;
            gridSifarnici.Columns[0].HeaderText = "Šifra";
            gridSifarnici.Columns[1].HeaderText = "Junak";
            gridSifarnici.Columns[0].FillWeight = 30;
            lblSif.Text = "J U N A C I";
            navSif.BindingSource = bsJunaci;
            
        }

        private void btnIzdavaci_Click(object sender, EventArgs e)
        {
            bsIzdavaci.Filter = "";
            gridSifarnici.AutoGenerateColumns = true;
            gridSifarnici.Columns.Clear();
            gridSifarnici.DataSource = null;
            gridSifarnici.DataSource = bsIzdavaci;
            gridSifarnici.Columns[0].HeaderText = "Šifra";
            gridSifarnici.Columns[1].HeaderText = "Izdavač";
            gridSifarnici.Columns[0].FillWeight = 30;
            lblSif.Text = "I Z D A V A Č I";
            navSif.BindingSource = bsIzdavaci;
        }

   

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string flt,sifra,naziv;
            FormSif frm = new FormSif();
            frm.Text = "Filter";
            frm.lblMain.Text = "F I L T E R";
            
            var rez = frm.ShowDialog();

            flt = "";

            if (rez == DialogResult.OK)
            {
                sifra = frm.tbSif.Text;
                naziv = frm.tbNaz.Text;

                if(gridSifarnici.DataSource == bsIzdavaci)
                {
                    flt = string.Format("SIF_IZDAV LIKE '%{0}%' AND Izdavac LIKE '%{1}%'",sifra,naziv);
                }
                if (gridSifarnici.DataSource == bsJunaci)
                {
                    flt = string.Format("SIF_JUNAK LIKE '%{0}%' AND Junak LIKE '%{1}%'", sifra, naziv);
                }
            }

            BindingSource bs = (BindingSource)gridSifarnici.DataSource;
            bs.Filter=flt;
        }

    

        private void navNasDel_Click(object sender, EventArgs e)
        {
            var dlgResult = MessageBox.Show("Brisanje ?", "Potvrda", MessageBoxButtons.YesNo);

            if (dlgResult == DialogResult.Yes)
            {
                var bs = (BindingSource)gridNaslovi.DataSource;
                bs.RemoveCurrent();
                bs.EndEdit();
                taManager.UpdateAll(dsSklad);
            }
        }

        /// <summary>
        /// Funkcija briše članove iz baze podataka.
        /// Prethodno postavlja pitanje i traži potvrdu za brisanje.
        /// </summary>
        /// <param name="sender">Kontrola koja je pokrenula događaj.</param>
        /// <param name="e">Podaci o događaju.</param>
        private void navClaDel_Click(object sender, EventArgs e)
        {
            var dlgResult = MessageBox.Show("Brisanje ?", "Potvrda", MessageBoxButtons.YesNo);

            if (dlgResult == DialogResult.Yes)
            {
                var bs = (BindingSource)gridClanovi.DataSource;
                bs.RemoveCurrent();
                bs.EndEdit();
                taManager.UpdateAll(dsSklad);
            }
        }

        private void navNasAdd_Click(object sender, EventArgs e)
        {
            FormNaslov frm = new FormNaslov();
            var rez=frm.ShowDialog();
            int kolicina = 0;
            int izdano = 0;
            int brojIzd = 0;
            int godIzd = 0;

            if (rez == DialogResult.OK)
            {
                Int32.TryParse(frm.tbKol.Text, out kolicina);
                Int32.TryParse(frm.tbIzdano.Text, out izdano);
                Int32.TryParse(frm.tbBrIzd.Text, out brojIzd);
                Int32.TryParse(frm.tbGodIzd.Text, out godIzd);
                
                var bs = (BindingSource)gridNaslovi.DataSource;
                bs.AddNew();
                var row = (DataRowView)bs.Current;
                row["SIF_IZDAV"] = frm.tbSifIzd.Text;
                row["SIF_JUNAK"] = frm.tbSifJun.Text;
                row["Naslov"] = frm.tbNaslov.Text;
                row["Broj_izd"] = brojIzd;
                row["God_izd"] = godIzd;
                row["Kolicina"] = kolicina;
                row["Izdano"] = izdano;
                row["Lokacija"] = frm.tbLok.Text;
                row["Papir"] = frm.cbPapir.Checked;
                row["Digit"] = frm.cbDigit.Checked;
                row["Slika"] = frm.tbSlika.Text;
                row["Izbor"] = frm.cbIzbor.Checked;
                bs.EndEdit();
                taManager.UpdateAll(dsSklad);
                taNaslovi.Fill(dsSklad.NASLOVI);
                bs.MoveLast();
            }
            
        }

        private void navClaAdd_Click(object sender, EventArgs e)
        {
            FormClan frm = new FormClan();
            var rez = frm.ShowDialog();

            int clanarina = 0;
            
            if (rez == DialogResult.OK)
            {
                Int32.TryParse(frm.tbClanarina.Text, out clanarina);
                
                var bs = (BindingSource)gridClanovi.DataSource;
                bs.AddNew();
                var row = (DataRowView)bs.Current;

                row["Prezime"] = frm.tbPrez.Text;
                row["Ime"] = frm.tbIme.Text;
                row["Oib"] = frm.tbOib.Text;

                if (!string.IsNullOrEmpty(frm.tbDatRod.Text.Trim())) row["Dat_rod"] = frm.tbDatRod.Text;
                else row["Dat_rod"] = DBNull.Value;

                row["Adresa"] = frm.tbAdresa.Text;
                row["Telefon"] = frm.tbTel.Text;
                row["Mail"] = frm.tbMail.Text;
                row["Firma"] = frm.tbFirma.Text;
                row["Clanarina"] = clanarina;
                row["Aktivan"] = frm.cbAktivan.Checked;
                bs.EndEdit();
                taManager.UpdateAll(dsSklad);
                taClanovi.Fill(dsSklad.CLANOVI);
                bs.MoveLast();
            }
        }

       
        private void navNasIzm_Click(object sender, EventArgs e)
        {
            FormNaslov frm = new FormNaslov();
            int kolicina = 0;
            int izdano = 0;
            int brojIzd = 0;
            int godIzd = 0;
            
            var bs = (BindingSource)gridNaslovi.DataSource;
            var row = (DataRowView)bs.Current;

            frm.tbID.Text = row["ID_NASLOVA"].ToString();
            frm.tbSifIzd.Text = row["SIF_IZDAV"].ToString();
            frm.tbIzdavac.Text = DajNazivIzdavaca(frm.tbSifIzd.Text);
            frm.tbSifJun.Text = row["SIF_JUNAK"].ToString();
            frm.tbJunak.Text = DajNazivJunaka(frm.tbSifJun.Text);
            frm.tbNaslov.Text = row["Naslov"].ToString();
            frm.tbBrIzd.Text = "" + row["Broj_izd"];
            frm.tbGodIzd.Text = "" + row["God_izd"];
            frm.tbKol.Text = "" + row["Kolicina"];
            frm.tbIzdano.Text = "" + row["Izdano"];
            frm.tbLok.Text = row["Lokacija"].ToString();
            frm.cbPapir.Checked = Convert.ToBoolean(row["Papir"]);
            frm.cbDigit.Checked = Convert.ToBoolean(row["Digit"]);
            frm.tbSlika.Text = row["Slika"].ToString();
            frm.cbIzbor.Checked = Convert.ToBoolean(row["Izbor"]);

            PokaziOmot(frm);

            var rez = frm.ShowDialog();

            if (rez == DialogResult.OK)
            {
                Int32.TryParse(frm.tbKol.Text, out kolicina);
                Int32.TryParse(frm.tbIzdano.Text, out izdano);
                Int32.TryParse(frm.tbBrIzd.Text, out brojIzd);
                Int32.TryParse(frm.tbGodIzd.Text, out godIzd);

                row["SIF_IZDAV"] = frm.tbSifIzd.Text;
                row["SIF_JUNAK"] = frm.tbSifJun.Text;
                row["Naslov"] = frm.tbNaslov.Text;
                row["Broj_izd"] = brojIzd;
                row["God_izd"] = godIzd;
                row["Kolicina"] = kolicina;
                row["Izdano"] = izdano;
                row["Lokacija"] = frm.tbLok.Text;
                row["Papir"] = frm.cbPapir.Checked;
                row["Digit"] = frm.cbDigit.Checked;
                row["Slika"] = frm.tbSlika.Text;
                row["Izbor"] = frm.cbIzbor.Checked;
                bs.EndEdit();
                taManager.UpdateAll(dsSklad);

            }

        }


        /// <summary>
        /// Funkcija prikazuje omot naslova.
        /// </summary>
        /// <param name="frm"> Objekt FormNaslov. </param>
        private void PokaziOmot(FormNaslov frm)
        {
            String imgpath = Application.StartupPath + "\\OMOTI\\";
            BindingSource bs = (BindingSource)gridNaslovi.DataSource;
            DataRowView dr = (DataRowView)bs.Current;

            imgpath = imgpath + frm.tbSlika.Text;
            if (File.Exists(imgpath))
            {
                Image img = Image.FromFile(imgpath);
                frm.pbOmot.Image = img;
            }
            else
            {
                frm.pbOmot.Image = null;
            }
        }

        /// <summary>
        /// Funkcija dohvaća naziv junaka.
        /// </summary>
        /// <param name="sifra">Šifra junaka.</param>
        /// <returns>Naziv junaka.</returns>
        private string DajNazivJunaka(string sifra)
        {
            int broj = -1;
            string junak = "";
            
            broj = bsJunaci.Find("SIF_JUNAK", sifra);
            if (broj >= 0)
            {
                bsJunaci.Position = broj;
                var row = (DataRowView)bsJunaci.Current;
                junak = row["Junak"].ToString();
            }
            return junak;
        }

        /// <summary>
        /// Funkcija dohvaća naziv izdavača.
        /// </summary>
        /// <param name="sifra">Šifra izdavača.</param>
        /// <returns>Naziv izdavača.</returns>
        private string DajNazivIzdavaca(string sifra)
        {
            int broj = -1;
            string izdavac = "";
            
            broj = bsIzdavaci.Find("SIF_IZDAV", sifra);
            if (broj >= 0)
            {
                bsIzdavaci.Position = broj;
                var row = (DataRowView)bsIzdavaci.Current;
                izdavac = row["Izdavac"].ToString();
            }
            return izdavac;
        }

        private void gridSifarnici_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            navSifIzm_Click(sender, e);
        }

        private void gridNaslovi_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            navNasIzm_Click(sender, e);
        }

        private void navClaIzm_Click(object sender, EventArgs e)
        {
            FormClan frm = new FormClan();
            int clanarina = 0;
            string datRod="";

            var bs = (BindingSource)gridClanovi.DataSource;
            var row = (DataRowView)bs.Current;

            frm.tbID.Text = row["ID_CLANA"].ToString();
            frm.tbPrez.Text = row["Prezime"].ToString();
            frm.tbIme.Text = row["Ime"].ToString();
            frm.tbOib.Text = row["Oib"].ToString();

            datRod = row["Dat_rod"].ToString();
            if (!string.IsNullOrEmpty(datRod))
            {
                frm.tbDatRod.Checked=true;
                frm.tbDatRod.Value = (DateTime)row["Dat_rod"];
            }
            frm.tbAdresa.Text = row["Adresa"].ToString();
            frm.tbTel.Text = row["Telefon"].ToString();
            frm.tbMail.Text = row["Mail"].ToString();
            frm.tbFirma.Text = row["Firma"].ToString();
            frm.tbClanarina.Text = row["Clanarina"].ToString();
            frm.cbAktivan.Checked = Convert.ToBoolean(row["Aktivan"]);

            var rez = frm.ShowDialog();

            
            if (rez == DialogResult.OK)
            {
                Int32.TryParse(frm.tbClanarina.Text, out clanarina);

                row["Prezime"] = frm.tbPrez.Text;
                row["Ime"] = frm.tbIme.Text;
                row["Oib"] = frm.tbOib.Text;

                if (!string.IsNullOrEmpty(frm.tbDatRod.Text.Trim())) row["Dat_rod"] = frm.tbDatRod.Text;
                else row["Dat_rod"] = DBNull.Value;

                row["Adresa"] = frm.tbAdresa.Text;
                row["Telefon"] = frm.tbTel.Text;
                row["Mail"] = frm.tbMail.Text;
                row["Firma"] = frm.tbFirma.Text;
                row["Clanarina"] = clanarina;
                row["Aktivan"] = frm.cbAktivan.Checked;
                bs.EndEdit();
                taManager.UpdateAll(dsSklad);
            }
        }

        private void gridClanovi_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            navClaIzm_Click(sender, e);
        }

        private void btnNasFilter_Click(object sender, EventArgs e)
        {
            string flt;
            
            flt = DajFilterNaslovi();
  
            var bs = (BindingSource)gridNaslovi.DataSource;
            bs.Filter = flt;
        }

        /// <summary>
        /// Funkcija pravi string za filtriranje naslova.
        /// </summary>
        /// <returns>String koji sadrži filter za naslove.</returns>
        private string DajFilterNaslovi()
        {
            int broj = -1;
            string flt="ID_NASLOVA >0", godIzd="", brIzd="", izdavac="", junak="", naslov="";
            string kolicina = "", izdano = "", lokacija = "", papir = "", digit = "", izbor = "";
            

            FormNaslov frm = new FormNaslov();

            frm.Text = "Filter";
            frm.lblMain.Text = "F I L T E R";

            var rez = frm.ShowDialog();
            
            if (rez == DialogResult.OK)
            {
                godIzd = frm.tbGodIzd.Text;
                if (godIzd != "")
                {
                    broj = godIzd.IndexOf('-');
                    if (broj >= 0)
                    {
                        godIzd = " AND God_izd >=" + godIzd.Substring(0, broj) +
                            " AND God_izd <=" + godIzd.Substring(broj + 1, godIzd.Length - broj - 1);
                    }
                    else godIzd = " AND God_izd =" + godIzd;
                }

                brIzd = frm.tbBrIzd.Text;
                if (brIzd != "")
                {
                    broj = brIzd.IndexOf('-');
                    if (broj >= 0)
                    {
                        brIzd = " AND Broj_izd >=" + brIzd.Substring(0, broj) +
                            " AND Broj_izd <=" + brIzd.Substring(broj + 1, brIzd.Length - broj - 1);
                    }
                    else brIzd = " AND Broj_izd =" + brIzd;
                }

                izdavac = frm.tbSifIzd.Text;
                if(izdavac !="") izdavac=" AND SIF_IZDAV ='"+izdavac+"'";

                junak = frm.tbSifJun.Text;
                if (junak != "") junak = " AND SIF_JUNAK ='" + junak + "'";

                naslov = frm.tbNaslov.Text;
                if (naslov != "") naslov = " AND Naslov LIKE '%" + naslov + "%'";

                kolicina = frm.tbKol.Text;
                if (kolicina != "")
                {
                    broj = kolicina.IndexOf('-');
                    if (broj >= 0)
                    {
                        kolicina = " AND Kolicina >=" + kolicina.Substring(0, broj) +
                            " AND Kolicina <=" + kolicina.Substring(broj + 1, kolicina.Length - broj - 1);
                    }
                    else kolicina = " AND Kolicina =" + kolicina;
                }

                izdano = frm.tbIzdano.Text;
                if (izdano != "")
                {
                    broj = izdano.IndexOf('-');
                    if (broj >= 0)
                    {
                        izdano = " AND Izdano >=" + izdano.Substring(0, broj) +
                            " AND Izdano <=" + izdano.Substring(broj + 1, izdano.Length - broj - 1);
                    }
                    else izdano = " AND Izdano =" + izdano;
                }

                lokacija = frm.tbLok.Text;
                if (lokacija != "") lokacija = " AND Lokacija LIKE '%" + lokacija + "%'";

                if (frm.cbPapir.Checked) papir = " AND Papir=1";
                if (frm.cbDigit.Checked) digit = " AND Digit=1";
                if (frm.cbIzbor.Checked) izbor = " AND Izbor=1";

                
                flt = flt + godIzd + brIzd + izdavac + junak + naslov + kolicina 
                    + izdano + lokacija + papir + digit + izbor; 
            }
            return flt;
        }

        private void btnClaFilter_Click(object sender, EventArgs e)
        {
            string flt;

            flt = DajFilterClanovi();

            var bs = (BindingSource)gridClanovi.DataSource;
            bs.Filter = flt;
        }

        /// <summary>
        /// Funkcija pravi string za filtriranje članova.
        /// </summary>
        /// <returns>String koji sadrži filter za članove.</returns>
        private string DajFilterClanovi()
        {
            int broj = -1;
            string flt = "ID_CLANA >0", prez = "", ime = "", oib = "", datRod = "", adresa = "";
            string tel = "", mail = "", firma = "", clanarina = "", aktivan = "";


            FormClan frm = new FormClan();

            frm.Text = "Filter";
            frm.lblMain.Text = "F I L T E R";

            var rez = frm.ShowDialog();

            if (rez == DialogResult.OK)
            {
                prez = frm.tbPrez.Text;
                if (prez != "") prez = " AND Prezime LIKE '%" + prez + "%'";

                ime = frm.tbIme.Text;
                if (ime != "") ime = " AND Ime LIKE '%" + ime + "%'";

                oib = frm.tbOib.Text;
                if (oib != "") oib = " AND Oib LIKE '%" + oib + "%'";

                datRod = frm.tbDatRod.Text.Trim();
                if (datRod != "") datRod = " AND Dat_rod = '" + datRod + "'";

                adresa = frm.tbAdresa.Text;
                if (adresa != "") adresa = " AND Adresa LIKE '%" + adresa + "%'";

                tel = frm.tbTel.Text;
                if (tel != "") tel = " AND Telefon LIKE '%" + tel + "%'";

                mail = frm.tbMail.Text;
                if (mail != "") mail = " AND Mail LIKE '%" + mail + "%'";

                firma = frm.tbFirma.Text;
                if (firma != "") firma = " AND Firma LIKE '%" + firma + "%'";

                clanarina = frm.tbClanarina.Text;
                if (clanarina != "")
                {
                    broj = clanarina.IndexOf('-');
                    if (broj >= 0)
                    {
                        clanarina = " AND Clanarina >=" + clanarina.Substring(0, broj) +
                            " AND Clanarina <=" + clanarina.Substring(broj + 1, clanarina.Length - broj - 1);
                    }
                    else clanarina = " AND Clanarina =" + clanarina;
                }

                if (frm.cbAktivan.Checked) aktivan = " AND Aktivan=1";

                flt = flt + prez + ime + oib + datRod + adresa + tel + mail + firma + clanarina + aktivan;
            }
            return flt;
        }


        /// <summary>
        /// Funkcija otvara korisničku formu za upis šifarnika.
        /// Ista funkcija koristi se za više šifarnika ovisno o varijabli DataSource.
        /// </summary>
        /// <param name="sender">Kontrola koja je pokrenula događaj.</param>
        /// <param name="e">Podaci o događaju.</param>
        private void navSifAdd_Click(object sender, EventArgs e)
        {
            int pos=0;
            FormSif frm = new FormSif();
            if (gridSifarnici.DataSource == bsIzdavaci)
            {
                frm.lblMain.Text = "I Z D A V A Č I";
            }
            else
            {
                frm.lblMain.Text = "J U N A C I";
            }


            var rez = frm.ShowDialog();
            if (rez == DialogResult.OK)
            {
                try
                {
                    var bs = (BindingSource)gridSifarnici.DataSource;
                    bs.AddNew();
                    var row = (DataRowView)bs.Current;
                    row[0] = frm.tbSif.Text;
                    row[1] = frm.tbNaz.Text;
                    bs.EndEdit();
                    taManager.UpdateAll(dsSklad);
                    if (bs == bsIzdavaci) {taIzdavaci.Fill(dsSklad.SIF_IZDAVACI); pos= bs.Find("SIF_IZDAV",frm.tbSif.Text);}
                    if (bs == bsJunaci) {taJunaci.Fill(dsSklad.SIF_JUNACI); pos=bs.Find("SIF_JUNAK",frm.tbSif.Text);}
                    
                    bs.Position=pos;
                }
                catch (Exception ex) {
                    bsIzdavaci.RemoveCurrent();
                    MessageBox.Show("Upis neuspješan!"); 
                };

            }
        }

        private void navSifDel_Click(object sender, EventArgs e)
        {
            var dlgResult = MessageBox.Show("Brisanje ?", "Potvrda", MessageBoxButtons.YesNo);

            if (dlgResult == DialogResult.Yes)
            {
                var bs = (BindingSource)gridSifarnici.DataSource;
                bs.RemoveCurrent();
                bs.EndEdit();
                taManager.UpdateAll(dsSklad);
            }
        }

        private void navSifIzm_Click(object sender, EventArgs e)
        {
            FormSif frm = new FormSif();
            frm.Text = "Izmjena";
            if (gridSifarnici.DataSource == bsIzdavaci)
            {
                frm.lblMain.Text = "I Z D A V A Č I";
            }
            else
            {
                frm.lblMain.Text = "J U N A C I";
            }

            var bs = (BindingSource)gridSifarnici.DataSource;
            var row = (DataRowView)bs.Current;
            frm.tbSif.Text = row[0].ToString();
            frm.tbNaz.Text = row[1].ToString();

            var rez = frm.ShowDialog();

            if (rez == DialogResult.OK)
            {
                row[0] = frm.tbSif.Text;
                row[1] = frm.tbNaz.Text;
                bs.EndEdit();
                taManager.UpdateAll(dsSklad);

            }
        }

        private void btnIzdat_Click(object sender, EventArgs e)
        {
            int id_izdat = 0;
            string brojIzdat = "";
            DateTime dat=DateTime.Now;
            FormIzdat frm = new FormIzdat();
            DBSklad db = new DBSklad();

            var bs = db.DajIzborNaslov();

            if (bs == null)
            {
                MessageBox.Show("Niste izabrali niti jedan naslov!");
                return;
            }

            frm.grIzdat.DataSource = bs;

            brojIzdat = DBSklad.DajBrojIzdat();
            frm.tbBrojIzdat.Text = brojIzdat;

            dat=dat.AddDays(30);
            frm.tbDatPovrat.Value = dat;

            frm.grIzdat.Tag = "upis";
            var ret= frm.ShowDialog();

            if (ret == DialogResult.OK)
            {
                id_izdat = UpisIzdatnica(frm);
                UpisIzdano(bs, id_izdat);
                this.taNaslovi.Fill(this.dsSklad.NASLOVI);
            }
        }


        /// <summary>
        /// Upis podataka o izdatnici u tablicu IZDATNICA.
        /// </summary>
        /// <param name="frm">Objekt FormIzdat.</param>
        /// <returns>Integer sa ID oznakom izdatnice.</returns>
        private int UpisIzdatnica(FormIzdat frm)
        {
            int broj = 0, id_izdat = 0;
            bool ok = false;
            
            DataRowView dr = (DataRowView)bsIzdatnica.AddNew();

            dr.Row["BR_IZDAT"] = frm.tbBrojIzdat.Text;
            dr.Row["Razlog"] = frm.tbOpis.Text;

            ok = Int32.TryParse(frm.tbIdClana.Text, out broj);
            if (ok) dr.Row["ID_CLANA"] = broj;
      
            dr.Row["Dat_izdavanja"] = frm.tbDatIzdav.Text;
            dr.Row["Dat_povrata"] = frm.tbDatPovrat.Text;

            bsIzdatnica.EndEdit();
            taManager.UpdateAll(dsSklad);

            taIzdatnica.Fill(dsSklad.IZDATNICA);
            bsIzdatnica.MoveLast();

            dr = (DataRowView)bsIzdatnica.Current;

            id_izdat = (int)dr["ID_IZDAT"];

            taQIzdatnica.Fill(dsSklad.QIZDATNICA);
            navQIzdat.BindingSource.MoveLast();
      
            return id_izdat;
        }


        /// <summary>
        /// Upis podataka o izdanim naslovima u tablicu IZDANO. 
        /// </summary>
        /// <param name="bs">BindingSource objekt sa odabranim naslovima.</param>
        /// <param name="id_izdat">ID oznaka izdatnice.</param>
        private void UpisIzdano(BindingSource bs, int id_izdat)
        {
            int id_naslova = 0, izdano = 0;
            DataTable dt;

            dt = (DataTable)bs.DataSource;
            
            foreach (DataRow row in dt.Rows)
            {
                id_naslova = (int)row["ID_NASLOVA"];
                izdano = (int)row["Izdano"];
                DBSklad.UpisIzdanoDB(id_izdat, id_naslova, izdano);
                DBSklad.PromijeniIzdanoNaslov(id_naslova, -izdano);
            }
        }

        private void gridNaslovi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == izborDataGridViewCheckBoxColumn.Index)
            {
                gridNaslovi.EndEdit();
                bsNaslovi.EndEdit();
                taManager.UpdateAll(dsSklad);
            }
        }

        private void btnIspisIzdat_Click(object sender, EventArgs e)
        {

            RunIspisIzdat();
        }


        /// <summary>
        /// Funkcija koja pokreće prikaz izvješća za ispis izdatnice.
        /// </summary>
        void RunIspisIzdat()
        {
            int idizdat = 0;
            String exepath = Application.StartupPath;
 
            DataRowView drnew = (DataRowView)bsQIzdatnica.Current;
            idizdat = (int)drnew.Row["ID_IZDAT"];

            DataTable dt = DBSklad.DajIzdatRep(idizdat);
            ReportDataSource rds = new ReportDataSource("DataSet1", dt);

            FormReport rep = new FormReport();
            rep.Report1.Reset();
            rep.Report1.LocalReport.ReportPath = exepath + "\\RepIzdat.rdlc";
            rep.Report1.LocalReport.DataSources.Clear();
            rep.Report1.LocalReport.DataSources.Add(rds);
            rep.Report1.LocalReport.Refresh();
            rep.Report1.RefreshReport();

            rep.Report1.SetDisplayMode(DisplayMode.PrintLayout);
            rep.Report1.Show();
            rep.ShowDialog();
            rep.Close();
        }

        private void navBtnAddIzdat_Click(object sender, EventArgs e)
        {
            btnIzdat_Click(sender, e);
        }

        private void navBtnDelIzdat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Brisanje?", "Potvrda", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int id_izdat = 0;

                DataRowView dr = (DataRowView)navQIzdat.BindingSource.Current;

                if (dr == null) return;

                id_izdat = (int)dr.Row["ID_IZDAT"];
                DBSklad.BrisiIzdat(id_izdat);
  
                taQIzdatnica.Fill(dsSklad.QIZDATNICA);
                navQIzdat.BindingSource.MoveFirst();
            }
        }

        private void navShowIzdat_Click(object sender, EventArgs e)
        {
            int id_izdat = 0;
            string brojIzdat = "";
            FormIzdat frm = new FormIzdat();
     

            var row =(DataRowView) bsQIzdatnica.Current;

            brojIzdat =row["BR_IZDAT"].ToString();
            frm.tbBrojIzdat.Text = brojIzdat;

            frm.tbDatIzdav.Text= row["Dat_izdavanja"].ToString();
            frm.tbDatPovrat.Text = row["Dat_povrata"].ToString();

            frm.tbIdClana.Text = row["ID_CLANA"].ToString();
            frm.tbImeClana.Text =row["Clan"].ToString();

            frm.tbOpis.Text = row["Razlog"].ToString();

            frm.cbVraceno.Checked = (bool)row["Vraceno"];
            bool vraceno = frm.cbVraceno.Checked;

            id_izdat = (int)row["ID_IZDAT"];
            var bs = DBSklad.DajIzdano(id_izdat);

            FormIzdatReadOnly(frm, true);

            frm.grIzdat.DataSource = bs;

 
            var ret = frm.ShowDialog();

            if (ret == DialogResult.OK)
            {
                if (vraceno != frm.cbVraceno.Checked) SetVraceno(id_izdat, frm.cbVraceno.Checked);
            }
    
        }


        /// <summary>
        /// Funkcija koja postavlja vrijednost polja Vraceno u tablici Izdatnica.
        /// </summary>
        /// <param name="id_izdat">ID oznaka izdatnice.</param>
        /// <param name="check">Bool vrijednost koju treba upisati u polje Vraceno.</param>
        private void SetVraceno(int id_izdat, bool check)
        {
            int broj = 0;
            broj=bsIzdatnica.Find("ID_IZDAT",id_izdat);
            bsIzdatnica.Position = broj;
            DataRowView row = (DataRowView)bsIzdatnica.Current;
            row["Vraceno"] = check;
            row.EndEdit();
            taManager.UpdateAll(dsSklad);
            this.taQIzdatnica.Fill(this.dsSklad.QIZDATNICA);
            broj=bsQIzdatnica.Find("ID_IZDAT", id_izdat);
            bsQIzdatnica.Position = broj;

        }


        /// <summary>
        /// Funkcija koja blokira ili deblokira mogućnost mijenjanja podataka na formi za pregled i izradu izdatnice.
        /// </summary>
        /// <param name="frm">Objekt FormIzdat.</param>
        /// <param name="da">Bool vrijednost koja postavlja ReadOnly i Enabled svojstva kontrola.</param>
        private void FormIzdatReadOnly(FormIzdat frm, bool da)
        {
            frm.tbBrojIzdat.ReadOnly = da;
            frm.tbDatIzdav.Enabled = !da;
            frm.tbDatPovrat.Enabled = !da;
            frm.tbOpis.ReadOnly = da;
            frm.btnClan.Enabled = !da;
            frm.grIzdat.ReadOnly = da;
            frm.cbVraceno.Visible = da;
        }

        private void grIzdat_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            navShowIzdat_Click(sender, e);
        }

        private void btnFilterIzdat_Click(object sender, EventArgs e)
        {
            string flt;

            flt = DajFilterIzdatnica();
            if (flt == "CANCEL") return;

            var bs = (BindingSource)grIzdat.DataSource;
            bs.Filter = flt;
   
        }


        /// <summary>
        /// Funkcija pravi string za filtriranje izdatnica.
        /// </summary>
        /// <returns>String koji sadrži filter za izdatnice.</returns>
        private string DajFilterIzdatnica()
        {
            FIzdatFlt frm = new FIzdatFlt();

            string brojIzd = "", clan = "", firma = "", opis = "", datIzd = "", datPov = "",
                vraceno = "", datod = "", datdo = "", flt = "ID_IZDAT >0";
            DateTime dt;
            int broj = -1;
            bool ok = false;

            var rez = frm.ShowDialog();
            if (rez == DialogResult.Cancel) return "CANCEL";
            if (rez == DialogResult.OK)
            {
                brojIzd = frm.tbBrojIzdat.Text;
                if (brojIzd != "") brojIzd = " AND BR_IZDAT LIKE '%" + brojIzd + "%'";

                clan = frm.tbClan.Text;
                if (clan != "") clan = " AND Clan LIKE '%" + clan + "%'";

                firma = frm.tbFirma.Text;
                if (firma != "") firma = " AND Firma LIKE '%" + firma + "%'";

                opis = frm.tbOpis.Text;
                if (opis != "") opis = " AND Razlog LIKE '%" + opis + "%'";

                vraceno = frm.tbVra.Text;
                if (vraceno == "DA") vraceno = " AND Vraceno = 1";
                else if (vraceno == "NE") vraceno = " AND Vraceno = 0";

                //datum izdavanja
                datIzd = frm.tbDatIzdav.Text;
                if (datIzd != "")
                {
                    broj = datIzd.IndexOf("-");
                    if (broj >= 0)
                    {
                        datod = datIzd.Substring(0, broj).Trim();
                        ok = DateTime.TryParse(datod, out dt);
                        if (ok) datod = dt.ToString("yyyy-MM-dd"); else datod = "";

                        datdo = datIzd.Substring(broj + 1, datIzd.Length - broj - 1).Trim();
                        ok = DateTime.TryParse(datdo, out dt);
                        if (ok) datdo = dt.ToString("yyyy-MM-dd"); else datdo = "";

                        if (!String.IsNullOrEmpty(datod) && !String.IsNullOrEmpty(datdo))
                        {
                            datIzd = " AND Dat_izdavanja>='" + datod + "' AND Dat_izdavanja<='" + datdo + "'";
                        }
                        else datIzd = "";

                    }
                    else
                    {
                        ok = DateTime.TryParse(datIzd, out dt);
                        if (ok) datIzd = " AND Dat_izdavanja='" + dt.ToString("yyyy-MM-dd") + "'";
                        else datIzd = "";
                    }
                }

                //datum povrata
                datPov = frm.tbDatPovrat.Text;
                if (datPov != "")
                {
                    broj = datPov.IndexOf("-");
                    if (broj >= 0)
                    {
                        datod = datPov.Substring(0, broj).Trim();
                        ok = DateTime.TryParse(datod, out dt);
                        if (ok) datod = dt.ToString("yyyy-MM-dd"); else datod = "";

                        datdo = datPov.Substring(broj + 1, datPov.Length - broj - 1).Trim();
                        ok = DateTime.TryParse(datdo, out dt);
                        if (ok) datdo = dt.ToString("yyyy-MM-dd"); else datdo = "";

                        if (!String.IsNullOrEmpty(datod) && !String.IsNullOrEmpty(datdo))
                        {
                            datPov = " AND Dat_povrata >='" + datod + "' AND Dat_povrata <='" + datdo + "'";
                        }
                        else datPov = "";

                    }
                    else
                    {
                        ok = DateTime.TryParse(datPov, out dt);
                        if (ok) datPov = " AND Dat_izdavanja='" + dt.ToString("yyyy-MM-dd") + "'";
                        else datPov = "";
                    }
                }
                flt = flt + brojIzd + clan + firma + opis + vraceno + datIzd + datPov;

            }
            
            return flt;
        }

        private void btnPovrat_Click(object sender, EventArgs e)
        {
            var bs = bsQIzdatnica;
            var row=(DataRowView) bs.Current;
            bool ok=(bool)row["Vraceno"];
            if (ok) { MessageBox.Show("Naslovi su već vraćeni!"); return; }
            var dlgResult = MessageBox.Show("Želite li vratiti naslove ?", "Potvrda", MessageBoxButtons.YesNo);
            if (dlgResult == DialogResult.Yes)
            {
                int idIzdat = (int)row["ID_IZDAT"];
                DBSklad.VratiNaslove(idIzdat);
                this.taQIzdatnica.Fill(this.dsSklad.QIZDATNICA);
                this.taNaslovi.Fill(this.dsSklad.NASLOVI);
                var pos = bs.Find("ID_IZDAT", idIzdat);
                bs.Position = pos;
            }

        }

        private void btnPopisNas_Click(object sender, EventArgs e)
        {
            RunPopisNaslov();
        }


        /// <summary>
        /// Funkcija koja pokreće prikaz izvješća za ispis naslova.
        /// </summary>
        private void RunPopisNaslov()
        {
            String flt = bsNaslovi.Filter;
            String exepath = Application.StartupPath;

            
            DataTable dt = DBSklad.DajNasloveRep(flt);
            ReportDataSource rds = new ReportDataSource("DataSet1", dt);

            FormReport rep = new FormReport();
            rep.Report1.Reset();
            rep.Report1.LocalReport.ReportPath = exepath + "\\RepNaslovi.rdlc";
            rep.Report1.LocalReport.DataSources.Clear();
            rep.Report1.LocalReport.DataSources.Add(rds);
            rep.Report1.LocalReport.Refresh();
            rep.Report1.RefreshReport();

            rep.Report1.SetDisplayMode(DisplayMode.PrintLayout);
            rep.Report1.Show();
            rep.ShowDialog();
            rep.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            tbControl.SelectedTab = tbMenu;
        }

        private void btnPopisCla_Click(object sender, EventArgs e)
        {
            RunPopisClan();
        }


        /// <summary>
        /// Funkcija koja pokreće prikaz izvješća za ispis članova.
        /// </summary>
        private void RunPopisClan()
        {
            String flt = bsClanovi.Filter;
            String exepath = Application.StartupPath;

            DataTable dt = DBSklad.DajClanoveRep(flt);
            ReportDataSource rds = new ReportDataSource("DataSet1", dt);

            FormReport rep = new FormReport();
            rep.Report1.Reset();
            rep.Report1.LocalReport.ReportPath = exepath + "\\RepClanovi.rdlc";
            rep.Report1.LocalReport.DataSources.Clear();
            rep.Report1.LocalReport.DataSources.Add(rds);
            rep.Report1.LocalReport.Refresh();
            rep.Report1.RefreshReport();

            rep.Report1.SetDisplayMode(DisplayMode.PrintLayout);
            rep.Report1.Show();
            rep.ShowDialog();
            rep.Close();
        }

        private void btnIzborSvi_Click(object sender, EventArgs e)
        {
            
            BindingSource bs = (BindingSource)gridNaslovi.DataSource;
            DBSklad.PromijeniIzborDa(bs);

            taManager.UpdateAll(dsSklad);
            
            
        }

        private void btnIzborNe_Click(object sender, EventArgs e)
        {
            DBSklad.PromijeniIzborNe();
            this.taNaslovi.Fill(this.dsSklad.NASLOVI);
        }

        private void btnNaslovi_Click(object sender, EventArgs e)
        {
            tbControl.SelectedTab = tbNaslovi;
        }

        private void btnClanovi_Click(object sender, EventArgs e)
        {
            tbControl.SelectedTab = tbClanovi;
        }

        private void btnIzdatnica_Click(object sender, EventArgs e)
        {
            tbControl.SelectedTab = tbIzdatnica;
        }

        private void btnSifarnici_Click(object sender, EventArgs e)
        {
            tbControl.SelectedTab = tbSifarnici;
        }

        private void btnHomeNas_Click(object sender, EventArgs e)
        {
            tbControl.SelectedTab = tbMenu;
        }

        private void btnHomeCla_Click(object sender, EventArgs e)
        {
            tbControl.SelectedTab = tbMenu;
        }

        private void btnHomeIzdat_Click(object sender, EventArgs e)
        {
            tbControl.SelectedTab = tbMenu;
        }

        private void btnHomeSif_Click(object sender, EventArgs e)
        {
            tbControl.SelectedTab = tbMenu;
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            tbControl.SelectedTab = tbAplikacija;
        }

       

        

     
      
        
    }
}
