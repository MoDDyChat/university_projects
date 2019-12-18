namespace OOP_Lab34
{
    partial class Form
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
            this.paintPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // paintPanel
            // 
            this.paintPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paintPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paintPanel.Location = new System.Drawing.Point(12, 12);
            this.paintPanel.Name = "paintPanel";
            this.paintPanel.Size = new System.Drawing.Size(1260, 538);
            this.paintPanel.TabIndex = 0;
            this.paintPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintPanel_Paint);
            this.paintPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PaintPanel_MouseClick);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 562);
            this.Controls.Add(this.paintPanel);
            this.Name = "Form";
            this.Text = "CircleConstructor";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paintPanel;
    }
}

