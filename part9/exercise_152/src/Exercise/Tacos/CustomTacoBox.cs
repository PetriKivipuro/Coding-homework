namespace Exercise
{
    public class CustomTacoBox : ITacoBox
    {

        private int taco;
        public CustomTacoBox(int tacos)
        {
            this.taco = tacos;
        }

        public int TacosRemaining()
        {

            return this.taco;
        }

        public void Eat()
        {
            if (this.taco > 0)
            {
                this.taco -= 1;
            }
        }
    }
}