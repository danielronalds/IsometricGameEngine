using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace IsometricGameEngine
{
    public class GridIndex
    {
        public int X, Y;

        public GridIndex(int x, int y)
        {
            X = x;

            Y = y;
        }

        public Point toScreenPoint(IsometricGrid2D grid)
        {
            Point screenPoint;

            screenPoint = grid.getPoint(X, Y);

            return screenPoint;
        }
    }
}
