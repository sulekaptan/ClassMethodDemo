using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {


            Customer customer1 = new Customer();
            customer1.Name = "Şule";
            customer1.Surname = "Kaptan";
            customer1.Age = 21;

            Customer customer2 = new Customer();
            customer2.Name = "Şevval";
            customer2.Surname = "Arslan";
            customer2.Age = 20;

            Customer[] customers = new Customer[] { customer1, customer2 };


            /*foreach (Customer cust in customers)
            {
                Console.WriteLine(cust.Name);
                Console.WriteLine(cust.Surname);
                Console.WriteLine(cust.Age);
            }*/

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);

            Console.WriteLine("-----------------------------------");

            customerManager.List(customer1);
            customerManager.List(customer2);

            Console.WriteLine("-----------------------------------");

            customerManager.Delete(customer2);


        }
    }
}
