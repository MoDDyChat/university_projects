namespace Network_Lab32_Client
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox = new System.Windows.Forms.TextBox();
            this.connectBtn = new System.Windows.Forms.Button();
            this.disconnectBtn = new System.Windows.Forms.Button();
            this.portBox = new System.Windows.Forms.TextBox();
            this.ipBox = new System.Windows.Forms.TextBox();
            this.nickBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.logBox = new System.Windows.Forms.TextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.Location = new System.Drawing.Point(728, 92);
            this.listBox.Multiline = true;
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(218, 303);
            this.listBox.TabIndex = 3;
            // 
            // connectBtn
            // 
            this.connectBtn.Location = new System.Drawing.Point(728, 12);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(218, 34);
            this.connectBtn.TabIndex = 7;
            this.connectBtn.Text = "Подключиться к серверу";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // disconnectBtn
            // 
            this.disconnectBtn.Enabled = false;
            this.disconnectBtn.Location = new System.Drawing.Point(728, 52);
            this.disconnectBtn.Name = "disconnectBtn";
            this.disconnectBtn.Size = new System.Drawing.Size(218, 34);
            this.disconnectBtn.TabIndex = 8;
            this.disconnectBtn.Text = "Отключиться от сервера";
            this.disconnectBtn.UseVisualStyleBackColor = true;
            this.disconnectBtn.Click += new System.EventHandler(this.DisconnectBtn_Click);
            // 
            // portBox
            // 
            this.portBox.Location = new System.Drawing.Point(523, 52);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(187, 26);
            this.portBox.TabIndex = 10;
            this.portBox.Text = "21719";
            this.portBox.TextChanged += new System.EventHandler(this.PortBox_TextChanged);
            // 
            // ipBox
            // 
            this.ipBox.Location = new System.Drawing.Point(523, 20);
            this.ipBox.Name = "ipBox";
            this.ipBox.Size = new System.Drawing.Size(187, 26);
            this.ipBox.TabIndex = 9;
            this.ipBox.Text = "127.0.0.1";
            this.ipBox.TextChanged += new System.EventHandler(this.IpBox_TextChanged);
            // 
            // nickBox
            // 
            this.nickBox.Location = new System.Drawing.Point(34, 52);
            this.nickBox.Name = "nickBox";
            this.nickBox.Size = new System.Drawing.Size(187, 26);
            this.nickBox.TabIndex = 11;
            this.nickBox.Text = "username";
            this.nickBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(490, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(466, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Порт:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Ваш Никнейм:";
            // 
            // logBox
            // 
            this.logBox.Location = new System.Drawing.Point(34, 92);
            this.logBox.Multiline = true;
            this.logBox.Name = "logBox";
            this.logBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logBox.Size = new System.Drawing.Size(676, 303);
            this.logBox.TabIndex = 16;
            this.logBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chatBox_KeyDown);
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(728, 408);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(218, 34);
            this.sendBtn.TabIndex = 18;
            this.sendBtn.Text = "Отправить";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(34, 412);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(676, 26);
            this.inputBox.TabIndex = 17;
            this.inputBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputBox_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 450);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nickBox);
            this.Controls.Add(this.portBox);
            this.Controls.Add(this.ipBox);
            this.Controls.Add(this.disconnectBtn);
            this.Controls.Add(this.connectBtn);
            this.Controls.Add(this.listBox);
            this.Name = "Form1";
            this.Text = "ChatClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox listBox;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.Button disconnectBtn;
        private System.Windows.Forms.TextBox portBox;
        private System.Windows.Forms.TextBox ipBox;
        private System.Windows.Forms.TextBox nickBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox logBox;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.TextBox inputBox;
    }
}

