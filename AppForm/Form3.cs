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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime d = myCalendar.SelectionStart;
            String dateStr = String.Format("{0}/{1}/{2}/{3}",d.DayOfWeek, d.Day, d.Month, d.Year);

            MessageBox.Show("Here  is your day: "+ dateStr);
        }
    }
}
