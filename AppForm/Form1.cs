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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String textBoxData = "";
            textBoxData += String.Format("MultiLine:  {0}\n", txtMultiline.Text);
            textBoxData += String.Format("\nPassword:  {0}\n", txtPass.Text);
            textBoxData += String.Format("\nUppercase:  {0}\n", txtUpper.Text);
            textBoxData += String.Format("\nMasked:  {0}\n", txtMaske.Text);

            MessageBox.Show(textBoxData,"Here is the data in your TextBoxes");
        }
    }
}
