using System;

namespace ClassMetotDemo1
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
            musteri1.Meslek = "Psikolog";
            musteri1.Sehir = "Bursa";
            musteri1.Ulke = "Türkiye";
            musteri1.Cinsiyet = "Erkek";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 24;
            musteri2.Ad = "Ezgi";
            musteri2.Soyad = "PARLAK";
            musteri2.Yas = 26;
            musteri2.Meslek = "Mimar";
            musteri2.Sehir = "Bursa";
            musteri2.Ulke = "Türkiye";
            musteri2.Cinsiyet = "Erkek";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 25;
            musteri3.Ad = "Bayram";
            musteri3.Soyad = "MASUM";
            musteri3.Yas = 27;
            musteri3.Meslek = "Doktor";
            musteri3.Sehir = "İstanbul";
            musteri3.Ulke = "Türkiye";
            musteri3.Cinsiyet = "Erkek";
            
            Musteri musteri4 = new Musteri();
            musteri4.Id = 98;
            musteri4.Ad = "Kate";
            musteri4.Soyad = "KARL";
            musteri4.Yas = 26;
            musteri4.Meslek = "Muhasebeci";
            musteri4.Sehir = "Yalova";
            musteri4.Ulke = "Türkiye";
            musteri4.Cinsiyet = "Kadın"; 
            
            Musteri musteri5 = new Musteri();
            musteri5.Id = 275;
            musteri5.Ad = "Neriman";
            musteri5.Soyad = "MASUM";
            musteri5.Yas = 27;
            musteri5.Meslek = "Öğrenci";
            musteri5.Sehir = "Bayburt";
            musteri5.Ulke = "Türkiye";
            musteri5.Cinsiyet = "Kadın";

            Musteri musteri6 = new Musteri();
            musteri6.Id = 76;
            musteri6.Ad = "Jack";
            musteri6.Soyad = "MEL";
            musteri6.Yas = 33;
            musteri6.Meslek = "Doktor";
            musteri6.Sehir = "Chicago";
            musteri6.Ulke = "USD";
            musteri6.Cinsiyet = "Erkek"; 

            Musteri musteri7 = new Musteri();
            musteri7.Id = 25;
            musteri7.Ad = "Austen";
            musteri7.Soyad = "MARK";
            musteri7.Yas = 54;
            musteri7.Meslek = "Pilot";
            musteri7.Sehir = "İstanbul";
            musteri7.Ulke = "Türkiye";
            musteri7.Cinsiyet = "Erkek";
            
            

            


            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4, musteri5, musteri6, musteri7};
            foreach (Musteri musteri in musteriler)
            {
                //Console.WriteLine(musteri.Id);
                //Console.WriteLine(musteri.Ad);
                //Console.WriteLine(musteri.Soyad);
                //Console.WriteLine(musteri.Meslek);
                //Console.WriteLine(musteri.Yas);
                //Console.WriteLine(musteri.Sehir);
                //Console.WriteLine(musteri.Ulke);
                //Console.WriteLine("--------------------");

                ////Console.WriteLine(musteri.Ad + " " + musteri.Soyad);


            }

            MusteriManager musteriManager = new MusteriManager();
            
            Console.WriteLine("\n ----------Müşteri Ekleme-------------- -\n ");
            musteriManager.MusteriEkle(musteri1);
            Console.WriteLine("\n");
            musteriManager.MusteriEkle(musteri2);
            Console.WriteLine("\n");
            musteriManager.MusteriEkle(musteri3);
            Console.WriteLine("\n");
            musteriManager.MusteriEkle(musteri4); 
            Console.WriteLine("\n");
            musteriManager.MusteriEkle(musteri5); 
            Console.WriteLine("\n");
            musteriManager.MusteriEkle(musteri6); 
            Console.WriteLine("\n");
            musteriManager.MusteriEkle(musteri7);

            Console.WriteLine("\n ----------Müşteri Listeleme-------------- - \n ");
            musteriManager.MusteriListele(musteri1);
            Console.WriteLine("\n");
            musteriManager.MusteriListele(musteri2);
            Console.WriteLine("\n");
            musteriManager.MusteriListele(musteri3);
            Console.WriteLine("\n");
            musteriManager.MusteriListele(musteri4); 
            Console.WriteLine("\n");
            musteriManager.MusteriListele(musteri5); 
            Console.WriteLine("\n");
            musteriManager.MusteriListele(musteri6); 
            Console.WriteLine("\n");
            musteriManager.MusteriListele(musteri7);

            Console.WriteLine("\n ----------Müşteri Silme-------------- - \n ");
            musteriManager.MusteriSil(musteri1);
            Console.WriteLine("\n");
            musteriManager.MusteriSil(musteri2);
            Console.WriteLine("\n");
            musteriManager.MusteriSil(musteri3);
            Console.WriteLine("\n");
            musteriManager.MusteriSil(musteri4);
            Console.WriteLine("\n");
            musteriManager.MusteriSil(musteri5);
            Console.WriteLine("\n");
            musteriManager.MusteriSil(musteri6);
            Console.WriteLine("\n");
            musteriManager.MusteriSil(musteri7);








        }
    }
}
