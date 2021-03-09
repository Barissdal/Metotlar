using System;
using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer
            {
                NationalityId = "28861499108",
                FirstName = "Engin",
                LastName = "Demiroğ",
                DateOfBirth = new DateTime(1988, 1, 6)

            });

            Console.ReadLine();
        }
    }
}
