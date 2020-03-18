using System.Collections.Generic;
using System;
public class GradeRegister
{
  private List<int> grades;
  private List<int> scores;

  public GradeRegister()
  {
    this.grades = new List<int>();
    this.scores = new List<int>();
  }

  public void AddGradeBasedOnPoints(int points)
  {
    this.grades.Add(PointsToGrades(points));
    this.scores.Add(points);
  }

  public int NumberOfGrades(int grade)
  {
    int count = 0;
    foreach (int received in this.grades)
    {
      if (received == grade)
      {
        count++;
      }
    }
    return count;
  }

  public static int PointsToGrades(int points)
  {
    int grade = 0;
    if (points < 50)
    {
      grade = 0;
    }
    else if (points < 60)
    {
      grade = 1;
    }
    else if (points < 70)
    {
      grade = 2;
    }
    else if (points < 80)
    {
      grade = 3;
    }
    else if (points < 90)
    {
      grade = 4;
    }
    else
    {
      grade = 5;
    }
    return grade;
  }

  public double AverageOfGrades()
  {
    // Hint! You don't need to round the -1, but you do need it for all the other results...

    if (this.grades.Count == 0)
    {
      return Math.Round(-1.00, 2);
    }

    double sum = 0.00;
    foreach (double grade in this.grades)
    {
      sum = sum + grade;
    }
    return Math.Round(sum / this.grades.Count, 2);
  }

  public double AverageOfPoints()
  {
    if (this.scores.Count == 0)
    {
      return Math.Round(-1.00, 2);
    }

    double sum = 0.00;
    foreach (double point in this.scores)
    {
      sum = sum + point;
    }
    return Math.Round(sum / this.scores.Count, 2);
  }
}
