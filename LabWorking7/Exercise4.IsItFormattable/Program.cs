using System;

namespace Exercise4.IsItFormattable
{
    class Program
    {
        private static void Main(string[] args)
        {
            int i = 0;
            ulong u = 0;
            string s = "Test";
            Console.WriteLine("int: {0}", IsItFormattable.Formattable(i));
            Console.WriteLine("ulong: {0}", IsItFormattable.Formattable(u));
            Console.WriteLine("String: {0}", IsItFormattable.Formattable(s));
        }
    }
}
