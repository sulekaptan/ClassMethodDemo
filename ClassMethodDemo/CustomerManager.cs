using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Congratulations! Customer added: " + customer.Name + " " + customer.Surname);
        }



        public void List(Customer customer)
        {
            Console.WriteLine("Customers: " + customer.Name + " " + customer.Surname + " " + customer.Age);
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("This customer deleted!: " + customer.Name + " " + customer.Surname);
        }

    }
}
