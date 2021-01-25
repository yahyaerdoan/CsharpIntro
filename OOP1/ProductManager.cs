using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
            {
        public void Add (Product product) 
        {
            Console.WriteLine(product.ProductName + " " + "Eklendi.");
           
            Console.WriteLine(" \n ");
        }

        public void Update (Product product) 
        {
            Console.WriteLine(" \n ");
            Console.WriteLine(product.ProductName + " " + "Güncellendi.");

        }

        public void  ProductDelete (Product product) 
        {
            Console.WriteLine(product.ProductName + " " + "Silindi");
        }

        public int Topla (int sayi1, int sayi2) 
        {
            return sayi1 + sayi2;
        }

        public void Topla2(int sayi1, int sayi2) 
        {
            Console.WriteLine(" \n ");
            Console.WriteLine(sayi1 + sayi2);
        }
    }


}
