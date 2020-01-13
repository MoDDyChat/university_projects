namespace OOP_Lab38
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
            this.colorSwitch = new System.Windows.Forms.ColorDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.CircleButton = new System.Windows.Forms.ToolStripMenuItem();
            this.RectButton = new System.Windows.Forms.ToolStripMenuItem();
            this.TriButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.DeleteButton = new System.Windows.Forms.ToolStripButton();
            this.ChangeColorButton = new System.Windows.Forms.ToolStripButton();
            this.ChangeSizeButton = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectAllButton = new System.Windows.Forms.ToolStripMenuItem();
            this.UnSelectAllButton = new System.Windows.Forms.ToolStripMenuItem();
            this.shapesToGroupBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.sizeXBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sizeYBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.typeLbl = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.CountLbl = new System.Windows.Forms.ToolStripLabel();
            this.testLbl = new System.Windows.Forms.ToolStripLabel();
            this.PaintPanel = new System.Windows.Forms.Panel();
            this.unGroupBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.toolStripSplitButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.saveToFileBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFormFileBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton3,
            this.toolStripSplitButton2,
            this.toolStripSplitButton1,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.sizeXBox,
            this.toolStripSeparator2,
            this.sizeYBox,
            this.toolStripSeparator3,
            this.typeLbl,
            this.toolStripSeparator4,
            this.CountLbl,
            this.testLbl});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1341, 32);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolBar";
            // 
            // toolStripSplitButton2
            // 
            this.toolStripSplitButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CircleButton,
            this.RectButton,
            this.TriButton});
            this.toolStripSplitButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            this.toolStripSplitButton2.Size = new System.Drawing.Size(89, 29);
            this.toolStripSplitButton2.Text = "Фигура";
            // 
            // CircleButton
            // 
            this.CircleButton.Name = "CircleButton";
            this.CircleButton.Size = new System.Drawing.Size(252, 30);
            this.CircleButton.Text = "Круг";
            this.CircleButton.Click += new System.EventHandler(this.CircleButton_Click);
            // 
            // RectButton
            // 
            this.RectButton.Name = "RectButton";
            this.RectButton.Size = new System.Drawing.Size(252, 30);
            this.RectButton.Text = "Прямоугольник";
            this.RectButton.Click += new System.EventHandler(this.RectButton_Click);
            // 
            // TriButton
            // 
            this.TriButton.Name = "TriButton";
            this.TriButton.Size = new System.Drawing.Size(252, 30);
            this.TriButton.Text = "Треугольник";
            this.TriButton.Click += new System.EventHandler(this.TriButton_Click);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteButton,
            this.ChangeColorButton,
            this.ChangeSizeButton,
            this.SelectAllButton,
            this.UnSelectAllButton,
            this.shapesToGroupBtn,
            this.unGroupBtn});
            this.toolStripSplitButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(105, 29);
            this.toolStripSplitButton1.Text = "Действия";
            this.toolStripSplitButton1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // DeleteButton
            // 
            this.DeleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DeleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(185, 29);
            this.DeleteButton.Text = "Удалить выделенное";
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ChangeColorButton
            // 
            this.ChangeColorButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ChangeColorButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ChangeColorButton.Name = "ChangeColorButton";
            this.ChangeColorButton.Size = new System.Drawing.Size(251, 29);
            this.ChangeColorButton.Text = "Изменить цвет выделенного";
            this.ChangeColorButton.Click += new System.EventHandler(this.ChangeColorButton_Click);
            // 
            // ChangeSizeButton
            // 
            this.ChangeSizeButton.Name = "ChangeSizeButton";
            this.ChangeSizeButton.Size = new System.Drawing.Size(323, 30);
            this.ChangeSizeButton.Text = "Изменить размер фигуры";
            this.ChangeSizeButton.Click += new System.EventHandler(this.ChangeSizeButton_Click);
            // 
            // SelectAllButton
            // 
            this.SelectAllButton.Name = "SelectAllButton";
            this.SelectAllButton.Size = new System.Drawing.Size(323, 30);
            this.SelectAllButton.Text = "Выделить всё";
            this.SelectAllButton.Click += new System.EventHandler(this.SelectAllButton_Click);
            // 
            // UnSelectAllButton
            // 
            this.UnSelectAllButton.Name = "UnSelectAllButton";
            this.UnSelectAllButton.Size = new System.Drawing.Size(323, 30);
            this.UnSelectAllButton.Text = "Снять все выделения";
            this.UnSelectAllButton.Click += new System.EventHandler(this.UnSelectAllButton_Click);
            // 
            // shapesToGroupBtn
            // 
            this.shapesToGroupBtn.Name = "shapesToGroupBtn";
            this.shapesToGroupBtn.Size = new System.Drawing.Size(323, 30);
            this.shapesToGroupBtn.Text = "Объединить в группу";
            this.shapesToGroupBtn.Click += new System.EventHandler(this.ShapesToGroupBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 32);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(143, 29);
            this.toolStripLabel1.Text = "Размер фигуры:";
            // 
            // sizeXBox
            // 
            this.sizeXBox.Name = "sizeXBox";
            this.sizeXBox.Size = new System.Drawing.Size(70, 32);
            this.sizeXBox.TextChanged += new System.EventHandler(this.SizeXBox_TextChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 32);
            // 
            // sizeYBox
            // 
            this.sizeYBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.sizeYBox.Name = "sizeYBox";
            this.sizeYBox.Size = new System.Drawing.Size(70, 32);
            this.sizeYBox.TextChanged += new System.EventHandler(this.SizeYBox_TextChanged);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 32);
            // 
            // typeLbl
            // 
            this.typeLbl.Name = "typeLbl";
            this.typeLbl.Size = new System.Drawing.Size(132, 29);
            this.typeLbl.Text = "Выбрано: Круг";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 32);
            // 
            // CountLbl
            // 
            this.CountLbl.Name = "CountLbl";
            this.CountLbl.Size = new System.Drawing.Size(120, 29);
            this.CountLbl.Text = "Элементов: 0";
            // 
            // testLbl
            // 
            this.testLbl.Name = "testLbl";
            this.testLbl.Size = new System.Drawing.Size(41, 29);
            this.testLbl.Text = "test";
            // 
            // PaintPanel
            // 
            this.PaintPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PaintPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PaintPanel.Location = new System.Drawing.Point(0, 32);
            this.PaintPanel.Name = "PaintPanel";
            this.PaintPanel.Size = new System.Drawing.Size(1341, 555);
            this.PaintPanel.TabIndex = 1;
            this.PaintPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintPanel_Paint);
            this.PaintPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PaintPanel_MouseClick);
            this.PaintPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PaintPanel_MouseMove);
            // 
            // unGroupBtn
            // 
            this.unGroupBtn.Name = "unGroupBtn";
            this.unGroupBtn.Size = new System.Drawing.Size(323, 30);
            this.unGroupBtn.Text = "Распустить группу";
            this.unGroupBtn.Click += new System.EventHandler(this.UnGroupBtn_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // toolStripSplitButton3
            // 
            this.toolStripSplitButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToFileBtn,
            this.loadFormFileBtn});
            this.toolStripSplitButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton3.Image")));
            this.toolStripSplitButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton3.Name = "toolStripSplitButton3";
            this.toolStripSplitButton3.Size = new System.Drawing.Size(71, 29);
            this.toolStripSplitButton3.Text = "Файл";
            // 
            // saveToFileBtn
            // 
            this.saveToFileBtn.Name = "saveToFileBtn";
            this.saveToFileBtn.Size = new System.Drawing.Size(253, 30);
            this.saveToFileBtn.Text = "Сохранить в файл";
            this.saveToFileBtn.Click += new System.EventHandler(this.SaveToFileBtn_Click);
            // 
            // loadFormFileBtn
            // 
            this.loadFormFileBtn.Name = "loadFormFileBtn";
            this.loadFormFileBtn.Size = new System.Drawing.Size(253, 30);
            this.loadFormFileBtn.Text = "Загрузить из файла";
            this.loadFormFileBtn.Click += new System.EventHandler(this.LoadFormFileBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 587);
            this.Controls.Add(this.PaintPanel);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorSwitch;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel PaintPanel;
        private System.Windows.Forms.ToolStripDropDownButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripButton DeleteButton;
        private System.Windows.Forms.ToolStripButton ChangeColorButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox sizeXBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripTextBox sizeYBox;
        private System.Windows.Forms.ToolStripMenuItem ChangeSizeButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel typeLbl;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel CountLbl;
        private System.Windows.Forms.ToolStripDropDownButton toolStripSplitButton2;
        private System.Windows.Forms.ToolStripMenuItem CircleButton;
        private System.Windows.Forms.ToolStripMenuItem RectButton;
        private System.Windows.Forms.ToolStripMenuItem TriButton;
        private System.Windows.Forms.ToolStripMenuItem SelectAllButton;
        private System.Windows.Forms.ToolStripMenuItem UnSelectAllButton;
        private System.Windows.Forms.ToolStripLabel testLbl;
        private System.Windows.Forms.ToolStripMenuItem shapesToGroupBtn;
        private System.Windows.Forms.ToolStripMenuItem unGroupBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripDropDownButton toolStripSplitButton3;
        private System.Windows.Forms.ToolStripMenuItem saveToFileBtn;
        private System.Windows.Forms.ToolStripMenuItem loadFormFileBtn;
    }
}

