using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsometricGameEngine
{
    class TileMap
    {
        private string[,] tileMap;

        public TileMap(string[,] map)
        {
            tileMap = map;
        }

        public string getID(int x, int y)
        {
            return tileMap[x,y];
        }
    }
}
