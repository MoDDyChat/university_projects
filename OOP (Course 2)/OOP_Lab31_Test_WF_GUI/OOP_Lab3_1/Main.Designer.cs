namespace OOP_Lab3_1
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.menuBox = new System.Windows.Forms.ComboBox();
            this.menuLbl = new System.Windows.Forms.Label();
            this.testLbl = new System.Windows.Forms.Label();
            this.FirstNumber = new System.Windows.Forms.TextBox();
            this.SecondNumber = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.TextBox();
            this.justEquis = new System.Windows.Forms.Label();
            this.calModeBtn = new System.Windows.Forms.Button();
            this.testXCoord = new System.Windows.Forms.Label();
            this.testYCoord = new System.Windows.Forms.Label();
            this.stopWatch = new System.Windows.Forms.Timer(this.components);
            this.watchHours = new System.Windows.Forms.TextBox();
            this.watchMinutes = new System.Windows.Forms.TextBox();
            this.watchSeconds = new System.Windows.Forms.TextBox();
            this.hoursTxt = new System.Windows.Forms.Label();
            this.MntsTxt = new System.Windows.Forms.Label();
            this.ScndTxt = new System.Windows.Forms.Label();
            this.watchBtnStart = new System.Windows.Forms.Button();
            this.watchBtnPause = new System.Windows.Forms.Button();
            this.watchBtnStop = new System.Windows.Forms.Button();
            this.gameMouseTimer = new System.Windows.Forms.Timer(this.components);
            this.winPicture = new System.Windows.Forms.PictureBox();
            this.Mouse = new System.Windows.Forms.PictureBox();
            this.CatBox = new System.Windows.Forms.PictureBox();
            this.gameRestart = new System.Windows.Forms.LinkLabel();
            this.smallCal = new System.Windows.Forms.DateTimePicker();
            this.calTypeCheck = new System.Windows.Forms.CheckBox();
            this.bigCal = new System.Windows.Forms.MonthCalendar();
            this.notify = new System.Windows.Forms.RichTextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.registerBtn = new System.Windows.Forms.Button();
            this.ageForm = new System.Windows.Forms.NumericUpDown();
            this.ageLbl = new System.Windows.Forms.Label();
            this.subCheckBox = new System.Windows.Forms.CheckedListBox();
            this.nationCheckBtn = new System.Windows.Forms.RadioButton();
            this.successBtn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.winPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CatBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageForm)).BeginInit();
            this.SuspendLayout();
            // 
            // menuBox
            // 
            this.menuBox.AllowDrop = true;
            this.menuBox.FormattingEnabled = true;
            this.menuBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuBox.Items.AddRange(new object[] {
            "Открыть картинку с котом",
            "Открыть калькулятор",
            "Открыть секундомер",
            "Открыть игру \"Поймай мышь\"",
            "Открыть планировщик",
            "Открыть анкету"});
            this.menuBox.Location = new System.Drawing.Point(257, 58);
            this.menuBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.menuBox.Name = "menuBox";
            this.menuBox.Size = new System.Drawing.Size(286, 21);
            this.menuBox.TabIndex = 0;
            this.menuBox.TextChanged += new System.EventHandler(this.menuBox_TextChanged);
            // 
            // menuLbl
            // 
            this.menuLbl.AutoSize = true;
            this.menuLbl.Location = new System.Drawing.Point(384, 29);
            this.menuLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.menuLbl.Name = "menuLbl";
            this.menuLbl.Size = new System.Drawing.Size(36, 13);
            this.menuLbl.TabIndex = 1;
            this.menuLbl.Text = "Меню";
            // 
            // testLbl
            // 
            this.testLbl.AutoSize = true;
            this.testLbl.Location = new System.Drawing.Point(712, 29);
            this.testLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.testLbl.Name = "testLbl";
            this.testLbl.Size = new System.Drawing.Size(13, 13);
            this.testLbl.TabIndex = 2;
            this.testLbl.Text = "0";
            // 
            // FirstNumber
            // 
            this.FirstNumber.Location = new System.Drawing.Point(128, 223);
            this.FirstNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FirstNumber.Name = "FirstNumber";
            this.FirstNumber.Size = new System.Drawing.Size(148, 20);
            this.FirstNumber.TabIndex = 3;
            this.FirstNumber.TextChanged += new System.EventHandler(this.Number_TextChanged);
            // 
            // SecondNumber
            // 
            this.SecondNumber.Location = new System.Drawing.Point(326, 223);
            this.SecondNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SecondNumber.Name = "SecondNumber";
            this.SecondNumber.Size = new System.Drawing.Size(148, 20);
            this.SecondNumber.TabIndex = 4;
            this.SecondNumber.TextChanged += new System.EventHandler(this.Number_TextChanged);
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(498, 223);
            this.Result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.Size = new System.Drawing.Size(148, 20);
            this.Result.TabIndex = 5;
            // 
            // justEquis
            // 
            this.justEquis.AutoSize = true;
            this.justEquis.Location = new System.Drawing.Point(479, 228);
            this.justEquis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.justEquis.Name = "justEquis";
            this.justEquis.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.justEquis.Size = new System.Drawing.Size(18, 20);
            this.justEquis.TabIndex = 6;
            this.justEquis.Text = "=";
            this.justEquis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calModeBtn
            // 
            this.calModeBtn.Location = new System.Drawing.Point(284, 215);
            this.calModeBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.calModeBtn.Name = "calModeBtn";
            this.calModeBtn.Size = new System.Drawing.Size(33, 35);
            this.calModeBtn.TabIndex = 7;
            this.calModeBtn.Text = "+";
            this.calModeBtn.UseVisualStyleBackColor = true;
            this.calModeBtn.Click += new System.EventHandler(this.calModeBtn_Click);
            // 
            // testXCoord
            // 
            this.testXCoord.AutoSize = true;
            this.testXCoord.Location = new System.Drawing.Point(22, 28);
            this.testXCoord.Name = "testXCoord";
            this.testXCoord.Size = new System.Drawing.Size(13, 13);
            this.testXCoord.TabIndex = 3;
            this.testXCoord.Text = "0";
            // 
            // testYCoord
            // 
            this.testYCoord.AutoSize = true;
            this.testYCoord.Location = new System.Drawing.Point(22, 48);
            this.testYCoord.Name = "testYCoord";
            this.testYCoord.Size = new System.Drawing.Size(13, 13);
            this.testYCoord.TabIndex = 4;
            this.testYCoord.Text = "0";
            // 
            // stopWatch
            // 
            this.stopWatch.Interval = 1000;
            this.stopWatch.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // watchHours
            // 
            this.watchHours.Location = new System.Drawing.Point(206, 190);
            this.watchHours.Name = "watchHours";
            this.watchHours.ReadOnly = true;
            this.watchHours.Size = new System.Drawing.Size(100, 20);
            this.watchHours.TabIndex = 5;
            this.watchHours.Text = "0";
            // 
            // watchMinutes
            // 
            this.watchMinutes.Location = new System.Drawing.Point(358, 190);
            this.watchMinutes.Name = "watchMinutes";
            this.watchMinutes.ReadOnly = true;
            this.watchMinutes.Size = new System.Drawing.Size(100, 20);
            this.watchMinutes.TabIndex = 6;
            this.watchMinutes.Text = "0";
            // 
            // watchSeconds
            // 
            this.watchSeconds.Location = new System.Drawing.Point(507, 188);
            this.watchSeconds.Name = "watchSeconds";
            this.watchSeconds.ReadOnly = true;
            this.watchSeconds.Size = new System.Drawing.Size(100, 20);
            this.watchSeconds.TabIndex = 7;
            this.watchSeconds.Text = "0";
            // 
            // hoursTxt
            // 
            this.hoursTxt.AutoSize = true;
            this.hoursTxt.Location = new System.Drawing.Point(226, 167);
            this.hoursTxt.Name = "hoursTxt";
            this.hoursTxt.Size = new System.Drawing.Size(60, 20);
            this.hoursTxt.TabIndex = 8;
            this.hoursTxt.Text = "Часов:";
            // 
            // MntsTxt
            // 
            this.MntsTxt.AutoSize = true;
            this.MntsTxt.Location = new System.Drawing.Point(377, 167);
            this.MntsTxt.Name = "MntsTxt";
            this.MntsTxt.Size = new System.Drawing.Size(60, 20);
            this.MntsTxt.TabIndex = 9;
            this.MntsTxt.Text = "Минут:";
            // 
            // ScndTxt
            // 
            this.ScndTxt.AutoSize = true;
            this.ScndTxt.Location = new System.Drawing.Point(522, 166);
            this.ScndTxt.Name = "ScndTxt";
            this.ScndTxt.Size = new System.Drawing.Size(68, 20);
            this.ScndTxt.TabIndex = 10;
            this.ScndTxt.Text = "Секунд:";
            // 
            // watchBtnStart
            // 
            this.watchBtnStart.Location = new System.Drawing.Point(220, 234);
            this.watchBtnStart.Name = "watchBtnStart";
            this.watchBtnStart.Size = new System.Drawing.Size(75, 30);
            this.watchBtnStart.TabIndex = 11;
            this.watchBtnStart.Text = "Старт";
            this.watchBtnStart.UseVisualStyleBackColor = true;
            this.watchBtnStart.Click += new System.EventHandler(this.WatchBtnStart_Click);
            // 
            // watchBtnPause
            // 
            this.watchBtnPause.Location = new System.Drawing.Point(371, 235);
            this.watchBtnPause.Name = "watchBtnPause";
            this.watchBtnPause.Size = new System.Drawing.Size(75, 30);
            this.watchBtnPause.TabIndex = 12;
            this.watchBtnPause.Text = "Пауза";
            this.watchBtnPause.UseVisualStyleBackColor = true;
            this.watchBtnPause.Click += new System.EventHandler(this.WatchBtnPause_Click);
            // 
            // watchBtnStop
            // 
            this.watchBtnStop.Location = new System.Drawing.Point(520, 234);
            this.watchBtnStop.Name = "watchBtnStop";
            this.watchBtnStop.Size = new System.Drawing.Size(75, 30);
            this.watchBtnStop.TabIndex = 13;
            this.watchBtnStop.Text = "Стоп";
            this.watchBtnStop.UseVisualStyleBackColor = true;
            this.watchBtnStop.Click += new System.EventHandler(this.WatchBtnStop_Click);
            // 
            // gameMouseTimer
            // 
            this.gameMouseTimer.Enabled = true;
            this.gameMouseTimer.Interval = 500;
            this.gameMouseTimer.Tick += new System.EventHandler(this.GameMouseTimer_Tick);
            // 
            // winPicture
            // 
            this.winPicture.BackColor = System.Drawing.Color.Transparent;
            this.winPicture.Image = global::OOP_Lab3_1.Properties.Resources.giphy;
            this.winPicture.Location = new System.Drawing.Point(157, 94);
            this.winPicture.Name = "winPicture";
            this.winPicture.Size = new System.Drawing.Size(495, 284);
            this.winPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.winPicture.TabIndex = 6;
            this.winPicture.TabStop = false;
            // 
            // Mouse
            // 
            this.Mouse.BackColor = System.Drawing.Color.Transparent;
            this.Mouse.Image = global::OOP_Lab3_1.Properties.Resources.rat_mouse_PNG2467;
            this.Mouse.Location = new System.Drawing.Point(307, 184);
            this.Mouse.Name = "Mouse";
            this.Mouse.Size = new System.Drawing.Size(72, 68);
            this.Mouse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Mouse.TabIndex = 5;
            this.Mouse.TabStop = false;
            this.Mouse.Click += new System.EventHandler(this.Mouse_Click);
            // 
            // CatBox
            // 
            this.CatBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CatBox.Enabled = false;
            this.CatBox.Image = global::OOP_Lab3_1.Properties.Resources._1564314090_3;
            this.CatBox.Location = new System.Drawing.Point(148, 90);
            this.CatBox.Name = "CatBox";
            this.CatBox.Size = new System.Drawing.Size(528, 134);
            this.CatBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CatBox.TabIndex = 3;
            this.CatBox.TabStop = false;
            this.CatBox.WaitOnLoad = true;
            // 
            // gameRestart
            // 
            this.gameRestart.AutoSize = true;
            this.gameRestart.Location = new System.Drawing.Point(256, 400);
            this.gameRestart.Name = "gameRestart";
            this.gameRestart.Size = new System.Drawing.Size(447, 20);
            this.gameRestart.TabIndex = 6;
            this.gameRestart.TabStop = true;
            this.gameRestart.Text = "Поздравляем! Вы поймали мышь! Попробовать ещё раз?";
            this.gameRestart.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GameRestart_LinkClicked);
            // 
            // smallCal
            // 
            this.smallCal.Location = new System.Drawing.Point(206, 114);
            this.smallCal.Name = "smallCal";
            this.smallCal.Size = new System.Drawing.Size(200, 20);
            this.smallCal.TabIndex = 5;
            this.smallCal.ValueChanged += new System.EventHandler(this.SmallCal_ValueChanged);
            // 
            // calTypeCheck
            // 
            this.calTypeCheck.AutoSize = true;
            this.calTypeCheck.Location = new System.Drawing.Point(418, 114);
            this.calTypeCheck.Name = "calTypeCheck";
            this.calTypeCheck.Size = new System.Drawing.Size(154, 17);
            this.calTypeCheck.TabIndex = 6;
            this.calTypeCheck.Text = "Расширенный календарь";
            this.calTypeCheck.UseVisualStyleBackColor = true;
            this.calTypeCheck.CheckedChanged += new System.EventHandler(this.calTypeCheck_CheckedChanged);
            // 
            // bigCal
            // 
            this.bigCal.Location = new System.Drawing.Point(242, 113);
            this.bigCal.Name = "bigCal";
            this.bigCal.SelectionRange = new System.Windows.Forms.SelectionRange(new System.DateTime(2019, 10, 2, 0, 0, 0, 0), new System.DateTime(2019, 10, 8, 0, 0, 0, 0));
            this.bigCal.TabIndex = 7;
            this.bigCal.Visible = false;
            this.bigCal.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.BigCal_DateChanged);
            // 
            // notify
            // 
            this.notify.Location = new System.Drawing.Point(418, 137);
            this.notify.Name = "notify";
            this.notify.Size = new System.Drawing.Size(164, 138);
            this.notify.TabIndex = 8;
            this.notify.Text = "";
            // 
            // progressBar
            // 
            this.progressBar.Enabled = false;
            this.progressBar.ForeColor = System.Drawing.SystemColors.GrayText;
            this.progressBar.Location = new System.Drawing.Point(257, 192);
            this.progressBar.Maximum = 5;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(286, 23);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 5;
            // 
            // registerBtn
            // 
            this.registerBtn.Enabled = false;
            this.registerBtn.Location = new System.Drawing.Point(549, 192);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(75, 23);
            this.registerBtn.TabIndex = 7;
            this.registerBtn.Text = "Отправить";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // ageForm
            // 
            this.ageForm.Location = new System.Drawing.Point(261, 107);
            this.ageForm.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.ageForm.Name = "ageForm";
            this.ageForm.Size = new System.Drawing.Size(120, 20);
            this.ageForm.TabIndex = 9;
            this.ageForm.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.ageForm.ValueChanged += new System.EventHandler(this.AgeForm_ValueChanged);
            // 
            // ageLbl
            // 
            this.ageLbl.AutoSize = true;
            this.ageLbl.Location = new System.Drawing.Point(258, 91);
            this.ageLbl.Name = "ageLbl";
            this.ageLbl.Size = new System.Drawing.Size(123, 13);
            this.ageLbl.TabIndex = 10;
            this.ageLbl.Text = "Укажите Ваш возраст:";
            // 
            // subCheckBox
            // 
            this.subCheckBox.AllowDrop = true;
            this.subCheckBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.subCheckBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.subCheckBox.CheckOnClick = true;
            this.subCheckBox.FormattingEnabled = true;
            this.subCheckBox.ImeMode = System.Windows.Forms.ImeMode.On;
            this.subCheckBox.Items.AddRange(new object[] {
            "Разрешить обработку данных",
            "Подписаться на нашу рассылку",
            "Оформить платную подписку"});
            this.subCheckBox.Location = new System.Drawing.Point(261, 135);
            this.subCheckBox.Name = "subCheckBox";
            this.subCheckBox.Size = new System.Drawing.Size(197, 45);
            this.subCheckBox.TabIndex = 11;
            this.subCheckBox.ThreeDCheckBoxes = true;
            this.subCheckBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.SubCheckBox_ItemCheck);
            // 
            // nationCheckBtn
            // 
            this.nationCheckBtn.AutoSize = true;
            this.nationCheckBtn.Location = new System.Drawing.Point(398, 107);
            this.nationCheckBtn.Name = "nationCheckBtn";
            this.nationCheckBtn.Size = new System.Drawing.Size(131, 17);
            this.nationCheckBtn.TabIndex = 6;
            this.nationCheckBtn.Text = "Я гражданин России";
            this.nationCheckBtn.UseVisualStyleBackColor = true;
            this.nationCheckBtn.CheckedChanged += new System.EventHandler(this.TrueAgeBtn_CheckedChanged);
            // 
            // successBtn
            // 
            this.successBtn.AutoSize = true;
            this.successBtn.Location = new System.Drawing.Point(316, 228);
            this.successBtn.Name = "successBtn";
            this.successBtn.Size = new System.Drawing.Size(184, 13);
            this.successBtn.TabIndex = 12;
            this.successBtn.Text = "Ваша заявка успешна отправлена!";
            // 
            // Main
            // 
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.testYCoord);
            this.Controls.Add(this.testXCoord);
            this.Controls.Add(this.testLbl);
            this.Controls.Add(this.menuLbl);
            this.Controls.Add(this.menuBox);
            this.Name = "Main";
            this.Text = "Form1";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.winPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CatBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox menuBox;
        private System.Windows.Forms.Label menuLbl;
        private System.Windows.Forms.Label testLbl;
        private System.Windows.Forms.PictureBox CatBox;
        private System.Windows.Forms.TextBox FirstNumber;
        private System.Windows.Forms.TextBox SecondNumber;
        private System.Windows.Forms.Label justEquis;
        private System.Windows.Forms.Button calModeBtn;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Label testXCoord;
        private System.Windows.Forms.Label testYCoord;
        private System.Windows.Forms.Timer stopWatch;
        private System.Windows.Forms.TextBox watchHours;
        private System.Windows.Forms.TextBox watchMinutes;
        private System.Windows.Forms.TextBox watchSeconds;
        private System.Windows.Forms.Label hoursTxt;
        private System.Windows.Forms.Label MntsTxt;
        private System.Windows.Forms.Label ScndTxt;
        private System.Windows.Forms.Button watchBtnStart;
        private System.Windows.Forms.Button watchBtnPause;
        private System.Windows.Forms.Button watchBtnStop;
        private System.Windows.Forms.PictureBox Mouse;
        private System.Windows.Forms.Timer gameMouseTimer;
        private System.Windows.Forms.PictureBox winPicture;
        private System.Windows.Forms.LinkLabel gameRestart;
        private System.Windows.Forms.DateTimePicker smallCal;
        private System.Windows.Forms.CheckBox calTypeCheck;
        private System.Windows.Forms.MonthCalendar bigCal;
        private System.Windows.Forms.RichTextBox notify;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.NumericUpDown ageForm;
        private System.Windows.Forms.Label ageLbl;
        private System.Windows.Forms.CheckedListBox subCheckBox;
        private System.Windows.Forms.RadioButton nationCheckBtn;
        private System.Windows.Forms.Label successBtn;
    }
}

