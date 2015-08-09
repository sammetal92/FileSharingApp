using System;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form : System.Windows.Forms.Form
    {
        private static string shortFilename = "";
        private static string filename = "";

        public Form()
        {
            InitializeComponent();
            Text = "File Sharing Client";
        }

        private void browse_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Browse";
            ofd.ShowDialog();
            file.Text = ofd.FileName;
            filename = ofd.FileName;
            shortFilename = ofd.SafeFileName;
        }

        private void upload_button_Click(object sender, EventArgs e)
        {
            string ip_address = ip.Text;
            int portNo = Int32.Parse(port.Text);
            Task.Factory.StartNew(() => SendFile(ip_address, portNo, filename, shortFilename));
            MessageBox.Show("File Uploaded.");
        }

        private void SendFile (string IP, int PORT, string FILENAME, string SHORTFILENAME)
        {
            try
            {
                if (!string.IsNullOrEmpty(IP))
                {
                    byte[] filenameByte = Encoding.ASCII.GetBytes(SHORTFILENAME);
                    byte[] fileData = File.ReadAllBytes(FILENAME);

                    byte[] clientData = new byte[4 + filenameByte.Length + fileData.Length];
                    byte[] filenameLen = BitConverter.GetBytes(filenameByte.Length);

                    filenameLen.CopyTo(clientData, 0);
                    filenameByte.CopyTo(clientData, 4);
                    fileData.CopyTo(clientData, 4 + filenameByte.Length);

                    TcpClient clientSocket = new TcpClient(IP, PORT);

                    NetworkStream netStream = clientSocket.GetStream();
                    netStream.Write(clientData, 0, clientData.GetLength(0));
                    netStream.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }
    }
}
