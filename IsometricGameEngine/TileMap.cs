using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsometricGameEngine
{
    public class TileMap
    {
        private string[,] tileMap;

        public string VoidCharacter;

        public int Width, Height;

        public TileMap(string[,] map, string voidCharacter)
        {
            tileMap = map;

            VoidCharacter = voidCharacter;

            Width = (int)Math.Sqrt(toArray().Length);
            Height = Width;
        }

        public TileMap(string[,] map, string voidCharacter, int width, int height)
        {
            tileMap = map;

            VoidCharacter = voidCharacter;

            Width = width;
            Height = height;
        }

        public string[,] toArray()
        {
            return tileMap;
        }

        public string getValue(int x, int y)
        {
            return tileMap[x,y];
        }
    }
}
