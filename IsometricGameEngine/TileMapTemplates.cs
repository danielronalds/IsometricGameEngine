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
            TileMap tileMap;

            int length = isometricGrid.gridSize;

            string[,] templateMap = new string[length, length];

            for (int y = 0; y < length; y++)
            {
                for (int x = 0; x < length; x++)
                {
                    templateMap[x, y] = "f";
                }
            }

            tileMap = new TileMap(templateMap, "0");

            return tileMap;
        }
        
        public TileMap FilledGrid(IsometricGrid3D isometricGrid)
        {
            TileMap tileMap;

            int length = isometricGrid.GridSize;

            string[,] templateMap = new string[length, length];

            for (int y = 0; y < length; y++)
            {
                for (int x = 0; x < length; x++)
                {
                    templateMap[x, y] = "f";
                }
            }

            tileMap = new TileMap(templateMap, "0");

            return tileMap;
        }
    }
}
