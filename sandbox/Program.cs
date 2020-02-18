using System;


namespace sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            Person ada = new Person("Ada");
            Person antti = new Person("Antti");
            Person martin = new Person("Martin");

            ada.PrintPerson();
            antti.PrintPerson();
            martin.PrintPerson();

            Console.WriteLine();

            ada.GrowOlder();
            antti.GrowOlder();
            antti.GrowOlder();
            antti.GrowOlder();
            antti.GrowOlder();
            antti.GrowOlder();
            martin.GrowOlder();

            ada.PrintPerson();
            antti.PrintPerson();
            martin.PrintPerson();

            // selvennykseksi kaksi tyhjää riviä
            Console.WriteLine();
            Console.WriteLine("------------------------------------------");

            Teacher teacher = new Teacher();
            int grading = teacher.Grade();

            Console.WriteLine("The grade is recieved is " + grading);

            // selvennykseksi kaksi tyhjää riviä
            Console.WriteLine();
            Console.WriteLine("------------------------------------------");

            Teacher firts = new Teacher();
            Teacher second = new Teacher();
            Teacher third = new Teacher();

            double average = (firts.Grade() + second.Grade() + third.Grade()) / 3.0;
            Console.WriteLine("The grading average " + average);

        }

    }
}
