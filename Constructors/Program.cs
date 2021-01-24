using System;

namespace Constructors // Yapıcı Blok demektir.
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id = 1, FirstName = "Yahya", LastName = "Erdoğan", City = "Bursa" };
            Console.WriteLine(customer1.FirstName);

            Customer customer2 = new Customer(2, "Engin", "Demiroğ", "Ankara");
            Console.WriteLine(customer2.Id);
        
        }


    }

    class Customer
    {
        public Customer()
        {
            
        }
        public Customer(int id, string firstName, string lastName, string city) // Constructors bir class gibi görünür burda
        {
            Id = Id;
            FirstName = FirstName;
            LastName = LastName;
            City = City;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
