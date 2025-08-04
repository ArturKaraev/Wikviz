using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace exam
{
    public partial class Form1 : Form
    {
        private volatile bool stopTimer = false;

        SqlConnection conn = null;
        SqlDataAdapter da = null;
        DataSet ds = null;
        SqlCommandBuilder cmd = null;
        String cs = "";

        private System.Timers.Timer timer;
        private int totalSeconds;
        private int elapsedSeconds = 0;
        public Form1()
        {
            InitializeComponent();
            SqlConnection conn = null;
            SqlDataAdapter da = null;
            DataSet ds = null;
            SqlCommandBuilder cmd = null;
            String cs = "";
        }
        int points;
        string grade;

        private void button2_Click(object sender, EventArgs e)
        {
            points = 0;
            button3.Visible = true;
            button2.Visible = false;

            label1.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
            label15.Visible = true;

            label11.Visible = false;

            label14.Text = "из кода";
            stopTimer = false;
            StartTimer();

            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EXAM_SQL_FORMS;Integrated Security=True;"; 
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string sqlQuery14 = "SELECT Quest FROM [Table] WHERE Id = 1";
                    SqlDataAdapter dataAdapter14 = new SqlDataAdapter(sqlQuery14, connection);
                    string sqlQuery15 = "SELECT Quest FROM [Table] WHERE Id = 2";
                    SqlDataAdapter dataAdapter15 = new SqlDataAdapter(sqlQuery15, connection);
                    string sqlQuery1 = "SELECT Quest FROM [Table] WHERE Id = 5";
                    SqlDataAdapter dataAdapter1 = new SqlDataAdapter(sqlQuery1, connection);
                    string sqlQuery13 = "SELECT Quest FROM [Table] WHERE Id = 6";
                    SqlDataAdapter dataAdapter13 = new SqlDataAdapter(sqlQuery13, connection);

                    string sqlQuery9 = "SELECT Answer FROM [Table] WHERE Id = 1";
                    SqlDataAdapter dataAdapter9 = new SqlDataAdapter(sqlQuery9, connection);
                    string sqlQuery8 = "SELECT Answer FROM [Table] WHERE Id = 2";
                    SqlDataAdapter dataAdapter8 = new SqlDataAdapter(sqlQuery8, connection);
                    string sqlQuery7 = "SELECT Answer FROM [Table] WHERE Id = 3";
                    SqlDataAdapter dataAdapter7 = new SqlDataAdapter(sqlQuery7, connection);
                    string sqlQuery6 = "SELECT Answer FROM [Table] WHERE Id = 4";
                    SqlDataAdapter dataAdapter6 = new SqlDataAdapter(sqlQuery6, connection);

                    string sqlQuery10 = "SELECT Answer FROM [Table] WHERE Id = 5";
                    SqlDataAdapter dataAdapter10 = new SqlDataAdapter(sqlQuery10, connection);
                    string sqlQuery3 = "SELECT Answer FROM [Table] WHERE Id = 6";
                    SqlDataAdapter dataAdapter3 = new SqlDataAdapter(sqlQuery3, connection);
                    string sqlQuery5 = "SELECT Answer FROM [Table] WHERE Id = 7";
                    SqlDataAdapter dataAdapter5 = new SqlDataAdapter(sqlQuery5, connection);
                    string sqlQuery4 = "SELECT Answer FROM [Table] WHERE Id = 8";
                    SqlDataAdapter dataAdapter4 = new SqlDataAdapter(sqlQuery4, connection);

                    DataSet dataSet = new DataSet();

                    dataAdapter14.Fill(dataSet, "Table14");
                    dataAdapter15.Fill(dataSet, "Table15");
                    dataAdapter1.Fill(dataSet, "Table1");
                    dataAdapter13.Fill(dataSet, "Table13");

                    dataAdapter9.Fill(dataSet, "Table9");
                    dataAdapter8.Fill(dataSet, "Table8");
                    dataAdapter7.Fill(dataSet, "Table7");
                    dataAdapter6.Fill(dataSet, "Table6");

                    dataAdapter10.Fill(dataSet, "Table10");
                    dataAdapter3.Fill(dataSet, "Table3");
                    dataAdapter5.Fill(dataSet, "Table5");
                    dataAdapter4.Fill(dataSet, "Table4");

                    string text_quest14 = dataSet.Tables["Table14"].Rows[0]["Quest"].ToString();
                    label14.Text = text_quest14;
                    string text_quest15 = dataSet.Tables["Table15"].Rows[0]["Quest"].ToString();
                    label15.Text = text_quest15;
                    string text_quest1 = dataSet.Tables["Table1"].Rows[0]["Quest"].ToString();
                    label1.Text = text_quest1;
                    string text_quest13 = dataSet.Tables["Table13"].Rows[0]["Quest"].ToString();
                    label13.Text = text_quest13;

                    string text_quest9 = dataSet.Tables["Table9"].Rows[0]["Answer"].ToString();
                    label9.Text = text_quest9;
                    string text_quest8 = dataSet.Tables["Table8"].Rows[0]["Answer"].ToString();
                    label8.Text = text_quest8;
                    string text_quest7 = dataSet.Tables["Table7"].Rows[0]["Answer"].ToString();
                    label7.Text = text_quest7;
                    string text_quest6 = dataSet.Tables["Table6"].Rows[0]["Answer"].ToString();
                    label6.Text = text_quest6;

                    string text_quest10 = dataSet.Tables["Table10"].Rows[0]["Answer"].ToString();
                    label10.Text = text_quest10;
                    string text_quest3 = dataSet.Tables["Table3"].Rows[0]["Answer"].ToString();
                    label3.Text = text_quest3;
                    string text_quest5 = dataSet.Tables["Table5"].Rows[0]["Answer"].ToString();
                    label5.Text = text_quest5;
                    string text_quest4 = dataSet.Tables["Table4"].Rows[0]["Answer"].ToString();
                    label4.Text = text_quest4;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false; 
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;

            label11.Visible = true;
            button3.Visible = false;
            button1.Visible = true;

            if (label10.BorderStyle == BorderStyle.FixedSingle) {points++;}
            if (label7.BorderStyle == BorderStyle.FixedSingle) { points++; }

            if (points == 0) { grade = "2-"; }
            else if(points == 1) { grade = "3"; }
            else if (points == 2) { grade = "5+"; }
            label11.Text = "ОЦЕНКА: " + grade;

            stopTimer = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            button1.Visible = false;
            label11.Visible = false;

            label10.BorderStyle = BorderStyle.None;
            label3.BorderStyle = BorderStyle.None;
            label4.BorderStyle = BorderStyle.None;
            label5.BorderStyle = BorderStyle.None;
            label6.BorderStyle = BorderStyle.None;
            label7.BorderStyle = BorderStyle.None;
            label8.BorderStyle = BorderStyle.None;
            label9.BorderStyle = BorderStyle.None;
           
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
        private void label11_Click(object sender, EventArgs e)
        {

        }
        private void label14_Click(object sender, EventArgs e)
        {

        }
        private void label15_Click(object sender, EventArgs e)
        {
            
        }
        
        private void label1_Click(object sender, EventArgs e)
        {
            label1.BorderStyle = BorderStyle.FixedSingle;
        }
        private void label10_Click(object sender, EventArgs e)
        {
            label10.BorderStyle = BorderStyle.FixedSingle;
            label3.BorderStyle = BorderStyle.None;
            label4.BorderStyle = BorderStyle.None;
            label5.BorderStyle = BorderStyle.None;
            
        }
        private void label3_Click(object sender, EventArgs e)
        {
            label10.BorderStyle = BorderStyle.None;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label4.BorderStyle = BorderStyle.None;
            label5.BorderStyle = BorderStyle.None;
        }
        private void label4_Click(object sender, EventArgs e)
        {
            label10.BorderStyle = BorderStyle.None;
            label3.BorderStyle = BorderStyle.None;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label5.BorderStyle = BorderStyle.None;
        }
        private void label5_Click(object sender, EventArgs e)
        {
            label10.BorderStyle = BorderStyle.None;
            label3.BorderStyle = BorderStyle.None;
            label4.BorderStyle = BorderStyle.None;
            label5.BorderStyle = BorderStyle.FixedSingle;
        }
        private void label6_Click(object sender, EventArgs e)
        {
            label6.BorderStyle = BorderStyle.FixedSingle;
            label7.BorderStyle = BorderStyle.None;
            label8.BorderStyle = BorderStyle.None;
            label9.BorderStyle = BorderStyle.None;
        }  
        private void label7_Click(object sender, EventArgs e)
        {
            label6.BorderStyle = BorderStyle.None;
            label7.BorderStyle = BorderStyle.FixedSingle;
            label8.BorderStyle = BorderStyle.None;
            label9.BorderStyle = BorderStyle.None;
            
        }
        private void label8_Click(object sender, EventArgs e)
        {
            label6.BorderStyle = BorderStyle.None;
            label7.BorderStyle = BorderStyle.None;
            label8.BorderStyle = BorderStyle.FixedSingle;
            label9.BorderStyle = BorderStyle.None;
        }
        private void label9_Click(object sender, EventArgs e)
        {
            label6.BorderStyle = BorderStyle.None;
            label7.BorderStyle = BorderStyle.None;
            label8.BorderStyle = BorderStyle.None;
            label9.BorderStyle = BorderStyle.FixedSingle;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }
        void StartTimer()
        {
            TimeSpan ts = new TimeSpan(0, 1, 0);
            Task.Factory.StartNew(() => {
                while (ts.Seconds != -1)
                {
                    if (stopTimer)
                    {
                        break;
                    }
                    label12.Invoke((Action)(() => { label12.Text = ts.ToString(); }));
                    Thread.Sleep(1000);
                    ts = ts.Subtract(new TimeSpan(0, 0, 1));
                }
                label12.Invoke((Action)(() => { label12.Text = "время закончилось!"; }));
            });
        }
    }
}
