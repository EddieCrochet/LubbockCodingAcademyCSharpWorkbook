using System;

namespace W1D2Pre
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "Hello world! It is a beautiful day!! Yippee!!!";
            string[] stringArray = sentence.Split('!');
            foreach (string s in stringArray)
            {
                Console.WriteLine(s);
            }
        }
    }
}
