namespace sandbox
{
    public class Student : Person
    {
        // object--> person --> student
        public int credits { get; set; }
        public Student(string name, string address) : base(name, address)
        {
            this.credits = 0;
        }

        public void Study()
        {
            this.credits++;
        }

        public override string ToString()
        {
            return base.ToString() + "kredits: " + this.credits;
        }
    }
}