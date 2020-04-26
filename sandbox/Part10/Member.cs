namespace sandbox
{
    // IComparable is in System
    using System;
    using System.Collections.Generic;
    // Implement IComparable<Member>
    // Explicit comparison to Member, not other objects
    public class Member : IComparable<Member>
    {
        public string name { get; }
        public int height { get; }

        // Basic constructor
        public Member(string name, int height)
        {
            this.name = name;
            this.height = height;
        }

        public int CompareTo(Member member)
        {

            return this.height * 10 - member.height * 10;
        }

        // Basic ToString
        public override string ToString()
        {
            return this.name + " (" + this.height + ")";
        }
    }

}