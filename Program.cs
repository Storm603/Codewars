using System;
using System.Linq;

namespace codewarstraining
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Find(Console.ReadLine().Split(", ").Select(int.Parse).ToArray()));
        }
        public static int Find(int[] integers)
        {
            int count = integers.Count(x => x % 2 == 0);

            for (int i = 0; i < integers.Length; i++)
            {
                if (integers[i] % 2 == 0 && count == 1)
                {
                    return integers[i];
                }
                else if (integers[i] % 2 == 1 && count > 1)
                {
                    return integers[i];
                }
            }
            return -1;
        }
    }
}
