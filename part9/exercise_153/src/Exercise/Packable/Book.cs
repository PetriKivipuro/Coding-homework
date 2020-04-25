namespace Exercise
{
    public class Book : IPackable
    {
        private string author;
        private string nameOfBook;
        private int publishYear;
        private int paino;

        public Book(string s, string s2, int i)
        {
            this.author = s;
            this.nameOfBook = s2;
            this.publishYear = i;
            this.paino = 1;
        }

        public int Weight()
        {
            return this.paino;
        }

        public override string ToString()
        {
            return this.author + ": " + this.nameOfBook + " (" + this.publishYear + ")";
        }
    }
}