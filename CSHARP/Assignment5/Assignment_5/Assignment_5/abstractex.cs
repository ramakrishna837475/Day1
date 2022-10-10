using System;

namespace Assignment5

{
    abstract class Student
    {
        public string Name;
        public int StudentId;
        public Double Grade;

        public abstract Boolean Ispassed(Double Grade);

    }

    class UnderGraduate : Student
    {
       public override Boolean Ispassed(Double Grade)

        {
            if (Grade >= 70)
                return true;
            else
                return false;
        }

       
    }

    class Graduate : Student
    {
        public override Boolean Ispassed(Double Grade)
        {
            if (Grade >= 80)
                return true;
            else
                return false;


        }
        static void Main(string[] args)  
        {
           
            Student s = new UnderGraduate();
            s.StudentId = 1;
            s.Name = "Ram";
            s.Grade = 60;

            
            Console.WriteLine("Student Id is : " + s.StudentId);
            Console.WriteLine("Student Name is : " + s.Name);
            Console.WriteLine("Student Grade for UnderGraduate is : " + s.Grade);
            
            Console.WriteLine(s.Ispassed(60));

            Console.WriteLine("=================####################==================");

            s = new Graduate();
            s.Grade = 85;
            Console.WriteLine("Student Grade for Graduate is : " + s.Grade);
            Console.WriteLine(s.Ispassed(85));

            Console.Read();


        }

    }

}