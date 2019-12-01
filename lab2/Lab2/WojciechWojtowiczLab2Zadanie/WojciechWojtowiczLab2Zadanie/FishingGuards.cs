using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WojciechWojtowiczLab2Zadanie
{
    class FishingGuards : Enemies
    {
        //uchwyt na obiekt typu Player
        Player player = null;
        //pole liczace ryby ponize wymiaru ochronnego
        int undersizedFishes;

        /// <summary>
        /// konstruktor
        /// </summary>
        /// <param name="_player"></param>
        public FishingGuards(Player _player)
        {
            player = _player as Player;
            undersizedFishes = 0;
            name = "Straż rybacka";
        }

        /// <summary>
        /// metoda ataku strazy rybackiej
        /// </summary>
        public override void Attack()
        {
            //jezeli nie ma sie karty wedkarskiej dostaje sie mandat
            if(!player.GetFishingCard())
            {
                player.SetMoney(player.GetMoney() - 200);
                MessageBox.Show("Brak karty wędkarskiej!\nOtrzymujesz mandat w wysokości 200PLN!");
            }

            //petla sprawdzajca czy ryba jest wymiarowa, jezeli nie za kazda płaci sie mandat
            for (int i = 0; i < player.GetList().Count; i++)
            {
                if (player.GetList()[i].GetLenghtOfFich() < player.GetList()[i].GetProtectiveLenght())
                {
                    player.SetHonor(player.GetHonor() - player.GetList()[i].GetLenghtOfFich());
                    player.GetList().RemoveAt(i);
                    i--;
                    undersizedFishes++;
                }
            }
            if (undersizedFishes != 0)
            {                
                int mandate = undersizedFishes * 200;
                player.SetMoney(player.GetMoney() - mandate);
                MessageBox.Show("Posiadasz " + undersizedFishes + " niewymiarowe ryby!\nOtrzymujesz mandat w wysokości " + mandate + "!");
            }
        }
    }
}
