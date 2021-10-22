using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Ayşe";
            customer1.LastName = "Aslan";
            customer1.TelephoneNumber= "00000000000";
            customer1.City ="Mersin";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.FirstName = "Fatma";
            customer2.LastName = "Gürsoy";
            customer2.TelephoneNumber = "00000000000";
            customer2.City = "İstanbul";

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.FirstName = "Okan";
            customer3.LastName = "Mehmet";
            customer3.TelephoneNumber = "00000000000";
            customer3.City = "Ankara";


            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Delete(customer2);
            customerManager.List(customer3);
        }
    }
}
