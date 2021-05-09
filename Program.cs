using System;
using System.Collections.Generic;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.SetBufferSize( 80, 25 );
            
            //Отрисовка рамки
            
            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 78, 15, '+');
            VerticalLine leftLine = new VerticalLine(0, 0, 15, '+');
            VerticalLine rightLine = new VerticalLine(78, 0, 15, '+');
            upLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            rightLine.Draw();
            
            //Отрисовка точек 
            
            List<Point> points = new List<Point>();
            
            points.Add(new Point(3,5,'*'));
            points.Add(new Point(4,5,'*'));
            points.Add(new Point(5,5,'*'));
            points.Add(new Point(6,5,'*'));
            
            foreach (var point in points)
            {
                point.Draw();
            }
        }
    }
}