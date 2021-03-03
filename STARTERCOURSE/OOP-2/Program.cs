using System;

namespace OOP_2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.ID = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Yasin";
            musteri1.Soyadi = "Bulut";
            musteri1.TcNo = "1111111111";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.ID = 2;
            musteri2.MusteriNo = "12346";
            musteri2.SirketAdi = "Bulut Holding";
            musteri2.VergiNo = "1098";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Ekle(musteri1);
            customerManager.Ekle(musteri2);

        }
    }
}
