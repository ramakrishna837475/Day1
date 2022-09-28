using System;
public class LengthString
{
    public static void Main()
    {
        string str; 
        int l = 0;
        Console.Write("Input the string : ");
        str = Console.ReadLine();

        foreach (char chr in str)
        {
            l += 1;

        }

        Console.Write("Length of the string is : {0}\n\n", l);
        Console.ReadKey();
    }
}