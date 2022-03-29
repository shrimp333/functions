using System;

namespace space_counter_task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a sentence:");
            string words = Console.ReadLine();
            int count = SpaceCount(words);
            Console.WriteLine("The amount of spaces in your sentence was: " + count);
        }
        
        static int SpaceCount(string words)
        {
            int count = 0;
            foreach (char i in words)
            {
                if (i == ' ')
                count++;
            }
            
            return count;
        }
    }
}
