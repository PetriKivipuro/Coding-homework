namespace Exercise
{
    public class SimpleDate
    {
        private int day;
        private int month;
        private int year;

        public SimpleDate(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public override string ToString()
        {
            return this.day + "." + this.month + "." + this.year;
        }

        public bool Earlier(SimpleDate compared)
        {
            if (this.year < compared.year)
            {
                return true;
            }
            if (this.year == compared.year && this.month < compared.month)
            {
                return true;
            }
            if (this.year == compared.year && this.month == compared.month &&
                this.day < compared.day)
            {
                return true;
            }
            return false;
        }

        public override bool Equals(object compared)
        {
            // DO SOMETHING HERE
            if (this == compared)
            {
                return false;
            }
            if ((compared == null || !this.GetType().Equals(compared.GetType())))
            {
                return false;
            }
            else
            {
                SimpleDate compDate = (SimpleDate)compared;
                return this.year == compDate.year && this.month == compDate.month && this.day == compDate.day;
            }
        }

        public override int GetHashCode()
        {
            // DO SOMETHING HERE
            return this.day + this.month + this.year.GetHashCode();
        }

    }
}