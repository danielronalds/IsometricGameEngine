using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace IsometricGameEngine
{
    public class IsometricUtilities
    {
        // Finding an objects Grid ID
        public GridIndex findGridID(IsometricGrid2D isometricGrid, Point Location)
        {
            for (int i = 0; i < isometricGrid.gridSize; i++)
            {
                for (int x = 0; x < isometricGrid.gridSize; x++)
                {
                    if (Location == isometricGrid.getPoint(i, x))
                    {
                        GridIndex gridIndex = new GridIndex(i, x);
                        return gridIndex;
                    }
                }
            }

            return null;
        }

        public GridIndex findGridID(IsometricGrid2D isometricGrid, int x, int y)
        {
            Point Location = new Point(x, y); // Overload conversion

            for (int i = 0; i < isometricGrid.gridSize; i++)
            {
                for (int z = 0; z < isometricGrid.gridSize; z++)
                {
                    if (Location == isometricGrid.getPoint(i, z))
                    {
                        GridIndex gridIndex = new GridIndex(i, x);
                        return gridIndex;
                    }
                }
            }

            return null;
        }

        public GridIndex findGridID(IsometricGrid2D isometricGrid, Rectangle Entity)
        {
            Point Location = Entity.Location; // Overload conversion

            for (int i = 0; i < isometricGrid.gridSize; i++)
            {
                for (int z = 0; z < isometricGrid.gridSize; z++)
                {
                    if (Location == isometricGrid.getPoint(i, z))
                    {
                        GridIndex gridIndex = new GridIndex(i, z);
                        return gridIndex;
                    }
                }
            }

            return null;
        }
    }
}
