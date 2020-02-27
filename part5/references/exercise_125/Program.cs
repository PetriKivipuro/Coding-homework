using System;

namespace exercise_125
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Try your code here, if you want
      HealthStation childrensHospital = new HealthStation();
      HealthStation sairaala = new HealthStation();

      // Create two new persons
      Person ethan = new Person("Ethan", 1, 110, 7);
      Person peter = new Person("Peter", 33, 176, 85);

      Person matti = new Person("Matti", 2, 100, 50);
      Person antti = new Person("Antti", 50, 150, 200);


      Console.WriteLine("************************************************");

      // Try out the Persons and method Weigh
      Console.WriteLine(ethan.name + " weight: " + childrensHospital.Weigh(ethan) + " kilos");
      Console.WriteLine(peter.name + " weight: " + childrensHospital.Weigh(peter) + " kilos");
      Console.WriteLine("************************************************");

      Console.WriteLine(matti.name + " paino: " + sairaala.Weigh(matti) + " kiloa");
      Console.WriteLine(antti.name + " paino: " + sairaala.Weigh(antti) + " kiloa");
      Console.WriteLine("************************************************");
      // Test feeding the persons
      childrensHospital.Feed(ethan);
      childrensHospital.Feed(peter);
      sairaala.Feed(antti);
      sairaala.Feed(matti);
      Console.WriteLine("***************nyt pojat on ruokittu*********************************");

      // See that the weights have changed
      Console.WriteLine(ethan.name + " weight: " + childrensHospital.Weigh(ethan) + " kilos");
      Console.WriteLine(peter.name + " weight: " + childrensHospital.Weigh(peter) + " kilos");

      Console.WriteLine(antti.name + " paino: " + sairaala.Weigh(antti) + " kiloa");
      Console.WriteLine("************************************************");
      // Keep weighing to increase the 'int weighings'
      childrensHospital.Weigh(ethan);
      childrensHospital.Weigh(ethan);
      childrensHospital.Weigh(ethan);
      childrensHospital.Weigh(ethan);
      Console.WriteLine("************************************************");
      sairaala.Weigh(antti);
      sairaala.Weigh(antti);
      sairaala.Weigh(antti);
      sairaala.Weigh(antti);
      sairaala.Weigh(antti);
      sairaala.Weigh(antti);
      sairaala.Weigh(antti);
      sairaala.Weigh(antti);
      Console.WriteLine("**********************tapahtuuko XXX.Weigh(nimi) mitään*********************");
      Console.WriteLine(ethan.name + " weight: " + childrensHospital.Weigh(ethan) + " kilos");
      Console.WriteLine(peter.name + " weight: " + childrensHospital.Weigh(peter) + " kilos");

      Console.WriteLine(antti.name + " paino: " + sairaala.Weigh(antti) + " kiloa");

      // See that the variable has increased to 8
      Console.WriteLine("weighings performed at childerns hosp: " + childrensHospital.weighings);

      Console.WriteLine("************************************************");

      Console.WriteLine("weighings performed at sairaala: " + sairaala.weighings);

      Console.WriteLine("punnaukset yhteensä: " + (sairaala.weighings + childrensHospital.weighings));
    }
  }
}

