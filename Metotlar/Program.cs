using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            string urunAdi = "Elma";
            double fiyati = 12;
            string aciklama = "Amasya Elması";

            string[] meyveler = new string[] { };

            Product urun1 = new Product();
            urun1.Adi = "Elma";
            urun1.Fiyati = 12;
            urun1.Aciklama = "Amasya Elması";

            Product urun2 = new Product();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 62;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Product[] products = new Product[] {urun1,urun2 };
            // typr safe -- tip güvenliği (Abi bana ne yazacağımı söyle)

            foreach (Product product in products)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine("---------------");

                //İnstance -- Örnek


            }

            Console.WriteLine("----------Metotlar-------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil Armut", 12, 2);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 13, 6);
            sepetManager.Ekle2("Karpuz", "Sulu Kaepuz", 15, 4);

                  
            Console.WriteLine("Yazdırmayı Bşarıyorum");
        
            


        
        
        }
    }
}

// Do not repeat yourself -DRY Kendini tekrar etme.  Clean kod -best practice Doğru uygulama teknikleri
