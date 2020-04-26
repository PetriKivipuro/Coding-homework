using System.Collections.Generic;
using System;
namespace sandbox
{
    public class Factory
    {
        public IStorable ProduceNew()
        {
            Random ticket = new Random();
            // increase the range by one
            int number = ticket.Next(0, 5);

            if (number == 0)
            {
                return new CD("Pink Floyd", "Dark Side of the Moon", 1973);
            }
            else if (number == 1)
            {
                return new CD("Wigwam", "Nuclear Nightclub", 1975);
            }
            else if (number == 2)
            {
                return new Book("Robert Martin", "Clean Code", 1);
            }
            else if (number == 3)
            {
                return new Book("Kent Beck", "Test Driven Development", 0.7);
            }
            else
            {
                return new ChocolateBar();
            }
        }
    }
}