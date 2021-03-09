using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 23;
            musteri1.Ad = "Yahya";
            musteri1.Soyad = "ERDOĞAN";
            musteri1.Yas = 25;
            musteri1.Meslek = "Öğretmen";
            musteri1.Sehir = "Bursa";
            musteri1.Ulke = "Türkiye";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 24;
            musteri2.Ad = "Kübra";
            musteri2.Soyad = "PARLAK";
            musteri2.Yas = 26;
            musteri2.Meslek = "Mimar";
            musteri2.Sehir = "Bursa";
            musteri2.Ulke = "Türkiye";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 25;
            musteri3.Ad = "Bayram";
            musteri3.Soyad = "MASUM";
            musteri3.Yas = 27;
            musteri3.Meslek = "Doktor";
            musteri3.Sehir = "İstanbul";
            musteri3.Ulke = "Türkiye";


            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Id);
                Console.WriteLine(musteri.Ad);
                Console.WriteLine(musteri.Soyad);
                Console.WriteLine(musteri.Meslek);
                Console.WriteLine(musteri.Yas);
                Console.WriteLine(musteri.Sehir);
                Console.WriteLine(musteri.Ulke);
                Console.WriteLine("--------------------");

                Console.WriteLine("Bankamıza Hoş Geldiniz: " + musteri.Ad + " " + musteri.Soyad);
                
            }
        }
    }
}
