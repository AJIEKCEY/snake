using System.Collections.Generic;

namespace snake
{
    public class Figure
    {
        protected List<Point> Points;
        
        public void Draw()
        {
            foreach (Point point in Points)
            {
                point.Draw();
            }
        }
    }
}