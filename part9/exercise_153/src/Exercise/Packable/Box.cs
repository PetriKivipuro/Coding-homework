using System.Collections.Generic;

namespace Exercise
{
    public class Box : IPackable
    {
        private int tilavuus;
        private List<IPackable> list;
        public Box(int i)
        {
            this.tilavuus = i;
            this.list = new List<IPackable>();
        }

        public void Add(IPackable item)
        {
            if (this.Weight() + item.Weight() <= this.tilavuus)
            {
                this.list.Add(item);
            }
        }

        public int Weight()
        {
            int weightOfBox = 0;
            foreach (IPackable item in this.list)
            {
                weightOfBox += item.Weight();
            }
            return weightOfBox;
        }

        public override string ToString()
        {
            return this.list.Count + " items, total weight " + Weight() + " kg"; ;
        }
    }
}