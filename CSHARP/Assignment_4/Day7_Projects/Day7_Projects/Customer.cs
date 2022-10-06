using System;

namespace Day7Projects
{
    class Customer
    {
        private int id;
        private string name;
        private int age;
        private string city;
        private string phone;
        
        public Customer() 
        {
            //Default Constructor

        }
        public Customer(int id, string name, int age, string city, string phone) // Parameterized Constructor
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.city = city;
            this.phone = phone;

        }

        public static void DisplayCustomer()
        {
            Console.WriteLine("**************Customer Details are***************");
            Console.WriteLine(" ");
            Customer customer1 = new Customer(1, "Ram", 24, "India", "8374758270");

            Console.WriteLine("Customer Id: {0}", customer1.id);
            Console.WriteLine("Customer Name: {0}", customer1.name);
            Console.WriteLine("Customer Age: {0}", customer1.age);
            Console.WriteLine("Customer City: {0}", customer1.city);
            Console.WriteLine("Customer Phone: {0}", customer1.phone);

            Console.ReadLine();
        }
        //~Customer()
        //{
        //    Console.WriteLine("Bye from Destructor");
        //}

        static void Main(string[] args)
        {

            DisplayCustomer();

        }
    }
}
