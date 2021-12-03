using System;
using System.Xml.Linq;

namespace T02._Exes_and_Ohs
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(XO(input));
        }

        public static bool XO(string input)
        {
            input = input.ToLower();

            int xCount = 0;
            int oCount = 0;

            foreach (char symbol in input)
            {
                if (symbol == 'x')
                {
                    xCount++;
                }
                else if (symbol == 'o')
                {
                    oCount++;
                }
            }

            if (!input.Contains('o') && !input.Contains('x'))
            {
                return true;
            }

            if (oCount == xCount)
            {
                return true;
            }
            return false;
            
        }
    }
}
