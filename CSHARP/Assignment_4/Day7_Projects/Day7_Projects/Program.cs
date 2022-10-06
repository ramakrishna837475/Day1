using System;

namespace Day7_Projects
{
    class Program
    {

        static void Display()
        {
            Console.WriteLine("Enter Your Frist Name :");
            string FirstName= Console.ReadLine();

            Console.WriteLine("Enter Your Last Name :");
            string LastName= Console.ReadLine();
            Console.WriteLine("###########################################");
            
            Console.WriteLine(" Your First Name is: " + FirstName.ToUpper());
            Console.WriteLine(" Your Last Name is: " + LastName.ToUpper());
     
        }

        static void Main(string[] args)
        {

            Display();
            Console.Read();

        }


    }
    
}
