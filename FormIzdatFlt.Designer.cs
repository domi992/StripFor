namespace StripFor
{
    partial class FIzdatFlt
    {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FIzdatFlt));
            this.panMain = new System.Windows.Forms.Panel();
            this.panIzdatZag = new System.Windows.Forms.Panel();
            this.tbVra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbFirma = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbClan = new System.Windows.Forms.TextBox();
            this.lblBoxClan = new System.Windows.Forms.Label();
            this.tbDatPovrat = new System.Windows.Forms.TextBox();
            this.tbDatIzdav = new System.Windows.Forms.TextBox();
            this.tbBrojIzdat = new System.Windows.Forms.TextBox();
            this.tbOpis = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.bsIzdat = new System.Windows.Forms.BindingSource(this.components);
            this.DSSklad = new StripFor.SKLADDataSet();
            this.panTop = new System.Windows.Forms.Panel();
            this.lblZaglavlje = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panBott = new System.Windows.Forms.Panel();
            this.taIzdat = new StripFor.SKLADDataSetTableAdapters.NASLOVITableAdapter();
            this.ManagerIzdat = new StripFor.SKLADDataSetTableAdapters.TableAdapterManager();
            this.panMain.SuspendLayout();
            this.panIzdatZag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsIzdat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSSklad)).BeginInit();
            this.panTop.SuspendLayout();
            this.panBott.SuspendLayout();
            this.SuspendLayout();
            // 
            // panMain
            // 
            this.panMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panMain.BackColor = System.Drawing.Color.Khaki;
            this.panMain.Controls.Add(this.panIzdatZag);
            this.panMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panMain.Location = new System.Drawing.Point(0, 34);
            this.panMain.Name = "panMain";
            this.panMain.Size = new System.Drawing.Size(453, 385);
            this.panMain.TabIndex = 3;
            // 
            // panIzdatZag
            // 
            this.panIzdatZag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panIzdatZag.BackColor = System.Drawing.Color.CadetBlue;
            this.panIzdatZag.Controls.Add(this.tbVra);
            this.panIzdatZag.Controls.Add(this.label4);
            this.panIzdatZag.Controls.Add(this.tbFirma);
            this.panIzdatZag.Controls.Add(this.label3);
            this.panIzdatZag.Controls.Add(this.tbClan);
            this.panIzdatZag.Controls.Add(this.lblBoxClan);
            this.panIzdatZag.Controls.Add(this.tbDatPovrat);
            this.panIzdatZag.Controls.Add(this.tbDatIzdav);
            this.panIzdatZag.Controls.Add(this.tbBrojIzdat);
            this.panIzdatZag.Controls.Add(this.tbOpis);
            this.panIzdatZag.Controls.Add(this.label5);
            this.panIzdatZag.Controls.Add(this.label2);
            this.panIzdatZag.Controls.Add(this.label1);
            this.panIzdatZag.Controls.Add(this.lblNaslov);
            this.panIzdatZag.Location = new System.Drawing.Point(5, 6);
            this.panIzdatZag.Name = "panIzdatZag";
            this.panIzdatZag.Size = new System.Drawing.Size(443, 374);
            this.panIzdatZag.TabIndex = 25;
            // 
            // tbVra
            // 
            this.tbVra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbVra.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbVra.Location = new System.Drawing.Point(329, 315);
            this.tbVra.Name = "tbVra";
            this.tbVra.Size = new System.Drawing.Size(66, 22);
            this.tbVra.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(330, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 14);
            this.label4.TabIndex = 43;
            this.label4.Text = "Vraćeno:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbFirma
            // 
            this.tbFirma.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbFirma.Location = new System.Drawing.Point(35, 257);
            this.tbFirma.Name = "tbFirma";
            this.tbFirma.Size = new System.Drawing.Size(359, 22);
            this.tbFirma.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(35, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 14);
            this.label3.TabIndex = 41;
            this.label3.Text = "Firma:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbClan
            // 
            this.tbClan.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbClan.Location = new System.Drawing.Point(35, 199);
            this.tbClan.Name = "tbClan";
            this.tbClan.Size = new System.Drawing.Size(359, 22);
            this.tbClan.TabIndex = 3;
            // 
            // lblBoxClan
            // 
            this.lblBoxClan.AutoSize = true;
            this.lblBoxClan.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBoxClan.ForeColor = System.Drawing.Color.Black;
            this.lblBoxClan.Location = new System.Drawing.Point(35, 180);
            this.lblBoxClan.Name = "lblBoxClan";
            this.lblBoxClan.Size = new System.Drawing.Size(134, 14);
            this.lblBoxClan.TabIndex = 39;
            this.lblBoxClan.Text = "Ime i Prezime člana:";
            this.lblBoxClan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbDatPovrat
            // 
            this.tbDatPovrat.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbDatPovrat.Location = new System.Drawing.Point(36, 142);
            this.tbDatPovrat.Name = "tbDatPovrat";
            this.tbDatPovrat.Size = new System.Drawing.Size(359, 22);
            this.tbDatPovrat.TabIndex = 2;
            // 
            // tbDatIzdav
            // 
            this.tbDatIzdav.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbDatIzdav.Location = new System.Drawing.Point(35, 85);
            this.tbDatIzdav.Name = "tbDatIzdav";
            this.tbDatIzdav.Size = new System.Drawing.Size(360, 22);
            this.tbDatIzdav.TabIndex = 1;
            // 
            // tbBrojIzdat
            // 
            this.tbBrojIzdat.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbBrojIzdat.Location = new System.Drawing.Point(35, 33);
            this.tbBrojIzdat.Name = "tbBrojIzdat";
            this.tbBrojIzdat.Size = new System.Drawing.Size(360, 22);
            this.tbBrojIzdat.TabIndex = 0;
            // 
            // tbOpis
            // 
            this.tbOpis.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbOpis.Location = new System.Drawing.Point(35, 315);
            this.tbOpis.Name = "tbOpis";
            this.tbOpis.Size = new System.Drawing.Size(273, 22);
            this.tbOpis.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(35, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 14);
            this.label5.TabIndex = 31;
            this.label5.Text = "Broj izdatnice:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(35, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 14);
            this.label2.TabIndex = 30;
            this.label2.Text = "Datum povrata:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(35, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 14);
            this.label1.TabIndex = 29;
            this.label1.Text = "Opis izdatnice:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaslov.ForeColor = System.Drawing.Color.Black;
            this.lblNaslov.Location = new System.Drawing.Point(35, 66);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(118, 14);
            this.lblNaslov.TabIndex = 24;
            this.lblNaslov.Text = "Datum izdavanja:";
            this.lblNaslov.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bsIzdat
            // 
            this.bsIzdat.DataMember = "NASLOVI";
            this.bsIzdat.DataSource = this.DSSklad;
            // 
            // DSSklad
            // 
            this.DSSklad.DataSetName = "SKLADDataSet";
            this.DSSklad.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panTop
            // 
            this.panTop.BackColor = System.Drawing.Color.Tan;
            this.panTop.Controls.Add(this.lblZaglavlje);
            this.panTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTop.Location = new System.Drawing.Point(0, 0);
            this.panTop.Name = "panTop";
            this.panTop.Size = new System.Drawing.Size(453, 34);
            this.panTop.TabIndex = 5;
            // 
            // lblZaglavlje
            // 
            this.lblZaglavlje.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblZaglavlje.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblZaglavlje.ForeColor = System.Drawing.Color.DimGray;
            this.lblZaglavlje.Location = new System.Drawing.Point(12, 9);
            this.lblZaglavlje.Name = "lblZaglavlje";
            this.lblZaglavlje.Size = new System.Drawing.Size(429, 18);
            this.lblZaglavlje.TabIndex = 1;
            this.lblZaglavlje.Text = "F I L T E R";
            this.lblZaglavlje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOk
            // 
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Peru;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Image = ((System.Drawing.Image)(resources.GetObject("btnOk.Image")));
            this.btnOk.Location = new System.Drawing.Point(28, 4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(58, 36);
            this.btnOk.TabIndex = 7;
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Peru;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(143, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(58, 36);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panBott
            // 
            this.panBott.BackColor = System.Drawing.Color.Tan;
            this.panBott.Controls.Add(this.btnCancel);
            this.panBott.Controls.Add(this.btnOk);
            this.panBott.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panBott.Location = new System.Drawing.Point(0, 419);
            this.panBott.Name = "panBott";
            this.panBott.Size = new System.Drawing.Size(453, 43);
            this.panBott.TabIndex = 4;
            // 
            // taIzdat
            // 
            this.taIzdat.ClearBeforeFill = true;
            // 
            // ManagerIzdat
            // 
            this.ManagerIzdat.BackupDataSetBeforeUpdate = false;
            this.ManagerIzdat.CLANOVITableAdapter = null;
            this.ManagerIzdat.IZDANOTableAdapter = null;
            this.ManagerIzdat.IZDATNICATableAdapter = null;
            this.ManagerIzdat.NASLOVITableAdapter = this.taIzdat;
            this.ManagerIzdat.SIF_IZDAVACITableAdapter = null;
            this.ManagerIzdat.SIF_JUNACITableAdapter = null;
            this.ManagerIzdat.UpdateOrder = StripFor.SKLADDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FIzdatFlt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 462);
            this.Controls.Add(this.panMain);
            this.Controls.Add(this.panTop);
            this.Controls.Add(this.panBott);
            this.Name = "FIzdatFlt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Izdatnica";
            this.Load += new System.EventHandler(this.FIzdat_Load);
            this.panMain.ResumeLayout(false);
            this.panIzdatZag.ResumeLayout(false);
            this.panIzdatZag.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsIzdat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSSklad)).EndInit();
            this.panTop.ResumeLayout(false);
            this.panBott.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panMain;
        private System.Windows.Forms.Panel panTop;
        public System.Windows.Forms.Label lblZaglavlje;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panBott;
        private System.Windows.Forms.Panel panIzdatZag;
        public System.Windows.Forms.TextBox tbBrojIzdat;
        public System.Windows.Forms.TextBox tbOpis;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblNaslov;
        private SKLADDataSet DSSklad;
        private System.Windows.Forms.BindingSource bsIzdat;
        private SKLADDataSetTableAdapters.NASLOVITableAdapter taIzdat;
        private SKLADDataSetTableAdapters.TableAdapterManager ManagerIzdat;
        public System.Windows.Forms.TextBox tbDatIzdav;
        public System.Windows.Forms.TextBox tbDatPovrat;
        public System.Windows.Forms.TextBox tbClan;
        public System.Windows.Forms.Label lblBoxClan;
        public System.Windows.Forms.TextBox tbFirma;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tbVra;
    }
}