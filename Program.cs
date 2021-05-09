using System;
using System.Collections.Generic;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Point> points = new List<Point>();
            
            points.Add(new Point(1,2,'*'));
            points.Add(new Point(4,5,'#'));
            points.Add(new Point(5,5,'#'));
            points.Add(new Point(6,5,'#'));

            foreach (var point in points)
            {
                point.Drow();
            }
        }
    }
}