using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProject
{
    class Program
    {
        static MyDataContext db = new MyDataContext();



        static void Main(string[] args)
        {
            var cat = db.dep1s.ToList();
            foreach(var v in cat)
            {
                Console.WriteLine($"{v.id} {v.name} {v.gender}");
            }
            Console.Read();
        }
    }
}
