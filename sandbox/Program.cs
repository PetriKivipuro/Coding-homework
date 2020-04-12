using System;
using System.Collections.Generic;



namespace sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskTracker trak = new TaskTracker();

            trak.Add("ada", 5);
            trak.Add("ada2", 6);
            trak.Add("ada3", 58);
            trak.Add("ada4", 45);
            trak.Add("pekka", 100);

            trak.Print();



        }
    }
}