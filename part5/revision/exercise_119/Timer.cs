using System;
using System.Collections.Generic;

namespace exercise_119
{
  public class Timer
  {

    private ClockHand seconds;
    private ClockHand hundredthOfSecond;
    public Timer()
    {
      this.seconds = new ClockHand(60);
      this.hundredthOfSecond = new ClockHand(100);
    }
    public void Advance()
    {
      this.hundredthOfSecond.Advance();
      if (this.hundredthOfSecond.value == 0)
      {
        this.seconds.Advance();
      }

    }
    public override string ToString()
    {
      return seconds + ":" + hundredthOfSecond;
    }
  }
}