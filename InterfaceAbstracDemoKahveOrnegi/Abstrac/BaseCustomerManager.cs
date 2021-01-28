using InterfaceAbstracDemoKahveOrnegi.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstracDemoKahveOrnegi.Abstrac
{
    public class BaseCustomerManager : ICustomerServise
    {
        public virtual  void Save(Customer customer)
        {
            Console.WriteLine("Kullanıcı Bilgileriniz Doğrulandı:\n" + "Starbucks'a Hoş Geldin " + customer.FirstName,  customer.LastName);
        }
    }
}
