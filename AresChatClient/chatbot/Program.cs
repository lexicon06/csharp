using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ConectarB0t(ip: IPAddress.Parse("31.222.202.178"), puerto: 36020);
        }

        public static void ConectarB0t(IPAddress ip, int puerto)
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            Console.WriteLine("Conectando, por favor espera...");

            try
            {
                socket.Connect(new IPEndPoint(ip, puerto));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al conectar: " + ex.Message);
                return;
            }

            if (socket.Connected)
            {
                Console.WriteLine("Conectando, iniciando protocolo....");

                socket.Send(MSG_CHAT_CLIENT_LOGIN());

                Console.WriteLine("Conectando, Login Aceptado....");
            }
            else
            {
                Console.WriteLine("No se pudo establecer la conexión.");
            }
        }

        public static byte[] MSG_CHAT_CLIENT_LOGIN()
        {
            List<byte> buffer = new List<byte>();
            buffer.AddRange(new byte[] {
                2, // id 2
            });
            buffer.AddRange(Guid.NewGuid().ToByteArray()); // guid 16 bytes
            buffer.AddRange(BitConverter.GetBytes(Convert.ToInt16(666))); // Numero de archivos
            buffer.AddRange(new byte[] {
                0, // Null 1 byte
            });
            buffer.AddRange(BitConverter.GetBytes(Convert.ToInt16(5555))); // puerto DC
            buffer.AddRange(new byte[] {
                0, 0, 0, 0, // Nodos ip. 4 bytes
                0, 0, // Nodos puerto 2 bytes
                0, 0, 0, 0, // 4 bytes Null.
            });
            buffer.AddRange(Encoding.UTF8.GetBytes("Nick")); // Nick x bytes
            buffer.AddRange(new byte[] {
                0, // Null 1 byte
            });
            buffer.AddRange(Encoding.UTF8.GetBytes("?")); // cliente version x byte
            buffer.AddRange(new byte[] {
                0, // 1 byte Null.
                127, 0, 0, 1, // Local IpAdress 4 bytes
                6, 6, 6, 6, // External IpAdress Null. 4 bytes
                0, // client features 1 byte
                0, // current upload 1 byte
                0, // maximum uploads allowed 1 byte
                0, // current queued users
                20, 1, 69, // User años 1 byte, User sexo 1 byte, User country 1 byte
            });
            buffer.AddRange(Encoding.UTF8.GetBytes("Ares")); // User location x byte
            buffer.AddRange(new byte[] {
                0, // Null 1 byte
            });
            buffer.InsertRange(0, BitConverter.GetBytes(Convert.ToInt16(buffer.Count - 1)));

            return buffer.ToArray();
        }
    }
}
