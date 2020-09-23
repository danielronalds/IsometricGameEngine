using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace IsometricGameEngine
{
    public class IsometricGrid2D
    {
        public Point GridOrigin;

        public int TileWidth, TileHeight,  gridSize;

        private Point[,] isomtricGridArray;

        /* Different Constructers for intitializing the grid */
        
        public IsometricGrid2D(int x, int y, int GridSize = 5, int tile_width = 64, int tile_height = 64)
        {
            GridOrigin = new Point(x, y);

            TileWidth = tile_width;

            TileHeight = tile_height;

            GridOrigin.X -= (TileWidth / 2);

            gridSize = GridSize;

            buildGrid();
        }

        public IsometricGrid2D(Point Location, Size Tile_Size, int GridSize = 5)
        {
            GridOrigin = Location;

            TileWidth = Tile_Size.Width;

            TileHeight = Tile_Size.Height;

            GridOrigin.X -= (Tile_Size.Width / 2);

            gridSize = GridSize;

            buildGrid();
        }

        public IsometricGrid2D(int x, int y, Image entityImage, int GridSize = 5)
        {
            GridOrigin = new Point(x, y);

            TileWidth = entityImage.Width;

            TileHeight = entityImage.Height;

            GridOrigin.X -= (TileWidth / 2);

            gridSize = GridSize;

            buildGrid();
        }

        public IsometricGrid2D(Point Location, Image entityImage, int GridSize = 5)
        {
            GridOrigin = Location;

            TileWidth = entityImage.Width;

            TileHeight = entityImage.Height;

            GridOrigin.X -= (TileHeight / 2);

            gridSize = GridSize;

            buildGrid();
        }

        public Point getPoint(GridIndex gridIndex)
        {
            return isomtricGridArray[gridIndex.X, gridIndex.Y];
        }

        public Point getPoint(int x, int y)
        {
            return isomtricGridArray[x, y];
        }

        private void buildGrid()
        {
            isomtricGridArray = new Point[gridSize, gridSize];

            int screen_x;
            int screen_y;

            for (int y = 0; y < gridSize; y++)
            {
                for (int x = 0; x < gridSize; x++)
                {
                    screen_x = GridOrigin.X + (x - y) * (TileWidth / 2);
                    screen_y = GridOrigin.Y + (x + y) * (TileHeight / 4);

                    isomtricGridArray[x, y] = new Point(screen_x, screen_y);
                }
            }
        }
    }
}
