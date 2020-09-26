using System;

namespace Chat_Client
{
    public class ChannelEventArgs : EventArgs
    {
        public delegate void ChannelEventHandler (object caller, ChannelEventArgs args);

        public string source;
        public string message;

        public ChannelEventArgs(string source, string message)
        {
            this.source = source;
            this.message = message;
        }
    }
}
