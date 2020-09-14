using System;
using System.Diagnostics;

namespace CSHARPBASIC
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("hello enter your name?");
            string name =Console.ReadLine();
            Console.WriteLine("hi, "+ name);

     Console.WriteLine("Hello World!");

        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}
