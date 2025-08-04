using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

//Сервер
namespace Serv
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
                    //вывод строки ошибки в случае проблемы
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }
            }
        }

    }
}
