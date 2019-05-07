namespace StripFor
{
    partial class FIzbor{
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FIzbor));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panTop = new System.Windows.Forms.Panel();
            this.lblMain = new System.Windows.Forms.Label();
            this.panBot = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.panMain = new System.Windows.Forms.Panel();
            this.gridIzbor = new System.Windows.Forms.DataGridView();
            this.sIFJUNAKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.junakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsJunaci = new System.Windows.Forms.BindingSource(this.components);
            this.dsSklad = new StripFor.SKLADDataSet();
            this.panFilter = new System.Windows.Forms.Panel();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.taJunaci = new StripFor.SKLADDataSetTableAdapters.SIF_JUNACITableAdapter();
            this.bsIzdavaci = new System.Windows.Forms.BindingSource(this.components);
            this.taIzdavaci = new StripFor.SKLADDataSetTableAdapters.SIF_IZDAVACITableAdapter();
            this.panTop.SuspendLayout();
            this.panBot.SuspendLayout();
            this.panMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridIzbor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsJunaci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSklad)).BeginInit();
            this.panFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsIzdavaci)).BeginInit();
            this.SuspendLayout();
            // 
            // panTop
            // 
            this.panTop.BackColor = System.Drawing.Color.Tan;
            this.panTop.Controls.Add(this.lblMain);
            this.panTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTop.Location = new System.Drawing.Point(0, 0);
            this.panTop.Name = "panTop";
            this.panTop.Size = new System.Drawing.Size(510, 42);
            this.panTop.TabIndex = 0;
            // 
            // lblMain
            // 
            this.lblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMain.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMain.ForeColor = System.Drawing.Color.DimGray;
            this.lblMain.Location = new System.Drawing.Point(0, 0);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(510, 42);
            this.lblMain.TabIndex = 0;
            this.lblMain.Text = "J U N A K";
            this.lblMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panBot
            // 
            this.panBot.BackColor = System.Drawing.Color.Tan;
            this.panBot.Controls.Add(this.btnCancel);
            this.panBot.Controls.Add(this.btnOk);
            this.panBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panBot.Location = new System.Drawing.Point(0, 441);
            this.panBot.Name = "panBot";
            this.panBot.Size = new System.Drawing.Size(510, 42);
            this.panBot.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(148, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(58, 36);
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
            this.btnOk.Location = new System.Drawing.Point(34, 0);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(58, 36);
            this.btnOk.TabIndex = 0;
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // panMain
            // 
            this.panMain.BackColor = System.Drawing.Color.CadetBlue;
            this.panMain.Controls.Add(this.gridIzbor);
            this.panMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panMain.Location = new System.Drawing.Point(0, 42);
            this.panMain.Name = "panMain";
            this.panMain.Padding = new System.Windows.Forms.Padding(5);
            this.panMain.Size = new System.Drawing.Size(510, 399);
            this.panMain.TabIndex = 2;
            // 
            // gridIzbor
            // 
            this.gridIzbor.AllowUserToAddRows = false;
            this.gridIzbor.AllowUserToDeleteRows = false;
            this.gridIzbor.AllowUserToResizeRows = false;
            this.gridIzbor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridIzbor.AutoGenerateColumns = false;
            this.gridIzbor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridIzbor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridIzbor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridIzbor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sIFJUNAKDataGridViewTextBoxColumn,
            this.junakDataGridViewTextBoxColumn});
            this.gridIzbor.DataSource = this.bsJunaci;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridIzbor.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridIzbor.EnableHeadersVisualStyles = false;
            this.gridIzbor.Location = new System.Drawing.Point(1, 43);
            this.gridIzbor.MultiSelect = false;
            this.gridIzbor.Name = "gridIzbor";
            this.gridIzbor.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridIzbor.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridIzbor.RowHeadersVisible = false;
            this.gridIzbor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridIzbor.Size = new System.Drawing.Size(508, 355);
            this.gridIzbor.TabIndex = 1;
            this.gridIzbor.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridIzbor_CellMouseDoubleClick);
            // 
            // sIFJUNAKDataGridViewTextBoxColumn
            // 
            this.sIFJUNAKDataGridViewTextBoxColumn.DataPropertyName = "SIF_JUNAK";
            this.sIFJUNAKDataGridViewTextBoxColumn.HeaderText = "Šifra";
            this.sIFJUNAKDataGridViewTextBoxColumn.Name = "sIFJUNAKDataGridViewTextBoxColumn";
            this.sIFJUNAKDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // junakDataGridViewTextBoxColumn
            // 
            this.junakDataGridViewTextBoxColumn.DataPropertyName = "Junak";
            this.junakDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.junakDataGridViewTextBoxColumn.Name = "junakDataGridViewTextBoxColumn";
            this.junakDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsJunaci
            // 
            this.bsJunaci.DataMember = "SIF_JUNACI";
            this.bsJunaci.DataSource = this.dsSklad;
            // 
            // dsSklad
            // 
            this.dsSklad.DataSetName = "SKLADDataSet";
            this.dsSklad.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panFilter
            // 
            this.panFilter.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panFilter.Controls.Add(this.tbFilter);
            this.panFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panFilter.Location = new System.Drawing.Point(0, 42);
            this.panFilter.Name = "panFilter";
            this.panFilter.Size = new System.Drawing.Size(510, 42);
            this.panFilter.TabIndex = 3;
            // 
            // tbFilter
            // 
            this.tbFilter.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tbFilter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbFilter.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbFilter.Location = new System.Drawing.Point(3, 12);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(504, 15);
            this.tbFilter.TabIndex = 0;
            this.tbFilter.TextChanged += new System.EventHandler(this.tbFilter_TextChanged);
            // 
            // taJunaci
            // 
            this.taJunaci.ClearBeforeFill = true;
            // 
            // bsIzdavaci
            // 
            this.bsIzdavaci.DataMember = "SIF_IZDAVACI";
            this.bsIzdavaci.DataSource = this.dsSklad;
            // 
            // taIzdavaci
            // 
            this.taIzdavaci.ClearBeforeFill = true;
            // 
            // FIzbor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 483);
            this.Controls.Add(this.panFilter);
            this.Controls.Add(this.panMain);
            this.Controls.Add(this.panBot);
            this.Controls.Add(this.panTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FIzbor";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Izbor";
            this.Load += new System.EventHandler(this.FIzbor_Load);
            this.Shown += new System.EventHandler(this.FIzbor_Shown);
            this.panTop.ResumeLayout(false);
            this.panBot.ResumeLayout(false);
            this.panMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridIzbor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsJunaci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSklad)).EndInit();
            this.panFilter.ResumeLayout(false);
            this.panFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsIzdavaci)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panTop;
        private System.Windows.Forms.Panel panBot;
        private System.Windows.Forms.Panel panMain;
        public System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Panel panFilter;
        public System.Windows.Forms.DataGridView gridIzbor;
        public System.Windows.Forms.TextBox tbFilter;
        private SKLADDataSet dsSklad;
        public System.Windows.Forms.BindingSource bsJunaci;
        private SKLADDataSetTableAdapters.SIF_JUNACITableAdapter taJunaci;
        public System.Windows.Forms.BindingSource bsIzdavaci;
        private SKLADDataSetTableAdapters.SIF_IZDAVACITableAdapter taIzdavaci;
        public System.Data.DataRowView selectedRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn sIFJUNAKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn junakDataGridViewTextBoxColumn;
        
    }
}