using System;


namespace sandbox
{
  public class Person
  {
    public string name;
    public SimpleDate birthday;
    private int weight;
    public int height;
    public Person(string name, SimpleDate date)
    {
      this.name = name;
      this.birthday = date;
      this.weight = 0;
      this.height = 0;
    }
    public Person(string name, int day, int month, int year)
    {
      this.name = name;
      this.birthday = new SimpleDate(day, month, year);
    }



    // or return more directly:
    // return this.birthday.Before(compared.birthday);





    public double BodyMassIndex()
    {
      return this.weight / (this.height * this.height);
    }





    public override string ToString()
    {
      return this.name + ", born on " + this.birthday;
    }
  }
}

