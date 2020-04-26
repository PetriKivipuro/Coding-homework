using System;
using System.Collections.Generic;

namespace sandbox
{
    public class Engine : Part
    {
        public string engineType { get; }

        public Engine(string engineType, string id, string manufacturer, string description) : base(id, manufacturer, description)
        {
            this.engineType = engineType;
        }
        public override string ToString()
        {
            return this.engineType + "-" + this.identifier + this.manufacturer;
        }

    }
}