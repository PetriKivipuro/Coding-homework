namespace Exercise
{
    using System.Collections.Generic;
    public class Herd : IMovable
    {


        private List<IMovable> group;

        public Herd()
        {

            this.group = new List<IMovable>();
        }

        public void AddToHerd(IMovable m)
        {
            this.group.Add(m);
        }

        public void Move(int dx, int dy)
        {
            foreach (IMovable unit in group)
            {
                unit.Move(dx, dy);
            }
        }

        public override string ToString()
        {
            string newLocation = "";

            foreach (IMovable member in group)
            {
                newLocation += member.ToString() + "\n";
            }
            return newLocation;
        }
    }
}