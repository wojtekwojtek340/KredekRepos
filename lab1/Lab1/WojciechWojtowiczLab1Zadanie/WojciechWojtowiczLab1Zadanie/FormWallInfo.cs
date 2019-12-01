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
    public partial class FormWallInfo : Form
    {
        double wallLevel = 0;

        /// <summary>
        /// to było od poczatku
        /// </summary>
        public FormWallInfo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// konstruktor wypisuje parametry w zaleznosci jakie mu sie wyśle
        /// </summary>
        /// <param name="_wallLevel"></param>
        public FormWallInfo(int _wallLevel)
        {
            InitializeComponent();
            wallLevel = _wallLevel;
            labelWallLevel.Text = "Poziom muru " + wallLevel;
            labelWallDefense.Text = "Współczynnik obrony " + ((wallLevel / 10) + 1);
            labelWallDefenseNext.Text = "Następny współczynnik " + (((wallLevel+1) / 10) + 1);
        }
    }
}
