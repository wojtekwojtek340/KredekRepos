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
    public partial class FormNet : Form, ShowLabels
    {
        //instancja obietku typu FormLake
        FormLake lake = null;
        //instancja obietku typu Player
        Player player = null;
        //instancja obietku typu Fish
        Fish fish = null;
        //ochwyt na liste obietów typu Fish
        List<Fish> fishList = null;
        //pole uzywane do poruszania sie po liście
        int listIndex = 0;

        /// <summary>
        /// konstruktor domyślny
        /// </summary>
        public FormNet()
        {
            InitializeComponent();   
        }

        /// <summary>
        /// konstruktor przeciążony
        /// </summary>
        /// <param name="_lake"></param>
        /// <param name="_player"></param>
        public FormNet(FormLake _lake, Player _player)
        {
            lake = _lake as FormLake;
            player = _player as Player ;
            InitializeComponent();
            fishList = player.GetList();
            fish = fishList[listIndex];
            ShowLabels();
        }

        /// <summary>
        /// przycisk do poruszania się po liście "w prawo"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNext_Click(object sender, EventArgs e)
        {
            listIndex++;
            if(listIndex == fishList.Count)
            {
                listIndex = 0;
            }

            fish = fishList[Math.Abs(listIndex)];
            ShowLabels();
        }

        /// <summary>
        /// przycisk do poruszania się po liście "w lewo"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            listIndex--;
            if(listIndex < 0)
            {
                listIndex = fishList.Count-1;
            }

            fish = fishList[Math.Abs(listIndex)];
            ShowLabels();
        }

        /// <summary>
        /// przycisk wypuszczający rybę i dodający za to honoru
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFree_Click(object sender, EventArgs e)
        {
            player.SetHonor(player.GetHonor() + fish.GetLenghtOfFich() + fish.GetWeightOfFish());
            fishList.RemoveAt(listIndex);
            MessageBox.Show("Otrzymano " + (fish.GetLenghtOfFich() + fish.GetWeightOfFish()) + " punktów honoru.");
            listIndex--;
            if (listIndex < 0)
            {
                listIndex = fishList.Count - 1;
            }
            if(fishList.Count != 0)
            {
                fish = fish = fishList[Math.Abs(listIndex)];
                ShowLabels();
            }
            else
            {
                this.Close();
            }
        }

        /// <summary>
        /// przcisk sprzedający rybę i dodający za to pieniędzy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSell_Click(object sender, EventArgs e)
        {
            player.SetMoney(player.GetMoney() + fish.GetLenghtOfFich() + fish.GetWeightOfFish());
            fishList.RemoveAt(listIndex);
            MessageBox.Show("Otrzymano " + (fish.GetLenghtOfFich() + fish.GetWeightOfFish()) + " PLN");
            listIndex--;
            if (listIndex < 0)
            {
                listIndex = fishList.Count - 1;
            }
            if (fishList.Count != 0)
            {
                fish = fish = fishList[Math.Abs(listIndex)];
                ShowLabels();
            }
            else
            {
                this.Close();
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
        /// interfejs uzupełniający napisy
        /// </summary>
        public void ShowLabels()
        {
            labelCatchedFishNumber.Text = "Ryba " + (listIndex + 1) + "/" + fishList.Count;
            labelCatchedFishName.Text = "Gatunek:" + fish.GetNameOfFish();
            labelCatchedFishWeighht.Text = "Waga: " + fish.GetWeightOfFish().ToString();
            labelCatchedFishLenght.Text = "Wymiar: " + fish.GetLenghtOfFich().ToString();
            labelCatchedFishProtectionLenght.Text = fish.GetProtectiveLenghtOfFish();
        }
    }
}
