using System;
using System.Collections.Generic;

namespace T01._Highest_and_Lowest02
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();

            Console.WriteLine(HighAndLow(numbers));
        }


        public static string HighAndLow(string numbers)
        {
            int minVal = Int32.MaxValue;
            int maxVal = Int32.MinValue;

            List<int> numberos = new List<int>();

            foreach (char number in numbers)
            {
                if (number >= 48 && number <= 57)
                {
                    numberos.Add(int.Parse(number.ToString()));
                }
            }

            for (int i = 0; i < numberos.Count; i++)
            {
                if (numberos[i] > maxVal)
                {
                    maxVal = numberos[i];
                }

                if (numberos[i] < minVal)
                {
                    minVal = numberos[i];
                }
            }

            return string.Join(" ", maxVal, minVal);
        }
    }
}
