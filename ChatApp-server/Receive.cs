using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp_server
{
    public class Receive
    {
        public Socket socket { get; set; }
        public int count { get; set; }
    }
}
