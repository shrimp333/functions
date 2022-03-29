using System;

namespace add_nums_task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the numbers you want to add");
            Console.WriteLine("Please Input Number 1");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Input Number 2");
            int second = int.Parse(Console.ReadLine());
            int answer = Add(first,second);
            Console.WriteLine("The answer is: " + answer);
        }
        static int Add(int first, int second)
        {
            int answer = first + second;
            return answer;
        }
    }
}
