using System;
public class MaxMin
{
    public static void Main()
    {
        int[] arr = new int[5] { 99, 95, 93, 89, 87 };
        int i, max, min, n;
        // size of the array
        n = 5;
        max = arr[0];
        min = arr[0];
        for (i = 1; i < n; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
            if (arr[i] < min)
            {
                min = arr[i];
            }
        }
        Console.Write("Maximum element = {0}\n", max);
        Console.Write("Minimum element = {0}\n\n", min);
        Console.ReadKey();
    }
}