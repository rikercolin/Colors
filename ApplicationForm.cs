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
                ColorBox1.BackColor = SeedColorPicker.Color;
            }

        }

        private void RandomSeedColor_Click(object sender, EventArgs e)
        {
            ColorManiplator maniplator = new ColorManiplator();
            maniplator.RandomColor();
            ColorBox1.BackColor = maniplator.GetColor();
        }

        private void Generate_Click(object sender, EventArgs e)
        {

        }

        private void SavePallete_Click(object sender, EventArgs e)
        {

        }
    }
}
