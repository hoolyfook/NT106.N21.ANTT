using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace lab3
{
    public partial class Lab03_Bai3_TcpServer : Form
    {
        private Socket listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        public Lab03_Bai3_TcpServer()
        {
            InitializeComponent();
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            btnListen.Enabled = false;
            Thread serverThread = new Thread(new ThreadStart(StartUnsafeThread));
            serverThread.Start();
        }

        private void StartUnsafeThread()
        {
            try
            {
                listBox1.Items.Add("Server running on 127.0.0.1:8888");
                int bytesReceived = 0;
                byte[] recv = new byte[1];
                Socket clientSocket;
                IPEndPoint ipepServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8888);
                //Gan socket lang nghe toi dia chi IP cua may va port 8888
                listenerSocket.Bind(ipepServer);
                //bat dau lang nghe.Socket.Listening(int backlog) voi backlog la do dai toi da cua hang doi cac ket noi dang cho xu ly
                listenerSocket.Listen(-1);
                //Dong y ket noi
                clientSocket = listenerSocket.Accept();
                //Nhan du lieu
                listBox1.Items.Add(new ListViewItem("New client connected!"));
                while (clientSocket.Connected)
                {
                    string text = "";
                    do
                    {
                        bytesReceived = clientSocket.Receive(recv);
                        text += Encoding.ASCII.GetString(recv);
                    }
                    while (text[text.Length - 1] != '\n');
                    listBox1.Items.Add(new ListViewItem(text));
                }
                listenerSocket.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Lab03_Bai3_TcpServer_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}