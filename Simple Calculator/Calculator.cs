/*
 * Analysis 
 * 
 * Program: Simple Calculator using C#
 * 
 * Developer: Jay Jaehoon Kang
 * 
 * Format: Window Form
 * 
 * Date: September 08 2018
 * 
 * Logic: Developing a calculator with funtions (+ - * /)
 * 
 * Using data types (primitive; float, int, bool) and control flows
 * 
 * number (1 and 2) first -> 0 ~ 9 calculation complete
 * 
 * */

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
    public enum Operators { Add, Sub, Multi, Div } //enum is a list-able variable -> save +, -, *, /

    public partial class Calculator : Form
    {
        public int Result = 0;
        public bool isNewNum = true;
        public Operators Opt = Operators.Add; 


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
             * Repeat ...., SetNum function, Result variable, ToString 
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
            // cleaned codes a little here

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
            if(isNewNum == false)
            { 

            int num = int.Parse(label1.Text);
            if (Opt == Operators.Add)
                Result = Add(Result, num);
            else if (Opt == Operators.Sub)
                Result = Sub(Result, num);

            Result = Result + num;

            label1.Text = Result.ToString();
            isNewNum = true;

            }
            Button optButton = (Button)sender;
            if (optButton.Text == "+")
                Opt = Operators.Add;
            else if (optButton.Text == "-")
                Opt = Operators.Sub;
        }

        private void NumClear_Click(object sender, EventArgs e)
        {
            Result = 0;
            isNewNum = true;
            Opt = Operators.Add;

            label1.Text = "0";
        }

        // var (Result) = 0
        // operator clicked +
        // enter a number

        // hit operator - number finished, variable and number saved-> result to another variable, save the current operator 
        // hit another number
        // hit operator button

        // repeat 
    }
}
