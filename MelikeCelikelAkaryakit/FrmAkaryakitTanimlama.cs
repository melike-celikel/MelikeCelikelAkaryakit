using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MelikeCelikelAkaryakit
{
    public partial class FrmAkaryakitTanimlama : Form
    {
        public FrmAkaryakitTanimlama()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Akaryakıt bilgileri ekleniyor.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEkle_Click(object sender, EventArgs e)
        {
            int AkaryakitId;
            string AkaryakitAdi;
            double LitreFiyat;
            AkaryakitId = Veriler.sonAkaryakitId() + 1;

            AkaryakitAdi = txtAkaryakitAdi.Text;
            LitreFiyat = double.Parse(txtLitreFiyati.Text);

            Akaryakit akaryakit = new Akaryakit(AkaryakitId, AkaryakitAdi, LitreFiyat);

            lstAkaryakitlar.Items.Add(akaryakit);
            Veriler.akaryakitlar.Add(akaryakit);

        }

        private void FrmAkaryakitTanimlama_Load(object sender, EventArgs e)
        {
            foreach (Akaryakit a in Veriler.akaryakitlar)
            {
                lstAkaryakitlar.Items.Add(a);
            }
            
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if( lstAkaryakitlar.SelectedIndex!=-1)
            {
                Akaryakit akaryakit = (Akaryakit)lstAkaryakitlar.SelectedItem;

                lstAkaryakitlar.Items.RemoveAt(lstAkaryakitlar.SelectedIndex);
                Veriler.akaryakitlar.Remove(akaryakit);

            }
        }

        private void lstAkaryakitlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstAkaryakitlar.SelectedIndex != -1)
            {
                Akaryakit akaryakit = (Akaryakit)lstAkaryakitlar.SelectedItem;

                txtAkaryakitAdi.Text = akaryakit.AkaryakitAdi;
                txtLitreFiyati.Text = "" + akaryakit.LitreFiyat;
               

            }
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {

            if (lstAkaryakitlar.SelectedIndex != -1)
            {
                Akaryakit akaryakit = (Akaryakit)lstAkaryakitlar.SelectedItem;

                akaryakit.AkaryakitAdi = txtAkaryakitAdi.Text  ;
                akaryakit.LitreFiyat = double.Parse(txtLitreFiyati.Text);

                lstAkaryakitlar.Items[lstAkaryakitlar.SelectedIndex]= akaryakit;

                Veriler.akaryakitlar[lstAkaryakitlar.SelectedIndex] = akaryakit;
            }
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            txtAkaryakitAdi.Text = "";
            txtLitreFiyati.Text = "";
        }
    }
}
