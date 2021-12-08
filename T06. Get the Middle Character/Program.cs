using System;

namespace T06._Get_the_Middle_Character
{
    class Program
    {
        static void Main(string[] args)      // UNFINISHED
        {
            string s = Console.ReadLine();

            string characters = String.Empty;

            if (s.Length == 1)
            {
                Console.WriteLine(s);
            }
            else if (s.Length % 2 == 0)
            {
                characters = $"{s[(s.Length / 2) - 1]}{s[s.Length / 2]}";
            }
            else
            {
                characters += s[s.Length / 2];
            }

            Console.WriteLine(characters);
        }
    }
}
