using System;

namespace W1D2Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter an english word to convert to pig latin");
            string english = Console.ReadLine();
            string pigLatin = TranslateWord(english);
            Console.WriteLine(pigLatin);
        }

        public static string TranslateWord(string word)
        {
            string[] vowels = { "a", "e", "i", "o", "u", "y" };
            int firstLetterNum = Array.IndexOf(vowels, word.Substring(0, 1));
            int lastLetterNum = Array.IndexOf(vowels, word.Substring(word.Length - 1, 1));
            if(firstLetterNum>-1 && lastLetterNum>-1)
            {
                return word + "yay";
            }
            return word;
        }
    }
}
