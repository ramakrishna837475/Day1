using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infinite.Casestudy
{
    class Course
    {
        public int CId;
        public string CName;
        public string Duration;
        public float Fees;

        public void display(Course course)
        {
            Console.WriteLine(course.CId);
            Console.WriteLine(course.CName);
            Console.WriteLine(course.Duration);
            Console.WriteLine(course.Fees);




        }

    }
}
