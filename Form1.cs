﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String operatinoPerformed = "";
        bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if((textBox_Result.Text == "0") || (isOperationPerformed))
                textBox_Result.Clear();
            isOperationPerformed = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if(!textBox_Result.Text.Contains("."))
               textBox_Result.Text = textBox_Result.Text+ button.Text;
            }else 
            textBox_Result.Text = textBox_Result.Text + button.Text;
        }

        private void textBox_Result_TextChanged(object sender, EventArgs e)
        {

        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultValue != 0)
            {
                button9.PerformClick();
                operatinoPerformed = button.Text;
                labelCurrentOperation.Text = resultValue + " " + operatinoPerformed;
                isOperationPerformed = true;
            }
            else
            {
                operatinoPerformed = button.Text;
                resultValue = Double.Parse(textBox_Result.Text);

                labelCurrentOperation.Text = resultValue + " " + operatinoPerformed;
                isOperationPerformed = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            resultValue = 0;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            switch(operatinoPerformed)
            {
                case "+":
                    textBox_Result.Text = (resultValue + Double.Parse(textBox_Result.Text)).ToString(); break;

                case "-":
                    textBox_Result.Text = (resultValue - Double.Parse(textBox_Result.Text)).ToString(); break;

                case "*":
                    textBox_Result.Text = (resultValue * Double.Parse(textBox_Result.Text)).ToString(); break;

                case "/":
                    textBox_Result.Text = (resultValue / Double.Parse(textBox_Result.Text)).ToString(); break;

                default:
                    break;
            }
            resultValue = Double.Parse(textBox_Result.Text);
            labelCurrentOperation.Text = "";
        }
    }
}
    