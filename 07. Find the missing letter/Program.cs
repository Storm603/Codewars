using System;
using System.Linq;

namespace _07._Find_the_missing_letter
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] array = Console.ReadLine().ToCharArray();
            Console.WriteLine(FindMissingLetter(array));
        }

        public static char FindMissingLetter(char[] array)
        {
            int zero = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                char currcharNum = array[i];
                if (zero + i != currcharNum)
                {
                    currcharNum--;
                    return char.Parse(currcharNum.ToString());
                }
            }

            return ' ';
        }
    }
}
