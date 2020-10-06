using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsometricGameEngine
{
    public class TileMapTemplates
    {
        // Filled Grid Template

        public TileMap FilledGrid(IsometricGrid2D isometricGrid)
        {
            int length = isometricGrid.gridSize;

            return filledgrid(length, length);
        }
        
        public TileMap FilledGrid(IsometricGrid3D isometricGrid)
        {
            int length = isometricGrid.GridSize;

            return filledgrid(length, length);
        }

        public TileMap FilledGrid(int width, int length)
        {
            return filledgrid(width, length);
        }

        private TileMap filledgrid(int width, int height)
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

        public TileMap BorderedGrid(IsometricGrid2D isometricGrid)
        {
            int length = isometricGrid.gridSize;

            return borderedGrid(length, length);
        }

        public TileMap BorderedGrid(IsometricGrid3D isometricGrid)
        {
            int length = isometricGrid.GridSize;

            return borderedGrid(length, length);
        }

        //public TileMap BorderedGrid(int width, int length)
        //{
        //    return borderedGrid(width, length);
        //}

        private TileMap borderedGrid(int width, int height)
        {
            TileMap tileMap;

            string[,] templateMap = new string[width, height];

            for (int i = 0; i < width; i++)
            {
                templateMap[0, i] = "f";
                templateMap[height - 1, i] = "f";


                if (i != 0 && i != width - 1)
                {
                    templateMap[i, 0] = "f";
                    templateMap[i, height - 1] = "f";
                }
            }

            // Fills in the blank spaces

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (templateMap[x, y] != "f")
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
