using System;

namespace LiveTest
{
    //Write a class Box that has Length and breadth as its members.
    //Write a function that adds 2 box objects and stores in the 3rd.
    //Create a Test class to execute the above.
   
    class Box
    {
        
            double length;
            double breadth;

            public void Acceptdetails()
            {
                length = 8.5;
                breadth = 6.5;
            }

            public double GetArea()
            {
                return length * breadth;
            }

            public void Display()
            {
                Console.WriteLine(" Box that has Length and breadth Details are :");
                Console.WriteLine("#######################################");
                Console.WriteLine("Length: {0}", length);
                Console.WriteLine("Width: {0}", breadth);
                Console.WriteLine("Area: {0}", GetArea());
            }
        }

    class Test
    {

        static void Main(string[] args)
        {
            Box b = new Box();
            b.Acceptdetails();
            b.Display();
            Console.Read();

        }

    }
}
