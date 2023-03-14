using System.ComponentModel;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ChatApp
{
    public partial class Client : Form
    {
        private Socket _socket;
        
        public Client()
        {
            InitializeComponent();
        }


        public void StartClient()
        {

            IPHostEntry iphost = Dns.GetHostEntry("127.0.0.1");
            IPAddress ip = iphost.AddressList[0];
            IPEndPoint ep = new IPEndPoint(ip, 22);

            Socket socketclient = new Socket(ep.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            socketclient.Connect(ep);
            

            _socket = socketclient;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.StartClient();
            Connect.Enabled = false;
            var endremote = _socket.RemoteEndPoint;
            ServerIp.Text = endremote.AddressFamily.ToString();

            
            BackgroundWorker worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.DoWork += backgroundWorker1_DoWork;
            worker.ProgressChanged += backgroundWorker1_ProgressChanged;
            worker.RunWorkerCompleted +=backgroundWorker1_RunWorkerCompleted;  
            worker.WorkerSupportsCancellation = true;
            worker.RunWorkerAsync();
            
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            int count = 0;
            int datasize = 0;
            byte[] data = new byte[byte.MaxValue];

            while(true)
            {
                if (!_socket.Connected)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    try
                    {
                        datasize = _socket.Receive(data);
                        var datastring = Encoding.UTF8.GetString(data, 0, datasize);
                        if (datasize > 0)
                        {
                            worker.ReportProgress(count, datastring);
                            datasize = 0;
                        }
                    }
                    catch (SocketException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }     
            }
        }
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            string msg = e.UserState as string;
            ClientList.Items.Add(msg); 
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender,RunWorkerCompletedEventArgs e)
        {
            if(e.Cancelled)
            {
                MessageBox.Show("Host closed the connection");
                this.OnClosed(e);
            }
        }
        protected override void OnClosed(EventArgs e)
        {
            _socket.Disconnect(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(SendBox.Text != null)
            {
                _socket.Send(Encoding.UTF8.GetBytes(SendBox.Text));
            }
        }
    }
}