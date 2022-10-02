using System;

namespace Day5Projects
{
    class Student
    {

        public int Rollno, Class, Semester, sub1, sub2, sub3, sub4, sub5;
        public string name, branch;

        public Student(string nm, int cls, int sem, string brn, int Rn)
        {
            Console.WriteLine("Enter the  student name : ");
            nm = Console.ReadLine();
            Console.WriteLine("Enter  the student class : ");
            cls = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the semester  : ");
            sem = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Branch : ");
            brn = Console.ReadLine();
            Console.WriteLine("Enter the  student Roll_Number : ");
            Rn = Convert.ToInt32(Console.ReadLine());
            Rollno = Rn;
            name = nm;
            Class = cls;
            Semester = sem;
            branch = brn;
        }

        public void Getmarks()
        {
            Console.WriteLine("Enter thw marks of 5 subjects : ");
            sub1 = Convert.ToInt32(Console.ReadLine());
            sub2 = Convert.ToInt32(Console.ReadLine());
            sub3 = Convert.ToInt32(Console.ReadLine());
            sub4 = Convert.ToInt32(Console.ReadLine());
            sub5 = Convert.ToInt32(Console.ReadLine());
            int[] marks = new int[5];
            marks[0] = sub1;
            marks[1] = sub2;
            marks[2] = sub3;
            marks[3] = sub4;
            marks[4] = sub5;

        }
        public void DisplayResults()
        {
            int sum;
            float avg = 0.0F;
            sum = sub1 + sub2 + sub3 + sub4 + sub5;
            avg = (float)sum / 5;
            if (sub1 < 35)
            {
                Console.WriteLine("student is failed ");
            }
            else if (sub2 < 35)
            {
                Console.WriteLine("Student is failed ");
            }
            else if (sub3 < 35)
            {
                Console.WriteLine("Student is failed ");
            }
            else if (sub4 < 35)
            {
                Console.WriteLine("Student is failed ");
            }
            else if (sub5 < 35)
            {
                Console.WriteLine("Student is failed ");
            }
            else if (sum > 35 && avg < 50)
            {
                Console.WriteLine("Student is failed ");
            }
            else if (avg > 50)
            {
                Console.WriteLine("Student is passed");
            }



        }
        static void Main(string[] args)
        {
            Student student = new Student("", 0, 0, "", 0);
            student.Getmarks();
            student.DisplayResults();
            Console.ReadLine();


        }
    }
}
