using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace IsometricGameEngine
{
    public class Collision
    {
        // Checking Collisions
        public bool collidersColliding(ColliderComponent colliderOne, ColliderComponent colliderTwo, IsometricGrid2D isometricGrid)
        {
            if (!colliderOne.Fixed)
            {
                colliderOne.configureCollisionArray(isometricGrid);
            }

            if (!colliderTwo.Fixed)
            {
                colliderTwo.configureCollisionArray(isometricGrid);
            }

            foreach (Rectangle collider1 in colliderOne.Colliders)
            {
                foreach (Rectangle collider2 in colliderTwo.Colliders)
                {
                    if (collider1.IntersectsWith(collider2))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public bool collidersColliding(ColliderComponent colliderOne, List<ColliderComponent> colliders, IsometricGrid2D isometricGrid)
        {
            foreach (ColliderComponent colliderTwo in colliders)
            {
                if (collidersColliding(colliderOne, colliderTwo, isometricGrid))
                {
                    return true;
                }
            }
            return false;
        }

        public bool collidersColliding(ColliderComponent colliderOne, ColliderComponent[] colliders, IsometricGrid2D isometricGrid)
        {
            foreach (ColliderComponent colliderTwo in colliders)
            {
                if (collidersColliding(colliderOne, colliderTwo, isometricGrid))
                {
                    return true;
                }
            }
            return false;
        }

        public List<ColliderComponent> placeColliders(IsometricGrid2D isometricGrid, TileMap sourceMap)
        {
            int length = isometricGrid.gridSize;

            List<ColliderComponent> colliders = new List<ColliderComponent>();

            for (int y = 0; y < length; y++)
            {
                for (int x = 0; x < length; x++)
                {
                    if (sourceMap.getValue(x, y) != sourceMap.VoidCharacter)
                    {
                        colliders.Add(new ColliderComponent(isometricGrid.getPoint(x, y), isometricGrid));
                    }
                }
            }

            return colliders;
        }
    }
}
