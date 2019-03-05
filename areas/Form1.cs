using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace areas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            double length = 0.0;
            try
            {
                length = double.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show(textBox1.Text + " is not an number");
                length = 0.0;
            }


            double width = 0.0;
            try
            {
                width = double.Parse(textBox2.Text);
            }
            catch
            {
                MessageBox.Show(textBox2.Text + " is not an number");
                width = 0.0;
            }



            double area = length * width;
            textBox3.AppendText(area.ToString());

        }
    }
}
