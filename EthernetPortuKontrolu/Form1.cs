using System;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace EthernetPortuKontrolu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckEthernetStatus();
        }
        private void CheckEthernetStatus()
        {
            NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();

            foreach (NetworkInterface nic in interfaces)
            {
                if (nic.NetworkInterfaceType == NetworkInterfaceType.Ethernet && nic.OperationalStatus == OperationalStatus.Up)
                {
                    MessageBox.Show("Ethernet bağlantısı mevcut.");
                    return;
                }
            }

            MessageBox.Show("Ethernet bağlantısı bulunamadı veya bağlantı kapalı.");
        }
    }
}
