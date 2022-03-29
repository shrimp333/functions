using System;

namespace welcomename2
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Hello, Please enter your name:");
          string PersonName = Console.ReadLine();
          Welcome(PersonName);
        }

        static void Welcome(string name)
        {
            Console.WriteLine("Welcome " + name);
            Console.WriteLine("Have a nice day!");
        }
    }
}
