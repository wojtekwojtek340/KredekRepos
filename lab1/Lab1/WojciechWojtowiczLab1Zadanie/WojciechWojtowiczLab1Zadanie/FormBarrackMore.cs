﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WojciechWojtowiczLab1Zadanie
{
    public partial class FormBarrackMore : Form
    {
        int numberOfWarriors = 0;
        // zmienna typu FormMain dzieki której bede mogł tutaj modyfikować niektóre wartości
        private FormMain formMain = null;

        /// <summary>
        /// to było od poczatku
        /// </summary>
        public FormBarrackMore()
        {
            InitializeComponent();
        }

        /// <summary>
        /// konstuktor 
        /// </summary>
        /// <param name="_gold"></param>
        /// <param name="_myArmy"></param>
        public FormBarrackMore(Form test)
        {
            formMain = test as FormMain;
            InitializeComponent();
            labelMyArmy.Text = "Posiadani wojownicy " + formMain.GetMyArmy();
            labelMyGold.Text = "Posiadane złoto " + formMain.GetGold();
        }

        /// <summary>
        /// metoda oblicza ile złota potrzeba na rekrutacje wojska i wypisuje to w odpowiednim labelu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxChoose_TextChanged(object sender, EventArgs e)
        {
            try
            {
                numberOfWarriors = Int32.Parse(textBoxChoose.Text);
                labelExpense.Text = "Koszt " + numberOfWarriors *(30-formMain.GetBarrackLevel());
            }
            catch
            {
                numberOfWarriors = 0;
                labelExpense.Text = "Koszt 0";
            }
            
        }

        /// <summary>
        /// przycisk potwierdzajacy wybrana przez nas ilośc wojska do rekturacji
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            //pobieram wartosci z formMain
            int gold = formMain.GetGold();
            int myArmy = formMain.GetMyArmy();   
            
            if(gold - numberOfWarriors * (30 - formMain.GetBarrackLevel()) >= 0)
            {
                //wykonuje operacje na tych wartościach
                gold -= numberOfWarriors * (30 - formMain.GetBarrackLevel());
                myArmy += numberOfWarriors;

                //ustawiam wartosci zmodyfikowane
                formMain.SetGold(gold);
                formMain.SetMyArmy(myArmy);

                //wyswietlam je w okienku
                labelMyArmy.Text = "Posiadani wojownicy " + formMain.GetMyArmy();
                labelMyGold.Text = "Posiadane złoto " + formMain.GetGold();
            }
            else
            {
                MessageBox.Show("Brak złota");
            }
        }
    }
}
