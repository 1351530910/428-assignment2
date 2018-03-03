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
        static string[] type = {"Regular","Xpress","Priority" };
        public Form1()
        {
            InitializeComponent();
            foreach (string item in type)
            {
                comboBox1.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            package package = new package(from.Text, To.Text, int.Parse(length.Text), int.Parse(width.Text), int.Parse(height.Text), int.Parse(weight.Text), (PostType)comboBox1.SelectedIndex);
            
            Pricetextbox.Text = calculator.getPrice(package); ;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void length_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(length.Text, "[^0-9]"))
            {
                length.Text = length.Text.Remove(length.Text.Length - 1);
            }
        }

        private void width_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(width.Text, "[^0-9]"))
            {
                width.Text = width.Text.Remove(width.Text.Length - 1);
            }
        }

        private void height_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(height.Text, "[^0-9]"))
            {
                height.Text = height.Text.Remove(height.Text.Length - 1);
            }
        }

        private void weight_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(weight.Text, "[^0-9]"))
            {
                weight.Text = weight.Text.Remove(weight.Text.Length - 1);
            }
        }
    }
}
