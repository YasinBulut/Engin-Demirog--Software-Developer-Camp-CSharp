using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Eğitmen = "Yasin Bulut";
            kurs1.İzlenmeOranı = 15000;
            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "JAVA";
            kurs2.Eğitmen = "MURAT YÜCEDAĞ";
            kurs2.İzlenmeOranı = 345;
            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "PYHTON";
            kurs3.Eğitmen = "ENGİN DEMİROĞ";
            kurs3.İzlenmeOranı = 2500;
            Console.WriteLine(kurs1.KursAdi + " " + kurs1.Eğitmen + " " + kurs1.İzlenmeOranı);
            Console.WriteLine(kurs2.KursAdi + " " + kurs2.Eğitmen + " " + kurs2.İzlenmeOranı);
            Console.WriteLine(kurs3.KursAdi + " " + kurs3.Eğitmen + " " + kurs3.İzlenmeOranı);
            Console.WriteLine("********************************");

            Kurs[] kurslar = new Kurs[] { kurs1,kurs2,kurs3};
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi+" "+kurs.Eğitmen+" "+kurs.İzlenmeOranı );
            }
            
        }
    }
}

class Kurs
{
    public string KursAdi { get; set; }
    public string Eğitmen { get; set; }
    public int İzlenmeOranı { get; set; }
}