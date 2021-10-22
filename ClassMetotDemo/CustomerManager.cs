using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Müşteri Eklendi : " + customer.FirstName + " " + customer.LastName);
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Müşteri Silindi : " + customer.FirstName + " " + customer.LastName);
        }

        public void List(Customer customer)
        {
            Console.WriteLine(customer.Id + "=" + customer.FirstName + " " + customer.LastName);
        }
    }
}
