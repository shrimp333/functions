using System;
using System.Collections.Generic;

namespace sum_of_num_task_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number");
            string num = Console.ReadLine();
            int sum = Sum(num);
            Console.WriteLine("The sum of those numbers was: " + sum);
        }
        static int Sum(string num)
        {
            int sum = 0;
            List<int> numList = new List<int>();
            foreach(char c in num)
            {
                string asString = c.ToString();
                int asInteger = int.Parse(asString);
                numList.Add(asInteger);
            }
            foreach(int i in numList)
                sum += i;
                return sum;
        }
    }
}
