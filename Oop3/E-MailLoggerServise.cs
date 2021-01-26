using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class E_MailLoggerServise : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("e-Mail bilgilendirme mesajı gönderildi");
        }
    }
}
