using System;
using System.Collections.Generic;

namespace exercise_111
{
  class Program
  {
    public static void Main(string[] args)
    {
      // IMPLEMENT YOUR CODE IN HERE!
      List<PersonalInformation> list = new List<PersonalInformation>();

      while (true)
      {

        Console.WriteLine("First name:");
        string firstName = Console.ReadLine();

        if (firstName == "")
        {
          break;
        }

        Console.WriteLine("Last name:");
        string lastName = Console.ReadLine();

        Console.WriteLine("Identification number:");
        string identificationNumber = Console.ReadLine();
        // tässä lisätään tiedot PersonalInformaatio luokkaan
        list.Add(new PersonalInformation(firstName, lastName, identificationNumber));
        // tämän jälkeen kyselykierros alkaa uudelleen ja jos etunimi on "tyhjä"
        // siirrytään eteenpäin
      }
      Console.WriteLine(); //yksi tyhjä rivi selventämään

      foreach (PersonalInformation pif in list)
      {
        Console.WriteLine(pif.firstName + " " + pif.lastName);
      }

    }
  }
}




