namespace sandbox
{
    public class BaseClass
    {
        private string objectVariable;
        public BaseClass() : this("Esimerkki")
        {

        }
        public BaseClass(string value)
        {
            this.objectVariable = value;
        }

        public override string ToString()
        {
            return this.objectVariable;
        }
    }
}