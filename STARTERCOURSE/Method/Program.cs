using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] meyveler = new string[] { };
            Urun urun1 = new Urun();
            urun1.UrunID = 1;
            urun1.UrunAd = "Elma";
            urun1.UrunFıyat = 15;
            urun1.UrunAciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.UrunID = 2;
            urun2.UrunAd = "Karpuz";
            urun2.UrunFıyat = 35;
            urun2.UrunAciklama = "Diyarbakır Karpuzu";
            //Console.WriteLine(urun1.UrunID+" "+urun1.UrunAd+" "+urun1.UrunFıyat+" "+urun1.UrunAciklama);
            //Console.WriteLine(urun2.UrunID + " " + urun2.UrunAd + " " + urun2.UrunFıyat + " " + urun2.UrunAciklama);
            Urun[] urunler = new Urun[] {urun1,urun2 };
            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.UrunAd);
                Console.WriteLine(urun.UrunAciklama);
                Console.WriteLine(urun.UrunFıyat);
                Console.WriteLine("**********");
            }
            Console.WriteLine("---------------METODLAR------------------");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            Console.WriteLine("**************");
            sepetManager.Ekle2("Elma","Yeşil Elma",15,12);
            sepetManager.Ekle2("Armut", "Yeşil Armut", 15,8);
        }
    }
}
