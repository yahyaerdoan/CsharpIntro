using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class BasvuruManager(IKrediManager krediManager)
    {
        public void  BasvuruYap () 
        {
         krediManager.Hesapla();
        }
    }
}
