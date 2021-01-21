using System;

namespace YeniClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri = new Musteri();
            musteri.Id = 23;
            musteri.Ad = "Yahya";
            musteri.Soyad = "ERDOĞAN";
            musteri.Yas = 25;
            musteri.Meslek = "Öğretmen";
            musteri.Sehir = "Bursa";
            musteri.Ulke = "Türkiye";

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


            Musteri[] musteriler = new Musteri[] { musteri, musteri2, musteri3 };
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Id);
                Console.WriteLine(musteri.Ad);
                Console.WriteLine(musteri.Soyad);
                Console.WriteLine(musteri.Meslek);
                Console.WriteLine("--------------------");

            }










            Console.WriteLine("Hello World!");
        }
    }
}
