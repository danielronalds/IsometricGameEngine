using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace IsometricGameEngine
{
    class RenderComponent
    {
        public Image renderImage;

        public Rectangle renderRect;

        public bool Visible;

        public RenderComponent(Image renderimage, Rectangle RenderRect, bool visible = true)
        {
            renderImage = renderimage;

            renderRect = RenderRect;

            Visible = visible;
        }

        public void Render(Graphics g)
        {
            if (Visible)
            {
                g.DrawImage(renderImage, renderRect);
            }
        }
    }
}
