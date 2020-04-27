namespace Exercise
{
    using System.Text.RegularExpressions;
    public class Checker
    {
        public bool DayOfWeek(string str)
        {
            Regex dow = new Regex("^(mon|tue|wed|thu|fri|sat|sun)$");
            if (dow.IsMatch(str))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool AllVowels(string str)
        {
            Regex allowVoffels = new Regex("^[a|e|i|o|u|A|E|I|O|U]*$");

            if (allowVoffels.IsMatch(str))
            {
                return true;
            }
            return false;


        }

        public bool TimeOfDay(string str)
        {
            Regex tOD = new Regex("^([0-1]?[0-9]|2[0-3]):[0-5][0-9]:[0-5][0-9]$");

            if (tOD.IsMatch(str))
            {
                return true;
            }
            return false;
        }
    }
}