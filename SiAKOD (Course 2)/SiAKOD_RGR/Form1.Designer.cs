namespace SiAKOD_RGR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.MergeBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.DeleteBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.DeselectBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.FindBtn = new System.Windows.Forms.ToolStripButton();
            this.paintBox = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MergeBtn,
            this.toolStripSeparator1,
            this.DeleteBtn,
            this.toolStripSeparator3,
            this.DeselectBtn,
            this.toolStripSeparator2,
            this.FindBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(946, 32);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // MergeBtn
            // 
            this.MergeBtn.Image = ((System.Drawing.Image)(resources.GetObject("MergeBtn.Image")));
            this.MergeBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MergeBtn.Name = "MergeBtn";
            this.MergeBtn.Size = new System.Drawing.Size(127, 29);
            this.MergeBtn.Text = "Соединить";
            this.MergeBtn.Click += new System.EventHandler(this.MergeBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 32);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Image = ((System.Drawing.Image)(resources.GetObject("DeleteBtn.Image")));
            this.DeleteBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(104, 29);
            this.DeleteBtn.Text = "Удалить";
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 32);
            // 
            // DeselectBtn
            // 
            this.DeselectBtn.Image = ((System.Drawing.Image)(resources.GetObject("DeselectBtn.Image")));
            this.DeselectBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeselectBtn.Name = "DeselectBtn";
            this.DeselectBtn.Size = new System.Drawing.Size(190, 29);
            this.DeselectBtn.Text = "Убрать выделения";
            this.DeselectBtn.Click += new System.EventHandler(this.DeselectBtn_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 32);
            // 
            // FindBtn
            // 
            this.FindBtn.Image = ((System.Drawing.Image)(resources.GetObject("FindBtn.Image")));
            this.FindBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FindBtn.Name = "FindBtn";
            this.FindBtn.Size = new System.Drawing.Size(211, 29);
            this.FindBtn.Text = "Выполнить алгоритм";
            this.FindBtn.Click += new System.EventHandler(this.FindBtn_Click);
            // 
            // paintBox
            // 
            this.paintBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.paintBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paintBox.Location = new System.Drawing.Point(3, 3);
            this.paintBox.Name = "paintBox";
            this.paintBox.Size = new System.Drawing.Size(733, 412);
            this.paintBox.TabIndex = 0;
            this.paintBox.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintBox_Paint);
            this.paintBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PaintBox_MouseClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.2241F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.7759F));
            this.tableLayoutPanel1.Controls.Add(this.paintBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 32);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(946, 418);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // textBox
            // 
            this.textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox.Location = new System.Drawing.Point(742, 3);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.Size = new System.Drawing.Size(201, 412);
            this.textBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Поиск минимальной суммы расстояний в графе";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton MergeBtn;
        private System.Windows.Forms.ToolStripButton DeselectBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton DeleteBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton FindBtn;
        private System.Windows.Forms.Panel paintBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox;
    }
}

