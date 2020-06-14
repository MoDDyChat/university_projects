namespace EngGraph_Lab42
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
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.PasteImgBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.changeColorBtn = new System.Windows.Forms.ToolStripButton();
            this.paintBox = new System.Windows.Forms.Panel();
            this.colorSwitch = new System.Windows.Forms.ColorDialog();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.LineBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.CircleBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.BezierBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.GraphBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.GradPathBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.ColorIntBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.TextBrshBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.XorShapeBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.ClipImgBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.InvertColorBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton2,
            this.toolStripDropDownButton1,
            this.changeColorBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1055, 32);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PasteImgBtn,
            this.ClipImgBtn,
            this.InvertColorBtn});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(186, 29);
            this.toolStripDropDownButton1.Text = "Растровая графика";
            // 
            // PasteImgBtn
            // 
            this.PasteImgBtn.Name = "PasteImgBtn";
            this.PasteImgBtn.Size = new System.Drawing.Size(281, 30);
            this.PasteImgBtn.Text = "Вставить изображение";
            this.PasteImgBtn.Click += new System.EventHandler(this.PasteImgBtn_Click);
            // 
            // changeColorBtn
            // 
            this.changeColorBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.changeColorBtn.Image = ((System.Drawing.Image)(resources.GetObject("changeColorBtn.Image")));
            this.changeColorBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.changeColorBtn.Name = "changeColorBtn";
            this.changeColorBtn.Size = new System.Drawing.Size(137, 29);
            this.changeColorBtn.Text = "Изменить цвет";
            this.changeColorBtn.Click += new System.EventHandler(this.ChangeColorBtn_Click);
            // 
            // paintBox
            // 
            this.paintBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.paintBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paintBox.Location = new System.Drawing.Point(0, 32);
            this.paintBox.Name = "paintBox";
            this.paintBox.Size = new System.Drawing.Size(1055, 418);
            this.paintBox.TabIndex = 2;
            this.paintBox.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintBox_Paint);
            this.paintBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PaintBox_MouseClick);
            this.paintBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PaintBox_MouseMove);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LineBtn,
            this.CircleBtn,
            this.BezierBtn,
            this.GraphBtn,
            this.GradPathBtn,
            this.ColorIntBtn,
            this.TextBrshBtn,
            this.XorShapeBtn});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(187, 29);
            this.toolStripDropDownButton2.Text = "Векторная графика";
            // 
            // LineBtn
            // 
            this.LineBtn.Name = "LineBtn";
            this.LineBtn.Size = new System.Drawing.Size(305, 30);
            this.LineBtn.Text = "Линия";
            this.LineBtn.Click += new System.EventHandler(this.LineBtn_Click);
            // 
            // CircleBtn
            // 
            this.CircleBtn.Name = "CircleBtn";
            this.CircleBtn.Size = new System.Drawing.Size(305, 30);
            this.CircleBtn.Text = "Окружность";
            this.CircleBtn.Click += new System.EventHandler(this.CircleBtn_Click);
            // 
            // BezierBtn
            // 
            this.BezierBtn.Name = "BezierBtn";
            this.BezierBtn.Size = new System.Drawing.Size(305, 30);
            this.BezierBtn.Text = "Кривая Безье";
            this.BezierBtn.Click += new System.EventHandler(this.BezierBtn_Click);
            // 
            // GraphBtn
            // 
            this.GraphBtn.Name = "GraphBtn";
            this.GraphBtn.Size = new System.Drawing.Size(305, 30);
            this.GraphBtn.Text = "Сектор";
            this.GraphBtn.Click += new System.EventHandler(this.PieBtn_Click);
            // 
            // GradPathBtn
            // 
            this.GradPathBtn.Name = "GradPathBtn";
            this.GradPathBtn.Size = new System.Drawing.Size(305, 30);
            this.GradPathBtn.Text = "Заливка пути градиентом";
            this.GradPathBtn.Click += new System.EventHandler(this.GraphicPathBtn_Click);
            // 
            // ColorIntBtn
            // 
            this.ColorIntBtn.Name = "ColorIntBtn";
            this.ColorIntBtn.Size = new System.Drawing.Size(305, 30);
            this.ColorIntBtn.Text = "Интерполяция цвета";
            this.ColorIntBtn.Click += new System.EventHandler(this.ColorIntBtn_Click);
            // 
            // TextBrshBtn
            // 
            this.TextBrshBtn.Name = "TextBrshBtn";
            this.TextBrshBtn.Size = new System.Drawing.Size(305, 30);
            this.TextBrshBtn.Text = "Текстурная кисть";
            this.TextBrshBtn.Click += new System.EventHandler(this.TextureBrushBtn_Click);
            // 
            // XorShapeBtn
            // 
            this.XorShapeBtn.Name = "XorShapeBtn";
            this.XorShapeBtn.Size = new System.Drawing.Size(305, 30);
            this.XorShapeBtn.Text = "Вычитание фигур";
            this.XorShapeBtn.Click += new System.EventHandler(this.XorShape_Click);
            // 
            // ClipImgBtn
            // 
            this.ClipImgBtn.Name = "ClipImgBtn";
            this.ClipImgBtn.Size = new System.Drawing.Size(281, 30);
            this.ClipImgBtn.Text = "Вырезать по маске";
            this.ClipImgBtn.Click += new System.EventHandler(this.ClipImgBtn_Click);
            // 
            // InvertColorBtn
            // 
            this.InvertColorBtn.Name = "InvertColorBtn";
            this.InvertColorBtn.Size = new System.Drawing.Size(281, 30);
            this.InvertColorBtn.Text = "Инвертировать цвета";
            this.InvertColorBtn.Click += new System.EventHandler(this.InvertColorBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 450);
            this.Controls.Add(this.paintBox);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel paintBox;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem PasteImgBtn;
        private System.Windows.Forms.ToolStripButton changeColorBtn;
        private System.Windows.Forms.ColorDialog colorSwitch;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem LineBtn;
        private System.Windows.Forms.ToolStripMenuItem CircleBtn;
        private System.Windows.Forms.ToolStripMenuItem BezierBtn;
        private System.Windows.Forms.ToolStripMenuItem GraphBtn;
        private System.Windows.Forms.ToolStripMenuItem GradPathBtn;
        private System.Windows.Forms.ToolStripMenuItem ColorIntBtn;
        private System.Windows.Forms.ToolStripMenuItem TextBrshBtn;
        private System.Windows.Forms.ToolStripMenuItem XorShapeBtn;
        private System.Windows.Forms.ToolStripMenuItem ClipImgBtn;
        private System.Windows.Forms.ToolStripMenuItem InvertColorBtn;
    }
}

