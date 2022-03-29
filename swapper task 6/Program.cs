using System;

namespace swapper_task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int num2 = int.Parse(Console.ReadLine());
            int[] nums = swapper(num1,num2);
            for (int i = 0; i < 2; i++)
            {
                int displayNum = i + 1;
                Console.WriteLine(nums[i] + " is now in place: " + displayNum);
            }
        }

        static int[] swapper(int num1,int num2)
        {
            int[] nums = {num2,num1};
            return nums;
        }
    }
}
