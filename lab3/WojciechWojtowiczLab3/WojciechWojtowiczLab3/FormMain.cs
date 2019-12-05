using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WojciechWojtowiczLab3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Przycisk logujący do bazy danych
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            SignIn sign = new SignIn(textBoxUsername.Text, textBoxPassword.Text); // wprowadzenie danych z pól tekstowych
            FormWarehouse formWarehouse = new FormWarehouse();
            if (sign.SignInWarehouse()) // sprawdzenie czy udało się zalogować
            {
                // pokazanie okna przy poprawnym zalogowaniu
                formWarehouse.Show();
            }
            else
            {
                MessageBox.Show("Nie udało się");
            }
        }
    }
}
