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
    public partial class FrmAkaryakitSatis : Form
    {
        public FrmAkaryakitSatis()
        {
            InitializeComponent();
        }

        private void FrmAkaryakitSatis_Load(object sender, EventArgs e)
        {
            AkaryakitlariYukle();
            SatislariYukle();
        }

        private void AkaryakitlariYukle()
        {
            foreach(Akaryakit a in Veriler.akaryakitlar)
            {
                cmbAkaryakitAdi.Items.Add(a);
            }


        }

        
        private void AkaryakitSec(Akaryakit a) 
        {
            Akaryakit akaryakit;
            for(int i=0; i< cmbAkaryakitAdi.Items.Count; i++)
            {

                akaryakit = (Akaryakit)cmbAkaryakitAdi.Items[i];
                if( a.AkaryakitId == akaryakit.AkaryakitId)
                {
                    cmbAkaryakitAdi.SelectedIndex = i;
                    return;
                }
            }

        }
        private void AkaryakitSec(int AkaryakitId)
        {
            Akaryakit akaryakit;
            for (int i = 0; i < cmbAkaryakitAdi.Items.Count; i++)
            {

                akaryakit = (Akaryakit)cmbAkaryakitAdi.Items[i];
                if (AkaryakitId == akaryakit.AkaryakitId)
                {
                    cmbAkaryakitAdi.SelectedIndex = i;
                    return;
                }
            }

        }

        private void SatislariYukle()
        {
            foreach (AkaryakitSatis satis in Veriler.satislar)
            {
                lstSatislar.Items.Add(satis);
            }


        }

        private void lstSatislar_SelectedIndexChanged(object sender, EventArgs e)
        {

            if( lstSatislar.SelectedIndex!=-1)
            {
                AkaryakitSatis akaryakitsatis = (AkaryakitSatis)lstSatislar.Items[lstSatislar.SelectedIndex];
                AkaryakitSec(akaryakitsatis.AkaryakitId);

                txtPlakaNo.Text = akaryakitsatis.PlakaNo;
                txtLitreFiyati.Text = akaryakitsatis.LitreFiyat.ToString();
                txtSatilanLitre.Text = akaryakitsatis.SatilanLitre.ToString();
                txtToplamTutar.Text = (akaryakitsatis.LitreFiyat * akaryakitsatis.SatilanLitre).ToString();


            }

        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            txtPlakaNo.Text = "";
            txtLitreFiyati.Text = "";
            cmbAkaryakitAdi.SelectedIndex = 0;
            if( cmbAkaryakitAdi.Items.Count>0)
            {
                Akaryakit akaryakit = (Akaryakit)cmbAkaryakitAdi.SelectedItem;
                txtLitreFiyati.Text = akaryakit.LitreFiyat.ToString();
            }

            txtSatilanLitre.Text = "";
            txtToplamTutar.Text = "";

        }

        private void btnSat_Click(object sender, EventArgs e)
        {
            AkaryakitSatis satis = new AkaryakitSatis();

            Akaryakit akaryakit = (Akaryakit)cmbAkaryakitAdi.SelectedItem;

            satis.AkaryakitSatisId = Veriler.sonSatisId() + 1;
            satis.PlakaNo = txtPlakaNo.Text;
            satis.AkaryakitId = akaryakit.AkaryakitId;
            satis.AkaryakitAdi = akaryakit.AkaryakitAdi;
            satis.LitreFiyat = akaryakit.LitreFiyat;
            satis.SatilanLitre = double.Parse(txtSatilanLitre.Text);

            lstSatislar.Items.Add(satis);
            Veriler.satislar.Add(satis);
        }

        private void cmbAkaryakitAdi_SelectedIndexChanged(object sender, EventArgs e)
        {

            if( cmbAkaryakitAdi.SelectedIndex!=-1)
            {
                Akaryakit akaryakit = (Akaryakit)cmbAkaryakitAdi.SelectedItem;
                txtLitreFiyati.Text = akaryakit.LitreFiyat.ToString();


                if( txtSatilanLitre.Text.Trim()!="" && txtLitreFiyati.Text.Trim()!="")
                {
                    toplamtutarhesapla();
                }

            }
        }

        private void txtSatilanLitre_Leave(object sender, EventArgs e)
        {
            if (txtSatilanLitre.Text.Trim() != "" && txtLitreFiyati.Text.Trim() != "")
            {
                toplamtutarhesapla();
            }
        }

        private void toplamtutarhesapla()
        {
            double litrefiyat = double.Parse(txtLitreFiyati.Text);
            double satilanlitre = double.Parse(txtSatilanLitre.Text);

            txtToplamTutar.Text = (litrefiyat * satilanlitre).ToString();
        }
    }
}
