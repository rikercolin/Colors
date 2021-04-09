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
        public ColorManiplator()
        {
            this.color = Color.White;
        }

        public ColorManiplator(Color color)
        {
            this.color = color;
        }

        public void RandomColor()
        {
            Random rand = new Random();
            color = Color.FromArgb(rand.Next());
        }

        public Color GetColor()
        {
            return this.color;
        }
    }
}
