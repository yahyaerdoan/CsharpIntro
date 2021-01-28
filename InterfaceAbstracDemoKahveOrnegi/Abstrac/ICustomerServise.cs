using InterfaceAbstracDemoKahveOrnegi.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstracDemoKahveOrnegi.Abstrac
{
    public interface ICustomerServise
    {
        void Save(Customer customer);
    }
}
