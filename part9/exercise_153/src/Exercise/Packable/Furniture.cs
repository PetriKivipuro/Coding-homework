namespace Exercise
{
    public class Furniture : IPackable
    {
        private string furnitureType;
        private string color;
        private int weight;

        public Furniture(string s, string s2, int i)
        {
            this.furnitureType = s;
            this.color = s2;
            this.weight = i;
        }

        public int Weight()
        {
            return this.weight;
        }

        public override string ToString()
        {
            return this.color + " " + this.furnitureType + " - weight " + this.weight + " kg";

        }
    }
}