using System;

namespace calculate_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            Console.WriteLine("Enter 5 Numbers:");
            for (int i = 0; i < 5; i++)
            {
                int displayNum = i + 1;
                Console.WriteLine("Enter number " + displayNum);
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int sum = arrayCalc(numbers);
            Console.WriteLine("The sum of those numbers was: " + sum);
        }

        static int arrayCalc(int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum;
        }
    }
}
