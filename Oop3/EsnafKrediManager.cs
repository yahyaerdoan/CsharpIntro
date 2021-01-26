using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class EsnafKrediManager : IKrediManager
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Esnaf Kredi ödeme planı hesaplandı");
        }
    }
}
