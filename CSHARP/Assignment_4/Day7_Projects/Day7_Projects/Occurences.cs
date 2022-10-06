using System;

namespace Day7_Projects
{
    class Occurences
    {
        public static void Main()
        {

            string str = "RAMAKRISHNA";
            Console.WriteLine("The number of Occurences of a String #####  " + str + "  ######## is :");
            Console.WriteLine(' ');
            while (str.Length > 0)
            {
                Console.Write(str[0] + " = ");
                int cal = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[0] == str[i])
                    {
                        cal++;
                    }
                }
                Console.WriteLine(cal);
                str = str.Replace(str[0].ToString(), string.Empty);
            }
            Console.ReadLine();
        }
    }
}
