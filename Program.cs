using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input : ");

            // int a = Convert.ToInt32(Console.ReadLine());
            string a = Console.ReadLine();
            if (a == "quit")
            {
                Environment.Exit(0);
            }
            if (!int.TryParse(a, out int value))
            {
                Console.WriteLine("Invalid number");
                Environment.Exit(0);
            }
            int d = int.Parse(a);
            int b = Convert.ToInt32(Check_Prime(d));
            if (b == 0)
            {
                Console.WriteLine(a + " is not prime number");
            }
            else
            {
                Console.WriteLine(a + " is prime number");
            }
            if (b != 0)
            {
                for (int i = 0; i < d - 1; i++)
                {
                    if (d == (Math.Pow(2, i) + 1) || d == (Math.Pow(2, i) - 1))
                    {
                        Console.WriteLine(a + " is Mresenne prime number");
                    }
                }
            }
        }
        static int Check_Prime(int n)
        {
            int j;
            for (j = 2; j <= n - 1; j++)
            {
                if (n % j == 0)
                {
                    return 0;
                }
            }
            if (j == n)
            {
                return 1;
            }
            return 0;
        }
    }
}
