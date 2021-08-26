using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    public class WordCountExt
    {
        public static int CalculateLineCount(string text)
        {
            int countLines = text.Split('\n').Length;
            return countLines;
        }
        public static int CalculateWordCount(string text)
        {
            string[] wordsArray = text.Replace("'", " ").Replace("  ", " ").Split(' ', '\n');
            int countWords = 0;
            foreach (var words in wordsArray)
            {
                countWords++;
            }
            return countWords;
        }

        public static int CalculateCharCount(string text)
        {
            int countChar = text.Length;
            return countChar;
        }
    }
}
