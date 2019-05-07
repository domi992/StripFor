using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;

namespace StripFor
{
    /// <summary>
    /// Klasa koja sadrži metode za rad s bazom podataka.
    /// </summary>
    class DBSklad
    {
        
        /// <summary>
        /// Funkcija vraća tablicu sa izabranim naslovima.
        /// </summary>
        /// <returns>BindingSource koji sadrži tablicu sa izabranim naslovima.</returns>
        public BindingSource DajIzborNaslov()
        {

            String exepath = Application.StartupPath;
            String connStr = "Provider=Microsoft.JET.OLEDB.4.0; data source=" + exepath + "\\SKLAD.mdb";

            BindingSource bs = null;

            try
            {
                String sql = "SELECT ID_NASLOVA,Naslov,SIF_IZDAV,God_izd,Broj_izd,1 AS Izdano FROM NASLOVI WHERE Izbor"
                            + " ORDER BY SIF_IZDAV,God_izd,Broj_izd";
                OleDbConnection conn = new OleDbConnection(connStr);
                conn.Open();

                DataTable dt = new DataTable();
                OleDbCommand cmd = new OleDbCommand(sql, conn);

                OleDbDataAdapter ad = new OleDbDataAdapter(cmd);
                
                ad.Fill(dt);
                if (dt.Rows.Count > 0)
                {

                    bs = new BindingSource();
                    bs.DataSource = dt;
                }
                conn.Close();
            }
            catch (Exception ex) { }

            return bs;
        }

               
        /// <summary>
        /// Funkcija vraća Tablicu šifarnika Članova. 
        /// Koristi se za izbor člana prilikom izrade izdatnice.
        /// </summary>
        /// <returns>BindingSource koji sadrži tablicu s članovima.</returns>
        public BindingSource DajSifarnikClanova()
        {
            String exepath = Application.StartupPath;
            String connStr = "Provider=Microsoft.JET.OLEDB.4.0;data source=" + exepath + "\\SKLAD.mdb";

            BindingSource bs = null;

            try
            {
                OleDbConnection conn = new OleDbConnection(connStr);
                conn.Open();

                DataTable dt = new DataTable();
                OleDbCommand cmd = new OleDbCommand("SELECT ID_CLANA AS Sifra,Prezime+' '+Ime AS Naziv FROM CLANOVI ORDER BY Prezime,Ime", conn);

                OleDbDataAdapter ad = new OleDbDataAdapter(cmd);
                ad.Fill(dt);
                

                bs = new BindingSource();
                bs.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex) { }

            return bs;
        }

        
        /// <summary>
        /// Funkcija upisuje podatke u tablicu IZDANO.
        /// </summary>
        /// <param name="id_izdat">ID oznaka izdatnice.</param>
        /// <param name="id_naslova">ID oznaka naslova.</param>
        /// <param name="kolicina">Broj izdanih primjeraka nekog naslova.</param>
        public static void UpisIzdanoDB(int id_izdat, int id_naslova, int kolicina)
        {
            String exepath = Application.StartupPath;
            String connStr = "Provider=Microsoft.JET.OLEDB.4.0;data source=" + exepath + "\\SKLAD.mdb";
            String cmd = "INSERT INTO IZDANO (ID_IZDAT,ID_NASLOVA,Izdano) VALUES (" + id_izdat + "," + id_naslova + "," + kolicina + ")";

            try
            {
                OleDbConnection conn = new OleDbConnection(connStr);
                conn.Open();

                OleDbCommand com = new OleDbCommand(cmd, conn);
                com.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex) { }
        }

        /// <summary>
        /// Funkcija vraća ukupni broj izdatnica u tekućoj godini.
        /// Koristi se za automatsko formiranje broja izdatnice.
        /// </summary>
        /// <returns>String koji predstavlja broj izdatnice.</returns>
        public static String DajBrojIzdat()
        {
            int broj = 0;
            String brizd = "";
            String exepath = Application.StartupPath;
            String connStr = "Provider=Microsoft.JET.OLEDB.4.0;data source=" + exepath + "\\SKLAD.mdb";
            String sql;

            String dat1, dat2;
            String yyyy = DateTime.Now.Year.ToString();


            dat1 = "#" + yyyy + "-01-01#";
            dat2 = "#" + yyyy + "-12-31#";

            sql = "SELECT COUNT(*) AS Broj FROM IZDATNICA WHERE Dat_izdavanja >= " + dat1 + " AND Dat_izdavanja <= " + dat2;


            try
            {
                OleDbConnection conn = new OleDbConnection(connStr);
                conn.Open();
 
                OleDbCommand cmd = new OleDbCommand(sql, conn);

                broj = (int)cmd.ExecuteScalar(); broj++;
                brizd = broj.ToString() + "/" + yyyy;

                conn.Close();
            }
            catch (Exception ex) { }

            return brizd;
        }
        
        /// <summary>
        /// Funkcija briše podatke o izdatnici iz tablica IZDATNICA i IZDANO. 
        /// </summary>
        /// <param name="id_izdat">ID oznaka izdatnice.</param>
        public static void BrisiIzdat(int id_izdat)
        {
            String exepath = Application.StartupPath;
            String connStr = "Provider=Microsoft.JET.OLEDB.4.0;data source=" + exepath + "\\SKLAD.mdb";
            String sql1 = "DELETE FROM IZDATNICA WHERE ID_IZDAT =" + id_izdat;
            String sql2 = "DELETE FROM IZDANO WHERE ID_IZDAT =" + id_izdat;

            try
            {
                OleDbConnection conn = new OleDbConnection(connStr);
                conn.Open();

                OleDbCommand cmd1 = new OleDbCommand(sql1, conn);
                cmd1.ExecuteNonQuery();
                OleDbCommand cmd2 = new OleDbCommand(sql2, conn);
                cmd2.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex) { }
        }

        /// <summary>
        /// Funkcija vraća tablicu izdanih naslova za izabranu izdatnicu.
        /// </summary>
        /// <param name="id_izdat">ID oznaka izdatnice.</param>
        /// <returns>BindingSource koji sadrži tablicu s izdanim naslovima.</returns>
        public static BindingSource DajIzdano(int id_izdat)
        {
            String exepath = Application.StartupPath;
            String connStr = "Provider=Microsoft.JET.OLEDB.4.0;data source=" + exepath + "\\SKLAD.mdb";

            String sql = "SELECT * FROM QIZDANO WHERE ID_IZDAT=" + id_izdat;
            sql = sql + " ORDER BY SIF_IZDAV,God_izd,Broj_izd";

            BindingSource bs = null;

            try
            {
                OleDbConnection conn = new OleDbConnection(connStr);
                conn.Open();

                DataTable dt = new DataTable();
                OleDbCommand cmd = new OleDbCommand(sql, conn);

                OleDbDataAdapter ad = new OleDbDataAdapter(cmd);
                ad.Fill(dt);
                
                bs = new BindingSource();
                bs.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex) { }

            return bs;
        }

        /// <summary>
        /// Funkcija za vraćanje naslova.
        /// Stavlja oznaku vraćeno u izdatnicu.
        /// Şmanjuje vrijednost polja Izdano u tablici NASLOVI.
        /// </summary>
        /// <param name="id_izdat">ID oznaka izdatnice.</param>
        public static void VratiNaslove(int id_izdat)
        {
            String exepath = Application.StartupPath;
            String connStr = "Provider=Microsoft.JET.OLEDB.4.0;data source=" + exepath + "\\SKLAD.mdb";
           
            String sql = "UPDATE IZDATNICA SET Vraceno = 1 WHERE ID_IZDAT =" + id_izdat;

            int idNaslov = 0, izdano=0;

            try
            {
                OleDbConnection conn = new OleDbConnection(connStr);
                conn.Open();

                OleDbCommand cmd = new OleDbCommand(sql, conn);
                cmd.ExecuteNonQuery();

                BindingSource bs = DajIzdano(id_izdat);
                DataTable dt =(DataTable)bs.DataSource;

                foreach(DataRow row  in dt.Rows)
                {
                   idNaslov=(int)row["ID_NASLOVA"];
                   izdano = (int)row["Izdano"];
                   PromijeniIzdanoNaslov(idNaslov,izdano);

                }

                conn.Close();
            }
            catch (Exception ex) { }
        }


        /// <summary>
        /// Funkcija mijenja vrijednost polja Izdano tablice NASLOVI.
        /// </summary>
        /// <param name="idNaslov">ID oznaka naslova.</param>
        /// <param name="izdano">Broj izdanih naslova.</param>
        public static void PromijeniIzdanoNaslov(int idNaslov, int izdano)
        {
            
            String exepath = Application.StartupPath;
            String connStr = "Provider=Microsoft.JET.OLEDB.4.0;data source=" + exepath + "\\SKLAD.mdb";

            String sql = "UPDATE NASLOVI SET Izdano=Izdano-" +izdano+ " WHERE ID_NASLOVA =" + idNaslov;


            try
            {
                OleDbConnection conn = new OleDbConnection(connStr);
                conn.Open();

                OleDbCommand cmd = new OleDbCommand(sql, conn);
                cmd.ExecuteNonQuery();

                
                conn.Close();
            }
            catch (Exception ex) { }
        }

        /// <summary>
        /// Funkcija vraća tablicu naslova i koristi se za ispis popisa naslova.
        /// </summary>
        /// <param name="flt">String koji predstavlja filter za izabrane naslove.</param>
        /// <returns>Tablica filtriranih naslova.</returns>
        public static DataTable DajNasloveRep(String flt)
        {
            String exepath = Application.StartupPath;
            String connStr = "Provider=Microsoft.JET.OLEDB.4.0;data source=" + exepath + "\\SKLAD.mdb";
            String sql;

            if (String.IsNullOrEmpty(flt)) flt = "1=1";
            sql = "SELECT * FROM NASLOVI WHERE " + flt;

            DataTable dt = null;

            try
            {
                OleDbConnection conn = new OleDbConnection(connStr);
                conn.Open();

                dt = new DataTable();
                OleDbCommand cmd = new OleDbCommand(sql, conn);

                OleDbDataAdapter ad = new OleDbDataAdapter(cmd);
                ad.Fill(dt);
                
                conn.Close();
            }
            catch (Exception ex) { }

            return dt;
        }

        /// <summary>
        /// Funkcija vraća tablicu članova i koristi se za ispis popisa članova.
        /// </summary>
        /// <param name="flt">String koji predstavlja filter za izabrane članove.</param>
        /// <returns>Tablica filtriranih članova.</returns>
        public static DataTable DajClanoveRep(String flt)
        {
            String exepath = Application.StartupPath;
            String connStr = "Provider=Microsoft.JET.OLEDB.4.0;data source=" + exepath + "\\SKLAD.mdb";
            String sql;

            if (String.IsNullOrEmpty(flt)) flt = "1=1";
            sql = "SELECT * FROM CLANOVI WHERE " + flt;

            DataTable dt = null;

            try
            {
                OleDbConnection conn = new OleDbConnection(connStr);
                conn.Open();

                dt = new DataTable();
                OleDbCommand cmd = new OleDbCommand(sql, conn);

                OleDbDataAdapter ad = new OleDbDataAdapter(cmd);
                ad.Fill(dt);

                conn.Close();
            }
            catch (Exception ex) { }

            return dt;
        }

        /// <summary>
        /// Funkcija vraća tablicu za ispis izdatnice.
        /// </summary>
        /// <param name="idizdat">ID oznaka izdatnice.</param>
        /// <returns>Tablica s podacima o naslovima izdatnice.</returns>
        public static DataTable DajIzdatRep(int idizdat)
        {
            String exepath = Application.StartupPath;
            String connStr = "Provider=Microsoft.JET.OLEDB.4.0;data source=" + exepath + "\\SKLAD.mdb";
            String sql;

            sql = "SELECT * FROM QIZDANO_REP WHERE ID_IZDAT=" + idizdat + " ORDER BY SIF_IZDAV,God_izd,Broj_izd";

            DataTable dt = null;

            try
            {
                OleDbConnection conn = new OleDbConnection(connStr);
                conn.Open();

                dt = new DataTable();
                OleDbCommand cmd = new OleDbCommand(sql, conn);

                OleDbDataAdapter ad = new OleDbDataAdapter(cmd);
                ad.Fill(dt);
                
                conn.Close();
            }
            catch (Exception ex) { }

            return dt;
        }

        /// <summary>
        /// Funkcija koja poništava izbor svim naslovima u tablici NASLOVI. 
        /// Mijenja vrijednost polja Izbor u false.
        /// </summary>
        public static void PromijeniIzborNe()
        {
            String exepath = Application.StartupPath;
            String connStr = "Provider=Microsoft.JET.OLEDB.4.0;data source=" + exepath + "\\SKLAD.mdb";

            String sql = "UPDATE NASLOVI SET Izbor=0";


            try
            {
                OleDbConnection conn = new OleDbConnection(connStr);
                conn.Open();

                OleDbCommand cmd = new OleDbCommand(sql, conn);
                cmd.ExecuteNonQuery();


                conn.Close();
            }
            catch (Exception ex) { }
        }

        
       /// <summary>
       /// Funkcija koja odabire sve naslove.
       /// Mijenja vrijednost polja Izbor u true.
       /// </summary>
       /// <param name="bs">BindingSource tablice za prikaz naslova.</param>
        public static void PromijeniIzborDa(BindingSource bs)
        {
            foreach (DataRowView row in bs.List)
            {
                row["Izbor"] = true;

            }
            bs.EndEdit();
            
        }
    }
}
