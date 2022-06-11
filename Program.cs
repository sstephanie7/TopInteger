using System;
using System.Linq;

namespace TopInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < inputArray.Length; i++)
            {
                bool currIterationBiggestNum = true; 
                for (int k = i + 1; k < inputArray.Length; k++)
                {
                    if (inputArray[i] <= inputArray[k])
                    {
                        currIterationBiggestNum = false;
                    }
                }
                if (currIterationBiggestNum)
                {
                    Console.Write($"{inputArray[i]} ");
                }
            }
        }
    }
}
