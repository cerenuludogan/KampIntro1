using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethotDemo
{
    class CustomerManager
    {

        public void Add(Customer customer)
        {
            Console.WriteLine(customer.Id + " numarali musteri ekleniyor..");

        }
        public void List(Customer[] customers)
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine("-----------");
                Console.WriteLine(customer.Id);
                Console.WriteLine(customer.name);
                Console.WriteLine(customer.lastname);
                Console.WriteLine(customer.city);

            }
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.Id + "numarali musteri siliniyor..");
        }
    }
}
