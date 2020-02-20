using System;

namespace exercise_97
{

    class Whistle
    {
        private string sound;

        //tämä on konstruktori (saman niminen kuin class rivillä 6)
        public Whistle(string whistleSound)
        {
            this.sound = whistleSound;
        }
        public void Sound()
        {
            Console.WriteLine(this.sound);
        }
    }
}









