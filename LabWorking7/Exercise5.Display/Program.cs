namespace Exercise5.InterfaceWork
{
    class Program
    {
        private static void Main(string[] args)
        {
            int num = 65;
            string str = "A String";
            Coordinate coordinate = new Coordinate(21.0, 68.0);
            Display.IsItFormattable(num);
            Display.IsItFormattable(str);
            Display.IsItFormattable(coordinate);
        }
    }
}
