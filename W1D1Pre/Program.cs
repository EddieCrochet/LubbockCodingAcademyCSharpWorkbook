using System;

namespace W1D1Pre
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInt = 30;
            string myString = "100";

            int myResult = myInt + int.Parse(myString);
            Console.WriteLine(myString);
            Console.WriteLine(myResult);
        }
    }
}
