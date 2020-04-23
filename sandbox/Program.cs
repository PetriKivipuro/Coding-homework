using System;
using System.Collections.Generic;



namespace sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInterface userInterface = new UserInterface();
            userInterface.AddOperation(new PlusOperation());
            userInterface.AddOperation(new PlusOperation());
            userInterface.AddOperation(new PlusOperation());
            userInterface.AddOperation(new PlusOperation());
            userInterface.AddOperation(new PlusOperation());
            userInterface.AddOperation(new PlusOperation());

            userInterface.Start();
        }
    }
}