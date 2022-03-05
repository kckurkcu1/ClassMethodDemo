using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
   class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.Name + "isimli müşteri eklendi !");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.Name + "isimli müşteri silindi !");
        }

        public void List(Customer[] customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Id + " " + customer.Name + " " + customer.Surname + " " + customer.Age);
            }
        }
    }
}
