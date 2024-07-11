namespace SocketClientMath
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
            tbPort = new TextBox();
            lbPort = new Label();
            tbHost = new TextBox();
            lbHost = new Label();
            btStart = new Button();
            SuspendLayout();
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 20;
            listBox.Location = new Point(56, 38);
            listBox.Name = "listBox";
            listBox.Size = new Size(289, 104);
            listBox.TabIndex = 0;
            // 
            // tbPort
            // 
            tbPort.Location = new Point(149, 216);
            tbPort.Margin = new Padding(3, 4, 3, 4);
            tbPort.Name = "tbPort";
            tbPort.Size = new Size(124, 27);
            tbPort.TabIndex = 8;
            tbPort.Text = "8080";
            // 
            // lbPort
            // 
            lbPort.AutoSize = true;
            lbPort.Location = new Point(89, 219);
            lbPort.Name = "lbPort";
            lbPort.Size = new Size(35, 20);
            lbPort.TabIndex = 7;
            lbPort.Text = "Port";
            // 
            // tbHost
            // 
            tbHost.Location = new Point(149, 177);
            tbHost.Margin = new Padding(3, 4, 3, 4);
            tbHost.Name = "tbHost";
            tbHost.Size = new Size(124, 27);
            tbHost.TabIndex = 6;
            tbHost.Text = "127.0.0.1";
            // 
            // lbHost
            // 
            lbHost.AutoSize = true;
            lbHost.Location = new Point(84, 180);
            lbHost.Name = "lbHost";
            lbHost.Size = new Size(40, 20);
            lbHost.TabIndex = 5;
            lbHost.Text = "Host";
            // 
            // btStart
            // 
            btStart.Location = new Point(89, 292);
            btStart.Name = "btStart";
            btStart.Size = new Size(218, 29);
            btStart.TabIndex = 9;
            btStart.Text = "Получить";
            btStart.UseVisualStyleBackColor = true;
            btStart.Click += btStart_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 482);
            Controls.Add(btStart);
            Controls.Add(tbPort);
            Controls.Add(lbPort);
            Controls.Add(tbHost);
            Controls.Add(lbHost);
            Controls.Add(listBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox;
        private TextBox tbPort;
        private Label lbPort;
        private TextBox tbHost;
        private Label lbHost;
        private Button btStart;
    }
}