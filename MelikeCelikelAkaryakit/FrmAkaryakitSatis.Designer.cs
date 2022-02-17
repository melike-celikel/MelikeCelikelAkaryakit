
namespace MelikeCelikelAkaryakit
{
    partial class FrmAkaryakitSatis
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtLitreFiyati = new System.Windows.Forms.TextBox();
            this.btnSat = new System.Windows.Forms.Button();
            this.lstSatislar = new System.Windows.Forms.ListBox();
            this.lblLitreFiyati = new System.Windows.Forms.Label();
            this.lblAkaryakitAdi = new System.Windows.Forms.Label();
            this.cmbAkaryakitAdi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlakaNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSatilanLitre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtToplamTutar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnYeni = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "TL";
            // 
            // txtLitreFiyati
            // 
            this.txtLitreFiyati.Location = new System.Drawing.Point(121, 97);
            this.txtLitreFiyati.Name = "txtLitreFiyati";
            this.txtLitreFiyati.ReadOnly = true;
            this.txtLitreFiyati.Size = new System.Drawing.Size(133, 20);
            this.txtLitreFiyati.TabIndex = 2;
            // 
            // btnSat
            // 
            this.btnSat.Location = new System.Drawing.Point(323, 61);
            this.btnSat.Name = "btnSat";
            this.btnSat.Size = new System.Drawing.Size(75, 34);
            this.btnSat.TabIndex = 7;
            this.btnSat.Text = "Sat";
            this.btnSat.UseVisualStyleBackColor = true;
            this.btnSat.Click += new System.EventHandler(this.btnSat_Click);
            // 
            // lstSatislar
            // 
            this.lstSatislar.FormattingEnabled = true;
            this.lstSatislar.Location = new System.Drawing.Point(26, 214);
            this.lstSatislar.Name = "lstSatislar";
            this.lstSatislar.Size = new System.Drawing.Size(253, 212);
            this.lstSatislar.TabIndex = 5;
            this.lstSatislar.SelectedIndexChanged += new System.EventHandler(this.lstSatislar_SelectedIndexChanged);
            // 
            // lblLitreFiyati
            // 
            this.lblLitreFiyati.AutoSize = true;
            this.lblLitreFiyati.Location = new System.Drawing.Point(25, 96);
            this.lblLitreFiyati.Name = "lblLitreFiyati";
            this.lblLitreFiyati.Size = new System.Drawing.Size(62, 15);
            this.lblLitreFiyati.TabIndex = 13;
            this.lblLitreFiyati.Text = "Litre Fiyatı";
            // 
            // lblAkaryakitAdi
            // 
            this.lblAkaryakitAdi.AutoSize = true;
            this.lblAkaryakitAdi.Location = new System.Drawing.Point(25, 61);
            this.lblAkaryakitAdi.Name = "lblAkaryakitAdi";
            this.lblAkaryakitAdi.Size = new System.Drawing.Size(75, 15);
            this.lblAkaryakitAdi.TabIndex = 11;
            this.lblAkaryakitAdi.Text = "Akaryakıt Adı";
            // 
            // cmbAkaryakitAdi
            // 
            this.cmbAkaryakitAdi.FormattingEnabled = true;
            this.cmbAkaryakitAdi.Location = new System.Drawing.Point(121, 61);
            this.cmbAkaryakitAdi.Name = "cmbAkaryakitAdi";
            this.cmbAkaryakitAdi.Size = new System.Drawing.Size(133, 21);
            this.cmbAkaryakitAdi.TabIndex = 1;
            this.cmbAkaryakitAdi.SelectedIndexChanged += new System.EventHandler(this.cmbAkaryakitAdi_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "PlakaNo";
            // 
            // txtPlakaNo
            // 
            this.txtPlakaNo.Location = new System.Drawing.Point(121, 26);
            this.txtPlakaNo.Name = "txtPlakaNo";
            this.txtPlakaNo.Size = new System.Drawing.Size(133, 20);
            this.txtPlakaNo.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Satılan Litre";
            // 
            // txtSatilanLitre
            // 
            this.txtSatilanLitre.Location = new System.Drawing.Point(121, 132);
            this.txtSatilanLitre.Name = "txtSatilanLitre";
            this.txtSatilanLitre.Size = new System.Drawing.Size(133, 20);
            this.txtSatilanLitre.TabIndex = 3;
            this.txtSatilanLitre.Leave += new System.EventHandler(this.txtSatilanLitre_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "Toplam Tutar";
            // 
            // txtToplamTutar
            // 
            this.txtToplamTutar.Location = new System.Drawing.Point(121, 167);
            this.txtToplamTutar.Name = "txtToplamTutar";
            this.txtToplamTutar.Size = new System.Drawing.Size(133, 20);
            this.txtToplamTutar.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(260, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 15);
            this.label5.TabIndex = 25;
            this.label5.Text = "TL";
            // 
            // btnYeni
            // 
            this.btnYeni.Location = new System.Drawing.Point(323, 18);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(75, 34);
            this.btnYeni.TabIndex = 6;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // FrmAkaryakitSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 457);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtToplamTutar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSatilanLitre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPlakaNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbAkaryakitAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLitreFiyati);
            this.Controls.Add(this.btnSat);
            this.Controls.Add(this.lstSatislar);
            this.Controls.Add(this.lblLitreFiyati);
            this.Controls.Add(this.lblAkaryakitAdi);
            this.Name = "FrmAkaryakitSatis";
            this.Text = "Akaryakıt Satış";
            this.Load += new System.EventHandler(this.FrmAkaryakitSatis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLitreFiyati;
        private System.Windows.Forms.Button btnSat;
        private System.Windows.Forms.ListBox lstSatislar;
        private System.Windows.Forms.Label lblLitreFiyati;
        private System.Windows.Forms.Label lblAkaryakitAdi;
        private System.Windows.Forms.ComboBox cmbAkaryakitAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPlakaNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSatilanLitre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtToplamTutar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnYeni;
    }
}