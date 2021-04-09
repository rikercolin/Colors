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
    public partial class OpeningForm : Form
    {
        public OpeningForm()
        {
            InitializeComponent();
        }

        private void OpeningForm_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                FreepikCredit.LinkVisited = true;
                System.Diagnostics.Process.Start("https://www.freepik.com");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something has gone wrong with the link you clicked!\n" + ex.Message);
            }
        }

        private void TablePanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
