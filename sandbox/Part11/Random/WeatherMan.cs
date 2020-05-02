namespace sandbox
{
    using System;

    public class WeatherMan

    {
        private Random random;
        public WeatherMan()
        {
            this.random = new Random();
        }
        public string Forecast()
        {
            double propability = this.random.NextDouble();

            if (propability <= 0.1)
            {
                return "it rains";
            }
            else if (propability <= 0.2)
            {
                return "Snows";
            }
            else
            {
                return "Sunny is the weather";
            }
        }
    }
}