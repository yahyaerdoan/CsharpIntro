using System;

namespace Delegates
{
    public delegate void MyDelagate(); //Elçilik
    public delegate void MyDelagateParametreli(string parametreli); //Elçilik parametreli voidli delaget oluşturduk
    public delegate int MyDelegateDeğerTip(int sayi1, int sayi2);
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            //customerManager.MesajGönder();
            //customerManager.Uyarı();

            MyDelagate myDelagate = customerManager.MesajGönder; //Elçi
            myDelagate += customerManager.Uyarı; // + işlemi döndürür. Yapacağımız işlemleri arka arkaya toplayıp işlemi çağırıyoruz.
            myDelagate -= customerManager.Uyarı; // - işlemi geri alır. İletiyi geri çeker.
            myDelagate();

            //Parametreli Delegate

            MyDelagateParametreli myDelagateParametreli = customerManager.MesajGönderParametreli;
            myDelagateParametreli("Mesaj Parametreli Delegate oluşturduk");
            //myDelagateParametreli += customerManager.UyarıParametreli;
            myDelagateParametreli("Uyarı Parametreli Delegate oluşturduk");


            //Matematik matematik = new Matematik();
            //MyDelegateDeğerTip myDelegateDeğerTip = matematik.Topla;
            //var toplasonuc = myDelegateDeğerTip(5, 6);
            //myDelegateDeğerTip = matematik.Carp;
            //var carpsonuc = myDelegateDeğerTip(5, 6);
            //Console.WriteLine(toplasonuc);
            //Console.WriteLine(carpsonuc);


            Matematik matematik = new Matematik();
            MyDelegateDeğerTip myDelegateDeğerTip = matematik.Carp;
            myDelegateDeğerTip += matematik.Topla;
            var carpsonuc = myDelegateDeğerTip(5, 6);
            Console.WriteLine(carpsonuc);
            Console.ReadLine();
        }
    }
    public class CustomerManager
    {
        public void MesajGönder()
        {
            Console.WriteLine("Azemetlu Hünkarımız Kanuni Sultan Süleyman'ın buyruğudur!");
        }

        public void Uyarı()
        {
            Console.WriteLine("Adaleti titizlikle hükmetmeyen kadılarımızın, hükümlerinde adaletle hükmetmeleri hususunda uyarıdır!");
        }

        public void MesajGönderParametreli(string mesaj)
        {
            Console.WriteLine(mesaj);
        }

        public void UyarıParametreli(string uyarı)
        {
            Console.WriteLine(uyarı);
        }        
    }
    public class Matematik
    {
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
    }
}
