 using System;

namespace Kamptintro
{
    class Program
    {
        static void Main(string[] args)
        {       //type safety - tip güvenliği(veri türünü belirtmektir.)

            //Do not repeat yourself - Kendini tekrar etme!

            // Değer tutucu, alias
            string kategoriEtiketi = "Kategoriler Sınıfı";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;

            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.87;
            double dolarBugun = 7.87;
            if (dolarBugun>dolarDun)
            {
                Console.WriteLine("Artış Oku");
            }
            else if (dolarBugun<dolarDun)
            {
                Console.WriteLine("Azalış Oku");
            }
            else
            {
                Console.WriteLine("Değişmedi Oku");

            }
            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }
            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(kategoriEtiketi);

        }
    }
}
