using System;
using System.Collections.Generic;

namespace MyDictonary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionaryy<int, string> adSoyadNumara = new MyDictionaryy<int, string>();
            adSoyadNumara.Add(1920, "Yahya ERDOĞAN");
            adSoyadNumara.Add(1951, "Bayram Kara");

            Console.WriteLine("Öğrenci Numarası: " + adSoyadNumara.Items1[0] + " " + "Adı Soyadı" + adSoyadNumara.Items2[0]);
        }
    }
}
