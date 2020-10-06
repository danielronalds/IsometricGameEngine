using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace IsometricGameEngine
{
    public static class IsometricUtilities
    {
        // Finding an objects Grid ID
        public static GridIndex findGridID(IsometricGrid2D isometricGrid, Point Location)
        {
            return findgridID(isometricGrid, Location);
        }

        public static GridIndex findGridID(IsometricGrid2D isometricGrid, int x, int y)
        {
            Point Location = new Point(x, y); // Overload conversion

            return findgridID(isometricGrid, Location);
        }

        public static GridIndex findGridID(IsometricGrid2D isometricGrid, Rectangle Entity)
        {
            Point Location = Entity.Location; // Overload conversion

            return findgridID(isometricGrid, Location);
        }

        public static GridIndex findGridID(IsometricGrid2D isometricGrid, RenderComponent Entity)
        {
            Point Location = Entity.renderRect.Location; // Overload conversion

            return findgridID(isometricGrid, Location);
        }

        public static GridIndex findGridID(IsometricGrid2D isometricGrid, ColliderComponent Entity)
        {
            Point Location = Entity.position; // Overload conversion

            return findgridID(isometricGrid, Location);
        }

        private static GridIndex findgridID(IsometricGrid2D isometricGrid, Point Location)
        {
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
