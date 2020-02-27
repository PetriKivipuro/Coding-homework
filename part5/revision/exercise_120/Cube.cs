using System;



namespace exercise_120
{
  public class Cube
  {
    private int edgeLenght;

    public Cube(int edgeLenght)
    {
      this.edgeLenght = edgeLenght;
    }
    public int Volume()
    {
      this.edgeLenght = this.edgeLenght * this.edgeLenght * this.edgeLenght;
      return this.edgeLenght;
    }

    public override string ToString()
    {
      return "The length of the edge is " + this.edgeLenght + " and the volume " + Volume();
    }
  }
}