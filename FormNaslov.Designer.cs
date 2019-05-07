namespace StripFor
{
    partial class FormNaslov{
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNaslov));
            this.panTop = new System.Windows.Forms.Panel();
            this.lblMain = new System.Windows.Forms.Label();
            this.panBot = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.panMain = new System.Windows.Forms.Panel();
            this.pbOmot = new System.Windows.Forms.PictureBox();
            this.btnJunak = new System.Windows.Forms.Button();
            this.btnIzdavac = new System.Windows.Forms.Button();
            this.tbJunak = new System.Windows.Forms.TextBox();
            this.tbIzdavac = new System.Windows.Forms.TextBox();
            this.cbDigit = new System.Windows.Forms.CheckBox();
            this.cbPapir = new System.Windows.Forms.CheckBox();
            this.btnIzborOmot = new System.Windows.Forms.Button();
            this.cbIzbor = new System.Windows.Forms.CheckBox();
            this.lblIzdano = new System.Windows.Forms.Label();
            this.lblSlika = new System.Windows.Forms.Label();
            this.lblLok = new System.Windows.Forms.Label();
            this.lblKol = new System.Windows.Forms.Label();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.lblBrIzd = new System.Windows.Forms.Label();
            this.lblGodIzd = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.tbLok = new System.Windows.Forms.TextBox();
            this.tbSlika = new System.Windows.Forms.TextBox();
            this.tbIzdano = new System.Windows.Forms.TextBox();
            this.tbKol = new System.Windows.Forms.TextBox();
            this.tbNaslov = new System.Windows.Forms.TextBox();
            this.tbSifJun = new System.Windows.Forms.TextBox();
            this.tbSifIzd = new System.Windows.Forms.TextBox();
            this.tbBrIzd = new System.Windows.Forms.TextBox();
            this.tbGodIzd = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.panTop.SuspendLayout();
            this.panBot.SuspendLayout();
            this.panMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOmot)).BeginInit();
            this.SuspendLayout();
            // 
            // panTop
            // 
            this.panTop.BackColor = System.Drawing.Color.Tan;
            this.panTop.Controls.Add(this.lblMain);
            this.panTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTop.Location = new System.Drawing.Point(0, 0);
            this.panTop.Name = "panTop";
            this.panTop.Size = new System.Drawing.Size(606, 45);
            this.panTop.TabIndex = 0;
            // 
            // lblMain
            // 
            this.lblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMain.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMain.ForeColor = System.Drawing.Color.DimGray;
            this.lblMain.Location = new System.Drawing.Point(0, 0);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(606, 45);
            this.lblMain.TabIndex = 0;
            this.lblMain.Text = "N A S L O V";
            this.lblMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panBot
            // 
            this.panBot.BackColor = System.Drawing.Color.Tan;
            this.panBot.Controls.Add(this.btnCancel);
            this.panBot.Controls.Add(this.btnOk);
            this.panBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panBot.Location = new System.Drawing.Point(0, 437);
            this.panBot.Name = "panBot";
            this.panBot.Size = new System.Drawing.Size(606, 48);
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
            this.btnOk.Location = new System.Drawing.Point(32, 6);
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
            this.panMain.Controls.Add(this.pbOmot);
            this.panMain.Controls.Add(this.btnJunak);
            this.panMain.Controls.Add(this.btnIzdavac);
            this.panMain.Controls.Add(this.tbJunak);
            this.panMain.Controls.Add(this.tbIzdavac);
            this.panMain.Controls.Add(this.cbDigit);
            this.panMain.Controls.Add(this.cbPapir);
            this.panMain.Controls.Add(this.btnIzborOmot);
            this.panMain.Controls.Add(this.cbIzbor);
            this.panMain.Controls.Add(this.lblIzdano);
            this.panMain.Controls.Add(this.lblSlika);
            this.panMain.Controls.Add(this.lblLok);
            this.panMain.Controls.Add(this.lblKol);
            this.panMain.Controls.Add(this.lblNaslov);
            this.panMain.Controls.Add(this.lblBrIzd);
            this.panMain.Controls.Add(this.lblGodIzd);
            this.panMain.Controls.Add(this.lblID);
            this.panMain.Controls.Add(this.tbLok);
            this.panMain.Controls.Add(this.tbSlika);
            this.panMain.Controls.Add(this.tbIzdano);
            this.panMain.Controls.Add(this.tbKol);
            this.panMain.Controls.Add(this.tbNaslov);
            this.panMain.Controls.Add(this.tbSifJun);
            this.panMain.Controls.Add(this.tbSifIzd);
            this.panMain.Controls.Add(this.tbBrIzd);
            this.panMain.Controls.Add(this.tbGodIzd);
            this.panMain.Controls.Add(this.tbID);
            this.panMain.Location = new System.Drawing.Point(3, 48);
            this.panMain.Name = "panMain";
            this.panMain.Size = new System.Drawing.Size(600, 386);
            this.panMain.TabIndex = 2;
            // 
            // pbOmot
            // 
            this.pbOmot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbOmot.Location = new System.Drawing.Point(409, 15);
            this.pbOmot.Name = "pbOmot";
            this.pbOmot.Size = new System.Drawing.Size(126, 162);
            this.pbOmot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbOmot.TabIndex = 29;
            this.pbOmot.TabStop = false;
            this.pbOmot.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pbOmot_MouseDoubleClick);
            // 
            // btnJunak
            // 
            this.btnJunak.BackColor = System.Drawing.Color.Transparent;
            this.btnJunak.FlatAppearance.BorderSize = 0;
            this.btnJunak.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnJunak.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnJunak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJunak.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnJunak.ForeColor = System.Drawing.Color.NavajoWhite;
            this.btnJunak.Location = new System.Drawing.Point(47, 129);
            this.btnJunak.Name = "btnJunak";
            this.btnJunak.Size = new System.Drawing.Size(62, 21);
            this.btnJunak.TabIndex = 28;
            this.btnJunak.Text = "Junak:";
            this.btnJunak.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJunak.UseVisualStyleBackColor = false;
            this.btnJunak.Click += new System.EventHandler(this.btnJunak_Click);
            // 
            // btnIzdavac
            // 
            this.btnIzdavac.BackColor = System.Drawing.Color.Transparent;
            this.btnIzdavac.FlatAppearance.BorderSize = 0;
            this.btnIzdavac.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnIzdavac.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnIzdavac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzdavac.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzdavac.ForeColor = System.Drawing.Color.NavajoWhite;
            this.btnIzdavac.Location = new System.Drawing.Point(47, 75);
            this.btnIzdavac.Name = "btnIzdavac";
            this.btnIzdavac.Size = new System.Drawing.Size(81, 20);
            this.btnIzdavac.TabIndex = 27;
            this.btnIzdavac.Text = "Izdavač:";
            this.btnIzdavac.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIzdavac.UseVisualStyleBackColor = false;
            this.btnIzdavac.Click += new System.EventHandler(this.btnIzdavac_Click);
            // 
            // tbJunak
            // 
            this.tbJunak.BackColor = System.Drawing.Color.Silver;
            this.tbJunak.Enabled = false;
            this.tbJunak.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbJunak.Location = new System.Drawing.Point(152, 150);
            this.tbJunak.Name = "tbJunak";
            this.tbJunak.ReadOnly = true;
            this.tbJunak.Size = new System.Drawing.Size(178, 22);
            this.tbJunak.TabIndex = 26;
            this.tbJunak.TabStop = false;
            // 
            // tbIzdavac
            // 
            this.tbIzdavac.BackColor = System.Drawing.Color.Silver;
            this.tbIzdavac.Enabled = false;
            this.tbIzdavac.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbIzdavac.Location = new System.Drawing.Point(152, 96);
            this.tbIzdavac.Name = "tbIzdavac";
            this.tbIzdavac.ReadOnly = true;
            this.tbIzdavac.Size = new System.Drawing.Size(178, 22);
            this.tbIzdavac.TabIndex = 25;
            this.tbIzdavac.TabStop = false;
            // 
            // cbDigit
            // 
            this.cbDigit.AutoSize = true;
            this.cbDigit.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbDigit.Location = new System.Drawing.Point(160, 337);
            this.cbDigit.Name = "cbDigit";
            this.cbDigit.Size = new System.Drawing.Size(81, 18);
            this.cbDigit.TabIndex = 11;
            this.cbDigit.Text = "Digitalno";
            this.cbDigit.UseVisualStyleBackColor = true;
            // 
            // cbPapir
            // 
            this.cbPapir.AutoSize = true;
            this.cbPapir.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbPapir.Location = new System.Drawing.Point(64, 337);
            this.cbPapir.Name = "cbPapir";
            this.cbPapir.Size = new System.Drawing.Size(58, 18);
            this.cbPapir.TabIndex = 10;
            this.cbPapir.Text = "Papir";
            this.cbPapir.UseVisualStyleBackColor = true;
            // 
            // btnIzborOmot
            // 
            this.btnIzborOmot.Location = new System.Drawing.Point(438, 288);
            this.btnIzborOmot.Name = "btnIzborOmot";
            this.btnIzborOmot.Size = new System.Drawing.Size(35, 23);
            this.btnIzborOmot.TabIndex = 22;
            this.btnIzborOmot.TabStop = false;
            this.btnIzborOmot.Text = "...";
            this.btnIzborOmot.UseVisualStyleBackColor = true;
            this.btnIzborOmot.Click += new System.EventHandler(this.btnIzborOmot_Click);
            // 
            // cbIzbor
            // 
            this.cbIzbor.AutoSize = true;
            this.cbIzbor.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbIzbor.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbIzbor.Location = new System.Drawing.Point(414, 337);
            this.cbIzbor.Name = "cbIzbor";
            this.cbIzbor.Size = new System.Drawing.Size(59, 18);
            this.cbIzbor.TabIndex = 12;
            this.cbIzbor.Text = "Izbor";
            this.cbIzbor.UseVisualStyleBackColor = true;
            // 
            // lblIzdano
            // 
            this.lblIzdano.AutoSize = true;
            this.lblIzdano.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIzdano.Location = new System.Drawing.Point(155, 227);
            this.lblIzdano.Name = "lblIzdano";
            this.lblIzdano.Size = new System.Drawing.Size(56, 14);
            this.lblIzdano.TabIndex = 19;
            this.lblIzdano.Text = "Izdano:";
            // 
            // lblSlika
            // 
            this.lblSlika.AutoSize = true;
            this.lblSlika.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSlika.Location = new System.Drawing.Point(45, 275);
            this.lblSlika.Name = "lblSlika";
            this.lblSlika.Size = new System.Drawing.Size(88, 14);
            this.lblSlika.TabIndex = 18;
            this.lblSlika.Text = "Omot (slika):";
            // 
            // lblLok
            // 
            this.lblLok.AutoSize = true;
            this.lblLok.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLok.Location = new System.Drawing.Point(263, 227);
            this.lblLok.Name = "lblLok";
            this.lblLok.Size = new System.Drawing.Size(63, 14);
            this.lblLok.TabIndex = 17;
            this.lblLok.Text = "Lokacija:";
            // 
            // lblKol
            // 
            this.lblKol.AutoSize = true;
            this.lblKol.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKol.Location = new System.Drawing.Point(45, 227);
            this.lblKol.Name = "lblKol";
            this.lblKol.Size = new System.Drawing.Size(59, 14);
            this.lblKol.TabIndex = 16;
            this.lblKol.Text = "Količina:";
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaslov.Location = new System.Drawing.Point(45, 178);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(54, 14);
            this.lblNaslov.TabIndex = 15;
            this.lblNaslov.Text = "Naslov:";
            // 
            // lblBrIzd
            // 
            this.lblBrIzd.AutoSize = true;
            this.lblBrIzd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBrIzd.Location = new System.Drawing.Point(243, 15);
            this.lblBrIzd.Name = "lblBrIzd";
            this.lblBrIzd.Size = new System.Drawing.Size(87, 14);
            this.lblBrIzd.TabIndex = 13;
            this.lblBrIzd.Text = "Broj izdanja:";
            // 
            // lblGodIzd
            // 
            this.lblGodIzd.AutoSize = true;
            this.lblGodIzd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblGodIzd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGodIzd.Location = new System.Drawing.Point(146, 15);
            this.lblGodIzd.Name = "lblGodIzd";
            this.lblGodIzd.Size = new System.Drawing.Size(91, 14);
            this.lblGodIzd.TabIndex = 11;
            this.lblGodIzd.Text = "God. izdanja:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblID.Location = new System.Drawing.Point(45, 15);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(26, 14);
            this.lblID.TabIndex = 10;
            this.lblID.Text = "ID:";
            // 
            // tbLok
            // 
            this.tbLok.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbLok.Location = new System.Drawing.Point(266, 243);
            this.tbLok.Name = "tbLok";
            this.tbLok.Size = new System.Drawing.Size(207, 22);
            this.tbLok.TabIndex = 8;
            // 
            // tbSlika
            // 
            this.tbSlika.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbSlika.Location = new System.Drawing.Point(47, 291);
            this.tbSlika.Name = "tbSlika";
            this.tbSlika.Size = new System.Drawing.Size(385, 22);
            this.tbSlika.TabIndex = 9;
            // 
            // tbIzdano
            // 
            this.tbIzdano.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbIzdano.Location = new System.Drawing.Point(158, 243);
            this.tbIzdano.Name = "tbIzdano";
            this.tbIzdano.Size = new System.Drawing.Size(82, 22);
            this.tbIzdano.TabIndex = 7;
            // 
            // tbKol
            // 
            this.tbKol.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbKol.Location = new System.Drawing.Point(47, 243);
            this.tbKol.Name = "tbKol";
            this.tbKol.Size = new System.Drawing.Size(81, 22);
            this.tbKol.TabIndex = 6;
            // 
            // tbNaslov
            // 
            this.tbNaslov.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbNaslov.Location = new System.Drawing.Point(47, 194);
            this.tbNaslov.Name = "tbNaslov";
            this.tbNaslov.Size = new System.Drawing.Size(426, 22);
            this.tbNaslov.TabIndex = 5;
            // 
            // tbSifJun
            // 
            this.tbSifJun.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbSifJun.Location = new System.Drawing.Point(47, 150);
            this.tbSifJun.Name = "tbSifJun";
            this.tbSifJun.ReadOnly = true;
            this.tbSifJun.Size = new System.Drawing.Size(89, 22);
            this.tbSifJun.TabIndex = 4;
            // 
            // tbSifIzd
            // 
            this.tbSifIzd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbSifIzd.Location = new System.Drawing.Point(47, 96);
            this.tbSifIzd.Name = "tbSifIzd";
            this.tbSifIzd.ReadOnly = true;
            this.tbSifIzd.Size = new System.Drawing.Size(89, 22);
            this.tbSifIzd.TabIndex = 3;
            // 
            // tbBrIzd
            // 
            this.tbBrIzd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbBrIzd.Location = new System.Drawing.Point(249, 32);
            this.tbBrIzd.Name = "tbBrIzd";
            this.tbBrIzd.Size = new System.Drawing.Size(81, 22);
            this.tbBrIzd.TabIndex = 2;
            // 
            // tbGodIzd
            // 
            this.tbGodIzd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbGodIzd.Location = new System.Drawing.Point(149, 31);
            this.tbGodIzd.Name = "tbGodIzd";
            this.tbGodIzd.Size = new System.Drawing.Size(81, 22);
            this.tbGodIzd.TabIndex = 1;
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
            // FormNaslov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(606, 485);
            this.Controls.Add(this.panMain);
            this.Controls.Add(this.panBot);
            this.Controls.Add(this.panTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNaslov";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Naslov";
            this.Shown += new System.EventHandler(this.FormNaslov_Shown);
            this.panTop.ResumeLayout(false);
            this.panBot.ResumeLayout(false);
            this.panMain.ResumeLayout(false);
            this.panMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOmot)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panTop;
        private System.Windows.Forms.Panel panBot;
        private System.Windows.Forms.Panel panMain;
        public System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnJunak;
        private System.Windows.Forms.Button btnIzdavac;
        public System.Windows.Forms.TextBox tbJunak;
        public System.Windows.Forms.TextBox tbIzdavac;
        public System.Windows.Forms.CheckBox cbDigit;
        public System.Windows.Forms.CheckBox cbPapir;
        private System.Windows.Forms.Button btnIzborOmot;
        public System.Windows.Forms.CheckBox cbIzbor;
        private System.Windows.Forms.Label lblIzdano;
        private System.Windows.Forms.Label lblSlika;
        private System.Windows.Forms.Label lblLok;
        private System.Windows.Forms.Label lblKol;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Label lblBrIzd;
        private System.Windows.Forms.Label lblGodIzd;
        private System.Windows.Forms.Label lblID;
        public System.Windows.Forms.TextBox tbLok;
        public System.Windows.Forms.TextBox tbSlika;
        public System.Windows.Forms.TextBox tbIzdano;
        public System.Windows.Forms.TextBox tbKol;
        public System.Windows.Forms.TextBox tbNaslov;
        public System.Windows.Forms.TextBox tbSifJun;
        public System.Windows.Forms.TextBox tbSifIzd;
        public System.Windows.Forms.TextBox tbBrIzd;
        public System.Windows.Forms.TextBox tbGodIzd;
        public System.Windows.Forms.TextBox tbID;
        public System.Windows.Forms.PictureBox pbOmot;
    }
}