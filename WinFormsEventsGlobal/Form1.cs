using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp0305
{
    public partial class Form1 : Form
    {
        int number = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void helloLbl_MouseHover(object sender, EventArgs e)
        {
            helloLbl.Text = "Mouse is hovering!";
        }

        private void helloLbl_MouseLeave(object sender, EventArgs e)
        {
            helloLbl.Text = "Hello!";
        }

        private void timeBtn_Click(object sender, EventArgs e)
        {
            //Convert.ToString
            MessageBox.Show(DateTime.Now.ToString(), "Time", MessageBoxButtons.OK);
        }

        private void CalcSum()
        {

            if (Double.TryParse(xTxtBx.Text, out double x) && Double.TryParse(yTxtBx.Text, out double y))
            {
                double sum = x + y;
                sumResultLbl.Text = sum.ToString();
            }
            else
            {
                sumResultLbl.Text = "?";
            }
        }

        private void xTxtBx_TextChanged(object sender, EventArgs e)
        {
            CalcSum();
            if (Double.TryParse(xTxtBx.Text, out double x))
            {
                xLbl.ForeColor = Color.Black;
            }
            else
            {
                xLbl.ForeColor = Color.Red;
            }
        }

        private void yTxtBx_TextChanged(object sender, EventArgs e)
        {
            CalcSum();
            if (Double.TryParse(yTxtBx.Text, out double y))
            {
                yLbl.ForeColor = Color.Black;
            }
            else
            {
                yLbl.ForeColor = Color.Red;
            }
        }

        private void plusBtn_Click(object sender, EventArgs e)
        {
            //int forget_me = 1;
            number++;
            numberLbl.Text = number.ToString();
        }

        private void minusBtn_Click(object sender, EventArgs e)
        {
            number--;
            numberLbl.Text = number.ToString();
        }
    }
}
