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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void txtInput_Validating(object sender, CancelEventArgs e)
        {
            if (txtInput.Text.Length > 5)
            {
                this.errorProvider1.SetError(txtInput, "Can't be greater than 5!");

            }
            else
            {
                this.errorProvider1.SetError(txtInput, "");
            }
        }
    }
}
