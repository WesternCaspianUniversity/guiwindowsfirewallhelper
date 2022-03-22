using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace GUIFirewallHelper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Process firewall = new Process();
            firewall.StartInfo.FileName = "cmd.exe"; firewall.StartInfo.WorkingDirectory = @"\windows\system32\";
            firewall.StartInfo.Verb = "runas";
            firewall.StartInfo.Arguments = "/c netsh advfirewall set currentprofile state on";
            firewall.Start();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Process firewall = new Process();
            firewall.StartInfo.FileName = "cmd.exe"; firewall.StartInfo.WorkingDirectory = @"\windows\system32\";
            firewall.StartInfo.Verb = "runas";
            firewall.StartInfo.Arguments = "/c netsh advfirewall set currentprofile state off";
            firewall.Start();
        }
    }
}
