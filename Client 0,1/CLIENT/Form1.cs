using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Клиент
namespace CLIENT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
       

        // Инициализация компонентов
        textBoxInput = new TextBox() { Location = new Point(10, 10), Width = 100 };
        buttonSend = new Button() { Location = new Point(120, 10), Text = "Отправить" };
        textBoxResult = new TextBox() { Location = new Point(10, 50), Width = 200, Height = 150, Multiline = true, ReadOnly = true, Text = "Введите действительный порядковый номер месяца" };

        this.Controls.Add(textBoxInput);
        this.Controls.Add(buttonSend);
        this.Controls.Add(textBoxResult);

        buttonSend.Click += ButtonSend_Click;

        }

    private async void ButtonSend_Click(object sender, EventArgs e)
    {
            if (int.TryParse(textBoxInput.Text, out int number))
            {
                //проверка на правильность ввода данных
                if (number == 1 || number == 2 || number == 3 || number == 4 || number == 5 || number == 6 || number == 7 || number == 8 || number == 9 || number == 10 || number == 11 || number == 12)
                {

                    //попытка отправки запроса
                    try
                    {
                        using (TcpClient client = new TcpClient())
                        {
                            await client.ConnectAsync("127.0.0.1", 2025);
                            using (NetworkStream stream = client.GetStream())
                            {
                                // Отправка числа
                                byte[] dataToSend = BitConverter.GetBytes(number);
                                await stream.WriteAsync(dataToSend, 0, dataToSend.Length);

                                // Чтение ответа
                                byte[] buffer = new byte[1024];
                                int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
                                string response = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                                //Вывод полученных данных
                                textBoxResult.Text = response;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        //вывод ошибки в случае проблемы
                        MessageBox.Show($"Ошибка: {ex.Message}");
                    }
                }
                else
                {
                    //просьба ввести правильные данные
                    MessageBox.Show("Требуется число от 1 до 12");
                }
            }
            else
            {
                //просьба ввести правильные данные
                MessageBox.Show("Требуется корректное целое число");
            }
    }

    private TextBox textBoxInput;
    private Button buttonSend;
    private TextBox textBoxResult;
}
}