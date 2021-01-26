 using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class CiftciKrediManager : IKrediManager
    {
        public void BiseyYap()
        {
            Console.WriteLine("Ne Yapayım?");
        }

        public void Hesapla()
        {
            Console.WriteLine("Çiftçi kredisi ödeme planı hesaplandı");
        }
    }
}
