using System;

namespace Exercise5.InterfaceWork
{
    class Display
    {
        public static void IsItFormattable(object x)
        {
            if (x is IPrintable printable)
                printable.Print();
            else
                Console.WriteLine(x.ToString());
        }
    }
}
