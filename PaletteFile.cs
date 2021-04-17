using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Colors
{
    class PaletteFile
    {
        private Color[] colors;
        public PaletteFile(Color a, Color b, Color c, Color d, Color e)
        {
            Color[] colorss = { a, b, c, d, e };
            colors = colorss;
        }

        public void Save()
        {
            SaveFileDialog savePaletteDialog = new SaveFileDialog();

            savePaletteDialog.Filter = "All files (*.*)|*.*|png files (*.png)|*.png";
            savePaletteDialog.FilterIndex = 2;
            savePaletteDialog.RestoreDirectory = true;

            if (savePaletteDialog.ShowDialog() == DialogResult.OK)
            {
                var bmp = GenerateImage();
                bmp.Save(savePaletteDialog.FileName);
            }
        }

        private Bitmap GenerateImage()
        {
            Bitmap bmp = new Bitmap(1000, 600);
            Graphics graphics = Graphics.FromImage(bmp);

            for (int i = 0; i < 5; i++)
            {
                SolidBrush textbrush = new SolidBrush(ColorManiplator.TextContrastColor(colors[i]));
                SolidBrush colorbrush = new SolidBrush(colors[i]);
                Font font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));

                graphics.FillRectangle(colorbrush, (i * 200), 0, 200, 600);
                graphics.DrawString(ColorManiplator.ColorHexCode(colors[i]), font, textbrush, ((i * 200) + 52),500);
            }
            graphics.Save();
            return bmp;
        }
    }
}

