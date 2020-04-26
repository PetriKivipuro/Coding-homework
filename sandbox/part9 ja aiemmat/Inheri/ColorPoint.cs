namespace sandbox
{
    public class ColorPoint : Point
    {
        private string color;
        public ColorPoint(int x, int y, string color) : base(x, y)
        {
            this.color = color;
        }
        public override string ToString()
        {
            return base.ToString() + "color: " + color;
        }
    }
}