using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace IsometricGameEngine
{
    public static class IsometricMovement
    {
        public static Rectangle Left(Rectangle rectangle, int Speed)
        {
            rectangle.X -= 2 * Speed;
            rectangle.Y += 1 * Speed;

            return rectangle;
        }

        public static Rectangle Right(Rectangle rectangle, int Speed)
        {
            rectangle.X += 2 * Speed;
            rectangle.Y -= 1 * Speed;

            return rectangle;
        }

        public static Rectangle Up(Rectangle rectangle, int Speed)
        {
            rectangle.X -= 2 * Speed;
            rectangle.Y -= 1 * Speed;

            return rectangle;
        }

        public static Rectangle Down(Rectangle rectangle, int Speed)
        {
            rectangle.X += 2 * Speed;
            rectangle.Y += 1 * Speed;

            return rectangle;
        }
    }
}
