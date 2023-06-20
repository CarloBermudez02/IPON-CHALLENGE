using System;

namespace IponChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Ipon Challenge!");

            bool Exit = true;
            while (Exit)
            {
                Console.WriteLine("\nChoose your daily ipon:");
                Console.WriteLine("1. 10 PHP");
                Console.WriteLine("2. 20 PHP");
                Console.WriteLine("3. 50 PHP");
                Console.WriteLine("4. Exit");

                Console.Write("\nChoose an amount: ");
                int ipon = Convert.ToInt32(Console.ReadLine());

                if (ipon == 1)
                {
                    int total = 10 * 365;
                    Console.WriteLine("Expected Ipon: " + total);
                }
                else if (ipon == 2)
                {
                    int total = 20 * 365;
                    Console.WriteLine("Expected Ipon: " + total);
                }
                else if (ipon == 3)
                {
                    int total = 50 * 365;
                    Console.WriteLine("Expected Ipon: " + total);
                }
                else if (ipon == 4)
                {
                    Exit  = false;
                    Console.WriteLine("\nThank you for using our service!");
                }
                else 
                {
                    Console.WriteLine("Invalid input");
                }

            }
        }
    }
}
