namespace StripFor
{
    partial class FormSif
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSif));
            this.panTop = new System.Windows.Forms.Panel();
            this.lblMain = new System.Windows.Forms.Label();
            this.panBot = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.panMain = new System.Windows.Forms.Panel();
            this.lblNaz = new System.Windows.Forms.Label();
            this.lblSif = new System.Windows.Forms.Label();
            this.tbNaz = new System.Windows.Forms.TextBox();
            this.tbSif = new System.Windows.Forms.TextBox();
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
            this.panTop.Size = new System.Drawing.Size(393, 48);
            this.panTop.TabIndex = 0;
            // 
            // lblMain
            // 
            this.lblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMain.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMain.ForeColor = System.Drawing.Color.DimGray;
            this.lblMain.Location = new System.Drawing.Point(0, 0);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(393, 48);
            this.lblMain.TabIndex = 0;
            this.lblMain.Text = "I Z D A V A Č I";
            this.lblMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panBot
            // 
            this.panBot.BackColor = System.Drawing.Color.Tan;
            this.panBot.Controls.Add(this.btnCancel);
            this.panBot.Controls.Add(this.btnOk);
            this.panBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panBot.Location = new System.Drawing.Point(0, 233);
            this.panBot.Name = "panBot";
            this.panBot.Size = new System.Drawing.Size(393, 48);
            this.panBot.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(142, 6);
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
            this.btnOk.Location = new System.Drawing.Point(33, 6);
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
            this.panMain.Controls.Add(this.lblNaz);
            this.panMain.Controls.Add(this.lblSif);
            this.panMain.Controls.Add(this.tbNaz);
            this.panMain.Controls.Add(this.tbSif);
            this.panMain.Location = new System.Drawing.Point(3, 51);
            this.panMain.Name = "panMain";
            this.panMain.Size = new System.Drawing.Size(387, 179);
            this.panMain.TabIndex = 2;
            // 
            // lblNaz
            // 
            this.lblNaz.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNaz.AutoSize = true;
            this.lblNaz.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaz.ForeColor = System.Drawing.Color.Black;
            this.lblNaz.Location = new System.Drawing.Point(173, 86);
            this.lblNaz.Name = "lblNaz";
            this.lblNaz.Size = new System.Drawing.Size(41, 14);
            this.lblNaz.TabIndex = 3;
            this.lblNaz.Text = "Naziv";
            // 
            // lblSif
            // 
            this.lblSif.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSif.AutoSize = true;
            this.lblSif.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSif.ForeColor = System.Drawing.Color.Black;
            this.lblSif.Location = new System.Drawing.Point(176, 35);
            this.lblSif.Name = "lblSif";
            this.lblSif.Size = new System.Drawing.Size(35, 14);
            this.lblSif.TabIndex = 2;
            this.lblSif.Text = "Šifra";
            // 
            // tbNaz
            // 
            this.tbNaz.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNaz.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbNaz.Location = new System.Drawing.Point(44, 105);
            this.tbNaz.Name = "tbNaz";
            this.tbNaz.Size = new System.Drawing.Size(298, 22);
            this.tbNaz.TabIndex = 1;
            // 
            // tbSif
            // 
            this.tbSif.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbSif.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbSif.Location = new System.Drawing.Point(44, 51);
            this.tbSif.Name = "tbSif";
            this.tbSif.Size = new System.Drawing.Size(298, 22);
            this.tbSif.TabIndex = 0;
            // 
            // FormSif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(393, 281);
            this.Controls.Add(this.panMain);
            this.Controls.Add(this.panBot);
            this.Controls.Add(this.panTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSif";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Šifarnik";
            this.Shown += new System.EventHandler(this.FUnos_Shown);
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
        public System.Windows.Forms.Label lblNaz;
        public System.Windows.Forms.Label lblSif;
        public System.Windows.Forms.TextBox tbNaz;
        public System.Windows.Forms.TextBox tbSif;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
    }
}