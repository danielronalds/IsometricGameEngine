using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsometricGameEngine
{
    public static class TileMapTemplates
    {
        // Filled Grid Template

        public static TileMap FilledGrid(IsometricGrid2D isometricGrid)
        {
            int length = isometricGrid.gridSize;

            return filledgrid(length, length);
        }

        public static TileMap FilledGrid(IsometricGrid3D isometricGrid)
        {
            int length = isometricGrid.GridSize;

            return filledgrid(length, length);
        }

        public static TileMap FilledGrid(int width, int length)
        {
            return filledgrid(width, length);
        }

        private static TileMap filledgrid(int width, int height)
        {
            TileMap tileMap;

            string[,] templateMap = new string[width, height];

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    templateMap[x, y] = "f";
                }
            }

            tileMap = new TileMap(templateMap, "0", width, height);

            return tileMap;
        }

        // Bordered Grid Template

        public static TileMap BorderedGrid(IsometricGrid2D isometricGrid)
        {
            int length = isometricGrid.gridSize;

            return borderedGrid(length, length);
        }

        public static TileMap BorderedGrid(IsometricGrid3D isometricGrid)
        {
            int length = isometricGrid.GridSize;

            return borderedGrid(length, length);
        }

        //public static TileMap BorderedGrid(int width, int length)
        //{
        //    return borderedGrid(width, length);
        //}

        private static TileMap borderedGrid(int width, int height)
        {
            TileMap tileMap;

            string[,] templateMap = new string[width, height];

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (y == 0 || y == height - 1)
                    {
                        templateMap[x, y] = "f";
                    }
                    else if (x == 0 || x == height - 1)
                    {
                        templateMap[x, y] = "f";
                    }
                    else
                    {
                        templateMap[x, y] = "0";
                    }
                }
            }

            tileMap = new TileMap(templateMap, "0", width, height);

            return tileMap;
        }
    }
}
