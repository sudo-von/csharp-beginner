using System;

namespace _06_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = null;
            if(string.IsNullOrEmpty(str))
            {
                Console.WriteLine("String is null or empty");
            }

            string str2 = "";
            if(string.IsNullOrWhiteSpace(str2))
            {
                Console.WriteLine("String is null or WhiteSpace");
            }
        }
    }
}
