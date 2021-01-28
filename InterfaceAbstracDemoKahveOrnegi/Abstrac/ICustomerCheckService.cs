using InterfaceAbstracDemoKahveOrnegi.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstracDemoKahveOrnegi.Abstrac
{
    public interface ICustomerCheckService
    {
        bool CheckedIfRealPerson(Customer customer);
        

        

    }
}
