namespace sandbox
{
    public class Book : IStorable
    {
        public string author;
        public string name;
        public double weight;
        public Book(string author, string name, double weight)
        {
            this.author = author;
            this.name = name;
            this.weight = weight;
        }

        public double Weight()
        {
            return this.weight;
        }

        public override string ToString()
        {
            return this.author + ": " + this.name;
        }
    }
}