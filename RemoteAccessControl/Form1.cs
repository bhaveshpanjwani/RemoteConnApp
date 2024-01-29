using MetroFramework.Forms;
using MSTSCLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemoteAccessControl
{
    public partial class RemoteDesktopApp : MetroForm
    {
        public RemoteDesktopApp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                DisconnectNow.Enabled = false;

                GetMyIp();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "SomeError", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetMyIp()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    textYourIP.Text = ip.ToString();
                }
            }
        }

        private void ConnectNow_Click(object sender, EventArgs e)
        {
            try
            {
                DisconnectNow.Enabled = true;
                ConnectNow.Enabled = false;
                /*
                                rdp.Server = txtClientIP.Text;
                                rdp.UserName = txtUserName.Text;

                                IMsTscNonScriptable isSecured = (IMsTscNonScriptable)rdp.GetOcx();

                                isSecured.ClearTextPassword = txtPassword.Text;

                                rdp.Connect();*/
                rdp.Server = txtClientIP.Text;
                rdp.UserName = txtUserName.Text;
                rdp.AdvancedSettings9.EnableCredSspSupport = true;

                IMsTscNonScriptable Secured = (IMsTscNonScriptable)rdp.GetOcx();

                Secured.ClearTextPassword = txtPassword.Text;

                rdp.Connect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "SomeError", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisconnectNow_Click(object sender, EventArgs e)
        {
            rdp.Disconnect();

            ConnectNow.Enabled = true;
            DisconnectNow.Enabled = false;

        }
    }
}
