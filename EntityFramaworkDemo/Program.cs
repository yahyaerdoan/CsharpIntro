using System;
using System.Linq;

namespace EntityFramaworkDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //GetAll();
            //GetProductsByCategory(1);
            GetProductsByProduct(5);
        }
      
               
        private static void GetAll()
        {
            NorthwindContext northwindContext = new NorthwindContext();

            foreach (var Product in northwindContext.products)
            {
                Console.WriteLine(Product.ProductName);
            }
        }

        private static void GetProductsByCategory(int categoryId) 
        {
            NorthwindContext northwindContext = new NorthwindContext();

            var result = northwindContext.products.Where(P => P.CategoryId == categoryId);

            foreach (var Product in result)
            {
                Console.WriteLine(Product.ProductName);
            }
        }

        private static void GetProductsByProduct(int productId) 
        {
            NorthwindContext northwindContext = new NorthwindContext();

            var result = northwindContext.products.Where(P => P.ProductId == productId);
            foreach (var Product in result)
            {
                Console.WriteLine(Product.ProductName + "   " + Product.ProductId + "   " + Product.QuantityPerUnit + "   " + Product.UnitsInStock + "   " + Product.UnitPrice + "   " + Product.CategoryId);
            }
        }


    }
}
