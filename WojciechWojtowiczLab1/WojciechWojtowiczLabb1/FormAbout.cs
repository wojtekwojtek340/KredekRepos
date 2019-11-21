using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WojciechWojtowiczLabb1
{
    public partial class FormAbout : Form
    {
        public string formName = "Wojciech Wojtowicz";

        public FormAbout()
        {
            InitializeComponent();
            labelName.Text = formName;
        }

        private void FormAbout_Load(object sender, EventArgs e)
        {

        }
    }
}
