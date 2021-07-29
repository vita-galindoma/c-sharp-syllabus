using System;
using System.IO;


namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText("../../lear.txt");

            int countLines = text.Split('\n').Length;
            Console.WriteLine($"Lines = {countLines}");

            string[] wordsArray = text.Replace("'", " ").Replace("  ", " ").Split(' ', '\n');
            int countWords = 0;
            foreach (var words in wordsArray)
            {
                countWords++;
            }
            Console.WriteLine($"Words = {countWords}");
            
            int countChar = text.Length;
            Console.WriteLine($"Chars = {countChar}");

            Console.ReadKey();
        }
    }
}
