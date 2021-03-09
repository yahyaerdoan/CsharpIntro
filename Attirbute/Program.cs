using System;

namespace Attirbute
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { Id = 1, LastName = "Erdoğan", Age = 27, };
            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);
            Console.ReadLine();
        }
    }  // Attributeler nesnelerimize anlam katmak için varlardır.
       // Her property için attribute eklenebileceği gibi bir Class için de attribute eklenebilir. Fakat Böyle olması durumuda burası kalabalık olur.
       // Nesnelerimize ve nesnelerimizin özelliklerine veya metotlarına Attribute ekleyebiliyoruz.


    [ToTable("Customers")]
    [ToTable("TblCustomers")]  // Attributlere parametre de yollayabiliriz. Fakat bunu generic constractor ile çömzümlemeliyiz.
    [RequiredProperty]
    class Customer
    {
        public int Id { get; set; }
        [RequiredProperty] // AllowMultiple = true yaptığımız için iki defa kullanmaya izin veriyor tabi burası için uygun örnek değil
        [RequiredProperty]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

    }
    class CustomerDal
    {
        [Obsolete("Add'i kullanma yeni addi kullan")] // Obsolote hazır Atributedir. 
                                                     //Burada Eski Add i kıullanmayacağımı söyleyen mimariye Reflection diyoruz.
                                                     // Burada ne anlama geldiğini [RequiredProperty] nin ne ifade ettiğini nasıl öğrenebilceğim logic ekleyeceğimiz bir reflection metodudur.
                                                     // Reflection bize yönlendirme ve kontrol hizmeti sunacak
        public void Add(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3} Eklendi!", customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }
        public void NewAdd(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3} Eklendi!", customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }
    }

    [AttributeUsage(AttributeTargets.Property| AttributeTargets.Class, AllowMultiple = true)] //AttributeTargets.All : Bu Attributü bir callasa metoda her kese kullanılabili demektir. Class verseydik sadece class üzerinde kullanabiliriz 
                                                // Nesnler için kullanacakcak Property vermeliyiz.
    class RequiredPropertyAttribute :Attribute //Bir nesne için kullandığımız attribute metodudur.
    {

    }
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    class ToTableAttribute : Attribute
    {
        private string _tableName;

        public ToTableAttribute(string tableName)
        {
            _tableName = tableName;
        }
    }
}
