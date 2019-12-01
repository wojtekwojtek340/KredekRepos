using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WojciechWojtowiczLab2Zadanie
{
    class EnemyFisher : Enemies
    {
        //uchwyt na obiekt typu Player
        Player player = null;

        /// <summary>
        /// konstruktor
        /// </summary>
        /// <param name="_player"></param>
        public EnemyFisher(Player _player)
        {
            player = _player as Player;
            name = "Wrogi wędkarz";
        }

        /// <summary>
        /// metoda ataku wrogiego wedkarza
        /// </summary>
        public override void Attack()
        {
            //jezeli nie mamy zadnych ryb wedkarz nas wyśmieje, jeżeli mamy ryby w sieci rybak ukradnie nam jedną z nich
            if(player.GetList().Count != 0)
            {
                player.GetList().RemoveAt(moose.Next(0, player.GetList().Count));
                MessageBox.Show("Odwiedził Cię zazdrosny wędkarz i ukradł Ci jedną z Twoich ryb!");
            }
            else
            {
                MessageBox.Show("Odwiedził Cię inny wędkarz, widząc ze nie masz nic w sieci wyśmiał Cie i poszedł dalej.");
            }
        }
    }
}
