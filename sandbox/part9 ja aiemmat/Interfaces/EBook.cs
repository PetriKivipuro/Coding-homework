namespace sandbox
{
    using System.Collections.Generic;
    public class EBook : IReadable
    {
        public string name { get; }
        private List<string> pages;
        private int pageNumber;

        public EBook(string name, List<string> pages)
        {
            this.name = name;
            this.pages = pages;
            this.pageNumber = 0;
        }

        public int Pages()
        {
            return this.pages.Count;
        }

        public string Read()
        {
            string page = this.pages[this.pageNumber];
            NextPage();
            return page;
        }

        private void NextPage()
        {
            this.pageNumber = this.pageNumber + 1;
            if (this.pageNumber % this.pages.Count == 0)
            {
                this.pageNumber = 0;
            }
        }
    }
}