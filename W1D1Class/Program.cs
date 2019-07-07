using System;

namespace W1D1Class
{
    class Program
    {
        static void Main(string[] args)
        {
            CatDog();
        }

        static void hello()
        {
            Console.WriteLine("Hello, User!");
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine("Bye {0}", userName);
        }

        static void CatDog()
        {
            Console.WriteLine("Do you prefer cats, or dogs????");
            string userResponse = Console.ReadLine();

            if (userResponse == "cats")
            {
                Console.WriteLine("MEOW");
            }
            else if (userResponse == "dogs")
            {
                Console.WriteLine("BARK");
            }
        }
    }
}
