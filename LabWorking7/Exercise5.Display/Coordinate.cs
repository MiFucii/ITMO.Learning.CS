using System;

namespace Exercise5.InterfaceWork
{
    class Coordinate : IPrintable
    {
        private double x;
        private double y;

        public Coordinate()
        {
            this.x = 0.0;
            this.y = 0.0;
        }

        public Coordinate(double px, double py)
        {
            this.x = px;
            this.y = py;
        }

        public void Print() => Console.WriteLine("({0},{1})", this.x, this.y);
    }
}
