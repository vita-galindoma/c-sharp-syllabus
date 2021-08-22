using System;
using System.IO;


namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText("../../lear.txt");

            Console.WriteLine($"Lines = {WordCountExt.CalculateLineCount(text)}");
            Console.WriteLine($"Words = {WordCountExt.CalculateWordCount(text)}");
            Console.WriteLine($"Chars = {WordCountExt.CalculateCharCount(text)}");

            Console.ReadKey();
        }
    }
}
