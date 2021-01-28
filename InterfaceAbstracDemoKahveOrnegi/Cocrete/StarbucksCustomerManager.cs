using InterfaceAbstracDemoKahveOrnegi.Abstrac;
using InterfaceAbstracDemoKahveOrnegi.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstracDemoKahveOrnegi.Cocrete
{
    public class StarbucksCustomerManager : BaseCustomerManager
    {
        ICustomerCheckService _customerCheckService;

       
        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckedIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                Console.WriteLine("Kullanıcı Bilgileri Doğrulanamadı!\n" + "Lütfen Tekrar Deneyiniz!");
            }

            
        }
    }
        
}
