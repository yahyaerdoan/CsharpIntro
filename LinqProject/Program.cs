using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{CategoryId = 1, CategoryName = "Bilgisayar"},
                new Category{CategoryId = 2, CategoryName = "Telefon"},
            };

            List<Product> products = new List<Product>
            {
                new Product{ CategoryId = 1, ProductId = 1, ProductName = "Acer Laptop", QuantityPerUnit = "32 GB Ram", UnitPrice = 19000, UnitInStock = 5},
                new Product{ CategoryId = 1, ProductId = 2, ProductName = "Asus Laptop", QuantityPerUnit = "16 GB Ram", UnitPrice = 18000, UnitInStock = 3},
                new Product{ CategoryId = 1, ProductId = 3, ProductName = "LG Laptop", QuantityPerUnit = "8 GB Ram", UnitPrice = 16000, UnitInStock = 2},
                new Product{ CategoryId = 2, ProductId = 4, ProductName = "Apple Telefon", QuantityPerUnit = "4 GB Ram", UnitPrice = 5000, UnitInStock = 15},
                new Product{ CategoryId = 2, ProductId = 5, ProductName = "Samsung Telefon", QuantityPerUnit = "4 GB Ram", UnitPrice = 8000, UnitInStock = 0},

            };

            //Test(products);
            //GetProductsLinq(products);
            //GetProducts(products);
            //AnyTest(products);
            //FindTest(products);
            //FindAllTest(products);
            //AscDescTest(products);                        
            //FromSelectMetodu(products);
            //ClassicLinqMetod(products);


            var result = from p in products
                         join c in categories
                         on p.CategoryId equals c.CategoryId
                         where p.UnitPrice > 5000
                         orderby p.UnitPrice descending
                         select new ProductDto { ProductId = p.ProductId, CategoryName = c.CategoryName, ProductName = p.ProductName, UnitPrice = p.UnitPrice, CategoryId = c.CategoryId };
            foreach (var productDto in result)
            {
                Console.WriteLine("{1} : {2} : {0}", productDto.ProductName, productDto.CategoryName, productDto.CategoryId);
            }

        }

        private static void ClassicLinqMetod(List<Product> products)
        {
            var result = from p in products        //Join ile ilişkisel tasarım yapılmaktadır.
                         where p.UnitPrice > 8000
                         orderby p.UnitPrice descending, p.ProductName ascending
                         select new ProductDto { ProductId = p.ProductId, ProductName = p.ProductName, UnitPrice = p.UnitPrice };
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void FromSelectMetodu(List<Product> products)
        {
            var result = from p in products             // Farklı bir şekilde ürünü yazdırma metodu
                         where p.UnitPrice > 8000 // ürün filitreleme işlemi de yapılabiliyor. listeyi yazıldığı gibi sıaralarken
                         orderby p.UnitPrice descending, p.ProductName ascending  // küçükten büyüğe sıralama yapıyor defaultu : azdan çoğa
                         select p;
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void AscDescTest(List<Product> products) // Ürünleri azdan çoğa vb şekilde sıralama ve alfabetik de sıralama
        {
            var result = products.Where(p => p.ProductName.Contains("top")).OrderByDescending(p => p.UnitPrice).ThenByDescending(p => p.ProductName);
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void FindAllTest(List<Product> products)
        {
            var result = products.FindAll(p => p.ProductName.Contains("top")); //Liste dönüyor.
            Console.WriteLine(result);
        }

        private static void AnyTest(List<Product> products)
        {
            var result = products.Any(products => products.ProductName == "Apple Telefon");  //Bu isimde ürün var mı yok mu sorusunun cevabını getirir. tru false döndürür.
            Console.WriteLine(result);
        }

        private static void FindTest(List<Product> products)
        {
            var result = products.Find(p => p.ProductId == 3); // Bulmak istediğimiz veriyi verip istediğimizi bulmamsızı sağlar
            Console.WriteLine(result.ProductName);
        }

        private static void Test(List<Product> products)
        {
            Console.WriteLine("------Algoritmik----------");
            NewMethod(products);

            Console.WriteLine("-----Linq--------");

            var result = products.Where(products => products.UnitPrice > 1000 && products.UnitInStock > 3);
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void NewMethod(List<Product> products)
        {
            foreach (var product in products)
                if (product.UnitPrice > 1000 && product.UnitInStock > 3)
                {
                    Console.WriteLine(product.ProductName);
                }
        }

        //Linq Kullanılmayan eski metod
        static List<Product> GetProducts(List<Product> products) 
        {
            List<Product> filtredProduct = new List<Product>();
            foreach (var product in products)
            {
                if (product.UnitPrice > 1000 && product.UnitInStock > 3)
                {
                    filtredProduct.Add(product);
                }
            }
            return filtredProduct;
        }

           //Sadece Linq Metodu
        static List<Product> GetProductsLinq(List<Product> products)
        {
           return products.Where(products => products.UnitPrice > 5000).ToList();
        }
    }

    class ProductDto //Data Tranformation object
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } 
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }

    }

    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; } 
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitInStock { get; set; }
    }

    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}   



