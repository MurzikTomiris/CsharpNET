using System.Net.Sockets;
using System.Windows.Forms;

namespace SoccketServerMath
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        async Task TCPSendToServer()
        {
            await Task.Run(() =>
            {
                TcpClient client = null;
                try
                {
                    string message = tbMesssage.Text;
                    client = new TcpClient("127.0.0.1", int.Parse(tbPort.Text) + 1);
                    NetworkStream stream = client.GetStream();


                    StreamWriter writer = new StreamWriter(stream);
                    writer.WriteLine(message);
                    writer.Flush();

                    // BinaryReader reader = new BinaryReader(new BufferedStream(stream));
                    StreamReader reader = new StreamReader(stream);
                    message = reader.ReadLine();
                    listBox.Items.Add("Получено от сервера : " + message);

                    reader.Close();
                    writer.Close();
                    stream.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    if (client != null)
                        client.Close();
                }

            });
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            TCPSendToServer();
        }
    }
}