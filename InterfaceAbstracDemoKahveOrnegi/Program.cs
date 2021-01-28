using InterfaceAbstracDemoKahveOrnegi.Abstrac;
using InterfaceAbstracDemoKahveOrnegi.Cocrete;
using InterfaceAbstracDemoKahveOrnegi.Entities;
using System;

namespace InterfaceAbstracDemoKahveOrnegi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TC Kimlik No Giriniz:");
            string nationalityID = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("Adınızı Giriniz:");
            string name = Console.ReadLine();
            Console.WriteLine("\n");

            Console.WriteLine("Soyadınızı Giriniz:");
            string lastName = Console.ReadLine();
            Console.WriteLine("\n");

            Console.WriteLine("Doğum Tarihinizi Giriniz:");
            DateTime dateofBirth = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("\n");

            Customer confirmedCustomer = new Customer
            {
                NationalityId = nationalityID,
                FirstName = name.ToUpper(),
                LastName = lastName.ToUpper(),
                DateOfBirth = dateofBirth
            };



            BaseCustomerManager baseCustomerManager = new StarbucksCustomerManager(new CustomerCheckServise());
            baseCustomerManager.Save(confirmedCustomer);

           
        }
    }
}
