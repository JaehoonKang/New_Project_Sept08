using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloCSharpWinForm
{
    public partial class Calculator : Form
    {
        public int Result = 0;
        public bool isNewNum = true;


        public Calculator()
        {
            InitializeComponent();
        }


        public int Add(int number1, int number2)
        {
            int sum = number1 + number2;
            return sum;
        }

        public float Add(float number1, float number2)
        {
            float sum = number1 + number2;
            return sum;
        }

        public int Sub(int number1, int number2)
        {
            int sub = number1 - number2;
            return sub;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void NumButton1_Click(object sender, EventArgs e)
        {
            /* Logic
             * var =0
             * 
             * Enter num1 and store it in var1
             * 
             * Enter num2
             * 
             * Store it as var2 and sum var1 and var2 => store the result in var1
             *
             * Repeat ....
             **/

            Button numButton = (Button) sender;
            SetNum(numButton.Text);
        }

        private void NumButton2_Click(object sender, EventArgs e)
        {
            SetNum("2");
        }
        
        public void SetNum(string num)
        {
            if (isNewNum)
            {
                label1.Text = num;
                isNewNum = false;
            }
            else if (label1.Text == "0")
            {
                label1.Text = num;
            }
            else
            {
                label1.Text = label1.Text + num;
            }
        }

        private void NumPlus_Click(object sender, EventArgs e)
        {
            int num = int.Parse(label1.Text);

            Result = Result + num;

            label1.Text = Result.ToString();
            isNewNum = true;
        }
    }
}
