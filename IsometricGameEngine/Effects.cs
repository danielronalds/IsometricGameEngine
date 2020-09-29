using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace IsometricGameEngine
{
    public class Effects
    {
        /// <summary>
        /// A method that shakes a panel/form with the given amplitude(Default of 10) and duration(Default of 20)
        /// </summary>
        public async void Shake(Panel Panel, int Amplitude = 10, int Duration = 20)
        {
            var original = Panel.Location;
            var rnd = new Random(1337);
            int shake_amplitude = Amplitude;
            for (int i = 0; i < 10; i++)
            {
                Panel.Location = new Point(original.X + rnd.Next(-shake_amplitude, shake_amplitude), original.Y + rnd.Next(-shake_amplitude, shake_amplitude));
                await Task.Delay(Duration);
            }
            Panel.Location = original;
        }

        public async void Shake(Form Form, int Amplitude = 10, int Duration = 20)
        {
            var original = Form.Location;
            var rnd = new Random(1337);
            int shake_amplitude = Amplitude;
            for (int i = 0; i < 10; i++)
            {
                Form.Location = new Point(original.X + rnd.Next(-shake_amplitude, shake_amplitude), original.Y + rnd.Next(-shake_amplitude, shake_amplitude));
                await Task.Delay(Duration);
            }
            Form.Location = original;
        }

        public async void Shake(Rectangle rectangle, int Amplitude = 10, int Duration = 20)
        {
            var original = rectangle.Location;
            var rnd = new Random(1337);
            int shake_amplitude = Amplitude;
            for (int i = 0; i < 10; i++)
            {
                rectangle.Location = new Point(original.X + rnd.Next(-shake_amplitude, shake_amplitude), original.Y + rnd.Next(-shake_amplitude, shake_amplitude));
                await Task.Delay(Duration);
            }
            rectangle.Location = original;
        }

    }
}
