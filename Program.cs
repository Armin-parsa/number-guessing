using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.green;
            Console.WriteLine("welcole to the guessing number game. you should guess your nymber and system say to you this number is big or no.");
            Console.WriteLine("you can guess 10 number if you cant say correct number you will failed");
            Console.WriteLine("you can find me with this email arminparsa789@gmail.com")
            Random randome = new Random();
            int randomenumber = randome.Next(1, 100);
        label1:
            try
            {
                int p = 10;
                int l = 0;
                while (l < p)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    int x = int.Parse(Console.ReadLine());
                    if (randomenumber < x)
                    {
                        Console.WriteLine("you should wright smaller than this number");
                    }
                    if (randomenumber > x)
                    {
                        Console.WriteLine("you should wright bigger than this number");
                    }
                    if (randomenumber == x)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("your number accept");
                        return;
                    }
                    l += 1;
                }
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine("you should write number.");
                Console.ReadKey();
                goto label1;
                Console.Clear();
                throw;
            }
            
            
        }
    }
}


