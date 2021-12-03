using System;

namespace T01._Highest_and_Lowest03
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

            foreach (char symbol in numbers)
            {
                if (symbol >= 48 && symbol <= 57)
                {
                    int value = int.Parse(symbol.ToString());

                    if (value > maxVal)
                    {
                        maxVal = value;
                    }

                    if (value < minVal)
                    {
                        minVal = value;
                    }
                }
            }

            return string.Join(" ", maxVal, minVal);
        }
    }
}
