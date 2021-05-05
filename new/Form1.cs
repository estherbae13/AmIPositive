using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace @new
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            int integer = Convert.ToInt32(integerInput.Text);

            //state if the integer is positive or negative
            if (integer > 0)
            {
                positiveOutput.Text = $"{integer} is a positive number";
            }
            else
            {
                positiveOutput.Text = $"{integer} is a negative number";
            }

            //state if the integer is divisible by 7
            if (integer % 7 == 0)
            {
                divisibleOutput.Text = $"{integer} is divisible by 7";
            }
            else
            {
                divisibleOutput.Text = $"{integer} is not divisible by 7";
            }
        }
    }
}
