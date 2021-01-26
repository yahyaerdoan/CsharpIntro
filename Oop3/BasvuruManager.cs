using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService>  loggerServices) // Bu alana hangi kredi türünün hesaplanacağını söylemek lazım 
        {
            krediManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)  // Birden fazla türü göstermek için liste kullanırız.
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }

        
    }


}

