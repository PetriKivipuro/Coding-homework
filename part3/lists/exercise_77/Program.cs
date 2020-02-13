using System;
using System.Collections.Generic;

namespace exercise_77
{
    class Program
    {
        public static void Main(string[] args)
        {
            //You can try your method here if you want
            //In the main method you add three items to the list, print it out. 
            //Then you remove the last item twice, meaning there’s only one left. 
            //Then you print the list, which means it prints the only item left (“First”).
            List<string> strings = new List<string>();

            strings.Add("First");
            strings.Add("Second");
            strings.Add("Third");

            strings.ForEach(Console.WriteLine);

            RemoveLast(strings);
            RemoveLast(strings);
            strings.ForEach(Console.WriteLine);

        }
        public static void RemoveLast(List<string> kakkulapio) //tämä viimeisin osa voi olla periaatteesa mikä vain, mielellään jokin joka viittaa aiheeseen
        {
            //Your method RemoveLast removes the last item from the list, as it should.
            int lastNumber = kakkulapio.Count - 1;
            kakkulapio.RemoveAt(lastNumber);
        }

    }
}


