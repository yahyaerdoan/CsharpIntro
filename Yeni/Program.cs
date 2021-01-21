using System;

namespace Yeni
{
    class Program
    {
        static void Main(string[] args)
        {

            Urun urun1 = new Urun();
            urun1.UrunAdi = "Şeker Portakalı";
            urun1.UrunTuru = "Edebiyat-Roman";
            urun1.UrunYazari = "Jose Mauro De Vasconcelos";
            urun1.UrunOzet = "Ne güzel bir şeker portakalı fidanıymış bu! Hem bak, dikeni de yok. Pek de kişilik sahibiymiş, şeker portakalı olduğu ta uzaktan belli. Ben senin boyunda olsaydım başka şey istemezdim.";
            urun1.UrunYayinEvi = "Can Yayınları";
            urun1.UrunKapakTasarim = "Utku Lomlu";
            urun1.UrunCevirmen = "Emrah İmre";
            urun1.UrunCiltTipi = "Karton Kapak";
            urun1.UrunYayinTarihi = "06.09.2019";
            urun1.UrunDili = "Türkçe";
            urun1.UrunSayfaSayisi = 182;
            urun1.UrunFiyat = 16;
            urun1.UrunEtiketFiyati = 20.98;
            

            Urun urun2 = new Urun();
            urun2.UrunAdi = "Elma Portakalı";
            urun2.UrunTuru = "Edebiyat-Atma Tutma";
            {
           


            }
            Urun[] urunler = new Urun[] { urun1};
            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.UrunAdi + " : " + urun.UrunTuru + " : " + urun.UrunYazari + " : " + urun.UrunOzet + " : " + urun.UrunYayinEvi + " : " +
                urun.UrunKapakTasarim + " : " + urun.UrunCevirmen + " : " + urun.UrunCiltTipi + " : " + urun.UrunYayinTarihi + " : " + urun.UrunDili + " : " +
                urun.UrunSayfaSayisi + " : " + urun.UrunFiyat + " : " + urun.UrunEtiketFiyati);
               
                Console.WriteLine("......FOREACH DÖNGÜSÜ BİTTİ........");

            }


            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].UrunAdi + " : " + urunler[i].UrunDili + ":" + urunler[i].UrunCevirmen);
            }
            Console.WriteLine("............ FOR BİTTi........");

            int a = 0;
            while (a< urunler.Length)
            {
                Console.WriteLine(urunler[a].UrunAdi + " : " + urunler[a].UrunYayinEvi); a++;
             
            }

            Console.WriteLine("..........WHİLE DÖNGÜSÜ BİTTİ.......");
             

            // Bu yapılardan en kolay ve mantıklı olanı Foreach döngüsü bence :)

            {

                Console.WriteLine("Yazdırmayı Başarıyorum!");

            }
            
        }
    }
    class Urun
    {

        public string UrunAdi { get; set; }
        public string UrunTuru { get; set; }
        public string UrunYazari { get; set; }
        public string UrunYayinEvi { get; set; }
        public string UrunKapakTasarim { get; set; }
        public string UrunOzet { get; set; }
        public string UrunCevirmen { get; set; }
        public string UrunYayinTarihi { get; set; }
        public string UrunDili { get; set; }
        public int UrunSayfaSayisi { get; set; }
        public string UrunCiltTipi { get; set; }
        public int UrunFiyat { get; set; }
        public double UrunEtiketFiyati { get; set; }
        }
}
