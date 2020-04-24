using System.Collections.Generic;
using System;

namespace sandbox
{
    public class Packer
    {
        private Factory factory;

        public Packer()
        {
            this.factory = new Factory();
        }

        public List<IStorable> GiveAListOfThings()
        {
            List<IStorable> list = new List<IStorable>();

            int i = 0;
            while (i < 10)
            {
                IStorable newThing = factory.ProduceNew();
                list.Add(newThing);

                i = i + 1;
            }

            return list;
        }
    }
}