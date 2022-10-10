using System;

namespace Assignment_5
{
    class Occurences
    {
        public static void Main()
        {

            string str = "RAMAKRISHNA";
            Console.WriteLine("The number of Occurences of a String #####  " + str + "  ######## is :");

            char ch = 'A';

            int cont = 0;
            foreach (char c in str)
            {
                if (c == ch)
                {
                    cont++;
                }
            }

            Console.WriteLine(cont);
            Console.ReadLine();
        }
    }
}
