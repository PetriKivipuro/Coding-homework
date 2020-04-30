namespace Exercise
{
    using System;
    public class Person
    {

        public string name { get; }
        public int age { get; }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;

            if (this.name == null || this.name == "" || this.name.Length > 40 || this.age > 120 || this.age < 0)
            {
                throw new ArgumentException("Name or age is wrong");
            }

        }



    }
}
