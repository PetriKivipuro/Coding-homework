using System;
using System.IO;
using System.Collections.Generic;

namespace sandbox
{
    using OuterNamespace.InnerNamespace;
    using OuterNamespace;
    class Program
    {
        static void Main(string[] args)
        {
            // Displays "ExampleMethod in "
            Example outer = new Example();
            outer.ExampleMethod();

            // Displays "ExampleMethod in InnerNamespace."
            ExampleInner inner = new ExampleInner();
            inner.ExampleMethod();
        }
    }
}