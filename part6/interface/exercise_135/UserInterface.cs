using System;

namespace exercise_135
{
  public class UserInterface
  {
    private JokeManager jokes;
    // tässä alla on nyt se konstruktori!!!
    public UserInterface(JokeManager jokes)
    {
      this.jokes = jokes;
    }

    public void Start()
    {
      while (true)
      {
        Console.WriteLine("Commands:");
        Console.WriteLine(" 1 - add a joke");
        Console.WriteLine(" 2 - draw a joke");
        Console.WriteLine(" 3 - list jokes");
        Console.WriteLine(" X - stop");

        string command = Console.ReadLine();

        if (command == "X" || command == "x")
        {
          break;
        }
        if (command == "1")
        {
          Console.WriteLine("Write the joke to be added:");
          jokes.AddJoke(Console.ReadLine());
        }
        else if (command == "2")
        {
          Console.WriteLine("Drawing a joke.");
          Console.WriteLine(jokes.DrawJoke());

        }
        else if (command == "3")
        {
          Console.WriteLine("Printing the jokes.");
          jokes.PrintJokes();

        }
      }
    }
  }
}