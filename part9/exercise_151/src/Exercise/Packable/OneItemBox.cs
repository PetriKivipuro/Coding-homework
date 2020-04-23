namespace Exercise
{
    public class OneItemBox : Box
    {
        private Item capacityOne;
        public OneItemBox()
        {
            this.capacityOne = null;
        }

        public override void Add(Item item)
        {
            if (this.capacityOne == null)
            {
                this.capacityOne = item;
            }
        }


        public override bool IsInBox(Item item)
        {
            if (this.capacityOne.Equals(item))
            {
                return true;
            }
            return false;
        }
    }
}