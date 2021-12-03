using System;
using System.Linq;

namespace T01._Highest_and_Lowest
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();

            Console.Write(HighAndLow(numbers));
        }

        public static string HighAndLow(string numbers)
        {

            string[] number = numbers.Split();

            int[] converted = new int[number.Length];

            for (int i = 0; i < number.Length; i++)
            {
                converted[i] = int.Parse(number[i]);
            }

            int highest = converted.Max(x => x);
            int lowest = converted.Min(x => x);

            string result = $"{highest} {lowest}";

            return result;
        }
    }
}
