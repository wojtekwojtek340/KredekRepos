using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WojciechWojtowiczLab2Zadanie
{
    public partial class FormLake : Form, GlobalTime, ShowLabels //używane są 2 interfejsy
    {
        //Uchwyt na obiekt typu Enemies
        Enemies enemy = null;
        //Uchwyt na obiekt typu Player
        Player player = null;
        //Uchwyt na obiekt typu FormGame
        FormGame game = null;        
        //Uchwyt na obiekt typu Time
        Time globalTime = null;
        //Uchwyt na obiekt typu Fish
        Fish fish = null;
        //Obiekt typu Random
        System.Random moose = new Random(System.DateTime.Now.Millisecond);
        //poziom trudności jeziora
        int levelOfLake;
        //pole służy to obsługi timera
        int timerMechanism = 0;

        /// <summary>
        /// Konstruktor domyślny.
        /// </summary>
        public FormLake()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Konstruktor przeciążony, ładuje parametry.
        /// </summary>
        /// <param name="_player"></param>
        /// <param name="_game"></param>
        /// <param name="_globalTime"></param>
        /// <param name="_levelOfLake"></param>
        public FormLake(Player _player, FormGame _game, Time _globalTime, int _levelOfLake)
        {
            player = _player as Player;
            game = _game as FormGame;
            globalTime = _globalTime;
            levelOfLake = _levelOfLake;
            InitializeComponent();
            ShowLabels();
            timerGlobalTime.Start();
        }

        /// <summary>
        /// Metoda służąca do powrotu do menu gry w przypadku ręczengo zamknięcia okna.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            int number = player.GetList().Count;
            for (int i = 0; i < number; i++)
            {
                player.GetList().RemoveAt(0);
            }
            game.Show();
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
        /// timer zliczający czas w grze, dodatkowo odpowiada za negatywne zdarzenia losowe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerGlobalTime_Tick_1(object sender, EventArgs e)
        {
            globalTime.Increment();
            ShowLabels();

            //kontrola strazy rybackiej
            if(moose.Next(1, 100) == 1 && levelOfLake != 1)
            {
                enemy = new FishingGuards(player);
                MessageBox.Show("Kontrola straży rybackiej!");
                enemy.Attack();
            }

            //atak wrogiego wędkarza
            if(moose.Next(1,100) == 1)
            {
                enemy = new EnemyFisher(player);
                enemy.Attack();
            }
        }

        /// <summary>
        /// Przycisk rozpoczynający łowienie.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStartFishing_Click(object sender, EventArgs e)
        {
            pictureBoxFishingRod.Show();
            timerFishingMechanism.Start();
        }

        /// <summary>
        /// Przycisk kończący łowienie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStopFishing_Click(object sender, EventArgs e)
        {
            pictureBoxFishingRod.Hide();
            timerFishingMechanism.Stop();
        }

        /// <summary>
        /// timer do mechanizmu połowu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerFishingMechanism_Tick(object sender, EventArgs e)
        {
            timerMechanism++;

            //po pewnym czasie znikają picture boxy
            if (timerMechanism == 18/levelOfLake)
            {
                pictureBoxBream.Hide();
                pictureBoxCarp.Hide();
                pictureBoxPike.Hide();
            }

            //po pewnym czasie pokazują sie picture boxy.
            if (timerMechanism == 120/levelOfLake)
            {
                timerMechanism = 0;
                int x = moose.Next(1, 4);
                if (x == 1)
                {
                    pictureBoxBream.Show();
                }
                else if (x == 2)
                {
                    pictureBoxCarp.Show();
                }
                else if (x == 3)
                {
                    pictureBoxPike.Show();
                }
            }
        }

        /// <summary>
        /// kliknięcie w picture box tworzy nową rybę i wyświetla okienko decyzji co z nią zrobić
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxCarp_Click(object sender, EventArgs e)
        {
            pictureBoxCarp.Hide();
            fish = new Carp(levelOfLake);
            FormFishDecision fishDecision = new FormFishDecision(fish, player);
            fishDecision.Show();
        }

        /// <summary>
        /// kliknięcie w picture box tworzy nową rybę i wyświetla okienko decyzji co z nią zrobić
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxBream_Click(object sender, EventArgs e)
        {
            pictureBoxBream.Hide();
            fish = new Bream(levelOfLake);
            FormFishDecision fishDecision = new FormFishDecision(fish, player);
            fishDecision.Show();
        }

        /// <summary>
        /// kliknięcie w picture box tworzy nową rybę i wyświetla okienko decyzji co z nią zrobić
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxPike_Click(object sender, EventArgs e)
        {
            pictureBoxPike.Hide();
            fish = new Pike(levelOfLake);
            FormFishDecision fishDecision = new FormFishDecision(fish, player);
            fishDecision.Show();
        }

        /// <summary>
        /// przycisk powrotu to menu gry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLeaveLake_Click(object sender, EventArgs e)
        {
            //oczyszcza listę z elementów jeśli są
            if(player.GetList().Count != 0 && pictureBoxFishingRod.Visible == false)
            {
                DialogResult dialogResult = MessageBox.Show("Opuszczając łowisko stracisz wszystkie ryby!", "Wyjście z łowiska.", MessageBoxButtons.YesNo);
                if(dialogResult == DialogResult.Yes)
                {
                    int number = player.GetList().Count;
                    for(int i = 0; i< number; i++)
                    {
                        player.GetList().RemoveAt(0);
                    }
                    game.LoadParameters(player, globalTime);
                    this.Close();
                    game.Show();
                }              
            }
            else
            {
                //sprawdza czy wędka jest schowana
                if(pictureBoxFishingRod.Visible == false)
                {
                    game.LoadParameters(player, globalTime);
                    this.Close();
                    game.Show();
                }
                else
                {
                    MessageBox.Show("Aby opuścić łowisko musisz schować wędkę!");
                }
            }
        }

        /// <summary>
        /// przysick pozwalający zobaczyć co złapaliśmy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLookAtNet_Click(object sender, EventArgs e)
        {
            if(pictureBoxFishingRod.Visible == false)
            {
                if (player.GetList().Count != 0)
                {
                    FormNet net = new FormNet(this, player);
                    net.Show();
                }
                else
                {
                    MessageBox.Show("W sieci nic nie ma!");
                }
            }
            else
            {
                MessageBox.Show("Aby zobaczyć co jest w sieci trzeba odłożyć wędkę!");
            }
        }

        /// <summary>
        /// metoda interfejsu wyświetlająca napisy
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
