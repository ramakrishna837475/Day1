using System;

namespace Day7_Projects
{
    class Doctor

    {
        int RegNo;
        string Name;
        float FeesCharged;

        public Doctor(int regno, string name, float fees)
        {
            RegNo = regno;
            Name = name;
            FeesCharged = fees;
        }

        public void Display()
        {
            Console.WriteLine("===========Patient Details =============");
            Console.WriteLine(" ");
            Console.WriteLine("Your RegNo is :" + RegNo);
            Console.WriteLine("Your Name is :" + Name);
            Console.WriteLine("FeesCharges is : " + FeesCharged);
        }

        static void Main(string[] args)
        {
            Doctor d = new Doctor(546,"Ram_Cheran",1000);
            d.Display();
            Console.Read();

        }
    }
}
