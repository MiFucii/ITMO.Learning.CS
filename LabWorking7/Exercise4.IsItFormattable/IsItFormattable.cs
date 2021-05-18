using System;

namespace Exercise4.IsItFormattable
{
    class IsItFormattable
    {
        public static bool Formattable(object x)
        {
            bool flag = false;
            if (x is IFormattable)
                flag = true;
            return flag;
        }
    }
}
