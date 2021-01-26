using System;
using System.Collections.Generic;

namespace Oop3
{
    class Program
    {
        static void Main(string[] args)
        {
            IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();

            TasıtKrediManager tasıtKrediManager = new TasıtKrediManager();
            //tasıtKrediManager.Hesapla();

            KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            IKrediManager ciftciKrediManager = new CiftciKrediManager();

            IKrediManager konutKrediManager1 = new KonutKrediManager();  // IKrediManager implemente ollmuş oluyor. bu şekilde de olabiliyor. 
            //konutKrediManager.Hesapla();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

           


            BasvuruManager basvuruManager = new BasvuruManager();

                                                                          // Aşağıdaki dodlar satır içinde loglama işlemidir. aşağıda verilen iki örnekten farklı kodlama sistemidir.
            basvuruManager.BasvuruYap(new CiftciKrediManager(), new List<ILoggerService> { new FileLoggerService(), new SmsLoggerServise() });
            Console.WriteLine("         ");

            basvuruManager.BasvuruYap(new EsnafKrediManager(), new List<ILoggerService> { new DatabaseLoggerService(), new SmsLoggerServise() });
            Console.WriteLine("             ");



                //Aşağıda verilen kodlar list yazma şeklidir. 
            List<ILoggerService> loggers = new List<ILoggerService>() { new DatabaseLoggerService(), new FileLoggerService(), new SmsLoggerServise(), new E_MailLoggerServise() };

            basvuruManager.BasvuruYap(ihtiyacKrediManager, loggers);
            Console.WriteLine("          ");


            

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, konutKrediManager, tasıtKrediManager, ciftciKrediManager };
            basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
