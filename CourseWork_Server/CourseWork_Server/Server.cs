using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using CW_Library;

namespace CourseWork_Server
{
    class Server//Мой сервер
    {
        const int port = 2505;
        static void Main(string[] args)
        {

            Calculation calculator = new Calculation();
            TcpListener server = null;
            try
            {
                IPAddress localAddr = IPAddress.Parse("127.0.0.1");
                server = new TcpListener(localAddr, port);
                BinaryFormatter formatter = new BinaryFormatter();

                // запуск слушателя
                server.Start();

                while (true)
                {
                    Console.WriteLine("Ожидание подключения... ");

                    // получаем входящее подключение
                    TcpClient client = server.AcceptTcpClient();
                    // получаем сетевой поток для чтения и записи
                    NetworkStream stream = client.GetStream();
                    Console.WriteLine("Подключен клиент.\n");
                    try
                    {
                        while (true)
                        {
                            Console.WriteLine("Ожидание запроса...");

                            //получение параметров для интегрирования
                            ApproxyParameters intParams = (ApproxyParameters)formatter.Deserialize(stream);

                            Console.WriteLine("step: {0}\nhalfperiod: {1}\ndegree: {2}", intParams.GetStep.ToString(), intParams.GetHalfPeriod.ToString(), intParams.GetDegree.ToString());

                            //расчет данных для клиента
                            GraphParameters graphParams = calculator.CalcParams(intParams.GetStep, intParams.GetHalfPeriod, intParams.GetDegree);

                            //отправляем сообщение с расчитанными данными
                            formatter.Serialize(stream, graphParams);
                            Console.WriteLine("Выполнено.\n");
                        }
                    }
                    catch (Exception ex)
                    {
                        client.Close();
                        stream.Close();
                        Console.WriteLine("[EXCEPTION] {0}", ex.Message);
                        Console.WriteLine("Клиент отключился.\n");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (server != null)
                    server.Stop();
            }
        }
    }
}
