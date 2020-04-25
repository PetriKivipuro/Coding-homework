namespace Exercise
{
    public class TripleTacoBox : ITacoBox
    {

        private int boxAmount;

        public TripleTacoBox()
        {
            this.boxAmount = 3;
        }

        public int TacosRemaining()
        {
            return this.boxAmount;
        }

        public void Eat()
        {
            if (boxAmount > 0)
            {
                this.boxAmount -= 1;
            }

        }
    }
}