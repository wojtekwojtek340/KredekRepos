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
    public partial class FormFishDecision : Form, ShowLabels //1 interfejs
    {
        //instancja obietku typu Fish
        Fish fish = null;
        //instancja obietku typu Player
        Player player = null;

        /// <summary>
        /// konstruktor domyślny
        /// </summary>
        /// <param name="_fish"></param>
        /// <param name="_player"></param>
        public FormFishDecision()
        {
            InitializeComponent();
        }

        /// <summary>
        /// konstruktor przeciążony
        /// </summary>
        /// <param name="_fish"></param>
        /// <param name="_player"></param>
        public FormFishDecision(Fish _fish, Player _player)
        {
            fish = _fish as Fish;
            player = _player as Player;
            InitializeComponent();
            ShowLabels();
        }

        /// <summary>
        /// Metoda interfejsu uzupełniająca napisy
        /// </summary>
        public void ShowLabels()
        {
            labelCatchedFishName.Text = "Gatunek: " + fish.GetNameOfFish();
            labelCatchedFishWeighht.Text = "Waga: " + fish.GetWeightOfFish().ToString();
            labelCatchedFishLenght.Text = "Wymiar: " + fish.GetLenghtOfFich().ToString();
            labelCatchedFishProtectionLenght.Text = fish.GetProtectiveLenghtOfFish();
        }

        /// <summary>
        /// przycisk dodający rybę do listy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTakeFish_Click(object sender, EventArgs e)
        {
            player.AddFishToList(fish);
            this.Close();
        }

        /// <summary>
        /// Przycisk dodaje honor i zamyka okno.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonThrowFish_Click(object sender, EventArgs e)
        {
            player.SetHonor(player.GetHonor() + fish.GetLenghtOfFich() + fish.GetWeightOfFish());
            MessageBox.Show("Otrzymujesz " + (fish.GetLenghtOfFich() + fish.GetWeightOfFish()) + " punktów honoru.");
            this.Close();
        }
    }
}
