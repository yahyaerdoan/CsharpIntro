using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product
    {
        public int Id { get; set; } // Ana anahtar ürüne verilen ıd numarasıdır. Yardımcı anahtrr ise kategori ait olduğunu gösteren numaradır.

        public int CategortId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public string Brand { get; set; }


        // Ekelek okumak silmek güncellemek orerasyonları buradan yürütülmeketedir. Crud Operasyonu denir.

    }
}
