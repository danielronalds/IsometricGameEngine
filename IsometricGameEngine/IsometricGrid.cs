using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace IsometricGameEngine
{
    class IsometricGrid
    {
        public Point GridOrigin;

        public Image tileImage;

        public int TileWidth, TileHeight;
        public int gridSize;

        public Point[,] isometricGrid;

        public IsometricGrid(int x, int y, Image image, int GridSize = 5)
        {
            GridOrigin = new Point(x, y);

            tileImage = image;

            TileWidth = tileImage.Width;

            TileHeight = tileImage.Height;

            GridOrigin.X -= (tileImage.Height / 2);

            buildGrid(GridSize);
        }

        public int toMapX(int screen_x, int screen_y)
        {
            decimal map_x;

            screen_x -= GridOrigin.X;
            screen_y -= GridOrigin.Y;

            map_x = (screen_x / (TileHeight / 2) + screen_y / (TileHeight / 4)) / 2;

            map_x = Math.Floor(map_x);

            return (int)map_x;
        }

        public int toMapY(int screen_x, int screen_y)
        {
            decimal map_y;

            screen_x -= GridOrigin.X;
            screen_y -= GridOrigin.Y;

            map_y = (screen_y / (TileHeight / 4) - screen_x / (TileHeight / 2)) / 2;

            map_y = Math.Floor(map_y);

            return (int)map_y;
        }

        private void buildGrid(int gridsize = 5)
        {
            gridSize = gridsize;

            isometricGrid = new Point[gridSize, gridSize];

            Point gridOrigin = new Point(GridOrigin.X - (TileWidth / 2), GridOrigin.Y);

            int map_x = 0;
            int map_y = 0;

            int screen_x;
            int screen_y;

            for (int y = 0; y < gridSize; y++)
            {
                for (int x = 0; x < gridSize; x++)
                {
                    screen_x = (x - y) * (TileWidth / 2);
                    screen_y = (x + y) * (TileHeight / 4);

                    isometricGrid[x, y] = new Point(screen_x, screen_y);

                    map_x++;
                }

                map_y++;
            }
        }
    }
}
