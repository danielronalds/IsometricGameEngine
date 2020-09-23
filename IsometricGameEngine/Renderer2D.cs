using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace IsometricGameEngine
{
    public class Renderer2D
    {
        public List<RenderComponent> renderComponents = new List<RenderComponent>();

        public Renderer2D(IsometricGrid2D isometricGrid, TileMap tileMap, Image renderImage )
        {
            fillGrid(isometricGrid, tileMap, renderImage);
        }

        public void Render(Graphics g)
        {
            foreach(RenderComponent renderComponent in renderComponents)
            {
                renderComponent.Render(g);
            }
        }

        private void fillGrid(IsometricGrid2D isometricGrid, TileMap tileMap, Image renderImage)
        {
            int length = isometricGrid.gridSize;

            for (int y = 0; y < length; y++)
            {
                for (int x = 0; x < length; x++)
                {
                    if(tileMap.getValue(x,y) != tileMap.VoidCharacter)
                    {
                        renderComponents.Add(new RenderComponent(renderImage, isometricGrid.getPoint(x, y)));
                    }
                }
            }
        }
    }
}
