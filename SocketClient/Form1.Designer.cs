namespace SocketClient
{
    partial class Form1
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
            listBox1 = new ListBox();
            label1 = new Label();
            tbHost = new TextBox();
            tbPort = new TextBox();
            label2 = new Label();
            button1 = new Button();
            tbMessage = new TextBox();
            label3 = new Label();
            btTCPClint = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Dock = DockStyle.Top;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(0, 0);
            listBox1.Margin = new Padding(3, 4, 3, 4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(375, 544);
            listBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(97, 584);
            label1.Name = "label1";
            label1.Size = new Size(40, 20);
            label1.TabIndex = 1;
            label1.Text = "Host";
            // 
            // tbHost
            // 
            tbHost.Location = new Point(136, 580);
            tbHost.Margin = new Padding(3, 4, 3, 4);
            tbHost.Name = "tbHost";
            tbHost.Size = new Size(124, 27);
            tbHost.TabIndex = 2;
            tbHost.Text = "127.0.0.1";
            // 
            // tbPort
            // 
            tbPort.Location = new Point(136, 619);
            tbPort.Margin = new Padding(3, 4, 3, 4);
            tbPort.Name = "tbPort";
            tbPort.Size = new Size(124, 27);
            tbPort.TabIndex = 4;
            tbPort.Text = "8080";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(97, 623);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 3;
            label2.Text = "Port";
            // 
            // button1
            // 
            button1.Location = new Point(22, 713);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(156, 31);
            button1.TabIndex = 5;
            button1.Text = "SocketSend";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tbMessage
            // 
            tbMessage.Location = new Point(136, 657);
            tbMessage.Margin = new Padding(3, 4, 3, 4);
            tbMessage.Name = "tbMessage";
            tbMessage.Size = new Size(124, 27);
            tbMessage.TabIndex = 7;
            tbMessage.Text = "Hello world";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 661);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 6;
            label3.Text = "Message";
            // 
            // btTCPClint
            // 
            btTCPClint.Location = new Point(184, 713);
            btTCPClint.Margin = new Padding(3, 4, 3, 4);
            btTCPClint.Name = "btTCPClint";
            btTCPClint.Size = new Size(163, 31);
            btTCPClint.TabIndex = 8;
            btTCPClint.Text = "TCP Clint Send";
            btTCPClint.UseVisualStyleBackColor = true;
            btTCPClint.Click += btTCPClint_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 760);
            Controls.Add(btTCPClint);
            Controls.Add(tbMessage);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(tbPort);
            Controls.Add(label2);
            Controls.Add(tbHost);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "SocketClient";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private TextBox tbHost;
        private TextBox tbPort;
        private Label label2;
        private Button button1;
        private TextBox tbMessage;
        private Label label3;
        private Button btTCPClint;
    }
}