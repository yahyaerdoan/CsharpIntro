using System;

namespace Classİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Yahya";
            int yas = 36;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;
            kurs1.Degerlendirme = 88;
            kurs1.Sonuc = "Gayretli";

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Yahya Erdoğan";
            kurs2.IzlenmeOrani = 90;
            kurs2.Degerlendirme = 1;
            kurs2.Sonuc = "Güzel";

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Cpp";
            kurs3.Egitmen = "Murat Bilgin";
            kurs3.IzlenmeOrani = 95;
            kurs3.Degerlendirme = 96;
            kurs3.Sonuc = "Harika";

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "HTML";
            kurs4.Egitmen = "Yusuf Pak";
            kurs4.IzlenmeOrani = 99;
            kurs4.Degerlendirme = 5;
            kurs4.Sonuc = "Başarılı";



            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);
            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen + " : " + kurs.IzlenmeOrani + " : " + kurs.Degerlendirme + " : " + kurs.Sonuc);
            }
            Console.WriteLine("KURSUMUZA HOŞ GELDİN!");
        }
    }
}
class Kurs
{
    public string KursAdi { get; set; }
    public string Egitmen { get; set; }
    public int IzlenmeOrani { get; set; }
    public int Degerlendirme { get; set; }
    public string Sonuc { get; set; }
}





       