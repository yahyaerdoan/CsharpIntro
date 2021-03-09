using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{
    public delegate void StockControl();
    public class Product
    {
        private int _stok;
        public Product(int stock)
        {
            _stok = stock;
        }

        public event StockControl StockControlEvent;
        public string ProductName { get; set; }
        public int Stock
        {
            get
            {
                return _stok;
            }


            set
            {
                _stok = value;
                if (value <= 10 && StockControlEvent != null)
                {
                    StockControlEvent();
                }
            }
        }

        public void Sell(int amount)
        {
            Stock -= amount;
            Console.WriteLine(" {1} Stock amount : {0}", Stock, ProductName);
        }
    }
}
