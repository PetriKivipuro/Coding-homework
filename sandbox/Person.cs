using System;


namespace sandbox
{
  public class Person
  {
    private string name;
    private int age;
    private int weight;
    private int height;
    public Person(string name) : this(name, 0)
    {

    }
    public Person(string name, int age)
    {
      this.name = name;
      this.age = age;
      this.weight = 0;
      this.height = 0;
    }

    public double BodyMassIndex()
    {
      return this.weight / (this.height * this.height);
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
      this.GrowOlder(1);
    }

    public void GrowOlder(int years)
    {
      this.age += years;
    }




    public override string ToString()
    {
      return this.name + ", age: " + this.age;
    }
  }
}