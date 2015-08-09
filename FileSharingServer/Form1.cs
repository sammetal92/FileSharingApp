using System;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;
using System.Threading.Tasks;

namespace FileSharingServer
{
    public partial class Form1 : Form
    {
        public delegate void FileReceivedEventHandler(object source, string filename);
        public event FileReceivedEventHandler NewFileReceived;

        public Form1()
        {
            InitializeComponent();
            Text = "File Sharing Server";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NewFileReceived += new FileReceivedEventHandler(Form1_NewFileReceived);
        }

        private void Form1_NewFileReceived(object sender, string filename)
        {
            BeginInvoke(new Action( delegate()
                                    {
                                        MessageBox.Show("File received: " + filename);
                                        System.Diagnostics.Process.Start("explorer", @"c:\");
                                    }));
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            int port = Int32.Parse(portBox.Text);
            Task.Factory.StartNew(() => HandleIncomingFile(port));
        }

        public void HandleIncomingFile(int port)
        {
            try
            {
                TcpListener listener = TcpListener.Create(port);
                listener.Start();
                while (true)
                {
                    Socket handlerSocket = listener.AcceptSocket();
                    if (handlerSocket.Connected)
                    {
                        string filename = string.Empty;
                        NetworkStream netStream = new NetworkStream(handlerSocket);
                        int thisRead = 0;
                        int blockSize = 1024;
                        byte[] dataByte = new byte[blockSize];

                        lock (this)
                        {
                            string folderpath = @"c:\";
                            int receivedBytesLen = handlerSocket.Receive(dataByte);
                            int filenameLen = BitConverter.ToInt32(dataByte, 0);
                            filename = Encoding.ASCII.GetString(dataByte, 4, filenameLen);
                            Stream fileStream = File.OpenWrite(folderpath + filename);
                            fileStream.Write(dataByte, 4 + filenameLen, (1024 - (4 + filenameLen)));

                            while (true)
                            {
                                thisRead = netStream.Read(dataByte, 0, blockSize);
                                fileStream.Write(dataByte, 0, thisRead);
                                if (thisRead == 0)
                                    break;
                            }

                            fileStream.Close();
                        }
                        if (NewFileReceived != null)
                            NewFileReceived(this, filename);
                        handlerSocket = null;
                    }
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }
    }
}
