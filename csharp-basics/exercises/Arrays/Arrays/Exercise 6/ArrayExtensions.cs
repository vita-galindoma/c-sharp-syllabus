using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_6
{
    public class ArrayExtensions
    {
        public static int[] CreateRandomArray(int length)
        {
            int[] randomArray = new int[length];
            Random randomNum = new Random();
            for (int i = 0; i < randomArray.Length; i++)
            {
                randomArray[i] = randomNum.Next(1, 100);
            }
            return randomArray;
        }

        public static int[] CopyArray(int[] randomArray)
        {
            int[] copiedArray = new int[randomArray.Length];
            Array.Copy(randomArray, copiedArray, 10);
            copiedArray[^1] = -7;
            return copiedArray;
        }
    }
}
