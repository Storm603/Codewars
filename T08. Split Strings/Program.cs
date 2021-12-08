using System;

namespace T08._Split_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            Console.WriteLine(string.Join(", ", Solution(str)));
        }

        public static string[] Solution(string str)
        {
            int groups = str.Length / 2;
            if (str.Length % 2 == 1) groups++;

            string[] arr = new string[groups];

            int count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (i > 0 && i % 2 == 1)
                {
                    arr[count] = $"{str[i - 1]}{str[i]}";
                    count++;
                }

                else if (i == str.Length -1)
                {
                    arr[count] = $"{str[i]}_";
                }
            }

            return arr;
        }
    }
}
