using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler Sepete Eklendi :"+urun.UrunAd);
        }

        public void Ekle2(string UrunAd, string UrunAciklama, double UrunFıyat, int StokAdedi )
        {
            Console.WriteLine("Tebrikler Sepete Eklendi :" + UrunAd);
        }
    }
}
