using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace @interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextAdress.Visible = false;
            TextPort.Visible = false;
            LabelAdress.Visible = false;
            LabelPort.Visible = false;
            Button1.Visible = false;

            Button2.Visible = true;
            TextAnswer.Visible = true;
            LabelQuest.Visible = true;
        TextAnswer: { Location = new Point(1000, 50); };
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)

        {

        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}
