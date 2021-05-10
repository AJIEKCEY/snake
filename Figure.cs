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
        
        internal bool IsHit( Figure figure )
        {
            foreach(var p in Points)
            {
                if ( figure.IsHit( p ) )
                    return true;
            }
            return false;
        }

        private bool IsHit( Point point )
        {
            foreach(var p in Points)
            {
                if ( p.IsHit( point ) )
                    return true;
            }
            return false;
        }
    }
}