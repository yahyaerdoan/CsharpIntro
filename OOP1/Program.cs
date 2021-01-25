using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategortId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product { Id = 2, CategortId = 5, ProductName = "Kalem", UnitPrice = 3, UnitsInStock = 35 };

            //PascalCase   //camelcase
            // Sol taraf steak              // Sağ taraf heap

            ProductManager productManager = new ProductManager();

            productManager.Add(product1);
            

            ProductManager productManager1 = new ProductManager();

            productManager1.Add(product2);
            

            productManager1.ProductDelete(product2);

            productManager1.Update(product2);



            productManager.Topla2(5, 7);

            int toplamaSonucu = productManager.Topla(5, 7 * 2); // return işlem sürekliliğini sağlar 
            Console.WriteLine(toplamaSonucu*2);
        
        
        }
    }
}
