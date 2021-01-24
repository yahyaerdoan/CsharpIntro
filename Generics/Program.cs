using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)   // Genericlerin çalışma mantığı verilen veri tipinin kolay kullanılmasını sağlar. Hangi tür veri verdiysek elaman o veriye bürünüyor.
        {                                // Hangi veri tipini kullanırsak elamanımız o veri tipinde oluyor.
                                        //Array satırında veri tpini girmemiz gerekiyor.

            List<string> sehirler = new List<string>();
            sehirler.Add("Ankara");
            sehirler.Add("Ankara"); 
            sehirler.Add("Ankara"); 
            sehirler.Add("Ankara"); 
            sehirler.Add("Ankara");
            Console.WriteLine(sehirler.Count); //Count bir property dir. Var olan elaman saayısını yazdırır.

            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("Uşak");
            sehirler2.Add("Uşak");
            Console.WriteLine(sehirler2.Count);

            MyList<string> sehirler3 = new MyList<string>();
            sehirler3.Add("Bursa");
            sehirler3.Add("Bursa");
            sehirler3.Add("Bursa");
            Console.WriteLine(sehirler3.Count);

        }


    }

    class MyList<T> // Buradaki T type(tip) anlamını ifade ediyor. Ne yazdığımız önemli değil. yukarıda list'e string tipi verdik. t de string oldu. sehirler string oldu. Böyle 
    {               // Bu bölüm generic class oldu.
        T[] _array;
        T[] _tempArray;

        public MyList()
        {
            _array = new T[0];

        }
        
        public void Add (T item) 
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }

            _array[_array.Length - 1] = item;
        }

       

        public int Count  //Arrayın elaman sayısını veriyor.
        {
            get { return _array.Length; }
            
        }

    }
}
