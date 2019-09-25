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
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
        }
        
        //переключение режима калькулятора (сложение/вычитание)
        int calMode = 0;

        //Счётчик таймера
        int timerSeconds = 0; 

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
            stopWatch.Enabled = false;
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
            int randomX = random.Next(0, Size.Width - 40);
            int randomY = random.Next(0, Size.Height - 40);
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
    }
}
