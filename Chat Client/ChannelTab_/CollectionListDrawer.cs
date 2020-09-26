using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chat_Client.Utility;
using IrcDotNet;

namespace Chat_Client.ChannelTab_
{
    abstract class CollectionListDrawer
    {
        protected ListBox listControl;
        protected List<Entry> entries;

        public delegate void RedrawHandler(object o, EventArgs e);
        public event RedrawHandler RedrawEvent;

        public CollectionListDrawer(ListBox listControl)
        {
            this.listControl = listControl;
            entries = new List<Entry>();
            listControl.DisplayMember = "DisplayMember";
            listControl.ValueMember = "ValueMember";
        }
        public void Redraw()
        {
            //This shenanigan maintains the list's current selection after redrawing.
            foreach (Entry entry in entries)
            {
                if (listControl.Items.Contains(entry) == false)
                {
                    listControl.Items.Add(entry);
                }
            }
            List<Entry> toRemove = new List<Entry>();
            foreach (Entry entry in listControl.Items)
            {
                if (entries.Contains(entry) == false)
                {
                    toRemove.Add(entry);
                }
            }
            foreach (Entry entry in toRemove)
            {
                listControl.Items.Remove(entry);
            }
        }

        protected void AddCollection (IEnumerable<object> collection)
        {
            foreach (object subject in collection)
            {
                AddEntry(subject);
            }
        }

        protected void AddEntry(object subject)
        {
            Entry entry = MakeEntry(subject);
            if (entries.Contains(entry) == false)
            {
                entries.Add(entry);
                RaiseRedraw();
            }
        }

        protected void RemoveEntry (object subject)
        {
            Entry entry = MakeEntry(subject);
            if (entries.Contains(entry))
            {
                entries.Remove(entry);
                RaiseRedraw();
            }
        }

        protected void RaiseRedraw()
        {
            RedrawEvent?.Invoke(this, EventArgs.Empty);
        }
        protected abstract Entry MakeEntry(object subject);

        protected abstract class Entry
        {
            public override bool Equals(object obj)
            {
                if (obj == null) return false;
                if (obj.GetType() != obj.GetType()) return false;
                return (CompareSubjects((Entry) obj));
            }
            public abstract string DisplayMember { get;}
            public abstract object ValueMember { get; }
            private bool CompareSubjects(Entry other)
            {
                return (other.ValueMember == ValueMember);
            }
        }
    }
    class ChannelListDrawer : CollectionListDrawer
    {
        private IrcClient client;

        public ChannelListDrawer(ListBox listControl, IrcClient client) : base(listControl)
        {
            this.client = client;
            RedrawEvent += ChannelListDrawer_RedrawEvent;

            client.ChannelListReceived += Client_ChannelListReceived;
            AddCollection(client.Channels);
        }

        private void ChannelListDrawer_RedrawEvent(object o, EventArgs e)
        {
            Form1.eventQueue.QueueEventAction(new EventQueue.VoidEventAction(Redraw));
        }

        private void Client_ChannelListReceived(object sender, IrcChannelListReceivedEventArgs e)
        {
            AddCollection(client.Channels);
        }

        protected override Entry MakeEntry(object subject)
        {
            return new ChannelEntry((IrcChannel) subject);
        }
        protected class ChannelEntry : Entry
        {
            private IrcChannel channel;

            public ChannelEntry(IrcChannel channel)
            {
                this.channel = channel;
            }

            public override string DisplayMember { get => channel.Name; }
            public override object ValueMember { get => channel; }
        }
    }

    class ChannelUserListDrawer : CollectionListDrawer
    {
        private IrcChannel channel;

        public ChannelUserListDrawer(ListBox listControl, IrcChannel channel) : base(listControl)
        {
            this.channel = channel;
            RedrawEvent += ChannelUserListDrawer_RedrawEvent;

            channel.UserJoined += Channel_UserJoined;
            channel.UserLeft += Channel_UserLeft;
            channel.UserKicked += Channel_UserKicked;

            channel.UsersListReceived += Channel_UsersListReceived;
            AddCollection(channel.Users.GetUsers());
        }

        private void ChannelUserListDrawer_RedrawEvent(object o, EventArgs e)
        {
            Form1.eventQueue.QueueEventAction(new EventQueue.VoidEventAction(Redraw));
        }

        private void Channel_UsersListReceived(object sender, EventArgs e) { AddCollection(channel.Users.GetUsers()); }
        private void Channel_UserKicked(object sender, IrcChannelUserEventArgs e){ RemoveEntry(e.ChannelUser.User); }
        private void Channel_UserLeft(object sender, IrcChannelUserEventArgs e) { RemoveEntry(e.ChannelUser.User); }
        private void Channel_UserJoined(object sender, IrcChannelUserEventArgs e) { AddEntry(e.ChannelUser.User); }

        protected override Entry MakeEntry(object subject)
        {
            return new UserEntry((IrcUser) subject);
        }

        protected class UserEntry : Entry
        {
            private IrcUser user;

            public UserEntry(IrcUser user)
            {
                this.user = user;
            }

            public override string DisplayMember { get => user.NickName; }

            public override object ValueMember { get => user; }
        }
    }
}
