using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caculator_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.main_label.Text = this.main_label.Text + "1";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.main_label.Text = this.main_label.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.main_label.Text = this.main_label.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.main_label.Text = this.main_label.Text + "4";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.main_label.Text = this.main_label.Text + "2";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.main_label.Text = this.main_label.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.main_label.Text = this.main_label.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.main_label.Text = this.main_label.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.main_label.Text = this.main_label.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.main_label.Text = this.main_label.Text + "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.main_label.Text = this.main_label.Text + "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            this.main_label.Text = "";
        }

        private void add_Click(object sender, EventArgs e)
        {
            this.operator_label.Text = "+";

            if (this.main_label.Text != "")
            {
                this.first_label.Text = this.main_label.Text;
            }
            this.main_label.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.operator_label.Text = "-";

            if (this.main_label.Text != "")
            {
                this.first_label.Text = this.main_label.Text;
            }
            this.main_label.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            double fn, sn, result = 0;

            double.TryParse(this.first_label.Text, out fn);
            double.TryParse(this.main_label.Text, out sn);

            this.main_label.Text = "";

            if (this.operator_label.Text=="+"){ result = fn + sn; }

            if (this.operator_label.Text == "-") { result = fn - sn; }

            if (this.operator_label.Text == "÷") { result = fn / sn; }

            if (this.operator_label.Text == "×") { result = fn * sn; }

            this.main_label.Text = result.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.operator_label.Text = "÷";

            if (this.main_label.Text != "")
            {
                this.first_label.Text = this.main_label.Text;
            }
            this.main_label.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.operator_label.Text = "×";

            if (this.main_label.Text != "")
            {
                this.first_label.Text = this.main_label.Text;
            }
            this.main_label.Text = "";
        }
    }
}
