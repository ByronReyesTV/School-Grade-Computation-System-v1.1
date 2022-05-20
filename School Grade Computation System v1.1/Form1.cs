using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Grade_Computation_System_v1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Name
            String label1 = textBox1.Text;
            String label2 = textBox2.Text;
            String label3 = textBox3.Text;

            // Section
            String label4 = textBox4.Text;

            // Grades
            double label5 = Convert.ToDouble(textBox5.Text);
            double label6 = Convert.ToDouble(textBox6.Text);
            double label7 = Convert.ToDouble(textBox7.Text);
            double label8 = Convert.ToDouble(textBox8.Text);
            double label9 = Convert.ToDouble(textBox9.Text);
            double label10 = Convert.ToDouble(textBox10.Text);
            double label11 = Convert.ToDouble(textBox11.Text);
            double label12 = Convert.ToDouble(textBox12.Text);

            // Compilation:

            // Full name
            String fullname = label1 + label2 + label3;

            // Math 
            double sum = label5 + label6 + label7 + label8 + label9 + label10 + label11 + label12;

            // Average Computation
            double div = sum / 8;

            label13.Text = fullname;
            label14.Text = label4;
            label15.Text = "The General Average is: " + div;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //clear
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //clear all
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
        }
    }
}
