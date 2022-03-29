using System;

namespace factorial_task_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number you want to find the factorial of:");
            int num = int.Parse(Console.ReadLine());
            int fact = factorial(num);
            Console.WriteLine("The factorial is: " + fact);
        }
        static int factorial(int num)
        {
            int fact = 1;
            for (int i = 1; i <= num; i++)
            {
                
                fact = fact * i;
            }
            return fact;
        }
    }
}
