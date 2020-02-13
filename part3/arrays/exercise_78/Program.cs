using System;
using System.Collections.Generic;

namespace exercise_78
{
    class Program
    {
        public static void Main(string[] args)
        {
            // DO NOT CHANGE THE FOLLOWING CODE!
            int[] array = new int[5];
            array[0] = 1;
            array[1] = 3;
            array[2] = 5;
            array[3] = 7;
            array[4] = 9;

            int index = 0;
            while (index < array.Length)
            {
                Console.WriteLine(array[index]);
                index++;
            }
            Console.WriteLine("");

            // Implement here
            // asking for the two indices
            // and then swapping them

            Console.WriteLine("Give two indices to swap:");
            int first = Convert.ToInt32(Console.ReadLine());
            int second = Convert.ToInt32(Console.ReadLine());

            int temp = 1; // tässä voi olla mikä vain numero. Ilmeisesti numero on vain tallennustila
            temp = array[first];
            array[first] = array[second];
            array[second] = temp;
            /*
                It works, because you create the variable temp, and on the same line you give it a value. On the next line you give it a new value.
                You could streamline that even more, to have it
                      int temp = array[first]
                      array[first] = array[second]
                      array[second] = temp




                     // Print the ones we want to swap
                        Console.WriteLine("array first: "+ array[first]);
                        Console.WriteLine("array second: " + array[second]);
                     // Create int temp, put array[first] value in it
                        int temp = array[first];
                     // Print-debugging, remove when done
                        Console.WriteLine("value of temp is " + temp);
                     // Put array[second] value INTO array[first]
                        array[first] = array[second];
                     // Print array[first] to see the new value is there
                        Console.WriteLine("value of array[first] is now " + array[first]);
                     // Put temp, or the original array[first], into array[second]
                        array[second] = temp;
                     // Print the new value of array[second] to see the swap worked
                        Console.WriteLine("value of array[second] is now " + array[second]);
                */


            // DO NOT CHANGE THE FOLLOWING CODE!
            Console.WriteLine("");
            index = 0;
            while (index < array.Length)
            {
                Console.WriteLine(array[index]);
                index++;
            }
        }

    }
}


