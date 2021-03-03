using System;

namespace Konu_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string KategoriEtiketleri = "Kategori";
            int ogrencisayisi =32000;
            double faizorani = 1.45;
            bool sistemegiris = true;

            if (sistemegiris == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }
            Console.WriteLine(KategoriEtiketleri);
            Console.WriteLine(ogrencisayisi);
        }
    }
}
