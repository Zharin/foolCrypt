using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace gmailFool
{
    public partial class IM : Form
    {
        Socket sck;
        EndPoint epLocal, epRemote;



        public IM()
        {
            InitializeComponent();
            
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            textLocalIp.Text = GetLocalIP();
        }
        
        private string GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());

            //Gets IP address to string
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "127.0.0.1";
        }

        private void MessageCallBack(IAsyncResult aResult)
        {
            try
            { //start of try
                int size = sck.EndReceiveFrom(aResult, ref epRemote);

                if (size > 0) //start of if
                {
                    //create array for receiving data
                    byte[] recvData = new byte[1464];
                    //add received data to byte array
                    recvData = (byte[])aResult.AsyncState;
                    //convert byte to string
                    ASCIIEncoding eEnconding = new ASCIIEncoding();
                    string recvMsg = eEnconding.GetString(recvData);
                    //add received data to chat window
                    chatWindow.Items.Add("Destination: " + recvMsg);
                } //end of if

                byte[] buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);

            } //end of try
            catch (Exception exp)
            { //start of catch
                MessageBox.Show(exp.ToString());
            } //end of catch
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
                this.AcceptButton = sendMsgBtn;

                if (connectBtn.Text == "Disconnect")
                {
                    sck.Shutdown(SocketShutdown.Both);
                    connectBtn.Text = "Connect";
                    statusLabel.Text = "Status: Inactive";
                    sendMsgBtn.Enabled = false;
                    textMessage.ReadOnly = true;
                }
                    else
                    {
            try
            {
                //convert local ip string input to IP address and port
                epLocal = new IPEndPoint(IPAddress.Parse(textLocalIp.Text), Convert.ToInt32(textLocalPort.Text));
                sck.Bind(epLocal);
                //convert destination ip string input to IP address and port
                epRemote = new IPEndPoint(IPAddress.Parse(textDestIp.Text), Convert.ToInt32(textDestPort.Text));
                sck.Connect(epRemote);
                //listen to port
                byte[] buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
                
                connectBtn.Text = "Disconnect";
                statusLabel.Text = "Status: Active";
                sendMsgBtn.Enabled = true;
                textMessage.ReadOnly = false;
                textMessage.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
                    }
        }

        
        private void sendMsgBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //convert message to byte
                ASCIIEncoding enc = new ASCIIEncoding();
                byte[] msg = new byte[1500];
                msg = enc.GetBytes(textMessage.Text);

                //send message
                sck.Send(msg);
                //add your message to the chat window and clear textbox
                chatWindow.Items.Add("You: " + textMessage.Text);
                textMessage.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please try again in a moment.\nYour connection might not have been established yet.");
                //MessageBox.Show(ex.ToString());
            }
        }

        private void attachFileBtn_Click(object sender, EventArgs e)
        {
            Form form = new Form2();
            form.ShowDialog();
        }

        //------------------------------------------------------------activate connect button-----------------------------------------------------------------------------------

        //enables connect button if all textboxes contain data
        private void textLocalIp_TextChanged(object sender, EventArgs e)
        {
            if (textLocalIp.TextLength > 0 && textLocalPort.TextLength > 0 && textDestIp.TextLength > 0 && textDestPort.TextLength > 0 || textLocalPort.Text == "dev")
            {
                this.AcceptButton = connectBtn;
                connectBtn.Enabled = true;
                //development only
                sendMsgBtn.Enabled = true;
                attachFileBtn.Enabled = true;
                textMessage.ReadOnly = false;
            }
            else
            {
                connectBtn.Enabled = false;
            }
        }

        private void textLocalPort_TextChanged(object sender, EventArgs e)
        {
            if (textLocalIp.TextLength > 0 && textLocalPort.TextLength > 0 && textDestIp.TextLength > 0 && textDestPort.TextLength > 0 || textLocalPort.Text == "dev")
            {
                this.AcceptButton = connectBtn;
                connectBtn.Enabled = true;
                //development only
                sendMsgBtn.Enabled = true;
                attachFileBtn.Enabled = true;
                textMessage.ReadOnly = false;
            }
            else
            {
                connectBtn.Enabled = false;
            }
        }

        private void textDestIp_TextChanged(object sender, EventArgs e)
        {
            if (textLocalIp.TextLength > 0 && textLocalPort.TextLength > 0 && textDestIp.TextLength > 0 && textDestPort.TextLength > 0 || textLocalPort.Text == "dev")
            {
                this.AcceptButton = connectBtn;
                connectBtn.Enabled = true;
                //development only
                sendMsgBtn.Enabled = true;
                attachFileBtn.Enabled = true;
                textMessage.ReadOnly = false;
            }
            else
            {
                connectBtn.Enabled = false;
            }
        }
        
        private void textDestPort_TextChanged(object sender, EventArgs e)
        {
            if (textLocalIp.TextLength > 0 && textLocalPort.TextLength > 0 && textDestIp.TextLength > 0 && textDestPort.TextLength > 0 || textLocalPort.Text == "dev")
            {
                this.AcceptButton = connectBtn;
                connectBtn.Enabled = true;
                //development only
                sendMsgBtn.Enabled = true;
                attachFileBtn.Enabled = true;
                textMessage.ReadOnly = false;
            }
            else
            {
                connectBtn.Enabled = false;
            }
        }
    }
}
