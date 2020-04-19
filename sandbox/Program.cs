using System;
using System.Collections.Generic;



namespace sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Point> points = new List<Point>();
            points.Add(new Point(4, 8));
            points.Add(new ColorPoint(1, 1, "green"));
            points.Add(new ColorPoint(2, 5, "blue"));
            points.Add(new Point3D(5, 2, 8));
            points.Add(new Point(0, 0));

            foreach (Point p in points)
            {
                Console.WriteLine(p);
            }
        }
    }
}