using System.Collections.Generic;
using System.Linq;

namespace snake
{
    public class Snake : Figure
    {
        private Direction _direction;
        public Snake(Point tail, int length, Direction direction)
        {
            _direction = direction;
            Points = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                Point p = new Point( tail );
                p.Move(i, _direction);
                Points.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = Points.First();
            Points.Remove(tail);
            Point head = GetNextPoint();
            Points.Add(head);

            tail.Clear();
            head.Draw();
        }

        private Point GetNextPoint()
        {
            Point currentHead = Points.Last();
            Point nextPoint = new Point(currentHead);
            nextPoint.Move(1, _direction);

            return nextPoint;
        }
    }
}