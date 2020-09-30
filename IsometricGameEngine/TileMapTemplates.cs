using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsometricGameEngine
{
    public class TileMapTemplates
    {
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
    }
}
