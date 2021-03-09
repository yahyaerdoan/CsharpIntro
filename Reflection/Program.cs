using System;
using System.Reflection;

namespace Reflection
{
    public class Program
    {
        static void Main(string[] args)
        {
            //DortIslem dortIslem = new DortIslem(2, 3);
            //Console.WriteLine(dortIslem.Topla2());
            //Console.WriteLine(dortIslem.Topla(4,4));

            var type = typeof(DortIslem);
            //DortIslem dortIslem = (DortIslem)Activator.CreateInstance(type, 10, 5); // new'lwmimize gerek kalmiycak. Neyin instanceni oluşurmak istiyorsak odur. Onun tipi
            //Console.WriteLine(dortIslem.Topla(5,3));                                                               //Activator.CreateInstance obje döndürür.
            //Console.WriteLine(dortIslem.Topla2());                                                               //Activator.CreateInstance obje döndürür.

            var instance = Activator.CreateInstance(type, 5, 5);
            Console.WriteLine(instance.GetType().GetMethod("Topla2").Invoke(instance, null));  // GetMethod ile mmetoda ulaşıp Invoke ile metodu çalıştırabiliyoruz.

            MethodInfo methodInfo = instance.GetType().GetMethod("Topla2"); // Soldaki reflection Metodu, Yukarıda yazdığımız reflection metodunun daha profosyonel metodudur.
            Console.WriteLine(methodInfo.Invoke(instance,null)); // Paraqntez içinde Hangi örneğin instance çalışacağı bilgisini vermiş olduk. 

            Console.WriteLine("---------");

            var methods = type.GetMethods();

            foreach (var info in methods)
            {
                Console.WriteLine("Metod adı : {0}", info.Name);
                foreach (var parameterInfo in info.GetParameters()) 
                {
                    Console.WriteLine("Parametre : {0}", parameterInfo.Name);                    
                }
                foreach (var attribute in info.GetCustomAttributes())
                {
                    Console.WriteLine("Attribute Name : {0}", attribute.GetType().Name);
                }
            }
            // Yukarıdaki ------ altındanki metotlarda özelliklere ulaşma işlemi yaptık.
            //Reflection Bir nesnemize ait özelliklere liste halinde ulaşabiliriz. Bir nesnenin metodlarına parametrelerine attributlerine vb bir çok özelliğine Reflection metodu ile ulaşabiliriz. 


            Console.ReadLine();
        }
    }
    class DortIslem
    {
        private int _sayi1;
        private int _sayi2;
        public DortIslem(int sayi1, int sayi2) //Constractor işlemi set ediyor
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;
        }

        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }


        //Aşağıdaki metotlar Constractor daki değerlerden çalışıyor. sonuç döndürmek için yeniden değer vermeye gerek kalmıyor.

        public int Topla2() 
        {
            return _sayi1 + _sayi2;
        }

        [MetodName("Çarpma İşlemi")] // Attribute bir imza anlamı taşımaktadır. Anlam yüklemektir.
        public int Carp2()
        {
            return _sayi1 + _sayi2;
        }
    }

    public class MetodNameAttribute : Attribute
    {
        public MetodNameAttribute(string v)
        {
        }
    }

}
