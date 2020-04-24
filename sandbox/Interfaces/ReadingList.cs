
using System.Collections.Generic;
namespace sandbox

{
    public class ReadingList : IReadable
    {
        private List<IReadable> readables;

        public ReadingList()
        {
            this.readables = new List<IReadable>();
        }

        public void Add(IReadable readable)
        {
            this.readables.Add(readable);
        }

        public int ToRead()
        {
            return this.readables.Count;
        }

        public string Read()
        {
            string read = "";

            foreach (IReadable readable in this.readables)
            {
                read = read + readable.Read() + "\n";
            }

            // once the reading list has been read, we empty it
            this.readables.Clear();
            return read;
        }
    }
}