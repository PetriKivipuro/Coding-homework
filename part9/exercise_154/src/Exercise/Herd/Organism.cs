namespace Exercise
{
    public class Organism : IMovable
    {
        private int xAxis;
        private int yAxis;

        public Organism(int x, int y)
        {
            this.xAxis = x;
            this.yAxis = y;
        }
        public void Move(int dx, int dy)
        {
            this.xAxis += dx;
            this.yAxis += dy;
        }

        public override string ToString()
        {
            return "x: " + this.xAxis + "; y: " + this.yAxis;
        }
    }
}