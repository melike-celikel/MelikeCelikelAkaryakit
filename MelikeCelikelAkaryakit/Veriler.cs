using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelikeCelikelAkaryakit
{
    public static class Veriler 
    {
        public static List<Akaryakit> akaryakitlar=new List<Akaryakit>(); //Akaryakıtları tutacak bir list tanımlandı.
        public static List<AkaryakitSatis> satislar= new List<AkaryakitSatis>();//Satışlar için bir list tanımlandı.

        /// <summary>
        /// En sonki akaryakıtı bulma işlemi için tanımlandı.
        /// </summary>
        /// <returns></returns>
        public static int sonAkaryakitId()
        {
            int enbuyukid = 0;
            if ( akaryakitlar.Count>0)
            {
                enbuyukid = akaryakitlar[0].AkaryakitId;
                foreach (Akaryakit a in akaryakitlar)
                {
                    if (a.AkaryakitId > enbuyukid)
                    {
                        enbuyukid = a.AkaryakitId;
                    }

                }
            }
            

            return enbuyukid;


        }
        /// <summary>
        /// En sonki satış işlemini bulmak için tanımlandı.
        /// </summary>
        /// <returns></returns>
        public static int sonSatisId()
        {
            int enbuyukid = 0;
            if (satislar.Count > 0)
            {
                enbuyukid = satislar[0].AkaryakitSatisId;
                foreach (AkaryakitSatis a in satislar)
                {
                    if (a.AkaryakitSatisId > enbuyukid)
                    {
                        enbuyukid = a.AkaryakitSatisId;
                    }

                }
            }


            return enbuyukid;


        }

    }
}
