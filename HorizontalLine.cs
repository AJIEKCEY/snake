using System.Collections.Generic;

namespace snake
{
    public class HorizontalLine
    {
        private List<Point> _pList;

        public HorizontalLine(int xLeft, int xRight, int y, char sym)
        {
            _pList = new List<Point>();
            for (int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point( x, y, sym );
                _pList.Add( p );
            }
        }

        public void Draw()
        {
            foreach (Point point in _pList)
            {
                point.Draw();
            }
        }
    }
}