using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infinite.Casestudy
{
    class Student
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string DateOfBirth { get; set; }
        
        public  Student(int studentid , string studentname,string studentdob)
        {
            Id = studentid;
            Name = studentname;
            DateOfBirth = studentdob;
        }

    }
}
