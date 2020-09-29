using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace IsometricGameEngine
{
    public class ColliderComponent
    {
        IsometricUtilities isoTools = new IsometricUtilities();

        public Point position;

        public List<Rectangle> Colliders = new List<Rectangle>();

        public bool Fixed = false;

        public ColliderComponent(Point Location, IsometricGrid2D isometricGrid)
        {
            position = Location;

            configureCollisionArray(isometricGrid);
        }

        public ColliderComponent(RenderComponent isometricComponent, IsometricGrid2D isometricGrid)
        {
            position = isometricComponent.renderRect.Location;//isoTools.findGridID(isometricGrid, isometricComponent.renderRect);

            configureCollisionArray(isometricGrid);
        }

        public ColliderComponent(Rectangle isometricComponent, IsometricGrid2D isometricGrid)
        {
            position = isometricComponent.Location;//isoTools.findGridID(isometricGrid, isometricComponent.renderRect);

            configureCollisionArray(isometricGrid);
        }

        public ColliderComponent(int x, int y, IsometricGrid2D isometricGrid)
        {
            position = new Point(x, y);//isoTools.findGridID(isometricGrid, x,y);

            configureCollisionArray(isometricGrid);
        }

        public void DrawCollider(Graphics g, Pen pen)
        {
            foreach(Rectangle collider in Colliders)
            {
                g.DrawRectangle(pen, collider);
            }
        }

        public void configureCollisionArray(IsometricGrid2D isometricGrid)
        {
            Colliders.Clear();

            for (int i = 0; i < (isometricGrid.TileHeight/4); i++)
            {
                Colliders.Add(createCollider(i + 1, isometricGrid));
            }
        }

        private Rectangle createCollider(int number, IsometricGrid2D isometricGrid)
        {
            Rectangle colliderRec;

            int x, y, width, height, TileWidth_Half, TileHeight_Half;

            TileWidth_Half = isometricGrid.TileWidth / 2;
            TileHeight_Half = isometricGrid.TileHeight / 2;

            x = position.X + TileWidth_Half - (2 * number) - 1;

            y = position.Y + number + TileHeight_Half;

            width = 1 + 4 * number;

            height = TileHeight_Half - (2 * number);

            colliderRec = new Rectangle(x, y, width, height);

            return colliderRec;
        }
    }
}
