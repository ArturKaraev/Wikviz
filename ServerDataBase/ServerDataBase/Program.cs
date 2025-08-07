
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

//Сервер
namespace Serv
{
    internal class Program
    {
        SqlConnection connection = null;
        public Program()
        {
            connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=QUESTIONS; Integrated Security=SSPI;");
        }

        // Для проверки работы и подключения к таблице базы данных Questions
        public void PrintQuestions()
        {
            try
            {
                connection.Open();

                string query = $"SELECT Quest FROM Questions";
                using (var command = new SqlCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader[0]}");
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

        // Для добавления данных в таблицу базы данных Questions, повторно не запустится, если БД уже заполнена, нужно очищать БД перед запуском запросов
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

        static void Main(string[] args)
        {
            var pr = new Program();
            pr.PrintQuestions();
            //pr.InsertQuery();

            Console.WriteLine("\n\n\n");

            int port = 2025; // порт для прослушивания
            TcpListener listener = new TcpListener(IPAddress.Loopback, port);
            listener.Start();
            Console.WriteLine($"Сервер запущен и слушает порт {port}.");

            //бесконечный цикл
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
                          
                            // Отправка строки клиенту
                            byte[] responseBytes = Encoding.UTF8.GetBytes("StringTypeVariable");
                            stream.Write(responseBytes, 0, responseBytes.Length);
                        }
                    }
                }
                catch (Exception ex)
                {
                    //вывод строки ошибки в случае проблемы
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }
            }
        }

    }
}
