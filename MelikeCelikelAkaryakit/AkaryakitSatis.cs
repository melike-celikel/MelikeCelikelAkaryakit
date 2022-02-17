using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelikeCelikelAkaryakit
{
    /// <summary>
    /// Akaryakıt satış işlemi için sınıf oluşturuldu.
    /// </summary>
    public class AkaryakitSatis 
    {

        public int AkaryakitSatisId { get; set; }

        public string PlakaNo { get; set; }

        public int AkaryakitId { get; set; }

        public string AkaryakitAdi { get; set; }

        public double LitreFiyat { get; set; }

        public double SatilanLitre { get; set; }

        public override string ToString()
        {
            return PlakaNo + " | "+ AkaryakitAdi + " | Fiyat: " + LitreFiyat + " | Litre: " + SatilanLitre;
        }

    }
}
