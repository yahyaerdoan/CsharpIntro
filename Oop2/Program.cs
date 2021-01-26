using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "4567890123";
            musteri1.Adi = "Yahya";
            musteri1.Soyadi = "Erdoğan";                     
            musteri1.TcNo = "345678912";


            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "5678901234";

            GercekMusteri musteri3 = new GercekMusteri();
            musteri3.Id = 3;
            musteri3.MusteriNo = "4567876";
            musteri3.Adi = "Emine";
            musteri3.Soyadi = "Erdoğan";
            musteri3.TcNo = "45678987656";

            Musteri musteri4 = new GercekMusteri();
            Musteri musteri5 = new TuzelMusteri();
           


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
        }
    }
}
