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
            this.LocalIP = new System.Windows.Forms.TextBox();
            this.LocalIPtxt = new System.Windows.Forms.Label();
            this.FirstIP = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FirstIPtxt
            // 
            this.FirstIPtxt.AutoSize = true;
            this.FirstIPtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstIPtxt.Location = new System.Drawing.Point(124, 28);
            this.FirstIPtxt.Name = "FirstIPtxt";
            this.FirstIPtxt.Size = new System.Drawing.Size(63, 20);
            this.FirstIPtxt.TabIndex = 2;
            this.FirstIPtxt.Text = "First IP:";
            // 
            // StartBtn
            // 
            this.StartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartBtn.Location = new System.Drawing.Point(500, 28);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(188, 52);
            this.StartBtn.TabIndex = 4;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // SecondIPtxt
            // 
            this.SecondIPtxt.AutoSize = true;
            this.SecondIPtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondIPtxt.Location = new System.Drawing.Point(335, 28);
            this.SecondIPtxt.Name = "SecondIPtxt";
            this.SecondIPtxt.Size = new System.Drawing.Size(63, 20);
            this.SecondIPtxt.TabIndex = 3;
            this.SecondIPtxt.Text = "Last IP:";
            // 
            // Output
            // 
            this.Output.BackColor = System.Drawing.Color.White;
            this.Output.Location = new System.Drawing.Point(62, 132);
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            this.Output.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.Output.Size = new System.Drawing.Size(655, 292);
            this.Output.TabIndex = 5;
            this.Output.Text = "";
            // 
            // SecondIP
            // 
            this.SecondIP.Location = new System.Drawing.Point(290, 54);
            this.SecondIP.Name = "SecondIP";
            this.SecondIP.Size = new System.Drawing.Size(150, 26);
            this.SecondIP.TabIndex = 1;
            this.SecondIP.Text = "193.233.146.245";
            this.SecondIP.TextChanged += new System.EventHandler(this.SecondIP_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Is Reachable";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(555, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "DNS";
            // 
            // SubnetMask
            // 
            this.SubnetMask.Location = new System.Drawing.Point(780, 254);
            this.SubnetMask.Name = "SubnetMask";
            this.SubnetMask.ReadOnly = true;
            this.SubnetMask.Size = new System.Drawing.Size(182, 26);
            this.SubnetMask.TabIndex = 11;
            this.SubnetMask.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SubnetIP
            // 
            this.SubnetIP.Location = new System.Drawing.Point(1001, 254);
            this.SubnetIP.Name = "SubnetIP";
            this.SubnetIP.ReadOnly = true;
            this.SubnetIP.Size = new System.Drawing.Size(182, 26);
            this.SubnetIP.TabIndex = 12;
            this.SubnetIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BroadcastIP
            // 
            this.BroadcastIP.Location = new System.Drawing.Point(780, 360);
            this.BroadcastIP.Name = "BroadcastIP";
            this.BroadcastIP.ReadOnly = true;
            this.BroadcastIP.Size = new System.Drawing.Size(182, 26);
            this.BroadcastIP.TabIndex = 13;
            this.BroadcastIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MACAddress
            // 
            this.MACAddress.Location = new System.Drawing.Point(1001, 360);
            this.MACAddress.Name = "MACAddress";
            this.MACAddress.ReadOnly = true;
            this.MACAddress.Size = new System.Drawing.Size(182, 26);
            this.MACAddress.TabIndex = 14;
            this.MACAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SubnetMaskTxt
            // 
            this.SubnetMaskTxt.AutoSize = true;
            this.SubnetMaskTxt.Location = new System.Drawing.Point(820, 231);
            this.SubnetMaskTxt.Name = "SubnetMaskTxt";
            this.SubnetMaskTxt.Size = new System.Drawing.Size(103, 20);
            this.SubnetMaskTxt.TabIndex = 15;
            this.SubnetMaskTxt.Text = "Subnet Mask";
            // 
            // SubnetIPTxt
            // 
            this.SubnetIPTxt.AutoSize = true;
            this.SubnetIPTxt.Location = new System.Drawing.Point(1031, 231);
            this.SubnetIPTxt.Name = "SubnetIPTxt";
            this.SubnetIPTxt.Size = new System.Drawing.Size(124, 20);
            this.SubnetIPTxt.TabIndex = 16;
            this.SubnetIPTxt.Text = "Subnet Address";
            // 
            // BroadcastIPTxt
            // 
            this.BroadcastIPTxt.AutoSize = true;
            this.BroadcastIPTxt.Location = new System.Drawing.Point(802, 337);
            this.BroadcastIPTxt.Name = "BroadcastIPTxt";
            this.BroadcastIPTxt.Size = new System.Drawing.Size(145, 20);
            this.BroadcastIPTxt.TabIndex = 17;
            this.BroadcastIPTxt.Text = "Broadcast Address";
            // 
            // MACAddressTxt
            // 
            this.MACAddressTxt.AutoSize = true;
            this.MACAddressTxt.Location = new System.Drawing.Point(1037, 337);
            this.MACAddressTxt.Name = "MACAddressTxt";
            this.MACAddressTxt.Size = new System.Drawing.Size(107, 20);
            this.MACAddressTxt.TabIndex = 18;
            this.MACAddressTxt.Text = "MAC Address";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(778, 42);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(402, 23);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 19;
            // 
            // LocalIP
            // 
            this.LocalIP.Location = new System.Drawing.Point(882, 158);
            this.LocalIP.Name = "LocalIP";
            this.LocalIP.ReadOnly = true;
            this.LocalIP.Size = new System.Drawing.Size(182, 26);
            this.LocalIP.TabIndex = 20;
            this.LocalIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LocalIPtxt
            // 
            this.LocalIPtxt.AutoSize = true;
            this.LocalIPtxt.Location = new System.Drawing.Point(944, 135);
            this.LocalIPtxt.Name = "LocalIPtxt";
            this.LocalIPtxt.Size = new System.Drawing.Size(66, 20);
            this.LocalIPtxt.TabIndex = 21;
            this.LocalIPtxt.Text = "Local IP";
            // 
            // FirstIP
            // 
            this.FirstIP.Location = new System.Drawing.Point(78, 54);
            this.FirstIP.Name = "FirstIP";
            this.FirstIP.Size = new System.Drawing.Size(150, 26);
            this.FirstIP.TabIndex = 22;
            this.FirstIP.Text = "193.233.146.242";
            this.FirstIP.TextChanged += new System.EventHandler(this.FirstIP_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 565);
            this.Controls.Add(this.FirstIP);
            this.Controls.Add(this.LocalIPtxt);
            this.Controls.Add(this.LocalIP);
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
            this.Controls.Add(this.Output);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.SecondIPtxt);
            this.Controls.Add(this.FirstIPtxt);
            this.Controls.Add(this.SecondIP);
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
        private System.Windows.Forms.TextBox LocalIP;
        private System.Windows.Forms.Label LocalIPtxt;
        private System.Windows.Forms.TextBox FirstIP;
    }
}

