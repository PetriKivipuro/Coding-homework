using System;
using System.Collections.Generic;


namespace sandbox
{
    public class Person11 : IIdentifiable, IComparable<Person11>
    {
        public string name { get; }
        public string socialSecurityNumber { get; }

        public Person11(string name, string socialSecurityNumber)
        {
            this.name = name;
            this.socialSecurityNumber = socialSecurityNumber;
        }

        public string GetId()
        {
            return this.socialSecurityNumber;
        }

        public int CompareTo(Person11 another)
        {
            if (this.name == another.name)
            {
                return this.socialSecurityNumber.CompareTo(another.socialSecurityNumber);
            }
            return this.name.CompareTo(another.name);
        }
    }
}
