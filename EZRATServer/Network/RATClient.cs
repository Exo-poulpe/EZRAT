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
    }
}
