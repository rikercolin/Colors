using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Colors
{
    static class Program
    {
        public static Color backgroundcolor = Color.FromArgb(224, 226, 219);
        public static Color textcolor = Color.FromArgb(95, 116, 112);

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new OpeningForm());
        }
    }
}
