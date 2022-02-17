
namespace MelikeCelikelAkaryakit
{
    partial class FrmAkaryakitTanimlama
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
            this.txtAkaryakitAdi = new System.Windows.Forms.TextBox();
            this.lblAkaryakitAdi = new System.Windows.Forms.Label();
            this.lblLitreFiyati = new System.Windows.Forms.Label();
            this.lstAkaryakitlar = new System.Windows.Forms.ListBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.txtLitreFiyati = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnYeni = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAkaryakitAdi
            // 
            this.txtAkaryakitAdi.Location = new System.Drawing.Point(108, 23);
            this.txtAkaryakitAdi.Name = "txtAkaryakitAdi";
            this.txtAkaryakitAdi.Size = new System.Drawing.Size(148, 20);
            this.txtAkaryakitAdi.TabIndex = 0;
            // 
            // lblAkaryakitAdi
            // 
            this.lblAkaryakitAdi.AutoSize = true;
            this.lblAkaryakitAdi.Location = new System.Drawing.Point(27, 23);
            this.lblAkaryakitAdi.Name = "lblAkaryakitAdi";
            this.lblAkaryakitAdi.Size = new System.Drawing.Size(75, 15);
            this.lblAkaryakitAdi.TabIndex = 1;
            this.lblAkaryakitAdi.Text = "Akaryakıt Adı";
            // 
            // lblLitreFiyati
            // 
            this.lblLitreFiyati.AutoSize = true;
            this.lblLitreFiyati.Location = new System.Drawing.Point(27, 49);
            this.lblLitreFiyati.Name = "lblLitreFiyati";
            this.lblLitreFiyati.Size = new System.Drawing.Size(62, 15);
            this.lblLitreFiyati.TabIndex = 2;
            this.lblLitreFiyati.Text = "Litre Fiyatı";
            // 
            // lstAkaryakitlar
            // 
            this.lstAkaryakitlar.FormattingEnabled = true;
            this.lstAkaryakitlar.Location = new System.Drawing.Point(30, 87);
            this.lstAkaryakitlar.Name = "lstAkaryakitlar";
            this.lstAkaryakitlar.Size = new System.Drawing.Size(253, 264);
            this.lstAkaryakitlar.TabIndex = 5;
            this.lstAkaryakitlar.SelectedIndexChanged += new System.EventHandler(this.lstAkaryakitlar_SelectedIndexChanged);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(299, 55);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 34);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnDegistir
            // 
            this.btnDegistir.Location = new System.Drawing.Point(299, 95);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(75, 34);
            this.btnDegistir.TabIndex = 3;
            this.btnDegistir.Text = "Değiştir";
            this.btnDegistir.UseVisualStyleBackColor = true;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // txtLitreFiyati
            // 
            this.txtLitreFiyati.Location = new System.Drawing.Point(108, 49);
            this.txtLitreFiyati.Name = "txtLitreFiyati";
            this.txtLitreFiyati.Size = new System.Drawing.Size(148, 20);
            this.txtLitreFiyati.TabIndex = 1;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(299, 135);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 34);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "TL";
            // 
            // btnYeni
            // 
            this.btnYeni.Location = new System.Drawing.Point(299, 15);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(75, 34);
            this.btnYeni.TabIndex = 9;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // FrmAkaryakitTanimlama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 377);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.txtLitreFiyati);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lstAkaryakitlar);
            this.Controls.Add(this.lblLitreFiyati);
            this.Controls.Add(this.lblAkaryakitAdi);
            this.Controls.Add(this.txtAkaryakitAdi);
            this.Name = "FrmAkaryakitTanimlama";
            this.Text = "Akaryakıt Tanımlama";
            this.Load += new System.EventHandler(this.FrmAkaryakitTanimlama_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAkaryakitAdi;
        private System.Windows.Forms.Label lblAkaryakitAdi;
        private System.Windows.Forms.Label lblLitreFiyati;
        private System.Windows.Forms.ListBox lstAkaryakitlar;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.TextBox txtLitreFiyati;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnYeni;
    }
}