namespace ChatApp_server
{
    partial class Server
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
            this.Start = new System.Windows.Forms.Button();
            this.ShutDown = new System.Windows.Forms.Button();
            this.SendBox = new System.Windows.Forms.RichTextBox();
            this.Send = new System.Windows.Forms.Button();
            this.ClientList = new System.Windows.Forms.ListView();
            this.ServerLocation = new System.Windows.Forms.GroupBox();
            this.Port = new System.Windows.Forms.TextBox();
            this.IPAddress = new System.Windows.Forms.TextBox();
            this.Portlabel = new System.Windows.Forms.Label();
            this.IPAddresslabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ServerLocation.SuspendLayout();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(660, 57);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(94, 29);
            this.Start.TabIndex = 1;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // ShutDown
            // 
            this.ShutDown.Location = new System.Drawing.Point(660, 115);
            this.ShutDown.Name = "ShutDown";
            this.ShutDown.Size = new System.Drawing.Size(94, 29);
            this.ShutDown.TabIndex = 2;
            this.ShutDown.Text = "ShutDown";
            this.ShutDown.UseVisualStyleBackColor = true;
            this.ShutDown.Click += new System.EventHandler(this.ShutDown_Click);
            // 
            // SendBox
            // 
            this.SendBox.Location = new System.Drawing.Point(12, 318);
            this.SendBox.Name = "SendBox";
            this.SendBox.Size = new System.Drawing.Size(518, 120);
            this.SendBox.TabIndex = 3;
            this.SendBox.Text = "";
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(575, 365);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(94, 29);
            this.Send.TabIndex = 4;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // ClientList
            // 
            this.ClientList.Location = new System.Drawing.Point(12, 12);
            this.ClientList.Name = "ClientList";
            this.ClientList.Size = new System.Drawing.Size(225, 289);
            this.ClientList.TabIndex = 5;
            this.ClientList.UseCompatibleStateImageBehavior = false;
            this.ClientList.View = System.Windows.Forms.View.List;
            // 
            // ServerLocation
            // 
            this.ServerLocation.Controls.Add(this.Port);
            this.ServerLocation.Controls.Add(this.IPAddress);
            this.ServerLocation.Controls.Add(this.Portlabel);
            this.ServerLocation.Controls.Add(this.IPAddresslabel);
            this.ServerLocation.Location = new System.Drawing.Point(243, 12);
            this.ServerLocation.Name = "ServerLocation";
            this.ServerLocation.Size = new System.Drawing.Size(287, 125);
            this.ServerLocation.TabIndex = 6;
            this.ServerLocation.TabStop = false;
            this.ServerLocation.Text = "ServerLocation";
            // 
            // Port
            // 
            this.Port.Location = new System.Drawing.Point(118, 81);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(163, 27);
            this.Port.TabIndex = 3;
            // 
            // IPAddress
            // 
            this.IPAddress.Location = new System.Drawing.Point(118, 34);
            this.IPAddress.Name = "IPAddress";
            this.IPAddress.Size = new System.Drawing.Size(163, 27);
            this.IPAddress.TabIndex = 2;
            // 
            // Portlabel
            // 
            this.Portlabel.AutoSize = true;
            this.Portlabel.Location = new System.Drawing.Point(28, 81);
            this.Portlabel.Name = "Portlabel";
            this.Portlabel.Size = new System.Drawing.Size(35, 20);
            this.Portlabel.TabIndex = 1;
            this.Portlabel.Text = "Port";
            // 
            // IPAddresslabel
            // 
            this.IPAddresslabel.AutoSize = true;
            this.IPAddresslabel.Location = new System.Drawing.Point(17, 32);
            this.IPAddresslabel.Name = "IPAddresslabel";
            this.IPAddresslabel.Size = new System.Drawing.Size(73, 20);
            this.IPAddresslabel.TabIndex = 0;
            this.IPAddresslabel.Text = "IPAddress";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ServerLocation);
            this.Controls.Add(this.ClientList);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.SendBox);
            this.Controls.Add(this.ShutDown);
            this.Controls.Add(this.Start);
            this.Name = "Server";
            this.Text = "Server";
            this.ServerLocation.ResumeLayout(false);
            this.ServerLocation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Button Start;
        private Button ShutDown;
        private RichTextBox SendBox;
        private Button Send;
        private ListView ClientList;
        private GroupBox ServerLocation;
        private TextBox Port;
        private TextBox IPAddress;
        private Label Portlabel;
        private Label IPAddresslabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}