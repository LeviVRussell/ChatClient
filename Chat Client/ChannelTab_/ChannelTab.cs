using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using IrcDotNet;
using System.Runtime.CompilerServices;
using Chat_Client.ChannelTab_;

namespace Chat_Client
{
    public partial class ChannelTab : UserControl
    {
        protected string waitingInputText;
        protected IrcChannel channel;

        ChannelEventLogger channelEventLogger;
        CollectionListDrawer userListDrawer;
        public ChannelTab(IrcChannel channel)
        {
            this.channel = channel;

            Dock = DockStyle.Fill;
            InitializeComponent();

            waitingInputText = "";

            channelEventLogger = new ChannelEventLogger(channel);
            channelEventLogger.ChannelEvent += ChannelEventLogger_ChannelEvent;
            channelEventLogger.MessageEvent += ChannelEventLogger_MessageEvent;

            Form1.client.LocalUser.LeftChannel += HandleLeaveChannel;
            userListDrawer = new ChannelUserListDrawer(UserListLbx, channel);
        }

        public void HandleLeaveChannel(object sender, IrcChannelEventArgs e)
        {
            if (e.Channel == channel)
            {
                IrcLocalUser client = (IrcLocalUser) sender;
                client.LeftChannel -= HandleLeaveChannel;
                Form1.eventQueue.QueueEventAction(new Utility.EventQueue.VoidEventAction(DeleteThisTab));
            }
        }

        private void ChannelEventLogger_ChannelEvent(object caller, ChannelEventArgs args)
        {
            LogChatLine(args.source + " " + args.message);
        }

        private void ChannelEventLogger_MessageEvent(object caller, ChannelEventArgs args)
        {
            LogChatLine("<" + args.source + "> " + args.message);
        }

        public void LogChatLine(string Line)
        {
            waitingInputText += Line + "\n";
        }
        public void Update_Tick(object sender, EventArgs e)
        {
            ChatHistLbl.Text += waitingInputText;
            waitingInputText = "";
        }

        private void DeleteThisTab()
        {
            UserListLbx.Items.Clear();
            Parent.Parent.Controls.Remove(Parent);
            Parent.Controls.Remove(this);
            Dispose();
        }

        ~ChannelTab()
        {
            Debug.WriteLine("Deleted Channel Tab");
        }

        //Move below to another class
        private void privateMessageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        public delegate void UserSelectionFunctionHandler(UserSelectionFunctionEventArgs args);
        public event UserSelectionFunctionHandler UserSelectionPrivateMessage;
        public class UserSelectionFunctionEventArgs : EventArgs
        {
            public List<string> users;
            public UserSelectionFunctionEventArgs(List<string> users)
            {
                this.users = users;
            }
        }
    }
}
