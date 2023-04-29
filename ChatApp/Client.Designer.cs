namespace ChatApp
{
    partial class Client
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SendBox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Connect = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ClientList = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ClientPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ClientIp = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ServerPort = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ServerIp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ComboClients = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // SendBox
            // 
            this.SendBox.Location = new System.Drawing.Point(12, 322);
            this.SendBox.Name = "SendBox";
            this.SendBox.Size = new System.Drawing.Size(556, 116);
            this.SendBox.TabIndex = 0;
            this.SendBox.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(676, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(676, 163);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(94, 29);
            this.Connect.TabIndex = 3;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.button2_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // ClientList
            // 
            this.ClientList.Location = new System.Drawing.Point(6, 25);
            this.ClientList.Name = "ClientList";
            this.ClientList.Size = new System.Drawing.Size(213, 277);
            this.ClientList.TabIndex = 4;
            this.ClientList.UseCompatibleStateImageBehavior = false;
            this.ClientList.View = System.Windows.Forms.View.List;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ClientPort);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ClientIp);
            this.groupBox1.Location = new System.Drawing.Point(280, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 125);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Your location";
            // 
            // ClientPort
            // 
            this.ClientPort.Location = new System.Drawing.Point(115, 85);
            this.ClientPort.Name = "ClientPort";
            this.ClientPort.Size = new System.Drawing.Size(158, 27);
            this.ClientPort.TabIndex = 3;
            this.ClientPort.TextChanged += new System.EventHandler(this.ClientPort_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(17, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(17, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "IPAddress";
            // 
            // ClientIp
            // 
            this.ClientIp.Location = new System.Drawing.Point(115, 35);
            this.ClientIp.Name = "ClientIp";
            this.ClientIp.Size = new System.Drawing.Size(158, 27);
            this.ClientIp.TabIndex = 0;
            this.ClientIp.TextChanged += new System.EventHandler(this.ClientIp_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ServerPort);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.ServerIp);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(280, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(288, 125);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Server location";
            // 
            // ServerPort
            // 
            this.ServerPort.Location = new System.Drawing.Point(115, 92);
            this.ServerPort.Name = "ServerPort";
            this.ServerPort.Size = new System.Drawing.Size(158, 27);
            this.ServerPort.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(17, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Port";
            // 
            // ServerIp
            // 
            this.ServerIp.Location = new System.Drawing.Point(115, 38);
            this.ServerIp.Name = "ServerIp";
            this.ServerIp.Size = new System.Drawing.Size(158, 27);
            this.ServerIp.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(17, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "IPAddress";
            // 
            // ComboClients
            // 
            this.ComboClients.FormattingEnabled = true;
            this.ComboClients.Location = new System.Drawing.Point(619, 32);
            this.ComboClients.Name = "ComboClients";
            this.ComboClients.Size = new System.Drawing.Size(151, 28);
            this.ComboClients.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ClientList);
            this.groupBox3.Location = new System.Drawing.Point(12, -3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(236, 319);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ServerMessages";
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.ComboClients);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.SendBox);
            this.Name = "Client";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox SendBox;
        private Button button1;
        private Button Connect;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ListView ClientList;
        private GroupBox groupBox1;
        private TextBox ClientPort;
        private Label label2;
        private Label label1;
        private TextBox ClientIp;
        private GroupBox groupBox2;
        private TextBox ServerPort;
        private Label label4;
        private TextBox ServerIp;
        private Label label3;
        private ComboBox ComboClients;
        private GroupBox groupBox3;
    }
}