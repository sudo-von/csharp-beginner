using System;

namespace _05_programming_constructs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display a simple message to the user.
            Console.WriteLine("***** My First C# App *****");
            Console.WriteLine("Hello World!");
            Console.WriteLine();
            // Wait for Enter key to be pressed before shutting down.
            Console.ReadLine();
            // Process any incoming args.
            for (int j = 0; j < args.Length; j++)
            {
                Console.WriteLine("Arg: {0}", args[j]);
            }
            Console.ReadLine();
            // Default literal.
            int defaultInt = default;
            Console.WriteLine(defaultInt);
            Console.WriteLine("=> Using new to create variables:");
            bool b = new bool();              // Set to false.
            int i = new int();                // Set to 0.
            double d = new double();          // Set to 0.
            DateTime dt = new DateTime();     // Set to 1/1/0001 12:00:00 AM
            Console.WriteLine("{0}, {1}, {2}, {3}", b, i, d, dt);
            Console.WriteLine();
            Console.WriteLine("=> System.Object Functionality:");
            // A C# int is really a shorthand for System.Int32,
            // which inherits the following members from System.Object.
            Console.WriteLine("12.GetHashCode() = {0}", 12.GetHashCode());
            Console.WriteLine("12.Equals(23) = {0}", 12.Equals(23));
            Console.WriteLine("12.ToString() = {0}", 12.ToString());
            Console.WriteLine("12.GetType() = {0}", 12.GetType());
            Console.WriteLine();
            Console.WriteLine("=> char type Functionality:");
            char myChar = 'a';
            Console.WriteLine("char.IsDigit('a'): {0}", char.IsDigit(myChar));
            Console.WriteLine("char.IsLetter('a'): {0}", char.IsLetter(myChar));
            Console.WriteLine("char.IsWhiteSpace('Hello There', 5): {0}",
            char.IsWhiteSpace("Hello There", 5));
            Console.WriteLine("char.IsWhiteSpace('Hello There', 6): {0}",
            char.IsWhiteSpace("Hello There", 6));
            Console.WriteLine("char.IsPunctuation('?'): {0}",
            char.IsPunctuation('?'));
            Console.WriteLine();
            Console.WriteLine("=> Data type parsing:");
            bool bb = bool.Parse("True");
            Console.WriteLine("Value of b: {0}", bb);
            double dd = double.Parse("99.884");
            Console.WriteLine("Value of d: {0}", dd);
            int ii = int.Parse("8");
            Console.WriteLine("Value of i: {0}", ii);
            char cc = Char.Parse("w");
            Console.WriteLine("Value of c: {0}", cc);
            Console.WriteLine();
        }
    }
}
