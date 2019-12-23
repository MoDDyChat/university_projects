namespace Network_Lab32_Server
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
            this.ipBox = new System.Windows.Forms.TextBox();
            this.portBox = new System.Windows.Forms.TextBox();
            this.listBox = new System.Windows.Forms.TextBox();
            this.logBox = new System.Windows.Forms.TextBox();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ipBox
            // 
            this.ipBox.Location = new System.Drawing.Point(516, 10);
            this.ipBox.Name = "ipBox";
            this.ipBox.Size = new System.Drawing.Size(187, 26);
            this.ipBox.TabIndex = 0;
            this.ipBox.Text = "127.0.0.1";
            this.ipBox.TextChanged += new System.EventHandler(this.IpBox_TextChanged);
            // 
            // portBox
            // 
            this.portBox.Location = new System.Drawing.Point(516, 42);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(187, 26);
            this.portBox.TabIndex = 1;
            this.portBox.Text = "21719";
            this.portBox.TextChanged += new System.EventHandler(this.PortBox_TextChanged);
            // 
            // listBox
            // 
            this.listBox.Location = new System.Drawing.Point(728, 83);
            this.listBox.Multiline = true;
            this.listBox.Name = "listBox";
            this.listBox.ReadOnly = true;
            this.listBox.Size = new System.Drawing.Size(218, 312);
            this.listBox.TabIndex = 2;
            // 
            // logBox
            // 
            this.logBox.Location = new System.Drawing.Point(27, 83);
            this.logBox.Multiline = true;
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logBox.Size = new System.Drawing.Size(676, 312);
            this.logBox.TabIndex = 3;
            this.logBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chatBox_KeyDown);
            // 
            // inputBox
            // 
            this.inputBox.Enabled = false;
            this.inputBox.Location = new System.Drawing.Point(27, 412);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(676, 26);
            this.inputBox.TabIndex = 4;
            this.inputBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputBox_KeyDown);
            // 
            // sendBtn
            // 
            this.sendBtn.Enabled = false;
            this.sendBtn.Location = new System.Drawing.Point(728, 408);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(218, 34);
            this.sendBtn.TabIndex = 5;
            this.sendBtn.Text = "Отправить";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(728, 12);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(218, 56);
            this.startBtn.TabIndex = 6;
            this.startBtn.Text = "Запустить сервер";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(458, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Порт:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(482, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "IP:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Консоль:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.portBox);
            this.Controls.Add(this.ipBox);
            this.Name = "Form1";
            this.Text = "CharServer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ipBox;
        private System.Windows.Forms.TextBox portBox;
        public System.Windows.Forms.TextBox listBox;
        public System.Windows.Forms.TextBox logBox;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}

