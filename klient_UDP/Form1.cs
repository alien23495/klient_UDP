using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;

namespace klient_UDP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void przycisk_wyslij_Click(object sender, EventArgs e)
        {
            string host = adres.Text;
            int port = Convert.ToInt32(my_port.Value);
            try
            {
                UdpClient klient = new UdpClient(host, port);
                Byte[] dane = Encoding.ASCII.GetBytes(wiadomosc.Text);
                klient.Send(dane, dane.Length);
                info_o_polaczeniu.Items.Add("Wysłanie wiadomosci do hosta" + host + ": " + port);
                klient.Close();
            }
            catch (Exception ex)
            {
                info_o_polaczeniu.Items.Add("Błąd: Nie udalo sie wysłac wiadomosci");
                MessageBox.Show(ex.ToString(), " bład");
            }

        }


    }
}
