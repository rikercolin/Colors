using System;
using System.Drawing;

namespace Colors
{
    class ColorManiplator
    {
        private Color color;
        private Random rand;
        public ColorManiplator()
        {
            this.color = Color.White;
            this.rand = new Random();
        }

        public ColorManiplator(Color color)
        {
            this.color = color;
            this.rand = new Random();
        }

        public void RandomColor()
        {
            color = Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255)); //Prevent Alpha changes
        }

        public Color GetColor()
        {
            return this.color;
        }

        public void MonochromaticShift()
        {
            byte[] colors = { color.R, color.G, color.B };

            int shift = rand.Next(8, 64);

            for (int i = 0; i < colors.Length; i++)
            {
                if (colors[i] < shift) colors[i] += (byte)shift;
                else colors[i] -= (byte)shift;
            }

            this.color = Color.FromArgb(colors[0], colors[1], colors[2]);
        }

        public void AnalogousShift()
        {
            byte shift = (byte)rand.Next(8, 255);
            byte[] colors = { color.R, color.G, color.B };

            //Find secondary color and rotate it about the primary by shift
            if (colors[0] < colors[1] && colors[1] <= colors[2]) colors[1] += shift;
            else if (colors[1] < colors[2] && colors[2] <= colors[0]) colors[2] += shift;
            else colors[0] += shift;

            this.color = Color.FromArgb(colors[0], colors[1], colors[2]);
        }

        public Color TextContrastColor()
        {
            int avg = (color.R + color.G + color.B) / 3;

            if (avg > 127) return Color.Black;
            else return Color.White;
        }
    }
}
