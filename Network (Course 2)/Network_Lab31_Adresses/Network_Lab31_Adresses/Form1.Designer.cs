namespace Network_Lab31_Adresses
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
            this.FirstIPtxt = new System.Windows.Forms.Label();
            this.StartBtn = new System.Windows.Forms.Button();
            this.SecondIPtxt = new System.Windows.Forms.Label();
            this.Output = new System.Windows.Forms.RichTextBox();
            this.FirstIP = new System.Windows.Forms.MaskedTextBox();
            this.SecondIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SubnetMask = new System.Windows.Forms.TextBox();
            this.SubnetIP = new System.Windows.Forms.TextBox();
            this.BroadcastIP = new System.Windows.Forms.TextBox();
            this.MACAddress = new System.Windows.Forms.TextBox();
            this.SubnetMaskTxt = new System.Windows.Forms.Label();
            this.SubnetIPTxt = new System.Windows.Forms.Label();
            this.BroadcastIPTxt = new System.Windows.Forms.Label();
            this.MACAddressTxt = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // FirstIPtxt
            // 
            this.FirstIPtxt.AutoSize = true;
            this.FirstIPtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstIPtxt.Location = new System.Drawing.Point(83, 18);
            this.FirstIPtxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FirstIPtxt.Name = "FirstIPtxt";
            this.FirstIPtxt.Size = new System.Drawing.Size(42, 13);
            this.FirstIPtxt.TabIndex = 2;
            this.FirstIPtxt.Text = "First IP:";
            // 
            // StartBtn
            // 
            this.StartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartBtn.Location = new System.Drawing.Point(333, 18);
            this.StartBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(125, 34);
            this.StartBtn.TabIndex = 4;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // SecondIPtxt
            // 
            this.SecondIPtxt.AutoSize = true;
            this.SecondIPtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondIPtxt.Location = new System.Drawing.Point(209, 18);
            this.SecondIPtxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SecondIPtxt.Name = "SecondIPtxt";
            this.SecondIPtxt.Size = new System.Drawing.Size(60, 13);
            this.SecondIPtxt.TabIndex = 3;
            this.SecondIPtxt.Text = "Second IP:";
            // 
            // Output
            // 
            this.Output.BackColor = System.Drawing.Color.White;
            this.Output.Location = new System.Drawing.Point(41, 86);
            this.Output.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            this.Output.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.Output.Size = new System.Drawing.Size(438, 191);
            this.Output.TabIndex = 5;
            this.Output.Text = "";
            // 
            // FirstIP
            // 
            this.FirstIP.Location = new System.Drawing.Point(59, 35);
            this.FirstIP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FirstIP.Name = "FirstIP";
            this.FirstIP.Size = new System.Drawing.Size(101, 20);
            this.FirstIP.TabIndex = 7;
            this.FirstIP.TextChanged += new System.EventHandler(this.FirstIP_TextChanged);
            // 
            // SecondIP
            // 
            this.SecondIP.Location = new System.Drawing.Point(193, 35);
            this.SecondIP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SecondIP.Name = "SecondIP";
            this.SecondIP.Size = new System.Drawing.Size(101, 20);
            this.SecondIP.TabIndex = 1;
            this.SecondIP.TextChanged += new System.EventHandler(this.SecondIP_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Is Reachable";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(370, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "DNS";
            // 
            // SubnetMask
            // 
            this.SubnetMask.Location = new System.Drawing.Point(519, 129);
            this.SubnetMask.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SubnetMask.Name = "SubnetMask";
            this.SubnetMask.ReadOnly = true;
            this.SubnetMask.Size = new System.Drawing.Size(123, 20);
            this.SubnetMask.TabIndex = 11;
            this.SubnetMask.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SubnetIP
            // 
            this.SubnetIP.Location = new System.Drawing.Point(666, 129);
            this.SubnetIP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SubnetIP.Name = "SubnetIP";
            this.SubnetIP.ReadOnly = true;
            this.SubnetIP.Size = new System.Drawing.Size(123, 20);
            this.SubnetIP.TabIndex = 12;
            this.SubnetIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BroadcastIP
            // 
            this.BroadcastIP.Location = new System.Drawing.Point(519, 217);
            this.BroadcastIP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BroadcastIP.Name = "BroadcastIP";
            this.BroadcastIP.ReadOnly = true;
            this.BroadcastIP.Size = new System.Drawing.Size(123, 20);
            this.BroadcastIP.TabIndex = 13;
            this.BroadcastIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MACAddress
            // 
            this.MACAddress.Location = new System.Drawing.Point(666, 217);
            this.MACAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MACAddress.Name = "MACAddress";
            this.MACAddress.ReadOnly = true;
            this.MACAddress.Size = new System.Drawing.Size(123, 20);
            this.MACAddress.TabIndex = 14;
            this.MACAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SubnetMaskTxt
            // 
            this.SubnetMaskTxt.AutoSize = true;
            this.SubnetMaskTxt.Location = new System.Drawing.Point(545, 114);
            this.SubnetMaskTxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SubnetMaskTxt.Name = "SubnetMaskTxt";
            this.SubnetMaskTxt.Size = new System.Drawing.Size(70, 13);
            this.SubnetMaskTxt.TabIndex = 15;
            this.SubnetMaskTxt.Text = "Subnet Mask";
            // 
            // SubnetIPTxt
            // 
            this.SubnetIPTxt.AutoSize = true;
            this.SubnetIPTxt.Location = new System.Drawing.Point(683, 114);
            this.SubnetIPTxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SubnetIPTxt.Name = "SubnetIPTxt";
            this.SubnetIPTxt.Size = new System.Drawing.Size(82, 13);
            this.SubnetIPTxt.TabIndex = 16;
            this.SubnetIPTxt.Text = "Subnet Address";
            // 
            // BroadcastIPTxt
            // 
            this.BroadcastIPTxt.AutoSize = true;
            this.BroadcastIPTxt.Location = new System.Drawing.Point(533, 202);
            this.BroadcastIPTxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BroadcastIPTxt.Name = "BroadcastIPTxt";
            this.BroadcastIPTxt.Size = new System.Drawing.Size(96, 13);
            this.BroadcastIPTxt.TabIndex = 17;
            this.BroadcastIPTxt.Text = "Broadcast Address";
            // 
            // MACAddressTxt
            // 
            this.MACAddressTxt.AutoSize = true;
            this.MACAddressTxt.Location = new System.Drawing.Point(690, 202);
            this.MACAddressTxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MACAddressTxt.Name = "MACAddressTxt";
            this.MACAddressTxt.Size = new System.Drawing.Size(71, 13);
            this.MACAddressTxt.TabIndex = 18;
            this.MACAddressTxt.Text = "MAC Address";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(519, 27);
            this.progressBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(268, 15);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 367);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.MACAddressTxt);
            this.Controls.Add(this.BroadcastIPTxt);
            this.Controls.Add(this.SubnetIPTxt);
            this.Controls.Add(this.SubnetMaskTxt);
            this.Controls.Add(this.MACAddress);
            this.Controls.Add(this.BroadcastIP);
            this.Controls.Add(this.SubnetIP);
            this.Controls.Add(this.SubnetMask);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FirstIP);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.SecondIPtxt);
            this.Controls.Add(this.FirstIPtxt);
            this.Controls.Add(this.SecondIP);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label FirstIPtxt;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Label SecondIPtxt;
        private System.Windows.Forms.RichTextBox Output;
        private System.Windows.Forms.TextBox SecondIP;
        private System.Windows.Forms.MaskedTextBox FirstIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SubnetMask;
        private System.Windows.Forms.TextBox SubnetIP;
        private System.Windows.Forms.TextBox BroadcastIP;
        private System.Windows.Forms.TextBox MACAddress;
        private System.Windows.Forms.Label SubnetMaskTxt;
        private System.Windows.Forms.Label SubnetIPTxt;
        private System.Windows.Forms.Label BroadcastIPTxt;
        private System.Windows.Forms.Label MACAddressTxt;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

