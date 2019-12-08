using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WojciechWojtowiczLab3Zadanie
{
    public partial class FormShop : Form, GlobalTime, ShowLabels //2 interfejsy
    {
        //instancja obietku typu Time
        Time globalTime = null;
        //instancja obietku typu FormGame
        FormGame game = null;
        //uchwyt na przycisk typu Player
        Player player = null;

        /// <summary>
        /// konstruktor domyślny
        /// </summary>
        public FormShop()
        {
            InitializeComponent();
        }

        /// <summary>
        /// konstruktor przeciążony
        /// </summary>
        /// <param name="_game"></param>
        /// <param name="_player"></param>
        /// <param name="_globalTime"></param>
        public FormShop(FormGame _game, Player _player, Time _globalTime)
        {
            globalTime = _globalTime as Time;
            game = _game as FormGame;
            player = _player as Player;
            InitializeComponent();
            ShowLabels();
            timerGlobalTime.Start();
            if(player.GetPassedExam())
            {
                labelCardExamCost.Hide();
                labelCardCost.Show();
                buttonGetFishingCard.Show();
                buttonFishingCard.Hide();
            }
        }

        /// <summary>
        /// Metoda interfejsu pokazująca godzinę w napisie.
        /// </summary>
        public void ShowHour()
        {
            labelHour.Text = "Godzina: " + globalTime.Hour;
        }

        /// <summary>
        /// Metoda interfejsu pokazująca dzień w napisie.
        /// </summary>
        public void ShowDay()
        {
            labelDay.Text = "Dzień: " + globalTime.Day;
        }

        /// <summary>
        /// Metoda interfejsu pokazująca tydzień w napisie.
        /// </summary>
        public void ShowWeek()
        {
            labelWeek.Text = "Tydzień: " + globalTime.Week;
        }

        /// <summary>
        /// timer liczący czas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerGlobalTime_Tick(object sender, EventArgs e)
        {
            ShowLabels();

            if(player.GetPassedExam())
            {
                labelCardExamCost.Hide();
                buttonFishingCard.Hide();
            }
        }

        /// <summary>
        /// przycisk rozpoczynający egzamin na kartę wedkarską
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFishingCard_Click(object sender, EventArgs e)
        {
            if(player.GetMoney() >= 50)
            {
                player.SetMoney(player.GetMoney() - 50);
                FormExam exam = new FormExam(this, player);
                exam.Show();
            }
            else
            {
                MessageBox.Show("Masz za mało pieniędzy aby przystąpić do egzaminu!");
            }
        }
        
        /// <summary>
        /// przycisk kupujący kartę wędkarską
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGetFishingCard_Click(object sender, EventArgs e)
        {
            if (player.GetMoney() >= 100 && !player.GetFishingCard())
            {
                player.SetMoney(player.GetMoney() - 100);
                player.SetFishingCard(true);
            }
            else
            {
                if(player.GetFishingCard())
                {
                    MessageBox.Show("Masz już kartę wędkarską!");
                }
                else
                {
                    MessageBox.Show("Masz za mało pieniędzy aby zapłacić za kartę wędkarską!");
                }
            }
        }

        /// <summary>
        /// przycisk zamykający okno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// metoda interfesju uzupełniajaca napisy
        /// </summary>
        public void ShowLabels()
        {
            ShowDay();
            ShowHour();
            ShowWeek();
            labelMyMoney.Text = "Pieniądze: " + player.GetMoney() + "PLN";
            labelMyHonor.Text = "Honor: " + player.GetHonor();
            if (player.GetFishingCard())
            {
                labelMyFishingCard.Text = "Karta wędkarska: Posiadam";
            }
            else
            {
                labelMyFishingCard.Text = "Karta wędkarska: Brak";
            }
        }
    }
}
