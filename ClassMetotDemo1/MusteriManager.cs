using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo1
{
    class MusteriManager
    {
        public void MusteriEkle (Musteri musteri) 
        {

            Console.WriteLine("Bankamıza Hoş Geldiniz Sayın: " + " " + musteri.Ad + " " + musteri.Soyad );


        }

        public void MusteriListele (Musteri musteri) 
        {

            Console.WriteLine("Müşteri Listesi ve Bilgileri Listelendi:  " + "\n Müşterinin Adı: " + musteri.Ad + "\n Müşterinin Soyadı: " + musteri.Soyad + "\n Müşterinin Yaşı:  " + musteri.Yas + "\n Müşterinin Cinsiyeti: " + musteri.Cinsiyet + "\n Müşterinin Mesleği:  " + musteri.Meslek + "\n Müşterinin Şehri:  " + musteri.Sehir + "\n Müşterinin ülkesi:  " + musteri.Ulke + "\n Müşterinin Id'si: " + musteri.Id);
        
        }

        public void MusteriSil(Musteri musteri) 
        {
            Console.WriteLine("Güle güle Sayın" + " " + musteri.Ad + " " + musteri.Soyad + " kaydınız silindi");

        }


    }
}
