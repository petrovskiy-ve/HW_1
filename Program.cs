// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;

public class HW1
{
    public static long QueueTime(int[] customers, int n)
    {
        int time = 0;
        do
        {
            int busyCashiers = n > customers.Length ? customers.Length : n;
            for (int i = 0; i < busyCashiers; i++)
            {
                customers[i]--;
            }
            customers = Array.FindAll(customers, x => x != 0);

            time++;
        } while (customers.Length > 0);
        return time;
    }
}

class Program
{
    public static void Main()
    {
        Console.WriteLine(HW1.QueueTime(new int[] { 5, 3, 4 }, 1));
        Console.WriteLine(HW1.QueueTime(new int[] { 10, 2, 3, 3 }, 2));
        Console.WriteLine(HW1.QueueTime(new int[] { 2, 3, 10 }, 2));
    }
}