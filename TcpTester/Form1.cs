using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TcpTester
{
    public partial class SimpleTcpTester : Form
    {
        public SimpleTcpTester()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                AbcTcpClient tcpClient = new AbcTcpClient(ipTextBox.Text, Int32.Parse(portTextBox.Text),
                    encodingTextBox.Text, headerCheckBox.Checked, Int32.Parse(headerLenTextBox.Text));
                responseTextBox.Text = tcpClient.Send(requestTextBox.Text);
            }
            catch (Exception ex)
            {
                responseTextBox.Text = ex.Message;
            }
        }
    }
}
