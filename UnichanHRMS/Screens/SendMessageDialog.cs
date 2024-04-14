using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnichanHRMS.Screens
{
    public partial class SendMessageDialog : Form
    {
        DateTime value = DateTime.MinValue;
        public delegate void CallBackFunction(DateTime f_i_d);
        CallBackFunction callback;
        private SerialPort _serialPort;
        String name = "", contact ="", message = "";
        public SendMessageDialog(String name,String contact,String message)
        {
            InitializeComponent();
            this.name = name;
            this.contact = contact;
            this.message = message;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetDateDialog_Load(object sender, EventArgs e)
        {
            cbPortList.Items.Clear();
            cbPortList.Items.AddRange(SerialPort.GetPortNames());

            tbMessage.Text = message;
            tbContactNumber.Text = contact;
            tbRecipient.Text = name;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            cbPortList.Items.Clear();
            cbPortList.Items.AddRange(SerialPort.GetPortNames());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to send this notification?","Send notification",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String port = cbPortList.Text;

                _serialPort = new SerialPort(port, 115200);


                MessageBox.Show(port);

                Thread.Sleep(1000);

                _serialPort.Open();
                Thread.Sleep(1000);

                _serialPort.Write("AT+CMGF=1\r");
                Thread.Sleep(1000);

                _serialPort.Write("AT+CMGS=\"" + tbContactNumber.Text + "\"\r\n");
                Thread.Sleep(1000);

                _serialPort.Write(tbMessage.Text + "\x1A");

                Thread.Sleep(1000);

                MessageBox.Show("SMS alert sent successfully!");

                _serialPort.Close();
                this.Close();
            }
        }
    }
}
