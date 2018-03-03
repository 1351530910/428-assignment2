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
    }
}
