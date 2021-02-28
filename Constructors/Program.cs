using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id = 1, FirstName = "Barış", LastName = "Dal", City = "Ankara" };
            // aşağıdaki gibi veri girişi yapabilmek için constructors'ta tanımlama yaparak default'ı aşmış oluruz.
            Customer customer2= new Customer(2, "Gizem", "Dal","Ankara");

            Customer customer3 = new Customer();
            customer3.Id = 3;

            Console.WriteLine(customer2.FirstName);

        }
    }

    class Customer
    {
        //default constructors: parametresi olmayan constructors
        public Customer()
        {
            Console.WriteLine("Yapıcı Blok Çalıştı");
        }
        // default customerı değiştirdik
        public Customer(int id, string firstname, string lastname, string city )
        {
            Id = id;
            FirstName = firstname;
            LastName = lastname;
            City = city;
            Console.WriteLine("Yapıcı Blok Çalıştı");
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
