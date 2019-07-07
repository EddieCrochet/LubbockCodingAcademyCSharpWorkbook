using System;

namespace W1D1Pre
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "100";
            int myInt = 30;

            int myResult = myInt + int.Parse(myString);
            Console.WriteLine(myResult);
        }
    }
}
