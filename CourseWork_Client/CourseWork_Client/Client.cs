using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using CW_Library;

namespace CourseWork_Client
{
    class Client//MOI
    {
        private const int port = 2505; // порт сервера
        private const string address = "127.0.0.1"; // адрес сервера
        private GraphParameters graphParams;

        BinaryFormatter formatter;
        TcpClient client;
        NetworkStream stream;

        public Client()
        {
            formatter = new BinaryFormatter();
        }

        public GraphParameters GetGraphParams => graphParams;
        public void Start(int step, int halfperiod, int degree) //установка соединения с сервером
        {
            client = new TcpClient();
            client.Connect(address, port);
            stream = client.GetStream();
        }

        public void Stop() //закрытие соединения
        {
            if (client != null && stream != null)
            {
                stream.Close();
                client.Close();
            }
        }

        public void Request(int step, int halfperiod, int degree)
        {
            ApproxyParameters intParams = new ApproxyParameters(step, halfperiod, degree);

            //отправляем значения для интегрирования на сервер
            formatter.Serialize(stream, intParams);

            //прием параметров для построения графа
            graphParams = (GraphParameters)formatter.Deserialize(stream);
        }
    }
}
