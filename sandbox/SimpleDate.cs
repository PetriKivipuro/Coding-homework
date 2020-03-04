using System;

namespace sandbox
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
    }
}