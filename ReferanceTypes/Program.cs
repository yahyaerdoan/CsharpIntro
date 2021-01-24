using System;

namespace ReferanceTypes
{
    class Program
    {
        static void Main(string[] args)
        {                               // int, decimal , float, enum, bolean: Value types
            //int sayi1 = 10;    //Değer tipler aşağıdaki mantıkla çalışır.
            //int sayi2 = 20;
            //sayi1 = sayi2; // Sayı 1in adresi sayı 2nin adresidir. Sayı 1 sayı 2 ye dönüşür.
            //sayi2 = 100;
            //Console.WriteLine("Sayı 1'in değeri " + sayi1 +"'dir." + "\n"+"Sebebi ise sayı 2'nin adresinde ikamet ettiğindendir."); // Kutuya ilk giren son çıkar; son giren ilk çıkar mantığı işlemektedir.


            //// arrays, class, interface...:Reference types
            //int[] sayilar1 = new int[] { 1, 3, 5 };
            //int[] sayilar2 = new int[] { 2, 4, 6 };
            //sayilar1 = sayilar2;
            //sayilar2[0] = 1000;
            //Console.WriteLine(sayilar1[0]);



            Insan insan1 = new Insan();
            Insan insan2 = new Insan();
            insan1.FirstName = "Yahya";

            //insan2 = insan1;  // insan 2'nin referans numara adresi insan 1'e aktarılmış olur. Adresler aynı eşitlenmiş olur.
            //insan1.FirstName = "Engin";
            ////Console.WriteLine(insan2.FirstName);


            Musteri müşteri = new Musteri();
            müşteri.FirstName = "Salih";
            müşteri.CreditCardNumber = "1234567890";

            

            Hizmetli hizmetli = new Hizmetli();
            hizmetli.FirstName = "Veli";

            Insan insan3 = müşteri;
            müşteri.FirstName = "Ahmet";



            //Console.WriteLine(((Musteri)insan3).CreditCardNumber); // Boxs ataması yapılmış oluyor burada

            InsanManager insanManager = new InsanManager();
            insanManager.Ekle( insan1);


        }



    }


    class Insan  // Insan burada ana sınıf olduğu için diğer atamaları kabul eder.  Aynı kodu farklı nesneler için kullanabikme kolaylığı sağlar.
    {              // base class : temel sınıf
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Musteri : Insan
    {
        public string CreditCardNumber { get; set; }
    }
    class Hizmetli : Insan
    {
        public int EmployeeNumber { get; set; }

    }
    class InsanManager
    {
        public void Ekle (Insan insan) 
        {
            Console.WriteLine(insan.FirstName + insan.FirstName);
        }
            
    }

}
