namespace SiAKOD_RGR_Nail
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.paintBox = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.MergeBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.FindBtn = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.125F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.875F));
            this.tableLayoutPanel1.Controls.Add(this.paintBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1002, 664);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // paintBox
            // 
            this.paintBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.paintBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paintBox.Location = new System.Drawing.Point(3, 3);
            this.paintBox.Name = "paintBox";
            this.paintBox.Size = new System.Drawing.Size(766, 658);
            this.paintBox.TabIndex = 0;
            this.paintBox.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintBox_Paint);
            this.paintBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PaintBox_MouseClick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.FindBtn, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.DeleteBtn, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.MergeBtn, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(775, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(224, 658);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // MergeBtn
            // 
            this.MergeBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MergeBtn.Location = new System.Drawing.Point(8, 8);
            this.MergeBtn.Margin = new System.Windows.Forms.Padding(5);
            this.MergeBtn.Name = "MergeBtn";
            this.MergeBtn.Size = new System.Drawing.Size(208, 40);
            this.MergeBtn.TabIndex = 0;
            this.MergeBtn.Text = "Соединить";
            this.MergeBtn.UseVisualStyleBackColor = true;
            this.MergeBtn.Click += new System.EventHandler(this.MergeBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteBtn.Location = new System.Drawing.Point(8, 61);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(5);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(208, 40);
            this.DeleteBtn.TabIndex = 1;
            this.DeleteBtn.Text = "Удалить";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // FindBtn
            // 
            this.FindBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FindBtn.Location = new System.Drawing.Point(8, 114);
            this.FindBtn.Margin = new System.Windows.Forms.Padding(5);
            this.FindBtn.Name = "FindBtn";
            this.FindBtn.Size = new System.Drawing.Size(208, 40);
            this.FindBtn.TabIndex = 2;
            this.FindBtn.Text = "Выполнить";
            this.FindBtn.UseVisualStyleBackColor = true;
            this.FindBtn.Click += new System.EventHandler(this.FindBtn_Click);
            // 
            // textBox
            // 
            this.textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox.Location = new System.Drawing.Point(6, 165);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.Size = new System.Drawing.Size(212, 57);
            this.textBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 664);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Поиск максимального паросочетания в двудольном графе";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel paintBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button MergeBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button FindBtn;
        private System.Windows.Forms.TextBox textBox;
    }
}

