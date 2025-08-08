using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace @interface
{
    internal class Program
    {
        // Для того чтобы вручную в коде запустился консоль
        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        private static extern bool AllocConsole();

        // Соединение c Базой данных
        SqlConnection connection = null;

        public Program()
        {
            connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;
                                          Initial Catalog=QUESTIONS;
                                          Integrated Security=True;");
        }

        // Этот метот заносит данные в Базу Данных
        public void InsertQuery()
        {
            try
            {
                connection.Open();

                string insert = "" +
                      "INSERT INTO Questions (Id, Quest, Answer) VALUES (1, N'Что выведет этот код?\n\tint i = 0;\n\tConsole.WriteLine(i++ + ++i);', '2');" +
                    "\bINSERT INTO Questions (Id, Quest, Answer) VALUES (2, N'Что произойдет при выполнении этого кода?\n\tstring s = null;\n\tConsole.WriteLine(s is string)', 'False');" +
                    "\bINSERT INTO Questions (Id, Quest, Answer) VALUES (3, N'Что выведет этот код?\n\tConsole.WriteLine(1 / 2 * 3.0);', '0.0');" +
                    "\bINSERT INTO Questions (Id, Quest, Answer) VALUES (4, N'Что выведет этот код?\n\tConsole.WriteLine(1 + 2 + \"3\" + 4 + 5)', '\"3345\"');" +
                    "\bINSERT INTO Questions (Id, Quest, Answer) VALUES (5, N'Что выведет этот код?\n\tvar a = new Action(() => Console.Write(\"A\"));\n\tvar b = new Action(() => Console.Write(\"B\"));\n\tvar c = a + b + a;c();', 'ABA');" +
                    "\bINSERT INTO Questions (Id, Quest, Answer) VALUES (6, N'Что выведет этот код?\n\tvar dict = new Dictionary<string, int> { { \"a\", 1 } };\n\tdict[\"a\"]++;\n\tConsole.WriteLine(dict[\"a\"]);', '2');" +
                    "\bINSERT INTO Questions (Id, Quest, Answer) VALUES (7, N'Какой результат выполнения?\n\ttry {throw new Exception(\"1\");}\n\tcatch (Exception ex)\n\t{Console.Write(ex.Message);\n\tthrow new Exception(\"2\");}\n\tfinally {Console.Write(\"3\");}', N'Программа упадёт с Exception(\"2\")');" +
                    "\bINSERT INTO Questions (Id, Quest, Answer) VALUES (8, N'Что будет, если в switch передать null для enum? enum Color {Red, Green}\n\tColor? color = null;\n\tswitch (color)\n\t{ ... }', N'Ничего, switch обрабатывает null.');" +
                    "\bINSERT INTO Questions (Id, Quest, Answer) VALUES (9, N'Где хранятся локальные переменные метода (не static, не поля класса)?', N'В стеке (stack)');" +
                    "\bINSERT INTO Questions (Id, Quest, Answer) VALUES (10, N'Можно ли создать экземпляр интерфейса в C#?', N'Нет, интерфейсы — это абстракции');" +
                    "\bINSERT INTO Questions (Id, Quest, Answer) VALUES (11, N'Что произойдёт, если в finally бросить исключение?\n\ttry {throw new Exception(\"A\");}\n\tfinally {throw new Exception(\"B\");}', N'Будет выброшено исключение \"B\" (первое теряется)');" +
                    "\bINSERT INTO Questions (Id, Quest, Answer) VALUES (12, N'Может ли деструктор (финализатор) быть вызван явно?\n\tclass Test {~Test() => Console.Write(\"Finalized\");}\n\tvar t = new Test(); // Можно ли вызвать деструктор вручную?', N'Нет, только сборщик мусора вызывает финализатор');";
                string[] inserts = insert.Split('\b');

                foreach (string command in inserts)
                {
                    SqlCommand cmd = new SqlCommand(command, connection);
                    cmd.ExecuteNonQuery();
                }
                Console.WriteLine("This came wonderful");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Database error: {ex.Message}");
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }

            }
        }

        // Этот метод выводит данные из таблицы, для проверки работы
        // Зачем
        public void PrintQuestions()
        {
            try
            {
                connection.Open();

                string query = $"SELECT Quest FROM QUESTIONS";
                using (var command = new SqlCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"Question: {reader[0]}");
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Database error: {ex.Message}");
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }

            }
        }

        // Метод, содержащий логику запуска и работы сервера
        // Еще даже не в разработке
        public void ServerRun()
        {
            int port = 2025;
            TcpListener listener = new TcpListener(IPAddress.Loopback, port);
            listener.Start();
            Console.WriteLine($"Сервер запущен и слушает порт {port}.");

            while (true)
            {
                try
                {
                    using (TcpClient client = listener.AcceptTcpClient())
                    using (NetworkStream stream = client.GetStream())
                    {
                        // Чтение данных
                        byte[] buffer = new byte[4]; // целое число int32 занимает 4 байта
                        int bytesRead = stream.Read(buffer, 0, buffer.Length);
                        if (bytesRead == 4)
                        {
                            int receivedNumber = BitConverter.ToInt32(buffer, 0);


                            // В зависимости от числа выбираем расцветку камуфляжа
                            string poem;
                            if (receivedNumber == 12 || receivedNumber == 1 || receivedNumber == 2)
                                poem = "ВЕСЕННЯЯ расцветка камуфляжа - коричневый цвет";
                            else if (receivedNumber == 6 || receivedNumber == 7 || receivedNumber == 8)
                                poem = "ЛЕТНЯЯ расцветка камуфляжа - зелённый цвет";
                            else if (receivedNumber == 9 || receivedNumber == 10 || receivedNumber == 11)
                                poem = "ОСЕННЯЯ расцветка камуфляжа - ораньжевый цвет";
                            else poem = "ЗИМНЯЯ расцветка камуфляжа - белый цвет";
                            Console.WriteLine($"Получено число: {receivedNumber}; Отпрвлен текст: {poem}");

                            // Отправка строки клиенту
                            byte[] responseBytes = Encoding.UTF8.GetBytes(poem);
                            stream.Write(responseBytes, 0, responseBytes.Length);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }
            }
        }

        // Метод содержит код работы клиента с сервером, каким-то боком асинхронно
        // Тем более не в разработке
        public async void ClientRun()
        {
            try
            {
                using (TcpClient client = new TcpClient())
                {
                    await client.ConnectAsync("127.0.0.1", 2025);
                    using (NetworkStream stream = client.GetStream())
                    {
                        // Отправка числа
                        byte[] dataToSend = Encoding.UTF8.GetBytes("number");
                        await stream.WriteAsync(dataToSend, 0, dataToSend.Length);

                        // Чтение ответа
                        byte[] buffer = new byte[1024];
                        int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
                        string response = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                        //Вывод полученных данных
                        //textBoxResult.Text = response;
                    }
                }
            }
            catch (Exception ex)
            {
                //вывод ошибки в случае проблемы
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        [STAThread]
        static void Main()
        {
            // Создаем и показываем консоль
            AllocConsole();

            // Запускаем сервер в отдельном потоке, чтобы обдновременно запустилась и форма и консольное приложение
            Thread serverThread = new Thread(() =>
            {
                var pr = new Program();
                pr.PrintQuestions();
                pr.ServerRun();
            });
            serverThread.IsBackground = true;
            serverThread.Start();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

    }
}
