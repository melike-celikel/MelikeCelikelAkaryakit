using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelikeCelikelAkaryakit
{

    /// <summary>
    /// Akaryakıtlar için bir akaryakıt sınıfı oluşturuldu.
    /// </summary>
    public class Akaryakit
    {
        public int AkaryakitId { get; set; }
        public string AkaryakitAdi { get; set; }

        public double  LitreFiyat { get; set; }

        public Akaryakit()
        {

        }
        /// <summary>
        /// Yapıcı metot tanımlandı.
        /// </summary>
        /// <param name="AkaryakitId"></param>
        /// <param name="AkaryakitAdi"></param>
        /// <param name="LitreFiyat"></param>
        public Akaryakit(int AkaryakitId, string AkaryakitAdi, double LitreFiyat)
        {
            this.AkaryakitId = AkaryakitId;
            this.AkaryakitAdi = AkaryakitAdi;
            this.LitreFiyat = LitreFiyat;
        }

        public override string ToString()
        {
            return AkaryakitAdi + " - " + LitreFiyat + " TL";
        }
    }
}
