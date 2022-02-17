using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MelikeCelikelAkaryakit
{
    public partial class FrmAnaProgram : Form
    {
        public FrmAnaProgram()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Giriş formundaki çıkış işlemi için tanımlandı.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cikisToolStripMenuItem_Click(object sender, EventArgs e) //Cıkma işlemi
        {
            this.Close();      
        }
        /// <summary>
        /// Akaryakıt tanımlamak için tanımlandı.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void akaryakitTanimlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAkaryakitTanimlama frm = new FrmAkaryakitTanimlama();

            frm.MdiParent = this; //ana form belirtme.

            frm.Visible = true;//görünür yapıldı
        }
        /// <summary>
        /// Akaryakıt satışı için tanımlandı.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void akaryakitSatisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAkaryakitSatis frm = new FrmAkaryakitSatis();

            frm.MdiParent = this;//ana form belirtme

            frm.Visible = true;//görünür yapıldı
        }
        /// <summary>
        /// Bilgilendirme için oluşturuldu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hakkindaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHakkinda frm = new FrmHakkinda();

         
            frm.ShowDialog();

            
        }

        private void FrmAnaProgram_Load(object sender, EventArgs e)
        {
            Veriler.akaryakitlar.Add(new Akaryakit { AkaryakitId = 1, AkaryakitAdi = "Benzin", LitreFiyat = 10 });
            Veriler.akaryakitlar.Add(new Akaryakit { AkaryakitId = 2, AkaryakitAdi = "Motorin", LitreFiyat = 9 });
        }

        /// <summary>
        /// Satış ve tanımlama verilerini json formatında kaydettirme.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void jSONFileKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dosyayaKaydet();
        }

        /// <summary>
        /// Verileri jason formatında dosyaya yazdırma işlemi.
        /// </summary>
        public  void dosyayaKaydet()
        {
            string json = "{\n";
            string jsonakaryakit;
            string jsonsatis;
            string dosyaadi;
            saveFileDialog1.ShowDialog();
            dosyaadi = saveFileDialog1.FileName;
            if( dosyaadi!=null && !dosyaadi.Equals(""))
            {
                using (StreamWriter wr = new StreamWriter(dosyaadi))
                {

                    json = json + "\"akaryakitlar\":[\n";
                    foreach (Akaryakit a in Veriler.akaryakitlar)
                    {
                        jsonakaryakit = "  {\n";
                        jsonakaryakit = jsonakaryakit + "   \"AkaryakitId\":" + a.AkaryakitId + ",\n";
                        jsonakaryakit = jsonakaryakit + "   \"akaryakıtAdı\":" + "\"" + a.AkaryakitAdi + "\",\n";
                        jsonakaryakit = jsonakaryakit + "   \"LitreFiyat\":" + a.LitreFiyat + "\n";

                        jsonakaryakit = jsonakaryakit + "  },\n";
                        json = json + jsonakaryakit;
                    }

                    json = json.Remove(json.LastIndexOf(","), 1);
                    json = json + "],\n";

                    json = json + "\"satislar\":[\n";
                    foreach (AkaryakitSatis satis in Veriler.satislar)
                    {
                        jsonsatis = "  {\n";
                        jsonsatis = jsonsatis + "   \"AkaryakitSatisId\":" +  satis.AkaryakitSatisId + ",\n";
                        jsonsatis = jsonsatis + "   \"PlakaNo\":" + "\"" + satis.PlakaNo + "\",\n";
                        jsonsatis = jsonsatis + "   \"AkaryakitId\":" +  satis.AkaryakitId + ",\n";
                        jsonsatis = jsonsatis + "   \"AkaryakitAdi\":" + "\"" + satis.AkaryakitAdi + "\",\n";
                        jsonsatis = jsonsatis + "   \"LitreFiyat\":" +  satis.LitreFiyat + ",\n";
                        jsonsatis = jsonsatis + "   \"SatilanLitre\":" + satis.SatilanLitre + "\n";

                        jsonsatis = jsonsatis + "  },\n";

                        json = json + jsonsatis;


                    }
                    json = json.Remove(json.LastIndexOf(","), 1);
                    json = json + "\n]\n";

                    json = json + "}";

                   
                    wr.WriteLine(json);
                }
            }
            

        }



    }
}
