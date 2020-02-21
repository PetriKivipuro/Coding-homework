using System;

namespace exercise_102
{
  class Gauge
  {
    public int value;

    public void Increase()
    {
      //this.value = value;
      if (this.value < 5)
      {
        this.value += 1;
      }

    }
    public void Decrease()
    {
      if (this.value > 0)
      {
        this.value -= 1;
      }
    }

    public bool Full()
    {
      if (this.value == 5)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

  }
}

