using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "Kerem Can";
            customer1.Surname = "Kürkçü";
            customer1.Age = 21;

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "Sebastian";
            customer2.Surname = "Vettel";
            customer2.Age = 34;

            Customer customer33 = new Customer();
            customer33.Id = 3;
            customer33.Name = "Max";
            customer33.Surname = "Verstappen";
            customer33.Age = 24;
        }
    }
}
