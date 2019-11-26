using System;
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
    public partial class FormMain : Form
    {
        //inicjalizacja zmiennych
        //ilosc zlota
        int gold = 100;
        //ilosc drewna
        int wood = 10;
        //ilosc wojska
        int myArmy = 10;
        // poziom tartaka
        int sawmillLevel = 1;
        //poziom kopalni zlota
        int goldMineLevel = 1;
        //poziom muru
        int wallLevel = 1;
        //poziom koszar
        int barrackLevel = 1;
        //wydobycie zlota
        int goldMineExtraction = 50;
        //wydobycie drewna
        int woodExtraction = 10;
        //godzina i dzien w grze
        int hour = 0;
        int day = 0;
        int week = 0;
        //zmienna liczaca przejsca zegara dla progress barow dla kopalni,muru,tartaku,koszar
        int timerTickGold = 0;
        int timerTickWall = 0;
        int timerTickBarrack = 0;
        int timerTickSawmill = 0;
        //zmienna do zdarzeń
        int myEvent  = 0;

        /// <summary>
        /// akcesor ustawiajacy wartosc złota
        /// </summary>
        /// <param name="_gold"></param>
        public void SetGold(int _gold)
        {
            gold = _gold;
        }
        
        /// <summary>
        /// akcesor zwracajacy wartość złota
        /// </summary>
        /// <returns></returns>
        public int GetGold()
        {
            return gold;
        }

        /// <summary>
        /// akcesor ustawiajacy wartość armii
        /// </summary>
        /// <param name="_myArmy"></param>
        public void SetMyArmy(int _myArmy)
        {
            myArmy = _myArmy;
        }

        /// <summary>
        /// akcesor zwracajacy ilość armii
        /// </summary>
        /// <returns></returns>
        public int GetMyArmy()
        {
            return myArmy;
        }

        /// <summary>
        /// akcesor zwracajacy poziom koszar
        /// </summary>
        /// <returns></returns>
        public int GetBarrackLevel()
        {
            return barrackLevel;
        }

        /// <summary>
        /// ustawia interwał zegara 1000 i odpala zegar globalny
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
            timerCount.Interval = 1000;
            timerCount.Start();
        }

        /// <summary>
        /// wyświetlenie poczatkowych infomacji odnosnie koszar kopalni tartaka i muru. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_Load(object sender, EventArgs e)
        {
            labelGoldMine.Text = "Kopalnia poziom " + goldMineLevel.ToString();
            labelSawmill.Text = "Tartak poziom " + sawmillLevel.ToString();
            labelBarrack.Text = "Koszary poziom " + barrackLevel.ToString();
            labelWallLevel.Text = "Poziom muru " + wallLevel.ToString();
            labelBarrackMaterials.Text = (10 * barrackLevel).ToString() + "D  " + (30*barrackLevel).ToString() + "Z" ;
            labelSawmillMaterials.Text = (10 * sawmillLevel).ToString() + "D  " + (30 * sawmillLevel).ToString() + "Z";
            labelGoldMineMaterials.Text = (10 * goldMineLevel).ToString() + "D  " + (30 * goldMineLevel).ToString() + "Z";
            labelWallMaterials.Text = (10 * wallLevel).ToString() + "D  " + (30 * wallLevel).ToString() + "Z";
        }

        /// <summary>
        /// funckja ma za zadanie liczyć globalny czas w grze, i w zależności od niego wykonywać różne akcje
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerCount_Tick(object sender, EventArgs e)
        {
            hour++;
            //co 24 godziny dodaje złota drewna, zwieksza dzień itp
            if(hour >24)
            {
                hour = 0;
                day++;
                gold += goldMineExtraction;
                wood += woodExtraction;
                myEvent++;
            }

            //wyświetla napisy informujace o stanie poszczególnych parametrów
            labelGlobalTime.Text = "Dzien " + day + " Godzina " + hour;
            labelMyArmy.Text = "Wojownicy " + myArmy;
            labelWood.Text = "Drewno " + wood;
            labelGold.Text = "Zloto " + gold;

            //zdarzenia losowe co 7 dni w grze
            if(myEvent >= 7)
            {
                week++;
                myEvent = 0;
                Random random = new Random();
                int moose = random.Next(1,3);

                //odwiedziny sojusznikow
                if(moose == 1)
                {
                    MessageBox.Show("Odwiedzili Cie sojusznicy i przywieźli ze sobą dary.");
                    wood += week * 100;
                    gold += week * 300;

                }
                //napad bandytów
                else if(moose == 2)
                {
                    MessageBox.Show("Napadło Cię" + week*10 + " bandytów.");
                    //do obliczeń potrzbuje typu zmiennoprzecinkowego, stąd te zmienne lokalne
                    double enemyArmyD = 10 * week;
                    double myArmyD = myArmy;
                    myArmyD = myArmy * (((double)wallLevel / 10) + 1);
                    myArmyD -= enemyArmyD;
                    myArmy = (int)myArmyD;                        
                
                    if(myArmyD < 0)
                    {
                        myArmy = 0;
                        MessageBox.Show("Bandyci złupili twoją wioskę.");
                        wood -= 40 * week;
                        gold -= 100 * week;
                        if(gold < 0)
                        {
                            gold = 0;
                        }
                        if(wood <0)
                        {
                            wood = 0;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Udało Ci się obronić.");
                    }                    
                }
                else if(moose == 3)
                {
                    MessageBox.Show("Wioskę nawiedziła zaraza, tracisz " + week*5 + " wojowników");
                    if(myArmy - week*5 >= 0)
                    {
                        myArmy -= week * 5;
                    }
                    else
                    {
                        myArmy = 0;
                    }

                }
            }
        }

        /// <summary>
        /// zegar dla kopalni zlota z mechanizmem ulepszenia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerGoldMineUpgrade_Tick(object sender, EventArgs e)
        {
            timerTickGold++;
            progressBarGoldMineUpgrade.Increment(1);
            if (5 < timerTickGold)
            {
                timerGoldMineUpgrade.Stop();
                progressBarGoldMineUpgrade.Hide();
                timerTickGold = 0;
                progressBarGoldMineUpgrade.Value = 0;
                goldMineLevel++;
                goldMineExtraction += 10;
                labelGoldMine.Text = "Kopalnia poziom " + goldMineLevel.ToString();
                labelGoldMineMaterials.Text = (10 * goldMineLevel).ToString() + "D  " + (30 * goldMineLevel).ToString() + "Z";
                labelGoldMineMaterials.Show();
            }
        }

        /// <summary>
        /// zegar dla tartaku z mechanizmem ulepszenia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerSawmillUpgrade_Tick(object sender, EventArgs e)
        {
            timerTickSawmill++;
            progressBarSawmillUpgrade.Increment(1);
            if (5 < timerTickSawmill)
            {
                timerSawmillUpgrade.Stop();
                progressBarSawmillUpgrade.Hide();
                timerTickSawmill = 0;
                progressBarSawmillUpgrade.Value = 0;
                sawmillLevel++;
                woodExtraction += 10;
                labelSawmill.Text = "Tartak poziom " + sawmillLevel.ToString();
                labelSawmillMaterials.Text = (10 * sawmillLevel).ToString() + "D  " + (30 * sawmillLevel).ToString() + "Z";
                labelSawmillMaterials.Show();
            }
        }

        /// <summary>
        /// zegar dla koszar z mechanizmem ulepszenia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerBarrackUpgrade_Tick(object sender, EventArgs e)
        {
            timerTickBarrack++;
            progressBarBarrackUpgrade.Increment(1);
            if (5 < timerTickBarrack)
            {
                timerBarrackUpgrade.Stop();
                progressBarBarrackUpgrade.Hide();
                timerTickBarrack = 0;
                progressBarBarrackUpgrade.Value = 0;
                barrackLevel++;
                labelBarrack.Text = "Koszary poziom " + barrackLevel.ToString();
                labelBarrackMaterials.Text = (10 * barrackLevel).ToString() + "D  " + (30 * barrackLevel).ToString() + "Z";
                labelBarrackMaterials.Show();
            }
        }

        /// <summary>
        /// zegar dla muru z mechanizmem ulepszenia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerWallUpgrade_Tick(object sender, EventArgs e)
        {
            timerTickWall++;
            progressBarWallUpgrade.Increment(1);
            if (5 < timerTickWall)
            {
                timerWallUpgrade.Stop();
                progressBarWallUpgrade.Hide();
                timerTickWall = 0;
                progressBarWallUpgrade.Value = 0;
                wallLevel++;
                labelWallLevel.Text = "Mur poziom " + wallLevel.ToString();
                labelWallMaterials.Text = (10 * wallLevel).ToString() + "D  " + (30 * wallLevel).ToString() + "Z";
                labelWallMaterials.Show();
            }
        }

        /// <summary>
        /// przycisk pozwalajcy ulepszyć mur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonWallUpgrade_Click(object sender, EventArgs e)
        {
            if (wood - 10 * wallLevel >= 0 && gold - 30 * wallLevel >= 0)
            {
                wood = wood - 10 * wallLevel;
                gold = gold - 30 * wallLevel;
                timerWallUpgrade.Start();
                labelWallMaterials.Hide();
                progressBarWallUpgrade.Show();
            }
            else
            {
                MessageBox.Show("Brak surowców");
            }
        }

        /// <summary>
        /// przycisk pozwalajacy ulepszyć koszary
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBarrackUpgrade_Click(object sender, EventArgs e)
        {
            if(wood - 10 * barrackLevel >=0 && gold - 30 * barrackLevel >= 0)
            {
                wood = wood - 10 * barrackLevel;
                gold = gold - 30 * barrackLevel;
                timerBarrackUpgrade.Start();
                labelBarrackMaterials.Hide();
                progressBarBarrackUpgrade.Show();
            }
            else
            {
                MessageBox.Show("Brak surowców");
            }
        }

        /// <summary>
        /// przycisk pozwalajacy ulepszyc kopalnie zlota
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGoldMineUpgrade_Click(object sender, EventArgs e)
        {
            if(wood - 10 * goldMineLevel >=0 && gold - 30 * goldMineLevel >=0)
            {
                wood = wood - 10 * goldMineLevel;
                gold = gold - 30 * goldMineLevel;
                labelGoldMineMaterials.Hide();
                progressBarGoldMineUpgrade.Show();
                timerGoldMineUpgrade.Start();
            }
            else
            {
                MessageBox.Show("Brak surowców");
            }
        }

        /// <summary>
        /// przycisk pozwalajacy ulepszyć tartak
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSawmillUpgrade_Click(object sender, EventArgs e)
        {
            if(wood - 10 * sawmillLevel >= 0 && gold - 30 * sawmillLevel >= 0)
            {
                wood = wood - 10 * sawmillLevel;
                gold = gold - 30 * sawmillLevel;
                timerSawmillUpgrade.Start();
                labelSawmillMaterials.Hide();
                progressBarSawmillUpgrade.Show();
            }
            else
            {
                MessageBox.Show("Brak surowców");
            }
        }

        /// <summary>
        /// przycisk otwierajacy okno inforcmacyjne o kopalni zlota
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGoldMineInfo_Click(object sender, EventArgs e)
        {
            FormExtractionInfo formGoldMine = new FormExtractionInfo(goldMineLevel, goldMineExtraction);
            formGoldMine.Show();
        }

        /// <summary>
        /// przycisk otwierajacy okno informacyjne o tartaku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSawmillInfo_Click(object sender, EventArgs e)
        {
            FormExtractionInfo formGoldMine = new FormExtractionInfo(sawmillLevel, woodExtraction);
            formGoldMine.Show();
        }

        /// <summary>
        /// przycisk otwierajacy okno informacyjne o murze
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonWallInfo_Click(object sender, EventArgs e)
        {
            FormWallInfo formWallInfo = new FormWallInfo(wallLevel);
            formWallInfo.Show();
        }

        /// <summary>
        /// przycisk otwierajacy okno koszar w celu rekrutacji wojska
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBarrackMore_Click(object sender, EventArgs e)
        {
            FormBarrackMore formBarrackMore = new FormBarrackMore(this);
            formBarrackMore.Show();
        }
    }
}
