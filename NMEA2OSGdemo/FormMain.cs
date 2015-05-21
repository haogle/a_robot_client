using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SmileWei.EmbeddedApp.WinForm
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            Application.Idle += Application_Idle;
            appBox.AppFilename = @"D:\wifi\WifCar.exe";
            appBox.Start();
        }

        void Application_Idle(object sender, EventArgs e)
        {
            if (appBox.IsStarted)
            lblInfo.Text = string.Format("{0}", appBox.AppProcess.MainWindowHandle);
        }

        private void btnBrowseApp_Click(object sender, EventArgs e)
        {
            if (openApp.ShowDialog(this)== DialogResult.OK)
            {
               // appBox.AppFilename = openApp.FileName;

              appBox.AppFilename=@"D:\wifi\WifCar.exe";
                appBox.Start();
                if (appBox.IsStarted)
                {
                   txtAppFilename.Text = appBox.AppFilename;
                   // txtAppFilename.Text = "haogle";
                    
                }
            }
        }

        private void lblEmbedAgain_Click(object sender, EventArgs e)
        {
            appBox.EmbedAgain();
        }

        private void lblEmbedHandle_Click(object sender, EventArgs e)
        {
            var frmHandle = new FormHandle();
            if (frmHandle.ShowDialog()== System.Windows.Forms.DialogResult.OK)
            {
                var handle = frmHandle.GetHandle();
                AppContainer.SetParent(handle, this.Handle);
                AppContainer.SetWindowLong(new HandleRef(this.appBox, handle), GWL_STYLE, WS_VISIBLE);                
            }
        }


        private const int GWL_STYLE = (-16);
        private const int WS_VISIBLE = 0x10000000;
        private void lblInfo_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.lblInfo.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
