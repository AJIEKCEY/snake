using System.Collections.Generic;
using System.Globalization;

namespace snake
{
    public class VerticalLine : Figure
    {
        public VerticalLine(int x, int yTop, int yBottom, char sym )
        {
            Points = new List<Point>();
            for (int y = yTop; y < yBottom; y++)
            {
                Points.Add(new Point( x, y, sym ));
            }
        }
    }
}