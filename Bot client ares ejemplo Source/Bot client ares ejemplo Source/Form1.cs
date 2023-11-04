using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Runtime.InteropServices;


namespace WindowsFormsApplication1
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Socket Socket;
        public System.Net.Sockets.NetworkStream Stream;




        public void ConectarB0t(IPAddress ip, int puerto)
        {


            Socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);


            richTextBox1.Text += " Conectando, por favor espera..." + Environment.NewLine;


            try
            {
                Socket.Connect(new IPEndPoint(ip, Convert.ToInt32(puerto)));
            }
            catch (Exception ex)
            {


            }
            if (Socket.Connected == true)
            {
                richTextBox1.Text += "Conectando, iniciando protocolo...." + Environment.NewLine;




                Socket.Send(MSG_CHAT_CLIENT_LOGIN());
                richTextBox1.Text += "Conectando, Login Aceptado...." + Environment.NewLine;
            }
            else
            {


            }
        }




        //
        public byte[] MSG_CHAT_CLIENT_LOGIN()
        {
            //Aclaracion Este codigo no es de cb0t ni nada parecido!!!




            List<byte> buffer = new List<byte>();
            buffer.AddRange(new byte[] {//nueva cadena de bytes
2,//id 2
});
            buffer.AddRange(Guid.NewGuid().ToByteArray()); //guid 16 bytes
            buffer.AddRange(BitConverter.GetBytes(Convert.ToInt16(666))); //Numero de archivos
            buffer.AddRange(new byte[] {
0,//Null 1byte
});
            buffer.AddRange(BitConverter.GetBytes(Convert.ToInt16(5555))); //puerto DC
            buffer.AddRange(new byte[] {//nueva cadena de bytes
0,0,0,0,//Nodos ip. 4bytes
0,0,//Nodos puerto 2 bytes
0,0,0,0,//4bytes Null.
});
            buffer.AddRange(Encoding.UTF8.GetBytes("Nick"));//Nick x bytes
            buffer.AddRange(new byte[] {
0,//Null 1byte
});
            buffer.AddRange(Encoding.UTF8.GetBytes("B0t"));//cliente version xbyte
            buffer.AddRange(new byte[] {//nueva cadena de bytes
0,//1byte Null.
127,0,0,1,//Local IpAdress 4 bytes
6,6,6,6,//External IpAdress Null. 4bytes
0,//client features 1 byte
0,//current upload 1byte
0,//maximum uploads allowed 1byte
0,//current queued users
20,1,69,//User años 1byte, User sexo 1byte, User country 1byte

});
            buffer.AddRange(Encoding.UTF8.GetBytes("Ares"));//User location xbyte
            buffer.AddRange(new byte[] {
0,//Null 1byte
});
            buffer.InsertRange(0, BitConverter.GetBytes(Convert.ToInt16(buffer.Count - 1)));
            return buffer.ToArray();
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            ConectarB0t(System.Net.IPAddress.Parse("127.0.0.1"), 6969);

        }
    }
}