namespace Chat_Client
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
    private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SendBtn = new System.Windows.Forms.Button();
            this.ChatInputTxb = new System.Windows.Forms.TextBox();
            this.AddressTxb = new System.Windows.Forms.TextBox();
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.UsernameTxb = new System.Windows.Forms.TextBox();
            this.PasswordTxb = new System.Windows.Forms.TextBox();
            this.ChannelsTabs = new System.Windows.Forms.TabControl();
            this.ServerTab = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ServerChannelsLbx = new System.Windows.Forms.ListBox();
            this.ServerChatTxb = new System.Windows.Forms.Label();
            this.ServerTabs = new System.Windows.Forms.TabControl();
            this.ChannelsTab = new System.Windows.Forms.TabPage();
            this.UsersTab = new System.Windows.Forms.TabPage();
            this.ServerUsersLbx = new System.Windows.Forms.ListBox();
            this.ChannelsTabs.SuspendLayout();
            this.ServerTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.ServerTabs.SuspendLayout();
            this.ChannelsTab.SuspendLayout();
            this.UsersTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // SendBtn
            // 
            this.SendBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SendBtn.Location = new System.Drawing.Point(510, 415);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(75, 23);
            this.SendBtn.TabIndex = 1;
            this.SendBtn.Text = "Send";
            this.SendBtn.UseVisualStyleBackColor = true;
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // ChatInputTxb
            // 
            this.ChatInputTxb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChatInputTxb.Location = new System.Drawing.Point(12, 418);
            this.ChatInputTxb.Name = "ChatInputTxb";
            this.ChatInputTxb.Size = new System.Drawing.Size(492, 20);
            this.ChatInputTxb.TabIndex = 2;
            // 
            // AddressTxb
            // 
            this.AddressTxb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddressTxb.Location = new System.Drawing.Point(592, 13);
            this.AddressTxb.Name = "AddressTxb";
            this.AddressTxb.Size = new System.Drawing.Size(196, 20);
            this.AddressTxb.TabIndex = 3;
            this.AddressTxb.Text = "irc://irc.w3.org";
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ConnectBtn.Location = new System.Drawing.Point(592, 91);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(196, 23);
            this.ConnectBtn.TabIndex = 4;
            this.ConnectBtn.Text = "Connect";
            this.ConnectBtn.UseVisualStyleBackColor = true;
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // UsernameTxb
            // 
            this.UsernameTxb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UsernameTxb.Location = new System.Drawing.Point(592, 39);
            this.UsernameTxb.Name = "UsernameTxb";
            this.UsernameTxb.Size = new System.Drawing.Size(196, 20);
            this.UsernameTxb.TabIndex = 5;
            this.UsernameTxb.Text = "R3D24sChatClient";
            // 
            // PasswordTxb
            // 
            this.PasswordTxb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordTxb.Location = new System.Drawing.Point(592, 65);
            this.PasswordTxb.Name = "PasswordTxb";
            this.PasswordTxb.PasswordChar = '*';
            this.PasswordTxb.Size = new System.Drawing.Size(196, 20);
            this.PasswordTxb.TabIndex = 7;
            // 
            // ChannelsTabs
            // 
            this.ChannelsTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChannelsTabs.Controls.Add(this.ServerTab);
            this.ChannelsTabs.Location = new System.Drawing.Point(13, 13);
            this.ChannelsTabs.Name = "ChannelsTabs";
            this.ChannelsTabs.SelectedIndex = 0;
            this.ChannelsTabs.Size = new System.Drawing.Size(572, 396);
            this.ChannelsTabs.TabIndex = 8;
            // 
            // ServerTab
            // 
            this.ServerTab.Controls.Add(this.splitContainer1);
            this.ServerTab.Location = new System.Drawing.Point(4, 22);
            this.ServerTab.Name = "ServerTab";
            this.ServerTab.Padding = new System.Windows.Forms.Padding(3);
            this.ServerTab.Size = new System.Drawing.Size(564, 370);
            this.ServerTab.TabIndex = 0;
            this.ServerTab.Text = "Server";
            this.ServerTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ServerChatTxb);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ServerTabs);
            this.splitContainer1.Size = new System.Drawing.Size(558, 364);
            this.splitContainer1.SplitterDistance = 298;
            this.splitContainer1.TabIndex = 0;
            // 
            // ServerChannelsLbx
            // 
            this.ServerChannelsLbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ServerChannelsLbx.FormattingEnabled = true;
            this.ServerChannelsLbx.Location = new System.Drawing.Point(3, 3);
            this.ServerChannelsLbx.Name = "ServerChannelsLbx";
            this.ServerChannelsLbx.Size = new System.Drawing.Size(242, 332);
            this.ServerChannelsLbx.TabIndex = 0;
            // 
            // ServerChatTxb
            // 
            this.ServerChatTxb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ServerChatTxb.Location = new System.Drawing.Point(0, 1);
            this.ServerChatTxb.Name = "ServerChatTxb";
            this.ServerChatTxb.Size = new System.Drawing.Size(295, 363);
            this.ServerChatTxb.TabIndex = 0;
            this.ServerChatTxb.Text = "label1";
            // 
            // ServerTabs
            // 
            this.ServerTabs.Controls.Add(this.ChannelsTab);
            this.ServerTabs.Controls.Add(this.UsersTab);
            this.ServerTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ServerTabs.Location = new System.Drawing.Point(0, 0);
            this.ServerTabs.Name = "ServerTabs";
            this.ServerTabs.SelectedIndex = 0;
            this.ServerTabs.Size = new System.Drawing.Size(256, 364);
            this.ServerTabs.TabIndex = 0;
            // 
            // ChannelsTab
            // 
            this.ChannelsTab.Controls.Add(this.ServerChannelsLbx);
            this.ChannelsTab.Location = new System.Drawing.Point(4, 22);
            this.ChannelsTab.Name = "ChannelsTab";
            this.ChannelsTab.Padding = new System.Windows.Forms.Padding(3);
            this.ChannelsTab.Size = new System.Drawing.Size(248, 338);
            this.ChannelsTab.TabIndex = 0;
            this.ChannelsTab.Text = "Channels";
            this.ChannelsTab.UseVisualStyleBackColor = true;
            // 
            // UsersTab
            // 
            this.UsersTab.Controls.Add(this.ServerUsersLbx);
            this.UsersTab.Location = new System.Drawing.Point(4, 22);
            this.UsersTab.Name = "UsersTab";
            this.UsersTab.Padding = new System.Windows.Forms.Padding(3);
            this.UsersTab.Size = new System.Drawing.Size(248, 338);
            this.UsersTab.TabIndex = 1;
            this.UsersTab.Text = "Users";
            this.UsersTab.UseVisualStyleBackColor = true;
            // 
            // ServerUsersLbx
            // 
            this.ServerUsersLbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ServerUsersLbx.FormattingEnabled = true;
            this.ServerUsersLbx.Location = new System.Drawing.Point(3, 3);
            this.ServerUsersLbx.Name = "ServerUsersLbx";
            this.ServerUsersLbx.Size = new System.Drawing.Size(242, 332);
            this.ServerUsersLbx.TabIndex = 0;
            // 
            // Form1
            // 
            this.AcceptButton = this.SendBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ChannelsTabs);
            this.Controls.Add(this.PasswordTxb);
            this.Controls.Add(this.UsernameTxb);
            this.Controls.Add(this.ConnectBtn);
            this.Controls.Add(this.AddressTxb);
            this.Controls.Add(this.ChatInputTxb);
            this.Controls.Add(this.SendBtn);
            this.Name = "Form1";
            this.Text = "Chat Client";
            this.ChannelsTabs.ResumeLayout(false);
            this.ServerTab.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ServerTabs.ResumeLayout(false);
            this.ChannelsTab.ResumeLayout(false);
            this.UsersTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SendBtn;
        private System.Windows.Forms.TextBox ChatInputTxb;
        private System.Windows.Forms.TextBox AddressTxb;
        private System.Windows.Forms.Button ConnectBtn;
        private System.Windows.Forms.TextBox UsernameTxb;
        private System.Windows.Forms.TextBox PasswordTxb;
        private System.Windows.Forms.TabControl ChannelsTabs;
        private System.Windows.Forms.TabPage ServerTab;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label ServerChatTxb;
        private System.Windows.Forms.ListBox ServerChannelsLbx;
        private System.Windows.Forms.TabControl ServerTabs;
        private System.Windows.Forms.TabPage ChannelsTab;
        private System.Windows.Forms.TabPage UsersTab;
        private System.Windows.Forms.ListBox ServerUsersLbx;
    }
}

