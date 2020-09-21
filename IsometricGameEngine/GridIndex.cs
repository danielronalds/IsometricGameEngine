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

        public Point toScreenPoint(IsometricGrid grid)
        {
            Point screenPoint;

            screenPoint = grid.isometricGrid(X, Y);

            return screenPoint;
        }
    }
}
