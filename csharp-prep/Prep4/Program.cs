using System;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        float x;
        float totalsum = 0;
        float LargestN = 0;
        List<float> numbers = new List<float>();
        Console.WriteLine("please enter items of a list. Type 0 when done");
        do
        {
            string y = Console.ReadLine();
            x = float.Parse(y);
            if (x != 0)
            {
                numbers.Add(x);
                totalsum += x;
                if (LargestN < x)
                {
                    LargestN = x;
                }
            }
            else
            {

            }
        } while (x != 0);
        // foreach (float number in numbers)
        // {
        //     Console.WriteLine(number);
        // }
        Console.WriteLine($"the sum is {totalsum}");
        Console.WriteLine($"the average is {totalsum / numbers.Count}");
        Console.WriteLine($"the largest number is {LargestN}");
    }
}