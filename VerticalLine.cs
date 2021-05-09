using System.Collections.Generic;
using System.Globalization;

namespace snake
{
    public class VerticalLine
    {
        private List<Point> _pList;

        public VerticalLine(int x, int yTop, int yBottom, char sym )
        {
            _pList = new List<Point>();
            for (int y = yTop; y < yBottom; y++)
            {
                _pList.Add(new Point( x, y, sym ));
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