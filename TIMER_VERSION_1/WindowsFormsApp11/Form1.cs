using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        bool timer_is_on;
        int begin; // Количество секунд в таймере
        public Form1()
        {
            InitializeComponent();
            timer_is_on = false;
            begin = 30;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.timer_is_on == false)
            {
                this.timer_is_on = true;
                TimerBeginAsync();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private async Task TimerBeginAsync()
        {
            TimeSpan time;
            while (this.begin > 0)
            {
                begin -= 1;
                time = new TimeSpan(0, 0, this.begin);
                label1.Text = time.ToString(@"m\:ss");
                await Task.Delay(1000);
            }
            time = new TimeSpan(0, 0, this.begin);
            label1.Text = time.ToString(@"m\:ss");
        }
    }
}
