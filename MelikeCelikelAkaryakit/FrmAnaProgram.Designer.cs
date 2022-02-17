
namespace MelikeCelikelAkaryakit
{
    partial class FrmAnaProgram
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jSONFileKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cikisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.akaryakitIslemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.akaryakitTanimlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.akaryakitSatisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkindaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.melikeÇelikelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.akaryakitIslemleriToolStripMenuItem,
            this.hakkindaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1159, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jSONFileKaydetToolStripMenuItem,
            this.cikisToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // jSONFileKaydetToolStripMenuItem
            // 
            this.jSONFileKaydetToolStripMenuItem.Name = "jSONFileKaydetToolStripMenuItem";
            this.jSONFileKaydetToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.jSONFileKaydetToolStripMenuItem.Text = "JSON File Kaydet";
            this.jSONFileKaydetToolStripMenuItem.Click += new System.EventHandler(this.jSONFileKaydetToolStripMenuItem_Click);
            // 
            // cikisToolStripMenuItem
            // 
            this.cikisToolStripMenuItem.Name = "cikisToolStripMenuItem";
            this.cikisToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.cikisToolStripMenuItem.Text = "Çıkış";
            this.cikisToolStripMenuItem.Click += new System.EventHandler(this.cikisToolStripMenuItem_Click);
            // 
            // akaryakitIslemleriToolStripMenuItem
            // 
            this.akaryakitIslemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.akaryakitTanimlamaToolStripMenuItem,
            this.akaryakitSatisToolStripMenuItem});
            this.akaryakitIslemleriToolStripMenuItem.Name = "akaryakitIslemleriToolStripMenuItem";
            this.akaryakitIslemleriToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.akaryakitIslemleriToolStripMenuItem.Text = "Akaryakıt İşlemleri";
            // 
            // akaryakitTanimlamaToolStripMenuItem
            // 
            this.akaryakitTanimlamaToolStripMenuItem.Name = "akaryakitTanimlamaToolStripMenuItem";
            this.akaryakitTanimlamaToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.akaryakitTanimlamaToolStripMenuItem.Text = "Akaryakıt Tanımlama";
            this.akaryakitTanimlamaToolStripMenuItem.Click += new System.EventHandler(this.akaryakitTanimlamaToolStripMenuItem_Click);
            // 
            // akaryakitSatisToolStripMenuItem
            // 
            this.akaryakitSatisToolStripMenuItem.Name = "akaryakitSatisToolStripMenuItem";
            this.akaryakitSatisToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.akaryakitSatisToolStripMenuItem.Text = "Akaryakıt Satış";
            this.akaryakitSatisToolStripMenuItem.Click += new System.EventHandler(this.akaryakitSatisToolStripMenuItem_Click);
            // 
            // hakkindaToolStripMenuItem
            // 
            this.hakkindaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.melikeÇelikelToolStripMenuItem});
            this.hakkindaToolStripMenuItem.Name = "hakkindaToolStripMenuItem";
            this.hakkindaToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.hakkindaToolStripMenuItem.Text = "Hakkında";
            this.hakkindaToolStripMenuItem.Click += new System.EventHandler(this.hakkindaToolStripMenuItem_Click);
            // 
            // melikeÇelikelToolStripMenuItem
            // 
            this.melikeÇelikelToolStripMenuItem.Name = "melikeÇelikelToolStripMenuItem";
            this.melikeÇelikelToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.melikeÇelikelToolStripMenuItem.Text = "Melike Çelikel";
            // 
            // FrmAnaProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 587);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAnaProgram";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmAnaProgram_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cikisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem akaryakitIslemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem akaryakitTanimlamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem akaryakitSatisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkindaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jSONFileKaydetToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem melikeÇelikelToolStripMenuItem;
    }
}

