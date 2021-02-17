using System;

namespace ClassMethotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();

            Customer customer1 = new Customer();
            customer1.Id = "1";
            customer1.name = "Ceren";
            customer1.lastname = "Uludogan";
            customer1.city = "Antalya";

            customerManager.Add(customer1);

            Customer customer2 = new Customer();
            customer2.Id = "2";
            customer2.name = "Selin";
            customer2.lastname = "Ayli";
            customer2.city = "Antalya";

            customerManager.Add(customer2);

            Customer customer3 = new Customer();
            customer3.Id = "3";
            customer3.name = "Ayşe";
            customer3.lastname = "Ata";
            customer3.city = "Manisa";

            customerManager.Add(customer3);

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };
            customerManager.List(customers);
            customerManager.Delete(customer2);

            customers = new Customer[] { customer1, customer3 };
            customerManager.List(customers);

        }
    }
}
