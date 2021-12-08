using System;

namespace T04._Facebook_Like_System
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = Console.ReadLine().Split();

            string answer = String.Empty;

            if (name.Length == 0)
            {
                answer = "no one likes this";
            }
            else if (name.Length == 1)
            {
                answer = $"{name[0]} likes this";
            }
            else if (name.Length == 2)
            {
                answer = $"{name[0]} and {name[1]} like this";   
            }
            else if (name.Length == 3)
            {
                answer = $"{name[0]}, {name[1]} and {name[2]} like this";
            }
            else if (name.Length > 3)
            {
                answer = $"{name[0]}, {name[1]} and {name.Length-2} others like this";
            }
            //return answer; 
        }
    }
}
