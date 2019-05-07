namespace StripFor
{
    partial class FormReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Report1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.NASLOVIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SKLADDataSet = new StripFor.SKLADDataSet();
            this.NASLOVITableAdapter = new StripFor.SKLADDataSetTableAdapters.NASLOVITableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.NASLOVIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SKLADDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Report1
            // 
            this.Report1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.NASLOVIBindingSource;
            this.Report1.LocalReport.DataSources.Add(reportDataSource1);
            this.Report1.LocalReport.ReportEmbeddedResource = "StripFor.RepNaslovi.rdlc";
            this.Report1.Location = new System.Drawing.Point(0, 0);
            this.Report1.Name = "Report1";
            this.Report1.Size = new System.Drawing.Size(735, 482);
            this.Report1.TabIndex = 0;
            // 
            // NASLOVIBindingSource
            // 
            this.NASLOVIBindingSource.DataMember = "NASLOVI";
            this.NASLOVIBindingSource.DataSource = this.SKLADDataSet;
            // 
            // SKLADDataSet
            // 
            this.SKLADDataSet.DataSetName = "SKLADDataSet";
            this.SKLADDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // NASLOVITableAdapter
            // 
            this.NASLOVITableAdapter.ClearBeforeFill = true;
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 482);
            this.Controls.Add(this.Report1);
            this.Name = "FormReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormReport";
            this.Load += new System.EventHandler(this.FormReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NASLOVIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SKLADDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource NASLOVIBindingSource;
        private SKLADDataSet SKLADDataSet;
        private SKLADDataSetTableAdapters.NASLOVITableAdapter NASLOVITableAdapter;
        public Microsoft.Reporting.WinForms.ReportViewer Report1;
    }
}