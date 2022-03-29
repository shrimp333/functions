using System;

namespace powers_task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            
        
            Console.WriteLine("Enter the numbers");
            Console.WriteLine("Please Input the Number");
            double first = double.Parse(Console.ReadLine());
            Console.WriteLine("Please Input Exponent");
            double second = double.Parse(Console.ReadLine());
            double answer = Power(first,second);
            Console.WriteLine("The answer is: " + answer);
        }
        static double Power(double first, double second)
        {
            double answer = Math.Pow(first, second);
            return answer;
        }
        
    }
}
