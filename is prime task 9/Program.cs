using System;

namespace is_prime_task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to check if it is a prime:");
            int num = int.Parse(Console.ReadLine());
            bool isTrue = IsPrime(num);
            if (isTrue == true)
            Console.WriteLine("That is a prime number");
            else
            Console.WriteLine("That is not a prime number");
        }
        
        static bool IsPrime(int n)
        {
            if (n == 2 || n == 3)
                return true;

            if (n <= 1 || n % 2 == 0 || n % 3 == 0)
                return false;

            for (int i = 5; i * i <= n; i += 6)
            {
                if (n % i == 0 || n % (i + 2) == 0)
                    return false;
            }

            return true;
        }
        //function appropriated from https://en.wikipedia.org/wiki/Primality_test#C#,_C++_&_C
    }
}
