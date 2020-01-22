using System;

namespace exercise_10
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Write your code here:
            Console.WriteLine("I will tell a story, but I need some information.\nGive a name for main character:");
            string nimi = Console.ReadLine();
            
            Console.WriteLine("Give the character a profession:");
            string ammatti = Console.ReadLine();
            Console.WriteLine("Here is the story:");
            Console.WriteLine("Once upon a time there was a " + ammatti + " called " + nimi + "\n" + 
            "On her way to work, " + nimi + " often pondered what being " + ammatti + " meant to them.\n" + 
            "When you work as a " + ammatti + " you meet interesting people.\n" +
            nimi + " enjoys their work as " + ammatti + ", The end.");

                      

        }
    }
}
