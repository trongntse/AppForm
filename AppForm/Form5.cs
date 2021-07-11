using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppForm
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void red_scroll_event(object sender, EventArgs e)
        {
            changeColor();
        }

        private void green_scroll_event(object sender, EventArgs e)
        {
            changeColor();
        }

        private void blue_scroll_event(object sender, EventArgs e)
        {
            changeColor();
        }

        void changeColor()
        {
            Color c = Color.FromArgb(redTrackBar.Value, greenTrackBar.Value, blueTrackBar.Value);
            this.panelColor.BackColor = c;

            lblCurrColor.Text = String.Format("Current color is: ({0},{1},{2})",redTrackBar.Value, greenTrackBar.Value, blueTrackBar.Value);

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
