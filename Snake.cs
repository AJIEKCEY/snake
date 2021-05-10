using System;
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

        internal bool IsHitTail()
        {
            Point head = Points.Last();
            for (int i = 0; i < Points.Count - 2; i++)
            {
                if (head.IsHit(Points[i]))
                    return true;
            }

            return false;
        }
        public void HandleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                _direction = Direction.LEFT;
            else if (key == ConsoleKey.RightArrow)
                _direction = Direction.RIGHT;
            else if (key == ConsoleKey.UpArrow)
                _direction = Direction.UP;
            else if (key == ConsoleKey.DownArrow)
                _direction = Direction.DOWN;
        }

        public bool Eat(Point food)
        {
            Point head = GetNextPoint();
            
            if (head.IsHit(food))
            {
                food.sym = head.sym;
                Points.Add(food);
                return true;
            }
            
            return false;
        }
    }
}