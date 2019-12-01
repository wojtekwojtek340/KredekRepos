using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WojciechWojtowiczLab2Zadanie
{
    class Bandit : Enemies
    {
        //uchwyt na obiekt typu Player
        Player player = null;

        /// <summary>
        /// konstruktor
        /// </summary>
        /// <param name="_player"></param>
        public Bandit(Player _player)
        {
            player = _player as Player;
            name = "Bandyta";
        }

        /// <summary>
        /// metoda ataku bandyty
        /// </summary>
        public override void Attack()
        {
            //jesli mamy wiecej niz 100PLN bandyta zabierze nam 100, jezeli nie to nas pobije
            if(player.GetMoney() > 100)
            {
                player.SetMoney(player.GetMoney() - 100);

                //jezeli posiadamy kartę wedkarską, mamy 25% szans ze bandyta nam ja odbierze
                if(player.GetFishingCard())
                {
                    if (moose.Next(1, 5) == 1)
                    {
                        player.SetFishingCard(false);
                        MessageBox.Show("Napadli Cię bandyci!\nUkradli Ci 100PLN oraz kartę wędkarską!");
                    }
                    else
                    {
                        MessageBox.Show("Pobili Cię bandyci i ukradli Ci 100PLN!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Pobili Cię bandyci!");
            }
        }
    }
}
