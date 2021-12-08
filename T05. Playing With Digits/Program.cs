using System;

namespace T05._Playing_With_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            int p = int.Parse(Console.ReadLine());

            int sumOfN = 0;
            double currNum = 0;

            for (int i = 0; i < n.Length; i++)
            {
                int curNumConv = int.Parse(n[i].ToString());


                currNum = Math.Pow(curNumConv, p + 1);


                sumOfN += 0;
            }

        }
    }
}
