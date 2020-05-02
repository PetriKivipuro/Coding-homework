namespace sandbox
{
    using System;
    public class Grade
    {
        public int grade { get; }

        public Grade(int grade)
        {
            if (grade < 0 || grade > 5)
            {
                throw new ArgumentException("Grade must be between 0 and 5.");
            }
            this.grade = grade;
        }
    }
}