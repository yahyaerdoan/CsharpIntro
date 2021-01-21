 using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Proglamlamaya Başlangıç İçin Temel Kurs";
            string kurs3 = "Java";
            string kurs4 = "C#";
            //Console.WriteLine(kurs1);

            string[] kurslar = new string[] {"Yazılım Geliştirici Yetiştirme Kampı", "Proglamlamaya Başlangıç İçin Temel Kurs", "Java", "C#", "Yahya", "Erdoğan", "Python" };

            for (int i = 0; i<kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For Biiti");
            +
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("Sayfa Sonu- Footer");
        }   
    }
}
