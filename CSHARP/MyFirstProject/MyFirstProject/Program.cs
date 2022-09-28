using System;

namespace MyFirstProject
{

    class TwoNumbers
    {
        public static void Main(string[] args)
        {
            int a;
            int b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            if (a == b)
            {
                Console.WriteLine(a + "  and  " + b + "  are equal");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine(a + "  and  " + b + "  are not  equal");
                Console.ReadKey();
            }
        }

    }
}