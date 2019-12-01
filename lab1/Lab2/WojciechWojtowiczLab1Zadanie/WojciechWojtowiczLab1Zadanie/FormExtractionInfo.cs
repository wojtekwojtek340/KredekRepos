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
    public partial class FormExtractionInfo : Form
    {
        //poziom
        int level = 0;
        //wydobycie
        int extraction = 0;

        /// <summary>
        /// to było od poczatku
        /// </summary>
        public FormExtractionInfo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// konstruktor wypisuje parametry w zaleznosci jakie mu sie wyśle
        /// </summary>
        /// <param name="_level"></param>
        /// <param name="_extraction"></param>
        public FormExtractionInfo(int _level, int _extraction)
        {
            InitializeComponent();
            level = _level;
            extraction = _extraction;
            labelGoldMineLevel.Text = "Poziom " + level;
            labelGoldMineExtraction.Text = "Aktualne wydobycie " + extraction;
            labelGoldMineExtractionNext.Text = "Kolejne wydobycie " + (extraction + 10);
        }
    }
}
