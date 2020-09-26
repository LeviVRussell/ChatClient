using System.Windows.Forms;

namespace Chat_Client
{
    partial class ChannelTab : UserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SplitContainer = new System.Windows.Forms.SplitContainer();
            this.ChatHistLbl = new System.Windows.Forms.Label();
            this.UserListLbx = new System.Windows.Forms.ListBox();
            this.UserOptionsCms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.privateMessageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).BeginInit();
            this.SplitContainer.Panel1.SuspendLayout();
            this.SplitContainer.Panel2.SuspendLayout();
            this.SplitContainer.SuspendLayout();
            this.UserOptionsCms.SuspendLayout();
            this.SuspendLayout();
            // 
            // SplitContainer
            // 
            this.SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer.Location = new System.Drawing.Point(0, 0);
            this.SplitContainer.Name = "SplitContainer";
            // 
            // SplitContainer.Panel1
            // 
            this.SplitContainer.Panel1.Controls.Add(this.ChatHistLbl);
            // 
            // SplitContainer.Panel2
            // 
            this.SplitContainer.Panel2.Controls.Add(this.UserListLbx);
            this.SplitContainer.Size = new System.Drawing.Size(617, 387);
            this.SplitContainer.SplitterDistance = 478;
            this.SplitContainer.SplitterIncrement = 12;
            this.SplitContainer.TabIndex = 0;
            // 
            // ChatHistLbl
            // 
            this.ChatHistLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChatHistLbl.Location = new System.Drawing.Point(3, 3);
            this.ChatHistLbl.Margin = new System.Windows.Forms.Padding(3);
            this.ChatHistLbl.Name = "ChatHistLbl";
            this.ChatHistLbl.Size = new System.Drawing.Size(472, 381);
            this.ChatHistLbl.TabIndex = 0;
            // 
            // UserListLbx
            // 
            this.UserListLbx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserListLbx.ContextMenuStrip = this.UserOptionsCms;
            this.UserListLbx.FormattingEnabled = true;
            this.UserListLbx.Location = new System.Drawing.Point(3, 3);
            this.UserListLbx.Name = "UserListLbx";
            this.UserListLbx.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.UserListLbx.Size = new System.Drawing.Size(156, 511);
            this.UserListLbx.TabIndex = 0;
            // 
            // UserOptionsCms
            // 
            this.UserOptionsCms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.privateMessageToolStripMenuItem});
            this.UserOptionsCms.Name = "UserOptionsCms";
            this.UserOptionsCms.Size = new System.Drawing.Size(160, 26);
            // 
            // privateMessageToolStripMenuItem
            // 
            this.privateMessageToolStripMenuItem.Name = "privateMessageToolStripMenuItem";
            this.privateMessageToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.privateMessageToolStripMenuItem.Text = "Private Message";
            this.privateMessageToolStripMenuItem.Click += new System.EventHandler(this.privateMessageToolStripMenuItem_Click);
            // 
            // ChannelTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SplitContainer);
            this.Name = "ChannelTab";
            this.Size = new System.Drawing.Size(617, 387);
            this.SplitContainer.Panel1.ResumeLayout(false);
            this.SplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).EndInit();
            this.SplitContainer.ResumeLayout(false);
            this.UserOptionsCms.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer SplitContainer;
        private System.Windows.Forms.Label ChatHistLbl;
        private System.Windows.Forms.ListBox UserListLbx;
        private System.Windows.Forms.ContextMenuStrip UserOptionsCms;
        private System.Windows.Forms.ToolStripMenuItem privateMessageToolStripMenuItem;
    }
}
