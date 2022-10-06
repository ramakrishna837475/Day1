using System;

namespace Day7_Projects
{
    public class Scholarship
    {
        public static int Totalmarks;
        public static float fees;
        public int SAmount;
        public float Merit(int m, float f)
        {

            if (m >= 70 && m <= 80)
            {
                SAmount = 20 * Convert.ToInt32(f) / 100;

            }
            if (m >= 80 && m <= 90)
            {
                SAmount = 30 * Convert.ToInt32(f) / 100;
            }
            if (m > 90)
            {
                SAmount = 50 * Convert.ToInt32(f) / 100;
            }
            return SAmount;

        }
        public static void Main(string[] args)
        {
            Console.WriteLine("===========Scholarship Details are ========");
            Console.WriteLine("please enter Marks : ");
            Totalmarks = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter fees");
            fees = Convert.ToInt32(Console.ReadLine());
            Scholarship sp = new Scholarship();
            float feess = sp.Merit(Totalmarks, fees);
            Console.WriteLine("###########");
            Console.WriteLine("Your scholarship is : " + feess);
           
            Console.Read();
        }
    }
    }
