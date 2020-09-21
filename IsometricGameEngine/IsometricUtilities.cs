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
        public int[] findGridID(IsometricGrid isometricGrid, Point Location)
        {
            for (int i = 0; i < isometricGrid.gridSize; i++)
            {
                for (int x = 0; x < isometricGrid.gridSize; x++)
                {
                    if (Location == isometricGrid.isometricGrid(i, x))
                    {
                        int[] mapLocation = { i, x };
                        return mapLocation;
                    }
                }
            }

            return null;
        }

        public int[] findGridID(IsometricGrid isometricGrid, int x, int y)
        {
            Point Location = new Point(x, y);

            for (int i = 0; i < isometricGrid.gridSize; i++)
            {
                for (int z = 0; z < isometricGrid.gridSize; z++)
                {
                    if (Location == isometricGrid.isometricGrid[i, z])
                    {
                        int[] mapLocation = { i, z };
                        return mapLocation;
                    }
                }
            }

            return null;
        }

        public int[] findGridID(IsometricGrid isometricGrid, Rectangle Entity)
        {
            Point Location = Entity.Location;

            for (int i = 0; i < isometricGrid.gridSize; i++)
            {
                for (int z = 0; z < isometricGrid.gridSize; z++)
                {
                    if (Location == isometricGrid.isometricGrid[i, z])
                    {
                        int[] mapLocation = { i, z };
                        return mapLocation;
                    }
                }
            }

            return null;
        }
    }
}
