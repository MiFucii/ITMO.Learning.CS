namespace Exercise2.Reverse
{
    class Reverse
    {
        public static void ReversStrn(ref string revers)
        {
            string str = "";
            for (int index = revers.Length - 1; index >= 0; --index)
                str += revers[index].ToString();
            revers = str;
        }
    }
}

