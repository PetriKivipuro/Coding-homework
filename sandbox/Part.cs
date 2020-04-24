namespace sandbox
{
    public class Part
    {

        protected string identifier { get; }
        public string manufacturer { get; }
        public string description { get; }

        public Part(string identifier, string manufacturer, string description)
        {
            this.identifier = identifier;
            this.manufacturer = manufacturer;
            this.description = description;
        }

    }
}
