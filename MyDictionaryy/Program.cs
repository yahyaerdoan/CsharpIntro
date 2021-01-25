using System;

namespace MyDictionaryy
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionaryys<int, string> adSoyadNumara = new MyDictionaryys<int, string>();
            adSoyadNumara.Add(1920, "Yahya ERDOĞAN");
            adSoyadNumara.Add(1951, "Bayram Kara");
            adSoyadNumara.Add(1765, "Resul Dindar");
            adSoyadNumara.Add(7675, "Kübra Çelik"); 
            adSoyadNumara.Add(5677, "Zehra Bozkurt");
          

            Console.WriteLine("  " + adSoyadNumara.Items1[0] + " " + "" + adSoyadNumara.Items2[0]);
            Console.WriteLine("  " + adSoyadNumara.Items1[1] + " " + "" + adSoyadNumara.Items2[1]);
            Console.WriteLine("  " + adSoyadNumara.Items1[2] + " " + "" + adSoyadNumara.Items2[2]);
            Console.WriteLine("  " + adSoyadNumara.Items1[3] + " " + "" + adSoyadNumara.Items2[3]);
            Console.WriteLine("  " + adSoyadNumara.Items1[4] + " " + "" + adSoyadNumara.Items2[4]);

        }
    }
}
