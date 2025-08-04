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
                timer_begin();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void timer_begin()
        {
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        // Отвечает за то, что будtт меняться через каждую итерацию таймера timer
        void Timer_Tick(object sender, EventArgs e)
        {
            if (this.begin == 0)
            {
                label1.Text = "КОНЕЦ:)";
            }
            else
            {
                begin -= 1;
                // Специальный класс для удобного хранения Времени
                TimeSpan time = new TimeSpan(0, 0, this.begin);
                label1.Text = time.ToString(@"m\:ss");
            }
        }
    }
}
