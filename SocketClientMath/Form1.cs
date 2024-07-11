using System.Net.Sockets;
using System.Net;
using System.Windows.Forms;

namespace SocketClientMath
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        async Task SendToServer()
        {
            await Task.Run(() =>
            {
                TcpListener tcpListener = null;
                try
                {
                    IPAddress localAddr = IPAddress.Parse("127.0.0.1");
                    tcpListener = new TcpListener(localAddr, int.Parse(tbPort.Text) + 1);


                    tcpListener.Start();
                    listBox.Items.Add("Listen to ");
                    while (true)
                    {
                        TcpClient client = tcpListener.AcceptTcpClient();
                        NetworkStream stream = client.GetStream();

                        StreamReader reader = new StreamReader(stream);
                        string message = reader.ReadLine();
                        string res = Math(message);
                        listBox.Items.Add("Результат " + res);


                        StreamWriter writer = new StreamWriter(stream);
                        writer.WriteLine(res);

                        writer.Close();
                        reader.Close();
                        stream.Close();
                        client.Close();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    if (tcpListener != null)
                        tcpListener.Stop();
                }
            });

        }

        private string Math(string str)
        {
            double result = 0;
            string[] args = str.Split(' ');

            double num1 = double.Parse(args[0]);
            double num2 = double.Parse(args[2]);
            string operation = args[1];

            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                //.............
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
                default:
                    listBox.Items.Add("Такой символ не предусмотрен");
                    break;
            }

            string res = result.ToString();
            return res;
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            SendToServer();
        }
    }
}