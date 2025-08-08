using Serv;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
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
            
            Random rand = new Random();
            // Генерируем число от 1 до 12
            int randomNumber1 = rand.Next(1, 13);
            int randomNumber2 = rand.Next(1, 13);
            int randomNumber3 = rand.Next(1, 13);

            number1 = randomNumber1;
            number2 = randomNumber2;
            number3 = randomNumber3;
        }

        // Создаем объект Random
        int number1;
        int number2;
        int number3;

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            TextAdress.Visible = false;
            TextPort.Visible = false;
            LabelAdress.Visible = false;
            LabelPort.Visible = false;
            Button1.Visible = false;

            Button2.Visible = true;
            TextAnswer.Visible = true;
            LabelQuest.Visible = true;
            using (var service = new QuestionService())
            {
                if (number1 == 1) { string question1 = service.LoadQuestion1(); LabelQuest.Text = question1 ?? "Вопрос не загружен из БД"; }
                if (number1 == 2) { string question1 = service.LoadQuestion2(); LabelQuest.Text = question1 ?? "Вопрос не загружен из БД"; }
                if (number1 == 3) { string question1 = service.LoadQuestion3(); LabelQuest.Text = question1 ?? "Вопрос не загружен из БД"; }
                if (number1 == 4) { string question1 = service.LoadQuestion4(); LabelQuest.Text = question1 ?? "Вопрос не загружен из БД"; }
                if (number1 == 5) { string question1 = service.LoadQuestion5(); LabelQuest.Text = question1 ?? "Вопрос не загружен из БД"; }
                if (number1 == 6) { string question1 = service.LoadQuestion6(); LabelQuest.Text = question1 ?? "Вопрос не загружен из БД"; }
                if (number1 == 7) { string question1 = service.LoadQuestion7(); LabelQuest.Text = question1 ?? "Вопрос не загружен из БД"; }
                if (number1 == 8) { string question1 = service.LoadQuestion8(); LabelQuest.Text = question1 ?? "Вопрос не загружен из БД"; }
                if (number1 == 9) { string question1 = service.LoadQuestion9(); LabelQuest.Text = question1 ?? "Вопрос не загружен из БД"; }
                if (number1 == 10) { string question1 = service.LoadQuestion10(); LabelQuest.Text = question1 ?? "Вопрос не загружен из БД"; }
                if (number1 == 11) { string question1 = service.LoadQuestion11(); LabelQuest.Text = question1 ?? "Вопрос не загружен из БД"; }
                if (number1 == 12) { string question1 = service.LoadQuestion12(); LabelQuest.Text = question1 ?? "Вопрос не загружен из БД"; }
                
               
            }
            */
        }
            
        
        int num = 0;
        string Answer1 = "";
        string Answer2 = "";
        string Answer3 = "";
        int point = 0;
        private void Button2_Click(object sender, EventArgs e)
        {
            /*
            num++;
            if (num == 1)
            {
                string Answer1 = TextAnswer.Text;
                if (Answer1 == "а") { point++; } else { }
                using (var service = new QuestionService())
                {
                    if (number2 == 1) { string question2 = service.LoadQuestion1(); LabelQuest.Text = question2 ?? "Вопрос не загружен из БД"; }
                    if (number2 == 2) { string question2 = service.LoadQuestion2(); LabelQuest.Text = question2 ?? "Вопрос не загружен из БД";}
                    if (number2 == 3) { string question2 = service.LoadQuestion3(); LabelQuest.Text = question2 ?? "Вопрос не загружен из БД";}
                    if (number2 == 4) { string question2 = service.LoadQuestion4(); LabelQuest.Text = question2 ?? "Вопрос не загружен из БД";}
                    if (number2 == 5) { string question2 = service.LoadQuestion5(); LabelQuest.Text = question2 ?? "Вопрос не загружен из БД";}
                    if (number2 == 6) { string question2 = service.LoadQuestion6(); LabelQuest.Text = question2 ?? "Вопрос не загружен из БД";}
                    if (number2 == 7) { string question2 = service.LoadQuestion7(); LabelQuest.Text = question2 ?? "Вопрос не загружен из БД";}
                    if (number2 == 8) { string question2 = service.LoadQuestion8(); LabelQuest.Text = question2 ?? "Вопрос не загружен из БД";}
                    if (number2 == 9) { string question2 = service.LoadQuestion9(); LabelQuest.Text = question2 ?? "Вопрос не загружен из БД";}
                    if (number2 == 10) { string question2 = service.LoadQuestion10(); LabelQuest.Text = question2 ?? "Вопрос не загружен из БД";}
                    if (number2 == 11) { string question2 = service.LoadQuestion11(); LabelQuest.Text = question2 ?? "Вопрос не загружен из БД";}
                    if (number2 == 12) { string question2 = service.LoadQuestion12(); LabelQuest.Text = question2 ?? "Вопрос не загружен из БД";}
                }
                TextAnswer.Text = "";
            }
            if (num == 2)
            {
                string Answer2 = TextAnswer.Text;
                if (Answer2 == "ф") { point++; } else { }               
                using (var service = new QuestionService())
                {
                    if (number3 == 1) { string question3 = service.LoadQuestion1(); LabelQuest.Text = question3 ?? "Вопрос не загружен из БД"; }
                    if (number3 == 2) { string question3 = service.LoadQuestion2(); LabelQuest.Text = question3 ?? "Вопрос не загружен из БД";}
                    if (number3 == 3) { string question3 = service.LoadQuestion3(); LabelQuest.Text = question3 ?? "Вопрос не загружен из БД";}
                    if (number3 == 4) { string question3 = service.LoadQuestion4(); LabelQuest.Text = question3 ?? "Вопрос не загружен из БД";}
                    if (number3 == 5) { string question3 = service.LoadQuestion5(); LabelQuest.Text = question3 ?? "Вопрос не загружен из БД";}
                    if (number3 == 6) { string question3 = service.LoadQuestion6(); LabelQuest.Text = question3 ?? "Вопрос не загружен из БД";}
                    if (number3 == 7) { string question3 = service.LoadQuestion7(); LabelQuest.Text = question3 ?? "Вопрос не загружен из БД";}
                    if (number3 == 8) { string question3 = service.LoadQuestion8(); LabelQuest.Text = question3 ?? "Вопрос не загружен из БД";}
                    if (number3 == 9) { string question3 = service.LoadQuestion9(); LabelQuest.Text = question3 ?? "Вопрос не загружен из БД";}
                    if (number3 == 10) { string question3 = service.LoadQuestion10(); LabelQuest.Text = question3 ?? "Вопрос не загружен из БД";}
                    if (number3 == 11) { string question3 = service.LoadQuestion11(); LabelQuest.Text = question3 ?? "Вопрос не загружен из БД";}
                    if (number3 == 12) { string question3 = service.LoadQuestion12(); LabelQuest.Text = question3 ?? "Вопрос не загружен из БД";}
                }
                TextAnswer.Text = "";
            }

            if (num == 3)
            {
                string Answer3 = TextAnswer.Text;
                if (Answer3 == "к") { point++; } else { }
                Button2.Visible = false;
                TextAnswer.Visible = false;
                LabelQuest.Visible = false;
                LabelResult.Visible = true;
                LabelResult.Text = "Ваш результат: " + point.ToString() + "/3";
                TextAnswer.Text = "";
            }
            */
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

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
    }

    public class QuestionService
    {
        public QuestionService() { }

    }
}
