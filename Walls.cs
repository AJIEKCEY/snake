using System.Collections.Generic;

namespace snake
{
    public class Walls
    {
        private List<Figure> _wallList;

        public Walls(int mapWidth, int mapHeight)
        {
            _wallList = new List<Figure>();
            
            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 78, 15, '+');
            VerticalLine leftLine = new VerticalLine(0, 0, 15, '+');
            VerticalLine rightLine = new VerticalLine(78, 0, 15, '+');
        
            _wallList.Add( upLine );
            _wallList.Add( downLine );
            _wallList.Add( leftLine );
            _wallList.Add( rightLine );
        }

        internal bool IsHit(Figure figure)
        {
            foreach (var wall in _wallList)
            {
                if (wall.IsHit(figure))
                    return true;
            }
            return false;
        }

        public void Draw()
        {
            foreach (var wall in _wallList)
            {
                wall.Draw();
            }
        }
    }
}