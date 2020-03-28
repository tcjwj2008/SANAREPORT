using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MSTSCLib;

namespace SAServicesCenter
{
    public partial class DesktopConnectForm : SMes.Controls.ExtendForm.BaseForm
    {
        private string _serviceIP = string.Empty;
        private string _loginID = string.Empty;
        private string _passWord = string.Empty;

        public DesktopConnectForm(string serviceIP, string loginID, string passWord)
        {
            _serviceIP = serviceIP;
            _loginID = loginID;
            _passWord = passWord;
            InitializeComponent();
        }

        private void DesktopConnectForm_Load(object sender, EventArgs e)
        {
            rdpClient.Server = _serviceIP;
            rdpClient.UserName = _loginID;
            rdpClient.Width = Screen.PrimaryScreen.Bounds.Width;//控件宽度     
            rdpClient.Height = Screen.PrimaryScreen.Bounds.Height;//控件宽度 
            rdpClient.AdvancedSettings8.RDPPort = 3389;
            rdpClient.AdvancedSettings8.NegotiateSecurityLayer = true;
            //rdpClient.FullScreen = true;
            this.Text = _serviceIP;
            IMsTscNonScriptable secured = (IMsTscNonScriptable)rdpClient.GetOcx();
            secured.ClearTextPassword = _passWord;
            rdpClient.AdvancedSettings5.ClearTextPassword = _passWord;

            rdpClient.ColorDepth = 16;

            rdpClient.Connect(); 
        }

        private void DesktopConnectForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.rdpClient.Disconnect();
            rdpClient.Refresh();
            _serviceIP = "";
            _loginID = "";
            _passWord = "";
        }
    }
}
