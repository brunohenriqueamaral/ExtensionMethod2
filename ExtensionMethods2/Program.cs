using System;
using ExtensionMethods2.Extensions;

namespace ExtensionMethods2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Good morning dears!";
            Console.WriteLine(s1.Cut(10));   
        }
    }
}
