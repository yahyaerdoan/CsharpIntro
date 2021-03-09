using System;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Product erkekDeriCüzdan = new Product(15);
            erkekDeriCüzdan.ProductName = "Marka Erkek Deri Cüzdan";

            Product çokSatanKitap = new Product(15);
            çokSatanKitap.ProductName = "Çok Satan Kitap; Küçük Prenss";
            çokSatanKitap.StockControlEvent += ÇokSatanKitap_StockControlEvent; ;

            for (int i = 0; i < 3; i++)
            {
                çokSatanKitap.Sell(3);
                erkekDeriCüzdan.Sell(3);

                Console.ReadLine();
            }

            Console.ReadLine();
        }

        private static void ÇokSatanKitap_StockControlEvent()
        {
            Console.WriteLine("Çok Satan Kitap; Küçük Prenss Stok Adedi 10'dan azaldı. Tedarik Yapacak mısın?");
        }
    }
}
