using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IrcDotNet;

namespace Chat_Client
{
    public class ChannelEventLogger
    {
        protected IrcChannel channel;
        public ChannelEventLogger(IrcChannel channel)
        {
            this.channel = channel;
            channel.UserInvited += Channel_UserInvited;
            channel.UserJoined += Channel_UserJoined;
            channel.UserKicked += Channel_UserKicked;
            channel.UserLeft += Channel_UserLeft;
            channel.MessageReceived += Channel_MessageReceived;
        }



        private void Channel_UserInvited(object sender, IrcUserEventArgs e)
        {
            //TODO: Map this message for a format file
            RaiseChannelEvent(e.User.NickName, "was invited.");
        }
        private void Channel_UserJoined(object sender, IrcChannelUserEventArgs e)
        {
            //TODO: Map this message for a format file
            RaiseChannelEvent(e.ChannelUser.User.NickName, "has joined the channel.");
        }

        private void Channel_UserKicked(object sender, IrcChannelUserEventArgs e)
        {
            //TODO: Map this message for a format file
            RaiseChannelEvent(e.ChannelUser.User.NickName, "was kicked from the channel.");
        }
        private void Channel_UserLeft(object sender, IrcChannelUserEventArgs e)
        {
            //TODO: Map this message for a format file
            RaiseChannelEvent(e.ChannelUser.User.NickName, "has left the channel.");
        }

        private void Channel_MessageReceived(object sender, IrcMessageEventArgs e)
        {
            //TODO: Map this message for a format file
            RaiseMessageEvent(e.Source.Name, e.Text);
        }

        public event ChannelEventArgs.ChannelEventHandler ChannelEvent;
        public event ChannelEventArgs.ChannelEventHandler MessageEvent;

        public void RaiseChannelEvent(string source, string message)
        {
            ChannelEventArgs args = new ChannelEventArgs(source, message);
            ChannelEvent?.Invoke(this, args);
        }

        public void RaiseMessageEvent(string source, string message)
        {
            ChannelEventArgs args = new ChannelEventArgs(source, message);
            MessageEvent?.Invoke(this, args);
        }

        ~ChannelEventLogger ()
        {
            if (channel != null)
            {
                channel.UserInvited -= Channel_UserInvited;
                channel.UserJoined -= Channel_UserJoined;
                channel.UserKicked -= Channel_UserKicked;
                channel.UserLeft -= Channel_UserLeft;
                channel.MessageReceived -= Channel_MessageReceived;
            }
        }
    }
}
