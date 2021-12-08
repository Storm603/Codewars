using System;
using System.Numerics;

namespace T03._Bit_Counting
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int oneCounter = 0;

            while (n > 0)
            {
                int remainder = n % 2;
                n /= 2;
                if (remainder == 1) oneCounter++;
            }

            Console.WriteLine(oneCounter);

        }
    }
}
