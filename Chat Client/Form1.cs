using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chat_Client.ChannelTab_;
using Chat_Client.Utility;
using IrcDotNet;

namespace Chat_Client
{
    public partial class Form1 : Form
    {
        public static EventQueue eventQueue;

        public static StandardIrcClient client;
        IrcChannel currentChannel;
        List<IrcChannel> newChannels;
        Timer timer;
        public Form1()
        {
            InitializeComponent();

            eventQueue = new EventQueue();

            newChannels = new List<IrcChannel>();

            timer = new Timer();
            timer.Interval = 33;
            timer.Tick += Timer_Tick;
            timer.Start();

            client = new StandardIrcClient();
            
            client.Connected += Client_Connected;
            client.Disconnected += Client_Disconnected;
        }

        private void Client_Disconnected(object sender, EventArgs e)
        {
            //ChannelTabCtb.LogChatLine("Disconnected!");
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            eventQueue.RunAllActions();
            //ChannelTabCtb.UpdateChannelTab();
            if (client.IsConnected)
            {
                ConnectBtn.Text = "Disconnect";
            }
            if (newChannels.Count > 0)
            {
                foreach (IrcChannel channel in newChannels)
                {
                    TabPage page = new TabPage();
                    page.Text = channel.Name;
                    ChannelTab channelTab = new ChannelTab(channel);
                    page.Controls.Add(channelTab);
                    ChannelsTabs.Controls.Add(page);
                    timer.Tick += channelTab.Update_Tick;
                }
                newChannels.Clear();
            }
        }

        ~Form1()
        {
            if (client.IsConnected)
            {
                client.Disconnect();
            }
        }

        private void Client_Connected(object sender, EventArgs e)
        {
            client.LocalUser.MessageReceived += LocalUser_MessageReceived;
            client.LocalUser.JoinedChannel += LocalUser_JoinedChannel;
            //client.Join(new List<string>() { channel });
        }

        private void LocalUser_JoinedChannel(object sender, IrcChannelEventArgs e)
        {
            currentChannel = e.Channel;

            newChannels.Add(e.Channel);
            //ChannelTabCtb.Channel = e.Channel;
            //ChannelTabCtb.LogChatLine("Joined channel: " + currentChannel.Name);
        }

        private void LocalUser_MessageReceived(object sender, IrcMessageEventArgs e)
        {
            //ChannelTabCtb.LogChatLine(e.Source + "> " + e.Text);
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            string text = ChatInputTxb.Text;
            if (text != "")
            {

                if (text.Substring(0, 1) == "/")
                {
                    client.SendRawMessage(text.Substring(1));
                } else if (currentChannel != null)
                {
                    List<string> targets = new List<string>() { currentChannel.Name };
                    client.SendPrivateMessage(targets, text);
                    //ChannelTabCtb.LogChatLine("Me > " + text);
                }
                
                ChatInputTxb.Text = "";
            }
        }

        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            if (client.IsConnected)
            {
                client.Disconnect();
                ConnectBtn.Text = "Connect";
            }
            else
            {
                Uri uri = new Uri(AddressTxb.Text);
                ConnectBtn.Text = "Connecting...";
                IrcUserRegistrationInfo info = new IrcUserRegistrationInfo();
                string username = UsernameTxb.Text;
                if (username.Length < 1) username = "Username" + RandomNumberGenerator.Create().ToString();
                info.NickName = username;
                info.RealName = username;
                info.UserName = username;
                info.Password = PasswordTxb.Text;
                client.Connect(uri, info);
            }
        }
    }
}
