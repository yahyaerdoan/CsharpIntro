using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class SmsLoggerServise : ILoggerService
    {
       
        public void Log()
        {
            Console.WriteLine("Sms yollandı");
        }
    }
}
