using System;

namespace LiveTest
{
    //Write a program to find the Sum and the Average points scored by the teams in the IPL.
    //Create a Class called Cricket that has a function called Pointscalculation(int no_of_matches)
    //that takes no.of matches as input and accepts that many scores from the user.
    //The function should then display the Average and Sum of the scores.

    class Cricket
    {
        public void Pointscalculation(int no_of_matches)
        {

            double sum = 0, avg = 0;
            Console.Write("Enter the Number of Matches  Scored by each team : ");
           
            int n = Int32.Parse(Console.ReadLine());
            double[] numbers = new double[n];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Team  {0} Score: ", i + 1  );
                numbers[i] = Convert.ToDouble(Console.ReadLine());
                sum += numbers[i];
            }
            avg = sum / numbers.Length;
            Console.WriteLine(" ====================================");
            Console.WriteLine("The Sum is : " + sum);
            Console.WriteLine("The Average is : " + avg);

            Console.ReadKey();

        }

        static void Main(string[] args)
        {
            Cricket c = new Cricket();
            c.Pointscalculation(1);
            Console.Read();
            

        }
    }
}
