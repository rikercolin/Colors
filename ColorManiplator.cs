using System;
using System.Drawing;

namespace Colors
{
    /// <summary>
    /// Color Maniplator is a class for changing and altering colors and certain related utlitizes and functions related to colors.
    /// </summary>
    class ColorManiplator
    {
        private Color color;
        private Random rand;
        
        /// <summary>
        /// Constructs a new maniplator with a default color
        /// </summary>
        public ColorManiplator()
        {
            this.color = Color.White;
            this.rand = new Random();
        }

        /// <summary>
        /// Constructs a new maniplator with a provided color
        /// </summary>
        /// <param name="color"></param>
        public ColorManiplator(Color color)
        {
            this.color = color;
            this.rand = new Random();
        }

        /// <summary>
        /// Seeds a random color into the maniplator
        /// </summary>
        public void RandomColor()
        {
            color = Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255)); //Prevent Alpha changes
        }

        /// <summary>
        /// Get's the color assocated with this maniplator
        /// </summary>
        /// <returns>The Color currently being maniplated</returns>
        public Color GetColor()
        {
            return this.color;
        }

        /// <summary>
        /// Mutates the seeded color through a bounded Monochromatic Shift.
        /// </summary>
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

        /// <summary>
        /// Mutates the seeded color through a bounded Analogous Shift.
        /// </summary>
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

        /// <summary>
        /// Get's a sane text color for the color being manuplated.
        /// </summary>
        /// <returns>A Color type to be used on text</returns>
        public Color TextContrastColor()
        {
            int avg = (color.R + color.G + color.B) / 3;

            if (avg > 127) return Color.Black;
            else return Color.White;
        }

        /// <summary>
        /// Statically get's a sane text color for the provided color.
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public static Color TextContrastColor(Color color)
        {
            int avg = (color.R + color.G + color.B) / 3;

            if (avg > 127) return Color.Black;
            else return Color.White;
        }

        /// <summary>
        /// Gets the hexcode repersentation of a Color Type
        /// </summary>
        /// <param name="color"></param>
        /// <returns>A string repersentation of the color's hexcode</returns>
        public static string ColorHexCode(Color color)
        {
            return "#" + color.R.ToString("X2") + color.G.ToString("X2") + color.B.ToString("X2");
        }
    }
}
