using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFlab1_2
{
    public partial class Form1 : Form
    {
        double Number;
        string Action;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null)
            { textBox1.Text = "7"; }
            else textBox1.Text = textBox1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null)
            { textBox1.Text = "8"; }
            else textBox1.Text = textBox1.Text + "8";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null)
            { textBox1.Text = "1"; }
            else textBox1.Text = textBox1.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null)
            { textBox1.Text = "2"; }
            else textBox1.Text = textBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null)
            { textBox1.Text = "3"; }
            else textBox1.Text = textBox1.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null)
            { textBox1.Text = "4"; }
            else textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null)
            { textBox1.Text = "5"; }
            else textBox1.Text = textBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null)
            { textBox1.Text = "6"; }
            else textBox1.Text = textBox1.Text + "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null)
            { textBox1.Text = "9"; }
            else textBox1.Text = textBox1.Text + "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null)
            { textBox1.Text = "0"; }
            else textBox1.Text = textBox1.Text + "0";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            Number = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            Action = "+";
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            Number = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            Action = "-";
        }

        private void buttonMnoz_Click(object sender, EventArgs e)
        {
            Number = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            Action = "*";
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            Number = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            Action = "/";
        }

        private void buttonSter_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void buttonRowna_Click(object sender, EventArgs e)
        {
            double SecondNumber;
            double Result;

            SecondNumber = Convert.ToDouble(textBox1.Text);

            if (Action == "+")
            {
                Result = (Number + SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                Number = Result;
            }
            if (Action == "-")
            {
                Result = (Number - SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                Number = Result;
            }
            if (Action == "*")
            {
                Result = (Number * SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                Number = Result;
            }
            if (Action == "/")
            {
                Result = (Number / SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                Number = Result;
            }
            
        }

        private void buttonPrze_Click(object sender, EventArgs e)
        {

            textBox1.Text = textBox1.Text+ ",";
        }

    }
    }
    

