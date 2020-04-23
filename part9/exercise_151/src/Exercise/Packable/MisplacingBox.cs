namespace Exercise
{
    using System.Collections.Generic;
    public class MisplacingBox : Box
    {

        private List<Item> missinBoxie;
        public MisplacingBox()
        {
            this.missinBoxie = new List<Item>();
        }

        public override void Add(Item item)
        {
            this.missinBoxie.Add(item);
        }


        public override bool IsInBox(Item item)
        {
            return false;
        }
    }
}