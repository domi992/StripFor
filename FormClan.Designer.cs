namespace StripFor
{
    partial class FormClan{
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClan));
            this.panTop = new System.Windows.Forms.Panel();
            this.lblMain = new System.Windows.Forms.Label();
            this.panBot = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.panMain = new System.Windows.Forms.Panel();
            this.tbDatRod = new System.Windows.Forms.DateTimePicker();
            this.lblDatRod = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.cbAktivan = new System.Windows.Forms.CheckBox();
            this.lblGodCla = new System.Windows.Forms.Label();
            this.lblFirma = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.lblOib = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.tbFirma = new System.Windows.Forms.TextBox();
            this.tbClanarina = new System.Windows.Forms.TextBox();
            this.tbTel = new System.Windows.Forms.TextBox();
            this.tbAdresa = new System.Windows.Forms.TextBox();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.tbOib = new System.Windows.Forms.TextBox();
            this.tbPrez = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.panTop.SuspendLayout();
            this.panBot.SuspendLayout();
            this.panMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panTop
            // 
            this.panTop.BackColor = System.Drawing.Color.Tan;
            this.panTop.Controls.Add(this.lblMain);
            this.panTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTop.Location = new System.Drawing.Point(0, 0);
            this.panTop.Name = "panTop";
            this.panTop.Size = new System.Drawing.Size(509, 45);
            this.panTop.TabIndex = 0;
            // 
            // lblMain
            // 
            this.lblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMain.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMain.ForeColor = System.Drawing.Color.DimGray;
            this.lblMain.Location = new System.Drawing.Point(0, 0);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(509, 45);
            this.lblMain.TabIndex = 0;
            this.lblMain.Text = "Č L A N";
            this.lblMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panBot
            // 
            this.panBot.BackColor = System.Drawing.Color.Tan;
            this.panBot.Controls.Add(this.btnCancel);
            this.panBot.Controls.Add(this.btnOk);
            this.panBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panBot.Location = new System.Drawing.Point(0, 435);
            this.panBot.Name = "panBot";
            this.panBot.Size = new System.Drawing.Size(509, 48);
            this.panBot.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(147, 13);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(52, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Transparent;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Image = ((System.Drawing.Image)(resources.GetObject("btnOk.Image")));
            this.btnOk.Location = new System.Drawing.Point(36, 6);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(58, 36);
            this.btnOk.TabIndex = 0;
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // panMain
            // 
            this.panMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panMain.BackColor = System.Drawing.Color.CadetBlue;
            this.panMain.Controls.Add(this.tbDatRod);
            this.panMain.Controls.Add(this.lblDatRod);
            this.panMain.Controls.Add(this.lblIme);
            this.panMain.Controls.Add(this.cbAktivan);
            this.panMain.Controls.Add(this.lblGodCla);
            this.panMain.Controls.Add(this.lblFirma);
            this.panMain.Controls.Add(this.lblMail);
            this.panMain.Controls.Add(this.lblTel);
            this.panMain.Controls.Add(this.lblAdresa);
            this.panMain.Controls.Add(this.lblOib);
            this.panMain.Controls.Add(this.lblPrezime);
            this.panMain.Controls.Add(this.lblID);
            this.panMain.Controls.Add(this.tbMail);
            this.panMain.Controls.Add(this.tbFirma);
            this.panMain.Controls.Add(this.tbClanarina);
            this.panMain.Controls.Add(this.tbTel);
            this.panMain.Controls.Add(this.tbAdresa);
            this.panMain.Controls.Add(this.tbIme);
            this.panMain.Controls.Add(this.tbOib);
            this.panMain.Controls.Add(this.tbPrez);
            this.panMain.Controls.Add(this.tbID);
            this.panMain.Location = new System.Drawing.Point(3, 48);
            this.panMain.Name = "panMain";
            this.panMain.Size = new System.Drawing.Size(503, 384);
            this.panMain.TabIndex = 2;
            // 
            // tbDatRod
            // 
            this.tbDatRod.Checked = false;
            this.tbDatRod.CustomFormat = " ";
            this.tbDatRod.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tbDatRod.Location = new System.Drawing.Point(308, 137);
            this.tbDatRod.Name = "tbDatRod";
            this.tbDatRod.ShowCheckBox = true;
            this.tbDatRod.Size = new System.Drawing.Size(165, 20);
            this.tbDatRod.TabIndex = 4;
            this.tbDatRod.ValueChanged += new System.EventHandler(this.tbDatRod_ValueChanged);
            // 
            // lblDatRod
            // 
            this.lblDatRod.AutoSize = true;
            this.lblDatRod.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDatRod.Location = new System.Drawing.Point(305, 124);
            this.lblDatRod.Name = "lblDatRod";
            this.lblDatRod.Size = new System.Drawing.Size(106, 14);
            this.lblDatRod.TabIndex = 24;
            this.lblDatRod.Text = "Datum rođenja:";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIme.Location = new System.Drawing.Point(305, 70);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(36, 14);
            this.lblIme.TabIndex = 23;
            this.lblIme.Text = "Ime:";
            // 
            // cbAktivan
            // 
            this.cbAktivan.AutoSize = true;
            this.cbAktivan.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbAktivan.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbAktivan.Location = new System.Drawing.Point(383, 344);
            this.cbAktivan.Name = "cbAktivan";
            this.cbAktivan.Size = new System.Drawing.Size(72, 18);
            this.cbAktivan.TabIndex = 10;
            this.cbAktivan.Text = "Aktivan";
            this.cbAktivan.UseVisualStyleBackColor = true;
            // 
            // lblGodCla
            // 
            this.lblGodCla.AutoSize = true;
            this.lblGodCla.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblGodCla.Location = new System.Drawing.Point(46, 328);
            this.lblGodCla.Name = "lblGodCla";
            this.lblGodCla.Size = new System.Drawing.Size(161, 14);
            this.lblGodCla.TabIndex = 19;
            this.lblGodCla.Text = "Godina uplate članarine:";
            // 
            // lblFirma
            // 
            this.lblFirma.AutoSize = true;
            this.lblFirma.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFirma.Location = new System.Drawing.Point(45, 275);
            this.lblFirma.Name = "lblFirma";
            this.lblFirma.Size = new System.Drawing.Size(46, 14);
            this.lblFirma.TabIndex = 18;
            this.lblFirma.Text = "Firma:";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMail.Location = new System.Drawing.Point(263, 227);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(109, 14);
            this.lblMail.TabIndex = 17;
            this.lblMail.Text = "Adresa e-pošte:";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTel.Location = new System.Drawing.Point(45, 227);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(57, 14);
            this.lblTel.TabIndex = 16;
            this.lblTel.Text = "Telefon:";
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAdresa.Location = new System.Drawing.Point(45, 178);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(56, 14);
            this.lblAdresa.TabIndex = 15;
            this.lblAdresa.Text = "Adresa:";
            // 
            // lblOib
            // 
            this.lblOib.AutoSize = true;
            this.lblOib.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOib.Location = new System.Drawing.Point(45, 124);
            this.lblOib.Name = "lblOib";
            this.lblOib.Size = new System.Drawing.Size(35, 14);
            this.lblOib.TabIndex = 13;
            this.lblOib.Text = "OIB:";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPrezime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPrezime.Location = new System.Drawing.Point(45, 70);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(62, 14);
            this.lblPrezime.TabIndex = 11;
            this.lblPrezime.Text = "Prezime:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblID.Location = new System.Drawing.Point(46, 14);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(26, 14);
            this.lblID.TabIndex = 10;
            this.lblID.Text = "ID:";
            // 
            // tbMail
            // 
            this.tbMail.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbMail.Location = new System.Drawing.Point(266, 243);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(207, 22);
            this.tbMail.TabIndex = 7;
            // 
            // tbFirma
            // 
            this.tbFirma.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbFirma.Location = new System.Drawing.Point(47, 291);
            this.tbFirma.Name = "tbFirma";
            this.tbFirma.Size = new System.Drawing.Size(426, 22);
            this.tbFirma.TabIndex = 8;
            // 
            // tbClanarina
            // 
            this.tbClanarina.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbClanarina.Location = new System.Drawing.Point(46, 344);
            this.tbClanarina.Name = "tbClanarina";
            this.tbClanarina.Size = new System.Drawing.Size(161, 22);
            this.tbClanarina.TabIndex = 9;
            // 
            // tbTel
            // 
            this.tbTel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbTel.Location = new System.Drawing.Point(47, 243);
            this.tbTel.Name = "tbTel";
            this.tbTel.Size = new System.Drawing.Size(197, 22);
            this.tbTel.TabIndex = 6;
            // 
            // tbAdresa
            // 
            this.tbAdresa.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbAdresa.Location = new System.Drawing.Point(47, 194);
            this.tbAdresa.Name = "tbAdresa";
            this.tbAdresa.Size = new System.Drawing.Size(426, 22);
            this.tbAdresa.TabIndex = 5;
            // 
            // tbIme
            // 
            this.tbIme.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbIme.Location = new System.Drawing.Point(308, 86);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(165, 22);
            this.tbIme.TabIndex = 2;
            // 
            // tbOib
            // 
            this.tbOib.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbOib.Location = new System.Drawing.Point(47, 140);
            this.tbOib.MaxLength = 11;
            this.tbOib.Name = "tbOib";
            this.tbOib.Size = new System.Drawing.Size(232, 22);
            this.tbOib.TabIndex = 3;
            // 
            // tbPrez
            // 
            this.tbPrez.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbPrez.Location = new System.Drawing.Point(47, 86);
            this.tbPrez.Name = "tbPrez";
            this.tbPrez.Size = new System.Drawing.Size(232, 22);
            this.tbPrez.TabIndex = 1;
            // 
            // tbID
            // 
            this.tbID.BackColor = System.Drawing.Color.Silver;
            this.tbID.Enabled = false;
            this.tbID.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbID.Location = new System.Drawing.Point(47, 31);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(81, 22);
            this.tbID.TabIndex = 0;
            this.tbID.TabStop = false;
            // 
            // FormClan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(509, 483);
            this.Controls.Add(this.panMain);
            this.Controls.Add(this.panBot);
            this.Controls.Add(this.panTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormClan";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Član";
            this.Shown += new System.EventHandler(this.FormClan_Shown);
            this.panTop.ResumeLayout(false);
            this.panBot.ResumeLayout(false);
            this.panMain.ResumeLayout(false);
            this.panMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panTop;
        private System.Windows.Forms.Panel panBot;
        private System.Windows.Forms.Panel panMain;
        public System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        public System.Windows.Forms.CheckBox cbAktivan;
        private System.Windows.Forms.Label lblGodCla;
        private System.Windows.Forms.Label lblFirma;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.Label lblOib;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblID;
        public System.Windows.Forms.TextBox tbMail;
        public System.Windows.Forms.TextBox tbFirma;
        public System.Windows.Forms.TextBox tbTel;
        public System.Windows.Forms.TextBox tbAdresa;
        public System.Windows.Forms.TextBox tbIme;
        public System.Windows.Forms.TextBox tbOib;
        public System.Windows.Forms.TextBox tbPrez;
        public System.Windows.Forms.TextBox tbID;
        public System.Windows.Forms.TextBox tbClanarina;
        private System.Windows.Forms.Label lblDatRod;
        private System.Windows.Forms.Label lblIme;
        public System.Windows.Forms.DateTimePicker tbDatRod;
    }
}