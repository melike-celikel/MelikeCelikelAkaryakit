using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MelikeCelikelAkaryakit
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana giriş noktasıdır.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles(); //Görsel stilleri etkinleştirir.
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmAnaProgram());
        }
    }
}
