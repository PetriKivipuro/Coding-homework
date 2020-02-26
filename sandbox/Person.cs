using System;


namespace sandbox
{
  public class Person
  {
    private string name;
    private int age;
    private double weight;
    private double height;
    public Person(string name, int age, double weight, double height)
    {
      this.age = age;
      this.name = name;
      this.weight = weight;
      this.height = height;
    }

    public double BodyMassIndex()
    {
      return this.weight / (this.height * this.height);
    }

    public double MaximumHeartRate()
    {
      return 206.3 - (0.711 * this.age);
    }

    public void GrowOlder()
    {
      if (this.age < 100)
      {
        this.age = this.age + 1;
      }
    }

    public override string ToString()
    {
      return this.name + ", BMI: " + this.BodyMassIndex()
            + ", maximum heart rate: " + this.MaximumHeartRate();
    }
  }
}