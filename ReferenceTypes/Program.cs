using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Person person2 = new Person();

            person1.FirstName = "Engin";
            person2 = person1;
            //Console.WriteLine("Person2.FirstName" + " " + person2.FirstName);

            person1.FirstName = "Barış";
            //Console.WriteLine("Person2.FirstName" + " " + person2.FirstName);

            Customer customer = new Customer();
            customer.FirstName = "Salih";
            customer.CreditCardNumber = "12345";

            Employee employee = new Employee();
            employee.FirstName = "Veli";

            // base class Person olduğu için bundan inherence alan sınıfın referansını atayabiliriz
            Person person3 = customer;
            //Console.WriteLine("Person3.FirstName" + " " + person3.FirstName);

            customer.FirstName = "Ahmet";
            //person3 için Customer class ında tanımlanan bir değerini görmek istersek aşağıdaki gibi ((Customer)person3) dememiz gerekmektedir.
            //Console.WriteLine(((Customer)person3).CreditCardNumber);

            PersonManager personManager = new PersonManager();
            personManager.Add(employee);
            personManager.Add(customer);

        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    // inherence , base class Person
    class Customer:Person
    {
        public string CreditCardNumber { get; set; }
    }

    // inherence
    class Employee :Person
    {
        public int EmployeeNumber { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
