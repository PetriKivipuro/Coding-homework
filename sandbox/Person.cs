using System;

namespace person
{
  public class Person
  {
    private string name;
    private int age;
    private int weight;
    private int height;


    public Person(string name)
    {
      this.name = name;
      this.age = 0;
      this.weight = 0;
      this.height = 0;
    }

    public double BodyMassIndex()
    {
      double heigthPerHundred = this.height / 100.0;
      return this.weight / (heigthPerHundred * heigthPerHundred);
    }

    public bool IsAdult()
    {
      if (this.age < 18)
      {
        return false;
      }
      return true;
    }

    public void GrowOlder()
    {
      this.age++;
    }

    public override string ToString()
    {
      return this.name + ", age: " + this.age;
    }
  }
}
