using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Configuration;

namespace WojciechWojtowiczLab3Zadanie
{
    public partial class FormMain : Form
    {
        readonly Func<SqlConnection> connectionFishingCentre = () => new SqlConnection(ConfigurationManager.ConnectionStrings["FishingCentre"].ConnectionString);

        //instancja obietku typu FormGame
        FormGame gameContinue = null;
        //obiekt typu Player
        Player player = new Player();
        //instancja obietku typu Time
        Time globalTime = null;

        /// <summary>
        /// Konstruktor domyślny
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
            buttonContinue.Hide();
        }

        /// <summary>
        /// Metoda rozpoczyna nową grę.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            globalTime = new Time();
            FormGame game = new FormGame(this,player,globalTime);
            game.Show();
            this.Hide();
        }

        /// <summary>
        /// Metoda kontynuuje rozgrywkę.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonContinue_Click(object sender, EventArgs e)
        {
            gameContinue = new FormGame(this, player, globalTime);
            gameContinue.Show();
            this.Hide();
        }

        /// <summary>
        /// Metoda wczytuje parametry rozpoczętej wcześniej gry gdy chcemy powrócić do menu głównego, dodatkowo wyświetla przyciki służące do kontynuacji i zapisu gry.
        /// </summary>
        /// <param name="_player"></param>
        /// <param name="_globalTime"></param>
        /// <param name="_gameContinue"></param>
        public void LoadParameters(Player _player, Time _globalTime, FormGame _gameContinue)
        {
            globalTime = _globalTime as Time;
            player = _player as Player;
            gameContinue = _gameContinue as FormGame;
            buttonContinue.Show();
            buttonSaveGame.Show();
        }

        /// <summary>
        /// Metoda wczytująca grę.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLoadGame_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        player = new Player();
                        globalTime = new Time();
                        player.SetMoney(Int32.Parse(reader.ReadLine()));
                        player.SetHonor(Int32.Parse(reader.ReadLine()));
                        globalTime.Hour = Int32.Parse(reader.ReadLine());
                        globalTime.Day = Int32.Parse(reader.ReadLine());
                        globalTime.Week = Int32.Parse(reader.ReadLine());
                        player.SetFishingCard(Boolean.Parse(reader.ReadLine()));
                        player.SetPassedExam(Boolean.Parse(reader.ReadLine()));
                        MessageBox.Show("Gra wczytana!");
                        buttonContinue.Show();
                        buttonSaveGame.Show();
                    }
                }
            }
        }

        /// <summary>
        /// Metoda zapisująca stan gry.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSaveGame_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = "c:\\";
                saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var fileStream = saveFileDialog.OpenFile();

                    using (StreamWriter writer = new StreamWriter(fileStream))
                    {
                        writer.Write(player.GetMoney() + "\n");
                        writer.WriteLine(player.GetHonor());
                        writer.WriteLine(globalTime.Hour);
                        writer.WriteLine(globalTime.Day);
                        writer.WriteLine(globalTime.Week);
                        writer.WriteLine(player.GetFishingCard());
                        writer.WriteLine(player.GetPassedExam());
                        MessageBox.Show("Zapis pomyślny!");
                    }
                }
            }
        }

        /// <summary>
        /// przycisk zamykajacy gre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// przycisk sluzacy do rejestracji
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSingUp_Click(object sender, EventArgs e)
        {
            FormSingUp singUp = new FormSingUp();
            singUp.Show();
        }

        /// <summary>
        /// przycisk sluzący do logowania
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSingIn_Click(object sender, EventArgs e)
        {
            try
            {
                SingIn singIn = new SingIn(textBoxUserName.Text, textBoxUserPassword.Text, player);
                singIn.SingInFishingCentre();
                MessageBox.Show("Zalogowano pomyślnie!");               
            }
            catch (ArgumentException exception)
            {
                textBoxUserName.Clear();
                textBoxUserPassword.Clear();
                MessageBox.Show(exception.Message);
                return;
            }

            labelLoggedName.Text = "Zalogowano: " + textBoxUserName.Text;
            textBoxUserName.Clear();
            textBoxUserPassword.Clear();
            textBoxUserPassword.Hide();
            textBoxUserName.Hide();
            labelUserName.Hide();
            labelUserPassword.Hide();
            buttonSingIn.Hide();
            buttonSingUp.Hide();
            buttonLogout.Show();
            labelLoggedName.Show();
        }

        /// <summary>
        /// przycisk sluzący do wylogowania
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogout_Click(object sender, EventArgs e)
        {
            player.SetUserId(0);
            textBoxUserPassword.Show();
            textBoxUserName.Show();
            labelUserName.Show();
            labelUserPassword.Show();
            buttonSingIn.Show();
            buttonSingUp.Show();
            buttonLogout.Hide();
            labelLoggedName.Hide();
        }
    }
}
