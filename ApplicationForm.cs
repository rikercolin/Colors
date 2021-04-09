using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colors
{
    public partial class ApplicationForm : Form
    {
        public ApplicationForm()
        {
            InitializeComponent();
        }

        private void ApplicationForm_Load(object sender, EventArgs e)
        {

        }

        private void SetSeedColor_Click(object sender, EventArgs e)
        {
            SeedColorPicker.AllowFullOpen = true;
            SeedColorPicker.ShowHelp = true;
            SeedColorPicker.Color = ColorBox1.BackColor;

            if (SeedColorPicker.ShowDialog() == DialogResult.OK)
            {
                ColorManiplator maniplator = new ColorManiplator(SeedColorPicker.Color);
                SetPanelAndLabel(ColorBox1, ColorLabel1, maniplator.GetColor(), maniplator.TextContrastColor());
            }

        }

        private void RandomSeedColor_Click(object sender, EventArgs e)
        {
            ColorManiplator maniplator = new ColorManiplator();
            maniplator.RandomColor();

            SetPanelAndLabel(ColorBox1, ColorLabel1, maniplator.GetColor(), maniplator.TextContrastColor());
         }

        private void Generate_Click(object sender, EventArgs e)
        {
            ColorManiplator maniplator = new ColorManiplator(ColorBox1.BackColor);
            maniplator.MonochromaticShift();
            SetPanelAndLabel(ColorBox2, ColorLabel2, maniplator.GetColor(), maniplator.TextContrastColor());

            maniplator = new ColorManiplator(ColorBox1.BackColor);
            maniplator.AnalogousShift();
            SetPanelAndLabel(ColorBox3, ColorLabel3, maniplator.GetColor(), maniplator.TextContrastColor());

            maniplator.AnalogousShift();
            SetPanelAndLabel(ColorBox4, ColorLabel4, maniplator.GetColor(), maniplator.TextContrastColor());

            maniplator.AnalogousShift();
            SetPanelAndLabel(ColorBox5, ColorLabel5, maniplator.GetColor(), maniplator.TextContrastColor());
        }

        private void SavePallete_Click(object sender, EventArgs e)
        {

        }

        private void SetPanelAndLabel(Panel panel, Label label, Color color, Color textcolor)
        {
            panel.BackColor = color;
            label.Text = "#" + color.R.ToString("X2") + color.G.ToString("X2") + color.B.ToString("X2");
            label.ForeColor = textcolor;
        }
    }
}
