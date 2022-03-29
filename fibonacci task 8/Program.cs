using System;
using System.Collections.Generic;

namespace fibonacci_task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number of Fibonacci Series");
            int num = int.Parse(Console.ReadLine());
            int[] numFib = new int[num];
            numFib = Fibonacci(num);
            Console.WriteLine("Fibonacci Series of " + num + " numbers is:");
            foreach (int i in numFib)
            {
                Console.WriteLine(i);
            }
        }

        static int[] Fibonacci(int num)
        {
            List<int> FibonacciList = new List<int>();
            FibonacciList.Add(0);
            FibonacciList.Add(1);
            int sum;
            for (int i = 2; i < num; i++)
            {
                sum = FibonacciList[i - 2] + FibonacciList[i-1];
                FibonacciList.Add(sum);
            }
            int[] FibonacciArray = FibonacciList.ToArray();
            return FibonacciArray;
        }

    }
}
