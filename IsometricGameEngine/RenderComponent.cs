using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace IsometricGameEngine
{
    public class RenderComponent
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

        public RenderComponent(Image renderimage, int x, int y, bool visible = true)
        {
            Point Location = new Point(x, y); 

            renderComponent(renderImage, Location, visible);
        }

        public RenderComponent(Image renderimage, Point Location, bool visible = true)
        {
            renderComponent(renderImage, Location, visible);
        }

        private void renderComponent(Image renderimage, Point Location, bool visible)
        {
            int width, height;

            renderImage = renderimage;

            width = renderImage.Width;
            height = renderImage.Height;

            renderRect = new Rectangle(Location.X, Location.Y, width, height);

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
