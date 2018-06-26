using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iCalc4me
{
    public partial class Form1 : Form
    {
        Double value = 0;
        String operation = "";
        bool operation_pressed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if((mytextBox.Text == "0") || (operation_pressed))
            {
                mytextBox.Clear();
            }
            operation_pressed = false;
            Button b = (Button)sender;
            mytextBox.Text = mytextBox.Text + b.Text;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            mytextBox.Text = "0";
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender; 
            operation = b.Text;
            value = Double.Parse(mytextBox.Text);
            operation_pressed = true;
            myLabel.Text = value + " " + operation;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
            myLabel.Text = " ";
            switch(operation)
            {
                case "+":
                    mytextBox.Text = (value + Double.Parse(mytextBox.Text)).ToString();
                    break;
                case "-":
                    mytextBox.Text = (value - Double.Parse(mytextBox.Text)).ToString();
                    break;
                case "*":
                    mytextBox.Text = (value * Double.Parse(mytextBox.Text)).ToString();
                    break;
                case "/":
                    mytextBox.Text = (value / Double.Parse(mytextBox.Text)).ToString();
                    break;
                default:
                    break;
            }
            
        }

        private void button17_Click(object sender, EventArgs e)
        {
            mytextBox.Clear();
            value = 0;

        }
    }
}
