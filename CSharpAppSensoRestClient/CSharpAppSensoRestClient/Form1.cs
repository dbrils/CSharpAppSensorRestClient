using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpAppSensoRestClient
{
    public partial class formAppSensorRestClient : Form
    {
        public formAppSensorRestClient()
        {
            InitializeComponent();
        }

        #region UI Event Handlers

        private void btnSendRequest_Click(object sender, EventArgs e)
        {
            RestClient rClient = new RestClient();

            rClient.endPoint = tbRequestURL.Text;
            rClient.requestHeader = tbRequestHeader.Text;

            debugOutput("Rest Client has been created");

            string strResponse = string.Empty;

            strResponse = rClient.makeRequest();

            debugOutput(strResponse);
        }

        #endregion

        private void debugOutput(string strDebugText)
        {
            try
            {
                System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
                tbRequestOutput.Text = tbRequestOutput.Text + strDebugText + Environment.NewLine;
                tbRequestOutput.SelectionStart = tbRequestOutput.TextLength;
                tbRequestOutput.ScrollToCaret();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message, ToString() + Environment.NewLine);
            }
        }
    }
}
