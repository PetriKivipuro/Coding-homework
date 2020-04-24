namespace sandbox
{
    using System;

    public class Point
    {

        private int x;
        private int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }


        public int ManhattanDistanceFromOrigin() // methodi
        {
            return Math.Abs(x) + Math.Abs(y);
        }
        protected string Location()
        {
            return x + ", " + y;
        }
        public override string ToString()
        {
            return "(" + this.Location() + ")" + this.ManhattanDistanceFromOrigin();
        }
    }
}