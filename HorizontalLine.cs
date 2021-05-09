using System.Collections.Generic;

namespace snake
{
    public class HorizontalLine : Figure
    {
        public HorizontalLine(int xLeft, int xRight, int y, char sym)
        {
            Points = new List<Point>();
            for (int x = xLeft; x <= xRight; x++)
            {
                Points.Add( new Point( x, y, sym ) );
            }
        }
    }
}