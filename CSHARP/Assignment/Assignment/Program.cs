using System;
namespace Day6Dotnet
{
    class Student
    {
        private string RollNo;
        private string Name;
        private string Class;

        public void GetData()
        {
            Console.WriteLine("Enter Roll No:");
            RollNo = Console.ReadLine();
            Console.WriteLine("Enter Name :");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Class :");
            Class = Console.ReadLine();
        }
        public void PutData()
        {
            Console.WriteLine("Name of the Student :" + Name);
            Console.WriteLine("No of the Student :" + RollNo);
            Console.WriteLine("Class of the Student :" + Class);

        }
    }
    class Marks : Student
    {
        protected int[] a = new int[5];

        public void GetMarks()
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("Enter Subject {0} Marks", i + 1);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
        }
        public void PutMarks()
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("Marks in Subject {0} {1} ", i + 1, a[i]);
            }
            Console.WriteLine();
        }
    }
    class Results : Marks
    {
        int TotalMarks = 0;
        public void GetResults()
        {
            for (int i = 0; i < a.Length; i++)
            {
                TotalMarks += a[i];
            }
        }
        public void DisplayResults()
        {
            Console.WriteLine("==========Results==========");
            PutData();
            PutMarks();
            Console.WriteLine("Total Marks =" + TotalMarks);

            double percentage;
            percentage = TotalMarks / 5.0;
            Console.WriteLine("percentage is : {0}", percentage);


            if (percentage >= 90 && percentage <= 100)
            {
                Console.WriteLine("Outstanding with Grade O");
            }
            else if (percentage >= 80 && percentage <= 90)
            {
                Console.WriteLine("Excellent with Grade E");
            }
            else if (percentage >= 70 && percentage <= 80)
            {
                Console.WriteLine("Very Good with Grade A");
            }
            else if (percentage >= 60 && percentage <= 70)
            {
                Console.WriteLine("Average with Grade B");
            }
            else if (percentage >= 50 && percentage <= 60)
            {
                Console.WriteLine("Good with Grade c");
            }
            else if (percentage >= 40 && percentage <= 50)
            {
                Console.WriteLine("Below Average with Grade D");
            }
            else if (percentage >= 35 && percentage <= 40)
            {
                Console.WriteLine("You just passed");
            }
            else if (percentage <= 0)
            {
                Console.WriteLine("Your entered Incorrect Data");
            }

        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Results res = new Results();
            res.GetData();
            res.GetMarks();
            res.GetResults();
            res.DisplayResults();
            Console.Read();
        }
    }
}