using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace Chat_3
{
    public partial class Form1 : Form
    {
        private TcpClient cliente;
        public StreamReader str;
        public StreamWriter stw;
        public string datos;
        public string info;


        public Form1()
        {
            InitializeComponent();


            IPAddress[] IPlocal = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress direccion in IPlocal)
            {
                if (direccion.AddressFamily == AddressFamily.InterNetwork)
                {
                    IPserver.Text = direccion.ToString();
                }
            }
        }

        private void btnenviar_Click(object sender, EventArgs e)
        {
            if (mensajebox.Text != "")
            {
                info = mensajebox.Text;
                backgroundWorker2.RunWorkerAsync();

            }
            mensajebox.Text = "";
        }

        private void btniniciar_Click(object sender, EventArgs e)
        {
            TcpListener escuchador = new TcpListener(IPAddress.Any, int.Parse(Puertoserver.Text));
            escuchador.Start();
            cliente = escuchador.AcceptTcpClient();
            str = new StreamReader(cliente.GetStream());
            stw = new StreamWriter(cliente.GetStream());
            stw.AutoFlush = true;
            backgroundWorker1.RunWorkerAsync();
            backgroundWorker2.WorkerSupportsCancellation = true;
        }

        private void btnconectar_Click(object sender, EventArgs e)
        {
            cliente = new TcpClient();
            IPEndPoint ipend = new IPEndPoint(IPAddress.Parse(Ipcliente.Text), int.Parse(Puertocliente.Text));
            try
            {
                cliente.Connect(ipend);
                if (cliente.Connected)
                {
                    Chatscreen.AppendText("Conectado con el servidor" + "\n");
                    str = new StreamReader(cliente.GetStream());
                    stw = new StreamWriter(cliente.GetStream());
                    stw.AutoFlush = true;
                    backgroundWorker1.RunWorkerAsync();
                    backgroundWorker2.WorkerSupportsCancellation = true;
                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message.ToString());
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (cliente.Connected) ;
            {
                try
                {
                    datos = str.ReadLine();
                    this.Chatscreen.Invoke(new MethodInvoker(delegate ()
                    {
                        Chatscreen.AppendText("Tu:" + datos + "\n");
                    }));
                    datos = "";
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message.ToString());
                }
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            if (cliente.Connected)
            {
                stw.WriteLine(info);
                this.Chatscreen.Invoke(new MethodInvoker(delegate ()
                {
                    Chatscreen.AppendText("Yo:" + info + "\n");
                }));
            }
            else
            {
                MessageBox.Show("Fallo al enviar");
            }
            backgroundWorker2.CancelAsync();

        }
    }
}
