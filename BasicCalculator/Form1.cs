using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicCalculator
{
    public partial class Form1 : Form
    {
        Double value = 0;
        String operation = "";
        bool operation_pressed = false;
        bool result_pressed = false;
        bool comma_pressed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_click(object sender, EventArgs e)
        {

            if (operation_pressed)
                txt_result.Clear();
            operation_pressed = false;
            
            Button btn_number = (Button)sender;
            txt_result.Text = txt_result.Text + btn_number.Text;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_result.Text = "";
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button btn_operator = (Button)sender;
            operation = btn_operator.Text;
            value = Double.Parse(txt_result.Text);
            operation_pressed = true;

        }

        private void btn_result_Click(object sender, EventArgs e)
        {
            result_pressed = true;

            switch (operation)
            {
                case "+":
                    txt_result.Text = (value + Double.Parse(txt_result.Text)).ToString();
                    break;

                case "-":
                    txt_result.Text = (value - Double.Parse(txt_result.Text)).ToString();
                    break;

                case "*":
                    txt_result.Text = (value * Double.Parse(txt_result.Text)).ToString();
                    break;

                case "/":
                    txt_result.Text = (value / Double.Parse(txt_result.Text)).ToString();
                    break;
                default:
                    break;
            }
            
            if (result_pressed)
                value = 0;
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_result.Text = ( -1 * Double.Parse(txt_result.Text)).ToString();
        }

        private void btn_click_comma(object sender, EventArgs e)
        {
            comma_pressed = true;
            Button btn_number = (Button)sender;
            txt_result.Text = txt_result.Text + btn_number.Text;
        }
    }
}
