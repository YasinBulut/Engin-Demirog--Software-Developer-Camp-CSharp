using System;

namespace Dögüler
{
    class Program
    {
        static void Main(string[] args)
        {
            //MANUEL
            //string kurs1 = "Yazılım Geliştirici Kampı";
            //string kurs2 = "C# Kampına Hazırlık Kursu";
            //string kurs3 = "Java Kursu";
            //string kurs4 = "Pyhton Kursu";
            //string kurs5 = "C++";

            //DİNAMİK YAZIM ŞEKLİ
            string[] kurslar = new string[] { "Yazılım Geliştirici Kampı", "C# Kampına Hazırlık Kursu", "Java Kursu", "Pyhton Kursu","C++" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("*****************");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }




            Console.WriteLine("****************");
            Console.WriteLine("SAYFA SONU");
        }
    }
}
