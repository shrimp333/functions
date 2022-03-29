using System;
using System.Collections.Generic;

namespace recursive_fibonacci_task_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number you want to find the fibonacci number of: ");
            int num = Fibonacci(int.Parse(Console.ReadLine()));
            Console.WriteLine("Fibonacci number is: " + num);
        }

        static int Fibonacci(int num)
        {
            List<int> FibonacciList = new List<int>();
            FibonacciList.Add(0);
            FibonacciList.Add(1);
            int sum = 0;
            for (int i = 2; i <= num; i++)
            {
                sum = FibonacciList[i - 2] + FibonacciList[i-1];
                FibonacciList.Add(sum);
            }
            return sum;
        }
    }
}
