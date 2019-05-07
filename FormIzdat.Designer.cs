namespace StripFor
{
    partial class FormIzdat
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIzdat));
            this.panCenter = new System.Windows.Forms.Panel();
            this.panIzdatZag = new System.Windows.Forms.Panel();
            this.cbVraceno = new System.Windows.Forms.CheckBox();
            this.tbDatPovrat = new System.Windows.Forms.DateTimePicker();
            this.tbDatIzdav = new System.Windows.Forms.DateTimePicker();
            this.btnClan = new System.Windows.Forms.Button();
            this.tbIdClana = new System.Windows.Forms.TextBox();
            this.tbImeClana = new System.Windows.Forms.Label();
            this.tbBrojIzdat = new System.Windows.Forms.TextBox();
            this.tbOpis = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.panIzdatGrid = new System.Windows.Forms.Panel();
            this.grIzdat = new System.Windows.Forms.DataGridView();
            this.iDNASLOVADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sIFIZDAVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naslovDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojizdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.godizdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.izdanoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsIzdat = new System.Windows.Forms.BindingSource(this.components);
            this.dsSklad = new StripFor.SKLADDataSet();
            this.panBott = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.panTop = new System.Windows.Forms.Panel();
            this.lblZaglavlje = new System.Windows.Forms.Label();
            this.taIzdat = new StripFor.SKLADDataSetTableAdapters.NASLOVITableAdapter();
            this.panCenter.SuspendLayout();
            this.panIzdatZag.SuspendLayout();
            this.panIzdatGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grIzdat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsIzdat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSklad)).BeginInit();
            this.panBott.SuspendLayout();
            this.panTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panCenter
            // 
            this.panCenter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panCenter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panCenter.BackColor = System.Drawing.Color.Khaki;
            this.panCenter.Controls.Add(this.panIzdatZag);
            this.panCenter.Controls.Add(this.panIzdatGrid);
            this.panCenter.Location = new System.Drawing.Point(0, 35);
            this.panCenter.Name = "panCenter";
            this.panCenter.Size = new System.Drawing.Size(652, 396);
            this.panCenter.TabIndex = 4;
            // 
            // panIzdatZag
            // 
            this.panIzdatZag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panIzdatZag.BackColor = System.Drawing.Color.CadetBlue;
            this.panIzdatZag.Controls.Add(this.cbVraceno);
            this.panIzdatZag.Controls.Add(this.tbDatPovrat);
            this.panIzdatZag.Controls.Add(this.tbDatIzdav);
            this.panIzdatZag.Controls.Add(this.btnClan);
            this.panIzdatZag.Controls.Add(this.tbIdClana);
            this.panIzdatZag.Controls.Add(this.tbImeClana);
            this.panIzdatZag.Controls.Add(this.tbBrojIzdat);
            this.panIzdatZag.Controls.Add(this.tbOpis);
            this.panIzdatZag.Controls.Add(this.label5);
            this.panIzdatZag.Controls.Add(this.label2);
            this.panIzdatZag.Controls.Add(this.label1);
            this.panIzdatZag.Controls.Add(this.lblNaslov);
            this.panIzdatZag.Location = new System.Drawing.Point(5, 6);
            this.panIzdatZag.Name = "panIzdatZag";
            this.panIzdatZag.Size = new System.Drawing.Size(642, 176);
            this.panIzdatZag.TabIndex = 25;
            // 
            // cbVraceno
            // 
            this.cbVraceno.AutoSize = true;
            this.cbVraceno.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbVraceno.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbVraceno.ForeColor = System.Drawing.Color.Black;
            this.cbVraceno.Location = new System.Drawing.Point(530, 36);
            this.cbVraceno.Name = "cbVraceno";
            this.cbVraceno.Size = new System.Drawing.Size(77, 18);
            this.cbVraceno.TabIndex = 3;
            this.cbVraceno.Text = "Vraćeno";
            this.cbVraceno.UseVisualStyleBackColor = true;
            this.cbVraceno.Visible = false;
            // 
            // tbDatPovrat
            // 
            this.tbDatPovrat.CustomFormat = "dd.MM.yyyy";
            this.tbDatPovrat.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbDatPovrat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tbDatPovrat.Location = new System.Drawing.Point(361, 33);
            this.tbDatPovrat.Name = "tbDatPovrat";
            this.tbDatPovrat.Size = new System.Drawing.Size(121, 23);
            this.tbDatPovrat.TabIndex = 2;
            // 
            // tbDatIzdav
            // 
            this.tbDatIzdav.CustomFormat = "dd.MM.yyyy";
            this.tbDatIzdav.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbDatIzdav.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tbDatIzdav.Location = new System.Drawing.Point(198, 32);
            this.tbDatIzdav.Name = "tbDatIzdav";
            this.tbDatIzdav.Size = new System.Drawing.Size(121, 23);
            this.tbDatIzdav.TabIndex = 1;
            // 
            // btnClan
            // 
            this.btnClan.FlatAppearance.BorderSize = 0;
            this.btnClan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClan.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClan.ForeColor = System.Drawing.Color.NavajoWhite;
            this.btnClan.Location = new System.Drawing.Point(35, 62);
            this.btnClan.Name = "btnClan";
            this.btnClan.Size = new System.Drawing.Size(75, 20);
            this.btnClan.TabIndex = 34;
            this.btnClan.Text = "Član:";
            this.btnClan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClan.UseVisualStyleBackColor = true;
            this.btnClan.Click += new System.EventHandler(this.btnClan_Click);
            // 
            // tbIdClana
            // 
            this.tbIdClana.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbIdClana.Location = new System.Drawing.Point(35, 83);
            this.tbIdClana.Name = "tbIdClana";
            this.tbIdClana.ReadOnly = true;
            this.tbIdClana.Size = new System.Drawing.Size(99, 22);
            this.tbIdClana.TabIndex = 4;
            // 
            // tbImeClana
            // 
            this.tbImeClana.BackColor = System.Drawing.Color.LightGray;
            this.tbImeClana.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbImeClana.ForeColor = System.Drawing.Color.DimGray;
            this.tbImeClana.Location = new System.Drawing.Point(146, 85);
            this.tbImeClana.Name = "tbImeClana";
            this.tbImeClana.Size = new System.Drawing.Size(458, 19);
            this.tbImeClana.TabIndex = 33;
            this.tbImeClana.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbBrojIzdat
            // 
            this.tbBrojIzdat.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbBrojIzdat.Location = new System.Drawing.Point(35, 33);
            this.tbBrojIzdat.Name = "tbBrojIzdat";
            this.tbBrojIzdat.Size = new System.Drawing.Size(122, 22);
            this.tbBrojIzdat.TabIndex = 0;
            // 
            // tbOpis
            // 
            this.tbOpis.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbOpis.Location = new System.Drawing.Point(35, 135);
            this.tbOpis.Name = "tbOpis";
            this.tbOpis.Size = new System.Drawing.Size(569, 22);
            this.tbOpis.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(33, 14);
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
            this.label2.Location = new System.Drawing.Point(366, 14);
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
            this.label1.Location = new System.Drawing.Point(33, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 14);
            this.label1.TabIndex = 29;
            this.label1.Text = "Opis:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaslov.ForeColor = System.Drawing.Color.Black;
            this.lblNaslov.Location = new System.Drawing.Point(199, 14);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(118, 14);
            this.lblNaslov.TabIndex = 24;
            this.lblNaslov.Text = "Datum izdavanja:";
            this.lblNaslov.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panIzdatGrid
            // 
            this.panIzdatGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panIzdatGrid.BackColor = System.Drawing.Color.LightSlateGray;
            this.panIzdatGrid.Controls.Add(this.grIzdat);
            this.panIzdatGrid.Location = new System.Drawing.Point(5, 188);
            this.panIzdatGrid.Name = "panIzdatGrid";
            this.panIzdatGrid.Size = new System.Drawing.Size(642, 202);
            this.panIzdatGrid.TabIndex = 24;
            // 
            // grIzdat
            // 
            this.grIzdat.AllowUserToAddRows = false;
            this.grIzdat.AllowUserToDeleteRows = false;
            this.grIzdat.AllowUserToOrderColumns = true;
            this.grIzdat.AllowUserToResizeRows = false;
            this.grIzdat.AutoGenerateColumns = false;
            this.grIzdat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grIzdat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grIzdat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grIzdat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDNASLOVADataGridViewTextBoxColumn,
            this.sIFIZDAVDataGridViewTextBoxColumn,
            this.naslovDataGridViewTextBoxColumn,
            this.brojizdDataGridViewTextBoxColumn,
            this.godizdDataGridViewTextBoxColumn,
            this.izdanoDataGridViewTextBoxColumn});
            this.grIzdat.DataSource = this.bsIzdat;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grIzdat.DefaultCellStyle = dataGridViewCellStyle3;
            this.grIzdat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grIzdat.EnableHeadersVisualStyles = false;
            this.grIzdat.Location = new System.Drawing.Point(0, 0);
            this.grIzdat.MultiSelect = false;
            this.grIzdat.Name = "grIzdat";
            this.grIzdat.RowHeadersVisible = false;
            this.grIzdat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grIzdat.Size = new System.Drawing.Size(642, 202);
            this.grIzdat.TabIndex = 6;
            this.grIzdat.Tag = "";
            // 
            // iDNASLOVADataGridViewTextBoxColumn
            // 
            this.iDNASLOVADataGridViewTextBoxColumn.DataPropertyName = "ID_NASLOVA";
            this.iDNASLOVADataGridViewTextBoxColumn.FillWeight = 40F;
            this.iDNASLOVADataGridViewTextBoxColumn.HeaderText = "Id";
            this.iDNASLOVADataGridViewTextBoxColumn.Name = "iDNASLOVADataGridViewTextBoxColumn";
            this.iDNASLOVADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sIFIZDAVDataGridViewTextBoxColumn
            // 
            this.sIFIZDAVDataGridViewTextBoxColumn.DataPropertyName = "SIF_IZDAV";
            this.sIFIZDAVDataGridViewTextBoxColumn.FillWeight = 40F;
            this.sIFIZDAVDataGridViewTextBoxColumn.HeaderText = "Izdavac";
            this.sIFIZDAVDataGridViewTextBoxColumn.Name = "sIFIZDAVDataGridViewTextBoxColumn";
            this.sIFIZDAVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // naslovDataGridViewTextBoxColumn
            // 
            this.naslovDataGridViewTextBoxColumn.DataPropertyName = "Naslov";
            this.naslovDataGridViewTextBoxColumn.FillWeight = 120F;
            this.naslovDataGridViewTextBoxColumn.HeaderText = "Naslov";
            this.naslovDataGridViewTextBoxColumn.Name = "naslovDataGridViewTextBoxColumn";
            this.naslovDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // brojizdDataGridViewTextBoxColumn
            // 
            this.brojizdDataGridViewTextBoxColumn.DataPropertyName = "Broj_izd";
            this.brojizdDataGridViewTextBoxColumn.FillWeight = 40F;
            this.brojizdDataGridViewTextBoxColumn.HeaderText = "Br.izd";
            this.brojizdDataGridViewTextBoxColumn.Name = "brojizdDataGridViewTextBoxColumn";
            this.brojizdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // godizdDataGridViewTextBoxColumn
            // 
            this.godizdDataGridViewTextBoxColumn.DataPropertyName = "God_izd";
            this.godizdDataGridViewTextBoxColumn.FillWeight = 50F;
            this.godizdDataGridViewTextBoxColumn.HeaderText = "God.izd";
            this.godizdDataGridViewTextBoxColumn.Name = "godizdDataGridViewTextBoxColumn";
            this.godizdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // izdanoDataGridViewTextBoxColumn
            // 
            this.izdanoDataGridViewTextBoxColumn.DataPropertyName = "Izdano";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.PeachPuff;
            this.izdanoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.izdanoDataGridViewTextBoxColumn.FillWeight = 40F;
            this.izdanoDataGridViewTextBoxColumn.HeaderText = "Izdano";
            this.izdanoDataGridViewTextBoxColumn.Name = "izdanoDataGridViewTextBoxColumn";
            // 
            // bsIzdat
            // 
            this.bsIzdat.DataMember = "NASLOVI";
            this.bsIzdat.DataSource = this.dsSklad;
            // 
            // dsSklad
            // 
            this.dsSklad.DataSetName = "SKLADDataSet";
            this.dsSklad.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panBott
            // 
            this.panBott.BackColor = System.Drawing.Color.Tan;
            this.panBott.Controls.Add(this.btnCancel);
            this.panBott.Controls.Add(this.btnOk);
            this.panBott.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panBott.Location = new System.Drawing.Point(0, 433);
            this.panBott.Name = "panBott";
            this.panBott.Size = new System.Drawing.Size(652, 43);
            this.panBott.TabIndex = 5;
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
            this.btnCancel.TabIndex = 1;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            this.btnOk.TabIndex = 0;
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // panTop
            // 
            this.panTop.BackColor = System.Drawing.Color.Tan;
            this.panTop.Controls.Add(this.lblZaglavlje);
            this.panTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTop.Location = new System.Drawing.Point(0, 0);
            this.panTop.Name = "panTop";
            this.panTop.Size = new System.Drawing.Size(652, 34);
            this.panTop.TabIndex = 6;
            // 
            // lblZaglavlje
            // 
            this.lblZaglavlje.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblZaglavlje.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblZaglavlje.ForeColor = System.Drawing.Color.DimGray;
            this.lblZaglavlje.Location = new System.Drawing.Point(12, 9);
            this.lblZaglavlje.Name = "lblZaglavlje";
            this.lblZaglavlje.Size = new System.Drawing.Size(628, 18);
            this.lblZaglavlje.TabIndex = 1;
            this.lblZaglavlje.Text = "IZDATNICA";
            this.lblZaglavlje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // taIzdat
            // 
            this.taIzdat.ClearBeforeFill = true;
            // 
            // FormIzdat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 476);
            this.Controls.Add(this.panTop);
            this.Controls.Add(this.panBott);
            this.Controls.Add(this.panCenter);
            this.Name = "FormIzdat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormIzdat";
            this.Shown += new System.EventHandler(this.FormIzdat_Shown);
            this.panCenter.ResumeLayout(false);
            this.panIzdatZag.ResumeLayout(false);
            this.panIzdatZag.PerformLayout();
            this.panIzdatGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grIzdat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsIzdat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSklad)).EndInit();
            this.panBott.ResumeLayout(false);
            this.panTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panCenter;
        private System.Windows.Forms.Panel panIzdatZag;
        public System.Windows.Forms.DateTimePicker tbDatPovrat;
        public System.Windows.Forms.DateTimePicker tbDatIzdav;
        public System.Windows.Forms.TextBox tbIdClana;
        public System.Windows.Forms.Label tbImeClana;
        public System.Windows.Forms.TextBox tbBrojIzdat;
        public System.Windows.Forms.TextBox tbOpis;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Panel panIzdatGrid;
        private System.Windows.Forms.Panel panBott;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Panel panTop;
        public System.Windows.Forms.Label lblZaglavlje;
        public System.Windows.Forms.DataGridView grIzdat;
        private SKLADDataSet dsSklad;
        private System.Windows.Forms.BindingSource bsIzdat;
        private SKLADDataSetTableAdapters.NASLOVITableAdapter taIzdat;
        public System.Windows.Forms.Button btnClan;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDNASLOVADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sIFIZDAVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn naslovDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojizdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn godizdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn izdanoDataGridViewTextBoxColumn;
        public System.Windows.Forms.CheckBox cbVraceno;
    }
}