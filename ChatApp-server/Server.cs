using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApp_server
{
    public partial class Server : Form
    {
        bool active;
        private Socket _socket;
        Dictionary<Socket, int> sockets = new Dictionary<Socket, int>();
        BackgroundWorker worker = new BackgroundWorker();
        public Server()
        {
            InitializeComponent();
        }
        public void StartServer()
        {
            active = true;
            IPHostEntry iphost = Dns.GetHostEntry("127.0.0.1");
            IPAddress ip = iphost.AddressList[0];
            IPEndPoint ep = new IPEndPoint(ip, 22);

            Socket socketserver = new Socket(ep.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            socketserver.Bind(ep);
            socketserver.Listen(10);

            _socket = socketserver;
        }
        private void Start_Click(object sender, EventArgs e)
        {
            this.StartServer();
            Start.Enabled = false;
            ShutDown.Enabled = true;
            IPAddress.Text = _socket.AddressFamily.ToString();
            Port.Text = "22";


            worker.DoWork += backgroundWorker1_DoWork;
            worker.ProgressChanged += backgroundWorker1_ProgressChanged;
            worker.WorkerSupportsCancellation = true;
            worker.WorkerReportsProgress = true;
            worker.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            BackgroundWorker worker = sender as BackgroundWorker;
            int count = 0;
            while (active)
            {
                var newconn = _socket.Accept();
                if (newconn != null)
                {
                    count++;
                    sockets.Add(newconn, count);
                    Receive receive = new Receive();
                    receive.socket = newconn;
                    receive.count = count;
                    Thread thread = new Thread(new ParameterizedThreadStart(ReceiveAsync));
                    thread.Start(receive);
                    newconn.Send(Encoding.UTF8.GetBytes($"Hi Client {count}th!!!"));
                    worker.ReportProgress(count);
                }
                else
                    continue;
            }

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            string msg = null;
            if (e.UserState != null)
                msg = e.UserState.ToString();

            if (msg != null)
            {
                ClientList.Items.Add($"Client {e.ProgressPercentage} : {msg}");
            }
            else
            {
                ClientList.Items.Add($"Client {e.ProgressPercentage} is connected...");
            }
        }

        private async void ReceiveAsync(object receive)
        {
            byte[] data = new byte[byte.MaxValue];
            Receive receive1 = receive as Receive;
                if (await receive1.socket.ReceiveAsync(data, SocketFlags.None) > 0)
                    worker.ReportProgress(receive1.count, Encoding.UTF8.GetString(data));

            data = new byte[byte.MaxValue];
        }

        private void ShutDown_Click(object sender, EventArgs e)
        {
            active = false;
            _socket.Close();
            Start.Enabled = true;
            ShutDown.Enabled = false;
        }

        private void Send_Click(object sender, EventArgs e)
        {
            if (SendBox.Text != null)
            {
                foreach (var socket in sockets)
                    socket.Key.Send(Encoding.UTF8.GetBytes(SendBox.Text));
            }
        }
    }
}

