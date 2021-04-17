using System;
using System.Windows.Forms;

namespace Colors
{
    /**
     * Title: Colors
     * Application Type: WinForms
     * Description: A Color Pallete Generation App
     * Author: Colin R.
     * Date Created: 4/8/2021
     * Last Edited: 4/17/2021
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
            if (start) Application.Run(new ApplicationForm());
            Application.Run(new ExitForm());
        }

    }
}
