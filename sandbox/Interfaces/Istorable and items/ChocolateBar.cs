namespace sandbox
{
    public class ChocolateBar : IStorable
    {
        // Because C#'s automatically generated default constructor is enough,
        // we don't need a constructor

        public double Weight()
        {
            return 0.2;
        }

        public override string ToString()
        {
            return "Candybar, weight: " + Weight();
        }
    }
}