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
    public partial class FormExam : Form
    {
        //instancja obietku typu FormShop
        FormShop shop = null;
        //instancja obietku typu Player
        Player player = null;

        /// <summary>
        /// konstruktor domyślny
        /// </summary>
        public FormExam()
        {
            InitializeComponent();
        }

        /// <summary>
        /// konstruktor przeciążony
        /// </summary>
        /// <param name="_shop"></param>
        /// <param name="_player"></param>
        public FormExam(FormShop _shop, Player _player)
        {
            player = _player as Player;
            shop = _shop as FormShop;
            InitializeComponent();
        }

        /// <summary>
        /// przycisk kończący egzamin. wynik zalezy od poprawności odpowiedzi na pytania
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEndExam_Click(object sender, EventArgs e)
        {
            //jezeli sa zaznaczone te radiobuttony to udało sie dać
            if(radioButtonAnswerCorrect.Checked && radioButtonAnswer5Correct.Checked && radioButtonAnswer7Correct.Checked)
            {
                player.SetPassedExam(true);
                MessageBox.Show("Udało Ci się zdać egzamin.\nPrzyjdz do sklepu za jakiś czas aby ją odebrać.");
                this.Close();
            }
            //jeśli nie to egzamin niezdany
            else
            {
                MessageBox.Show("Nie udało Ci się zdać egzaminu.");
                this.Close();
            }
        }
    }
}
