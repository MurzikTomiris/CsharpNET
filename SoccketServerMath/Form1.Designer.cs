namespace SoccketServerMath
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
            listBox = new ListBox();
            lbPort = new Label();
            tbPort = new TextBox();
            tbMesssage = new TextBox();
            lbMessage = new Label();
            btSend = new Button();
            tbHost = new TextBox();
            lbHost = new Label();
            SuspendLayout();
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 20;
            listBox.Location = new Point(64, 12);
            listBox.Name = "listBox";
            listBox.Size = new Size(244, 164);
            listBox.TabIndex = 0;
            // 
            // lbPort
            // 
            lbPort.AutoSize = true;
            lbPort.Location = new Point(64, 244);
            lbPort.Name = "lbPort";
            lbPort.Size = new Size(35, 20);
            lbPort.TabIndex = 1;
            lbPort.Text = "Port";
            // 
            // tbPort
            // 
            tbPort.Location = new Point(155, 241);
            tbPort.Name = "tbPort";
            tbPort.Size = new Size(153, 27);
            tbPort.TabIndex = 2;
            tbPort.Text = "8080";
            // 
            // tbMesssage
            // 
            tbMesssage.Location = new Point(64, 324);
            tbMesssage.Name = "tbMesssage";
            tbMesssage.Size = new Size(244, 27);
            tbMesssage.TabIndex = 3;
            // 
            // lbMessage
            // 
            lbMessage.AutoSize = true;
            lbMessage.Location = new Point(64, 288);
            lbMessage.Name = "lbMessage";
            lbMessage.Size = new Size(244, 20);
            lbMessage.TabIndex = 4;
            lbMessage.Text = "Напиши операцию через пробел";
            // 
            // btSend
            // 
            btSend.Location = new Point(129, 386);
            btSend.Name = "btSend";
            btSend.Size = new Size(94, 29);
            btSend.TabIndex = 5;
            btSend.Text = "Посчитать";
            btSend.UseVisualStyleBackColor = true;
            btSend.Click += btSend_Click;
            // 
            // tbHost
            // 
            tbHost.Location = new Point(157, 201);
            tbHost.Name = "tbHost";
            tbHost.Size = new Size(153, 27);
            tbHost.TabIndex = 7;
            tbHost.Text = "127.0.0.1";
            // 
            // lbHost
            // 
            lbHost.AutoSize = true;
            lbHost.Location = new Point(66, 204);
            lbHost.Name = "lbHost";
            lbHost.Size = new Size(35, 20);
            lbHost.TabIndex = 6;
            lbHost.Text = "Port";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 450);
            Controls.Add(tbHost);
            Controls.Add(lbHost);
            Controls.Add(btSend);
            Controls.Add(lbMessage);
            Controls.Add(tbMesssage);
            Controls.Add(tbPort);
            Controls.Add(lbPort);
            Controls.Add(listBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox;
        private Label lbPort;
        private TextBox tbPort;
        private TextBox tbMesssage;
        private Label lbMessage;
        private Button btSend;
        private TextBox tbHost;
        private Label lbHost;
    }
}