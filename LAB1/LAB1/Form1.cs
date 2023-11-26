using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LAB1
{
    public partial class Form1 : Form
    {
        public string num1;
        public int number = 0;
        public string number_str = "HaHa";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //add
            string user_input = textBox_input.Text;
            //textBox_input.Text = string.Format("{1} {0} " , "HaHa" , user_input);
            textBox_input.Text = String.Format("{0}",number);

        }

        private void button2_Click(object sender, EventArgs e)
        {

            textBox_input.Text = string.Empty;
            //clear
        }


        private void button3_Click(object sender, EventArgs e)
        {

            //1
            textBox_input.Text = "1";
            number_str += "1";
            //number += 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            textBox_input.Text = "2";
            number_str += "2";
            //number += 2;
        }

        private void button5_Click(object sender, EventArgs e)
        {

            number_str += "3";
            //number += 3;
            textBox_input.Text = "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox_input.Text = "4";
            number_str += "4";
            //number += 4;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox_input.Text = "5";
            number_str += "5";
            //number += 5;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            textBox_input.Text = "6";
            number_str += "6";
            //number += 6;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            number_str += "7";
            //number += 7;
            textBox_input.Text = "7";

        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox_input.Text = "8";
            number_str += "8";
            //number += 8;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            number_str += "9";
            //number += 9;
            textBox_input.Text = "9";

        }

        private void button12_Click(object sender, EventArgs e)
        {
            number_str += "0";
            number += 0;
            textBox_input.Text = "0";

        }

        string Operator ;
        private void button13_Click(object sender, EventArgs e)
        {
            // Plus

            num1 = textBox_input.Text;
            textBox_input.Text = string.Empty;
            Operator = "+";


        }

        private void button14_Click(object sender, EventArgs e)
        {
            // Result 

            try
            {
                    string num2 = textBox_input.Text;
                    double Num1 = double.Parse(num1) , Num2 = double.Parse(num2) ;

                    if (Operator == "+")
                    {

                        textBox_input.Text = String.Format("{0}", Num1 + Num2);

                    }
                    else if (Operator == "-")
                    {

                        textBox_input.Text = String.Format("{0}", Num1 - Num2);

                    }
                    else if (Operator == "*")
                    {

                        textBox_input.Text = String.Format("{0}", Num1 * Num2);
                }
                else
                    {
                        double num = Num1 / Num2;
                        string stringValue = num.ToString().Replace(',', '.');
                        textBox_input.Text = stringValue;
                    }
            }
            catch ( DivideByZeroException )
            {
                textBox_input.Text = "You cannot Devide by Zero";
            }
            






        }

        private void button15_Click(object sender, EventArgs e)
        {

            //minus
            num1 = textBox_input.Text;
            Operator = "-";
            textBox_input.Text = string.Empty;
            
            
        
        }

        private void button16_Click(object sender, EventArgs e)
        {
            num1 = textBox_input.Text;
            textBox_input.Text = string.Empty;
            Operator = "/";
            // devide

        }

        private void button17_Click(object sender, EventArgs e)
        {
            num1 = textBox_input.Text;
            textBox_input.Text = string.Empty;
            Operator = "*";
            // multiply

        }

        private void textBox_input_TextChanged(object sender, EventArgs e)
        {

        }
    }


}

