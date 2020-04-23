namespace Exercise
{
    using System.Collections.Generic;
    public class BoxWithMaxWeight : Box
    {
        private int capacity;
        private int boxesTotalWeight;
        private List<Item> list;


        public BoxWithMaxWeight(int capacity)
        {
            this.capacity = capacity;
            this.boxesTotalWeight = 0;
            this.list = new List<Item>();
        }

        public override void Add(Item item)
        {
            if (this.capacity - this.boxesTotalWeight >= item.weight)
            {
                list.Add(item);
                this.boxesTotalWeight += item.weight;
            }
        }


        public override bool IsInBox(Item item)
        {
            return this.list.Contains(item);
        }
    }
}