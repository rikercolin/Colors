using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
 
            color = Color.FromArgb(rand.Next(0,255), rand.Next(0, 255), rand.Next(0, 255)); //Prevent Alpha changes
        }

        public Color GetColor()
        {
            return this.color;
        }

        public void MonochromaticShift()
        {
            byte[] colors = { color.R, color.G, color.B};

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

        }

        public Color TextContrasticColor()
        {
            return Color.Black;
        }
    }
}
