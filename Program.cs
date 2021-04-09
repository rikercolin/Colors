using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Colors
{
    /**
     * Title: Colors
     * Application Type: WinForms
     * Description: A Color Pallete Generation App
     * Author: Colin R.
     * Date Created: 4/8/2021
     * Last Edited: 4/9/2021
    **/
    static class Program
    {
        public static bool start = false;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Application.Run(new OpeningForm()); //This is blocking
            if(start) Application.Run(new ApplicationForm());
        }

    }
}
