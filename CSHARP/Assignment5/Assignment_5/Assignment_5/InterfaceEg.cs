using System;


namespace Assignment_5
{
    interface IStudent
    {
        string Name
        {
            get;
            set;
        }
        int Id
        {
            get;
        }
    }
    class Recident :IStudent
    {
        public static int noOfEmp;
        private string name;
        public string Name
        {
            get => name;
            set => name = value;

        }

        private int id;
        public int Id
        {
            get => id;
        }
        public Recident() => id = +noOfEmp;
    }
    class DayScholar
    {
        static void Main()
        {
            Console.WriteLine("Enter Student Id :");
            Recident.noOfEmp = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Student Name");
            var re = new Recident();
            re.Name = Console.ReadLine();
            Console.WriteLine("===========Student Information========= :");
            Console.WriteLine($"{re.Id},{re.Name}" );

            Console.Read();

        } 
    }
}
