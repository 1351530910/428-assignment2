using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _428_assignment2
{
    public partial class Form1 : Form
    {
        static string numbers = "1234567890.";
        static string[] type = {"Regular","Xpress","Priority" };
        public Form1()
        {
            InitializeComponent();
            foreach (string item in type)
            {
                comboBox1.Items.Add(item);
            }
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                package package = new package(from.Text, To.Text, float.Parse(length.Text), float.Parse(width.Text), float.Parse(height.Text), float.Parse(weight.Text), (PostType)comboBox1.SelectedIndex);

                Pricetextbox.Text = calculator.getPrice(package);
            }
            catch (Exception)
            {
            }
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void length_TextChanged(object sender, EventArgs e)
        {
            length.Text = format(length.Text);
            
        }

        private void width_TextChanged(object sender, EventArgs e)
        {
            width.Text = format(width.Text);
            
        }

        private void height_TextChanged(object sender, EventArgs e)
        {
            height.Text = format(height.Text);
            
        }

        private void weight_TextChanged(object sender, EventArgs e)
        {
            weight.Text = format(weight.Text);
            
        }

        private string format(string input)
        {
            string output = "";
            foreach (char item in input)
            {
                if (numbers.Contains(item))
                {
                    output += item;
                }
            }
            return output;


        }
    }
}
