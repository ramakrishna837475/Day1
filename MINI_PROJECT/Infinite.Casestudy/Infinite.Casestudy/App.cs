using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infinite.Casestudy
{
    class App : Info
    {
        public void scenario1()
        {
            Student st = new Student(1,"Ram","10-07-1998");
            display(st);

        }
        public void scenario2()
        {

            Student[] s = new Student[3];
            s[0] = new Student(1, "Rama", "10-07-1998");
            s[1] = new Student(2, "Ravi", "12-08-1998");
            s[2] = new Student(3, "Raj", "9-09-1998");
            for (int i = 0; i < 3; ++i)
            {
              
                display(s[i]);
            }
        }
        public void scenario3()
        {
            for (int i = 0; i < 3; i++) 
            {
                Console.WriteLine("Enter student id :");

                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter student name :");
                string name = Console.ReadLine();
                Console.WriteLine("Enter student dob :");
                string dob = Console.ReadLine();


                Student[] s = new Student[3];
                s[i] = new Student(id, name, dob);


                display(s[i]);
            }
         
          
        }


        static void Main(string[] args)
        {
            App ap = new App();
            ap.scenario3();
            Console.Read();
        }
    }

}
