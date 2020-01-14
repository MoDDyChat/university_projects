using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Lab3_1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        
        //переключение режима калькулятора (сложение/вычитание)
        int calMode = 0;

        //Счётчик таймера
        int timerSeconds = 0;

        //Триггер паузы секундомера
        bool isPause = false;

        //Триггер для формы возраста
        bool ageTrigger = false;

        Random random = new Random();

        //Меню программы
        private void menuBox_TextChanged(object sender, EventArgs e)
        {
            switch (menuBox.Text)
            {
                case "Открыть картинку с котом":
                    unloadAll();
                    this.Controls.Add(this.CatBox);
                    break;
                case "Открыть калькулятор":
                    unloadAll();
                    loadCal();
                    break;
                case "Открыть секундомер":
                    unloadAll();
                    loadTimer();
                    break;
                case "Открыть игру \"Поймай мышь\"":
                    unloadAll();
                    loadMouseGame();
                    break;
                case "Открыть планировщик":
                    unloadAll();
                    loadPlanner();
                    break;
                case "Открыть анкету":
                    unloadAll();
                    loadReg();
                    break;
            } 
        }

        //Добавить на форму объекты кальулятора
        private void loadCal()
        {
            this.Controls.Add(this.calModeBtn);
            this.Controls.Add(this.justEquis);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.SecondNumber);
            this.Controls.Add(this.FirstNumber);
        }

        //Добавить на форму объекты игры
        private void loadMouseGame()
        {
            this.Controls.Add(this.Mouse);
            gameMouseTimer.Enabled = true;
        }

        //Добавить на форму объекты Секундомера
        private void loadTimer()
        {
            this.Controls.Add(this.watchBtnStop);
            this.Controls.Add(this.watchBtnPause);
            this.Controls.Add(this.watchBtnStart);
            this.Controls.Add(this.ScndTxt);
            this.Controls.Add(this.MntsTxt);
            this.Controls.Add(this.hoursTxt);
            this.Controls.Add(this.watchSeconds);
            this.Controls.Add(this.watchMinutes);
            this.Controls.Add(this.watchHours);
        }

        //Добавить на форму объекты Планировщика
        private void loadPlanner()
        {
            this.Controls.Add(this.notify);
            this.Controls.Add(this.bigCal);
            this.Controls.Add(this.calTypeCheck);
            this.Controls.Add(this.smallCal);
        }

        //Добавить на форму объекты Анкеты
        private void loadReg()
        {
            this.Controls.Add(this.subCheckBox);
            this.Controls.Add(this.ageLbl);
            this.Controls.Add(this.ageForm);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.nationCheckBtn);
            this.Controls.Add(this.progressBar);
        }

        //Удалить с формы объекты анкеты
        private void unloadReg()
        {
            this.Controls.Remove(this.subCheckBox);
            this.Controls.Remove(this.ageLbl);
            this.Controls.Remove(this.ageForm);
            this.Controls.Remove(this.registerBtn);
            this.Controls.Remove(this.nationCheckBtn);
            this.Controls.Remove(this.progressBar);
            this.Controls.Remove(this.successBtn);
        }

        //Удалить с формы объекты Планировщика
        private void unloadPlanner()
        {
            this.Controls.Remove(this.notify);
            this.Controls.Remove(this.bigCal);
            this.Controls.Remove(this.calTypeCheck);
            this.Controls.Remove(this.smallCal);
        }


        //Удалить с формы объекты игры
        private void unloadMouseGame()
        {
            this.Controls.Remove(this.Mouse);
            this.Controls.Remove(this.winPicture);
            this.Controls.Remove(this.gameRestart);
            gameMouseTimer.Enabled = false;
        }

        //Удалить с формы объекты калькулятора
        private void unloadCal()
        {
            this.Controls.Remove(this.calModeBtn);
            this.Controls.Remove(this.justEquis);
            this.Controls.Remove(this.Result);
            this.Controls.Remove(this.SecondNumber);
            this.Controls.Remove(this.FirstNumber);
        }

        //Удалить с формы объекты таймера
        private void unloadTimer()
        {
            this.Controls.Remove(this.watchBtnStop);
            this.Controls.Remove(this.watchBtnPause);
            this.Controls.Remove(this.watchBtnStart);
            this.Controls.Remove(this.ScndTxt);
            this.Controls.Remove(this.MntsTxt);
            this.Controls.Remove(this.hoursTxt);
            this.Controls.Remove(this.watchSeconds);
            this.Controls.Remove(this.watchMinutes);
            this.Controls.Remove(this.watchHours);
        }

        //Очистка формы от объектов всех режимов программы
        private void unloadAll()
        {
            unloadCal();
            unloadMouseGame();
            unloadTimer();
            unloadPlanner();
            unloadReg();
            this.Controls.Remove(this.CatBox);
        }

        //Логика вычислений калькулятора
        private void calResult()
        {
            if (FirstNumber.Text != "" && SecondNumber.Text != "")
            {
                if (calMode == 0)
                    Result.Text = (float.Parse(FirstNumber.Text) + float.Parse(SecondNumber.Text)).ToString();
                else
                    Result.Text = (float.Parse(FirstNumber.Text) - float.Parse(SecondNumber.Text)).ToString();
            }
        }

        //Меняется текст в текстовой форме - высчитывается результат 
        private void Number_TextChanged(object sender, EventArgs e)
        {
            calResult();
        }

        //Переключение режимов калькулятора (Сложение / Вычитаение)
        private void calModeBtn_Click(object sender, EventArgs e)
        {
            if (calMode == 0)
            {
                calMode = 1;
                calModeBtn.Text = "-";
            }
            else
            {
                calMode = 0;
                calModeBtn.Text = "+";
            }
            calResult();
        }

        //Визуализация координат курсора мыши (на всякий)
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            testXCoord.Text = e.X.ToString();
            testYCoord.Text = e.Y.ToString();
        }

        //Логика секундомера
        private void Timer1_Tick(object sender, EventArgs e)
        {
            timerSeconds++.ToString();
            watchSeconds.Text = (timerSeconds % 60).ToString();
            if (timerSeconds % 60 == 0)
                watchMinutes.Text = (timerSeconds / 60 - (Int32.Parse(watchHours.Text) * 60)).ToString();
            if (timerSeconds % 3600 == 0)
                watchHours.Text = (timerSeconds / 3600).ToString();
        }

        //Запуск секундомера
        private void WatchBtnStart_Click(object sender, EventArgs e)
        {
            stopWatch.Enabled = true;
        }

        //Пауза секундомера
        private void WatchBtnPause_Click(object sender, EventArgs e)
        {
            if (isPause == false)
            {
                stopWatch.Enabled = false;
                isPause = true;
            }
            else
            {
                stopWatch.Enabled = true;
                isPause = false;
            }
        }

        //Остановка и сброс секундомера
        private void WatchBtnStop_Click(object sender, EventArgs e)
        {
            stopWatch.Enabled = false;
            watchHours.Text = "0";
            watchMinutes.Text = "0";
            watchSeconds.Text = "0";
            timerSeconds = 0;
        }

        //Таймер изменения состояния игры (2.5 тика в секунду)
        private void GameMouseTimer_Tick(object sender, EventArgs e)
        {
            int randomX = random.Next(0, Size.Width - 80);
            int randomY = random.Next(0, Size.Height - 80);
            //Изменение положения мыши на рандомные координаты
            Mouse.Location = new System.Drawing.Point(randomX, randomY);
        }

        //Логика клика по мыши (Победа в игре)
        private void Mouse_Click(object sender, EventArgs e)
        {
            gameMouseTimer.Enabled = false; //Выключается таймер
            this.Controls.Remove(this.Mouse); //Удаляется мышь
            this.Controls.Add(this.winPicture); //Добавляется гифка салюта
            this.Controls.Add(this.gameRestart); //Добавляется надпись о рестарте
        }

        //Рестарт игры при клике на надпись о рестарте
        private void GameRestart_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            gameMouseTimer.Enabled = true;
            this.Controls.Add(this.Mouse);
            this.Controls.Remove(this.winPicture);
            this.Controls.Remove(this.gameRestart);
        }

        //Переключение между типами календаря
        private void calTypeCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (calTypeCheck.Checked == true)
            {
                bigCal.Visible = true;
                smallCal.Visible = false;
            }
            else
            {
                bigCal.Visible = false;
                smallCal.Visible = true;
            }
        }

        //Логика 'Большого' календаря
        private void BigCal_DateChanged(object sender, DateRangeEventArgs e)
        {
            notify.Text = "Вы выбрали: " + e.Start.ToString() + "\n\n";
            if (e.Start.ToString() == "08.10.2019 0:00:00")
            {
                notify.Text = notify.Text + "В этот день нужно сдать лабу по ООП";
            }
            else
                notify.Text = notify.Text + "В этот день ничего сдавать не нужно";
        }

        //Логика 'маленького' календаря
        private void SmallCal_ValueChanged(object sender, EventArgs e)
        {
            notify.Text = "Вы выбрали: " + smallCal.Text.ToString() + "\n\n";
            if (smallCal.Text.ToString() == "8 октября 2019 г.")
            {
                notify.Text = notify.Text + "В этот день нужно сдать лабу по ООП";
            }
            else
                notify.Text = notify.Text + "В этот день ничего сдавать не нужно";
        }

        //Логика бокса выбора возраста
        private void AgeForm_ValueChanged(object sender, EventArgs e)
        {
            if (ageTrigger == false)
                progressBar.Value++;
            ageTrigger = true;
            if (progressBar.Value == 5) registerBtn.Enabled = true;
            else registerBtn.Enabled = false;
        }

        //Проверка гражданства РФ (да-да)
        private void TrueAgeBtn_CheckedChanged(object sender, EventArgs e)
        {
            progressBar.Value++;
            if (progressBar.Value == 5) registerBtn.Enabled = true;
            else registerBtn.Enabled = false;
        }

        //Проверка на подтверждение подписок
        private void SubCheckBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue.ToString() == "Checked") progressBar.Value++;
            else progressBar.Value--;
            if (progressBar.Value == 5) registerBtn.Enabled = true;
            else registerBtn.Enabled = false;
        }

        //Логика кнопки 'Отправить'
        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            registerBtn.Enabled = false;
            this.Controls.Add(this.successBtn);
            progressBar.Enabled = false;
            subCheckBox.Enabled = false;
            ageForm.Enabled = false;
        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            var newSize = Convert.ToInt32(numericUpDown1.Value);
            pictureBox1.Size = new Size(newSize * 10, newSize * 10);
        }
    }
}
