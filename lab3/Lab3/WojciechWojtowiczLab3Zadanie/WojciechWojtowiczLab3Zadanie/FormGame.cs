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
    public partial class FormGame : Form, GlobalTime, ShowLabels //używane są 2 interfejsy
    {
        //instancja obietku typu Time
        Time globalTime  = null;
        //instancja obietku typu FormMain
        FormMain mainMenu = null;
        //instancja obietku typu Player
        Player player = null;
        //instancja obietku typu Enemies
        Enemies enemy = null;
        //Obiekt typu Random
        System.Random moose = new Random(System.DateTime.Now.Millisecond);

        /// <summary>
        /// Konstruktor domyślny
        /// </summary>
        public FormGame()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Konstruktor przeciążony, używany gry kontynuujemy grę.
        /// </summary>
        /// <param name="_mainMenu"></param>
        /// <param name="_player"></param>
        /// <param name="_globalTime"></param>
        public FormGame(FormMain _mainMenu, Player _player, Time _globalTime)
        {
            mainMenu = _mainMenu as FormMain;
            player = _player as Player;
            globalTime = _globalTime as Time;
            InitializeComponent();
            ShowLabels();
            timerGlobalTime.Start();
        }

        /// <summary>
        /// Przycisk służący do powrotu do menu głównego.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBackToMainMenu_Click(object sender, EventArgs e)
        {
            mainMenu.LoadParameters(player, globalTime, this);
            mainMenu.Show();
            timerGlobalTime.Stop();
            this.Hide();
        }

        /// <summary>
        /// Metoda służąca do powrotu do menu głównego w przypadku ręczengo zamknięcia okna.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            mainMenu.LoadParameters(player, globalTime, this);
            mainMenu.Show();
            timerGlobalTime.Stop();
        }

        /// <summary>
        /// Timer zliczający czas w grze, oraz wprowadzający zdarzenia losowe.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerGlobalTime_Tick(object sender, EventArgs e)
        {
            globalTime.Increment();
            ShowLabels();

            //atak bandytów
            if(moose.Next(1,100) == 1)
            {
                enemy = new Bandit(player);
                enemy.Attack();
            }
        }

        /// <summary>
        /// Przycisk informujący o parametrach jeziora
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLakeIntermediateInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Jezioro dla średniozaawansowanych wędkarzy.\nTrzeba posiadać minimum 100 punktów honoru.\nMoże wystąpić kontrola straży rybackiej!");
        }

        /// <summary>
        /// Przycisk informujący o parametrach jeziora
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLakeBeginerInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Jezioro dla początkujących wędkarzy!");
        }

        /// <summary>
        /// Przycisk informujący o parametrach jeziora
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLakeAdvencedInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Jezioro dla prawdziwych fanatyków wędkarstwa.\nTrzeba posiadać minimum 300 punktów honoru\nWymagana jest karta wędkarska!");
        }

        /// <summary>
        /// przycisk pozwala wejść na jezioro dla początkujących
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLakeBeginer_Click(object sender, EventArgs e)
        {
            FormLake lakeBeginer = new FormLake(player, this, globalTime, 1);
            this.Hide();
            timerGlobalTime.Stop();
            lakeBeginer.Show();
        }

        /// <summary>
        /// przycisk pozwala wejść na jezioro dla średniozaawansowanych
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLakeIntermediate_Click(object sender, EventArgs e)
        {
            if (player.GetHonor() >= 100)
            {
                FormLake LakeIntermediate = new FormLake(player, this, globalTime, 3);
                this.Hide();
                timerGlobalTime.Stop();
                LakeIntermediate.Show();
            }
            else
            {
                MessageBox.Show("Brak wymaganej liczby punktów honoru!");
            }
        }

        /// <summary>
        /// przycisk pozwala wejść na jezioro dla zaawansowanych
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLakeAdvenced_Click(object sender, EventArgs e)
        {
            if(player.GetFishingCard() && player.GetHonor() >= 300)
            {
                FormLake LakeAdvenced = new FormLake(player, this, globalTime, 5);
                this.Hide();
                timerGlobalTime.Stop();
                LakeAdvenced.Show();
            }
            else
            {
                MessageBox.Show("Brak karty wędkarskiej lub wymaganej liczby punktów honoru!");
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
        /// Metoda interfejsu pokazująca dzień w napisie
        /// </summary>
        public void ShowDay()
        {
            labelDay.Text = "Dzień: " + globalTime.Day;
        }

        /// <summary>
        /// Metoda z interfejsu pokazująca tydzień w napisie
        /// </summary>
        public void ShowWeek()
        {
            labelWeek.Text = "Tydzień: " + globalTime.Week;
        }

        /// <summary>
        /// przycisk pozwalający na wejście do sklepu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShop_Click(object sender, EventArgs e)
        {
            FormShop shop = new FormShop(this, player, globalTime);
            shop.Show();
        }

        /// <summary>
        /// Metoda ładująca parametry po powrocie z łowiska.
        /// </summary>
        /// <param name="_player"></param>
        /// <param name="_globalTime"></param>
        public void LoadParameters(Player _player, Time _globalTime)
        {
            player = _player as Player;
            globalTime = _globalTime as Time;
            ShowLabels();
            timerGlobalTime.Start();
        }

        /// <summary>
        /// Metoda interfejsu wyświetlająca napisy.
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

        /// <summary>
        /// przycisk otwiera przeglad zlowionych ryb
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFishingCentre_Click(object sender, EventArgs e)
        {
            FormFishingCentre fishingCentre = new FormFishingCentre(player.GetUserId());
            fishingCentre.Show();
        }
    }
}
