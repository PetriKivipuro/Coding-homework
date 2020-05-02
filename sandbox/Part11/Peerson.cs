namespace sandbox

{
    using System;
    public class Peerson
    {

        public string name { get; }
        public int age { get; }

        public Peerson(string name, int age)
        {
            this.name = name;
            this.age = age;



            if (this.name == null || this.name.Length > 40 || this.age > 120 || this.age < 0)
            {
                throw new ArgumentException("Give a real name.");
            }




        }



    }
}