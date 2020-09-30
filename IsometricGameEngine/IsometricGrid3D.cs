using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace IsometricGameEngine
{
    public class IsometricGrid3D
    {
        public Point GridOrigin;

        public int TileWidth, TileHeight, GridSize, GridHeight;

        private List<IsometricGrid2D> Layers = new List<IsometricGrid2D>();

        public IsometricGrid3D(int x, int y, int gridSize = 5, int gridHeight = 5, int tile_width = 64, int tile_height = 64)
        {
            Point gridorigin = new Point(x, y);

            Size tileSize = new Size(tile_width, tile_height);

            isometricgrid3D(gridorigin, tileSize, gridHeight, gridSize);

            buildGrid();
        }

        public IsometricGrid3D(Point Location, Size Tile_Size, int gridHeight = 5, int gridSize = 5)
        {
            isometricgrid3D(Location, Tile_Size, gridHeight, gridSize);

            buildGrid();
        }

        private void isometricgrid3D(Point Location, Size Tile_Size, int gridHeight, int gridSize)
        {
            GridOrigin = Location;

            TileWidth = Tile_Size.Width;

            TileHeight = Tile_Size.Height;

            GridOrigin.X -= (TileWidth / 2);

            GridSize = gridSize;

            GridHeight = gridHeight;
        }

        public IsometricGrid2D to2D(int z)
        {
            return Layers[z];
        }

        public Point getPoint(int x, int y, int z)
        {
            IsometricGrid2D layer = to2D(z);

            return layer.getPoint(x, y);
        }

        private void buildGrid()
        {
            int screen_y;

            IsometricGrid2D layer;

            for (int z = 0; z < GridHeight; z++)
            {
                screen_y = GridOrigin.Y - (z * (TileWidth / 2));

                layer = new IsometricGrid2D(GridOrigin.X, screen_y, GridSize);

                Layers.Add(layer);
            }
        }
    }
}
