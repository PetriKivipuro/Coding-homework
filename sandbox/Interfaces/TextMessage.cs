namespace sandbox
{
    public class TextMessage : IReadable
    {
        public string sender { get; }
        public string content;

        public TextMessage(string sender, string content)
        {
            this.sender = sender;
            this.content = content;
        }

        public string Read()
        {
            return this.content;
        }
    }
}